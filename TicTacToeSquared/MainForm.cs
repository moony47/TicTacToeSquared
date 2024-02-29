using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TicTacToeSquared {
	public partial class MainForm : Form {
		
		Button[,] grid = new Button[9,9];
		string[] cellCross = new string[9];
		bool crossTurn = true;
		StreamReader sr;
		StreamWriter sw;
		bool isServer = false;
		TcpClient client;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void CreateServer (object sender, EventArgs e) {
		    try {
				string ip = new WebClient().DownloadString("http://api.ipify.org");
				IPAddress externalIP = IPAddress.Parse(ip);

                lblIP.Text = ip;
                MessageBox.Show("Waiting for connection. Host name: " + ip + " This has been copied to your clipboard.");
				Clipboard.SetText(ip);
				
				Update();
				
				TcpListener listener = new TcpListener(3000);
				listener.Start();
				client = listener.AcceptTcpClient();
				sr = new StreamReader(client.GetStream());
				sw = new StreamWriter(client.GetStream());
				
				MessageBox.Show("Client Found");
				isServer = true;
				
				btnConnect.Visible = false;
				btnCreate.Visible = false;
				btnStart.Enabled = true;
			} catch (Exception ex) {
				MessageBox.Show("Setup failed\n" + ex);
			}
		}
		
		void ConnectToServer (object sender, EventArgs e) {
			try {
				
				string peerID = txtPeerID.Text;
				client = new TcpClient(peerID, 3000);
				sr = new StreamReader(client.GetStream());
				sw = new StreamWriter(client.GetStream());
				
				lblIP.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
				
				MessageBox.Show("Server Found");
				isServer = false;
				
				btnConnect.Visible = false;
				btnCreate.Visible = false;
				
				if (sr.ReadLine() == "STARTGAME") {
				    sr.DiscardBufferedData();
				    StartGame();
				}
				
				WaitForTurn();
			} catch {
				MessageBox.Show("Server not found, try again.");
			}
		}
		
		void DisableAll () {
			for (int x = 0; x < 9; x++) {
				for (int y = 0; y < 9; y++) {
					grid[x,y].Enabled = false;
					grid[x,y].BackColor = Color.DarkGray;
				}
			}
		}
		
		void WaitForTurn () {
			DisableAll();
			Update();
			
			try {
			int step = 0;
			while (crossTurn != isServer) {
				string data = sr.ReadLine();
				
				if (data == null)
				    continue;
				
				if (step == 0) {
					string[] splitData = data.Split(';');
					
					for (int x = 0; x < 9; x++) {
						for (int y = 0; y < 9; y++) {
							grid[x,y].Text = splitData[x*9 + y];
						}
					}
					
					step++;
				} else if (step == 1) {
					string[] splitData = data.Split(';');
					
					for (int x = 0; x < 9; x++) {
						cellCross[x] = splitData[x];
					}
					
					step++;
				} else if (step == 2) {
					string[] splitData = data.Split(';');
					
					bool won = false;
					if (CheckCell(int.Parse(splitData[0]), int.Parse(splitData[1]), splitData[2]) == true){
						cellCross[int.Parse(splitData[0])] = splitData[2];
						won = CheckBigCell(int.Parse(splitData[0]), splitData[2]);
					}
					LockToCell (int.Parse(splitData[1]));
					DrawBigCells(int.Parse(splitData[0]));
					crossTurn = !crossTurn;
					lblTurn.Text = (crossTurn?"X":"O") + " Turn";
					
					Update();
						
					if (won == true){
						MessageBox.Show (splitData[2] + " wins the game");
						
						sr.Close();
						sw.Close();
						Application.Restart();
					}
					
					step++;
				}
			}
			} catch {
				
			}
		}
		
		void StartGameClick (object sender, EventArgs e) {
			StartGame();
			
			sw.WriteLine("STARTGAME");
			sw.Flush();
		}
		
		void StartGame () {
			for (int x = 0; x < 9; x++) {
				((Label) Controls.Find("lbl" + x, false)[0]).Visible = false;
			}
			lblIP.Visible = false;
			btnStart.Visible = false;
			lblTurn.Visible = true;
			txtPeerID.Visible = false;
			CreateGrid();
		}
		
		void TakeTurn (object sender, EventArgs e) {
			if (((Button) sender).Text != "")
				return;
			
			bool won = false;
			int a = int.Parse(((Button) sender).Name[0].ToString());
			int b = int.Parse(((Button) sender).Name[2].ToString());
			string c = crossTurn?"X":"O";
			((Button) sender).Text = c;
			if (CheckCell(a, b, c) == true){
				cellCross[a] = c;
				won = CheckBigCell(a, c);
			}
			LockToCell (b);
			DrawBigCells(a);
			crossTurn = !crossTurn;
			lblTurn.Text = (crossTurn?"X":"O") + " Turn";
			
			Update();
			
			TransmitCurrentGameState(a, b, c);
			
			if (won == true){
				MessageBox.Show (c + " wins the game");
				
				sr.Close();
				sw.Close();
				Application.Restart();
			}
			
			WaitForTurn();
		}
		
		void TransmitCurrentGameState(int a, int b, string c) {
			string data = "";
			for (int x = 0; x < 9; x++) {
				for (int y = 0; y < 9; y++) {
					data += ";" + grid[x,y].Text;
				}
			}
			
			sw.WriteLine(data.Substring(1));
			sw.Flush();
			
			data = "";
			for (int x = 0; x < 9; x++) {
				data += ";" + cellCross[x];
			}
			
			sw.WriteLine(data.Substring(1));
			sw.Flush();
			
			sw.WriteLine(a + ";" + b + ";" + c);
			sw.Flush();
		}
		
		bool CheckBigCell (int a, string c){
			for (int x = 0; x < 3; x++) {
				if (a%3 == x)
					if (cellCross[x] == c && cellCross[3+x] == c && cellCross[6+x] == c) {
					((Label) Controls.Find("lbl" + x, false)[0]).BackColor = Color.Green;
					((Label) Controls.Find("lbl" + (3+x), false)[0]).BackColor = Color.Green;
					((Label) Controls.Find("lbl" + (6+x), false)[0]).BackColor = Color.Green;
					return true;
				}
				if (a/3 == x)
					if (cellCross[3*x] == c && cellCross[1 + 3*x]== c && cellCross[2 + 3*x] == c) {
					((Label) Controls.Find("lbl" + (3*x), false)[0]).BackColor = Color.Green;
					((Label) Controls.Find("lbl" + (1 + 3*x), false)[0]).BackColor = Color.Green;
					((Label) Controls.Find("lbl" + (2 + 3*x), false)[0]).BackColor = Color.Green;
					return true;
				}
			}
			if (a%4 == 0)
				if (cellCross[0] == c && cellCross[4] == c && cellCross[8] == c){
				((Label) Controls.Find("lbl0", false)[0]).BackColor = Color.Green;
				((Label) Controls.Find("lbl4", false)[0]).BackColor = Color.Green;
				((Label) Controls.Find("lbl8", false)[0]).BackColor = Color.Green;
				return true;
			}
			if (a%2 == 0 && a != 0 && a != 8)
				if (cellCross[2] == c && cellCross[4] == c && cellCross[6] == c){
				((Label) Controls.Find("lbl2", false)[0]).BackColor = Color.Green;
				((Label) Controls.Find("lbl4", false)[0]).BackColor = Color.Green;
				((Label) Controls.Find("lbl6", false)[0]).BackColor = Color.Green;
				return true;
			}
			
			bool draw = true;
			for (int x = 0; x < 9; x++)
				if (cellCross[x] == "")
					draw = false;
			
			if (draw == true) {
				MessageBox.Show("The game is a draw.");
				Application.Restart();
			}
			
			return false;
		}
		
		void DrawBigCells (int a) {
			((Label) Controls.Find("lbl" + a, false)[0]).Visible = cellCross[a]!="";
			((Label) Controls.Find("lbl" + a, false)[0]).Text = cellCross[a];
		}
		
		bool CheckCell (int a, int b, string c) {
			for (int x = 0; x < 3; x++) {
				if (b%3 == x)
					if (grid[a,x].Text == c && grid[a,3+x].Text == c && grid[a,6+x].Text == c)
						return true;
				if (b/3 == x)
					if (grid[a,3*x].Text == c && grid[a,1 + 3*x].Text == c && grid[a,2 + 3*x].Text == c)
						return true;
			}
			if (b%4 == 0)
				if (grid[a,0].Text == c && grid[a,4].Text == c && grid[a,8].Text == c)
					return true;
			if (b%2 == 0 && b != 0 && b != 8)
				if (grid[a,2].Text == c && grid[a,4].Text == c && grid[a,6].Text == c)
					return true;
			
			bool draw = true;
			for (int x = 0; x < 9; x++)
				if (grid[a, x].Text == "")
					draw = false;
			
			if (draw == true)
				for (int x = 0; x < 9; x++)
					grid[a,x].Text = "";
			
			return false;
		}
		
		void LockToCell (int a) {
			for (int x = 0; x < 9; x++) {
				for (int y = 0; y < 9; y++) {
					grid[x,y].Enabled = x==a || cellCross[a]!="";
					grid[x,y].BackColor = (x==a || cellCross[a]!="")?Color.Black:Color.DarkGray;
				}
			}
		}
		
		void CreateGrid (){
			for (int x = 0; x < 9; x++) {
				for (int y = 0; y < 9; y++) {
					grid[x,y] = new Button();
					grid[x,y].Name = x + "," + y;
					grid[x,y].Text = "";
					grid[x,y].FlatStyle = FlatStyle.Popup;
					grid[x,y].BackColor = Color.Black;
					grid[x,y].ForeColor = Color.White;
					grid[x,y].Size = new Size (32, 32);
					grid[x,y].Location = new Point (12 + 122*(x%3) + 38*(y%3), 12 + 122*(x/3) + 38*(y/3));
					grid[x,y].Click += new System.EventHandler(TakeTurn);
					grid[x,y].TextAlign = ContentAlignment.MiddleCenter;
					grid[x,y].Font = new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Bold);
					Controls.Add(grid[x,y]);
				}
				cellCross[x] = "";
			}
		}
	}
}
