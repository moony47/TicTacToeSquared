/*
 * Created by SharpDevelop.
 * User: sfmoo
 * Date: 09/02/2020
 * Time: 01:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TicTacToeSquared
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl0 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.lbl4 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.lbl6 = new System.Windows.Forms.Label();
			this.lbl8 = new System.Windows.Forms.Label();
			this.lbl7 = new System.Windows.Forms.Label();
			this.lblTurn = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtPeerID = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblIP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl0
			// 
			this.lbl0.BackColor = System.Drawing.Color.Black;
			this.lbl0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl0.ForeColor = System.Drawing.Color.White;
			this.lbl0.Location = new System.Drawing.Point(12, 12);
			this.lbl0.Name = "lbl0";
			this.lbl0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl0.Size = new System.Drawing.Size(108, 108);
			this.lbl0.TabIndex = 0;
			this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl0.Visible = false;
			// 
			// lbl1
			// 
			this.lbl1.BackColor = System.Drawing.Color.Black;
			this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.ForeColor = System.Drawing.Color.White;
			this.lbl1.Location = new System.Drawing.Point(134, 12);
			this.lbl1.Name = "lbl1";
			this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl1.Size = new System.Drawing.Size(108, 108);
			this.lbl1.TabIndex = 1;
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl1.Visible = false;
			// 
			// lbl2
			// 
			this.lbl2.BackColor = System.Drawing.Color.Black;
			this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.ForeColor = System.Drawing.Color.White;
			this.lbl2.Location = new System.Drawing.Point(256, 12);
			this.lbl2.Name = "lbl2";
			this.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl2.Size = new System.Drawing.Size(108, 108);
			this.lbl2.TabIndex = 2;
			this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl2.Visible = false;
			// 
			// lbl5
			// 
			this.lbl5.BackColor = System.Drawing.Color.Black;
			this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl5.ForeColor = System.Drawing.Color.White;
			this.lbl5.Location = new System.Drawing.Point(256, 134);
			this.lbl5.Name = "lbl5";
			this.lbl5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl5.Size = new System.Drawing.Size(108, 108);
			this.lbl5.TabIndex = 5;
			this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl5.Visible = false;
			// 
			// lbl4
			// 
			this.lbl4.BackColor = System.Drawing.Color.Black;
			this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl4.ForeColor = System.Drawing.Color.White;
			this.lbl4.Location = new System.Drawing.Point(134, 134);
			this.lbl4.Name = "lbl4";
			this.lbl4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl4.Size = new System.Drawing.Size(108, 108);
			this.lbl4.TabIndex = 4;
			this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl4.Visible = false;
			// 
			// lbl3
			// 
			this.lbl3.BackColor = System.Drawing.Color.Black;
			this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.ForeColor = System.Drawing.Color.White;
			this.lbl3.Location = new System.Drawing.Point(12, 134);
			this.lbl3.Name = "lbl3";
			this.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl3.Size = new System.Drawing.Size(108, 108);
			this.lbl3.TabIndex = 3;
			this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl3.Visible = false;
			// 
			// lbl6
			// 
			this.lbl6.BackColor = System.Drawing.Color.Black;
			this.lbl6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl6.ForeColor = System.Drawing.Color.White;
			this.lbl6.Location = new System.Drawing.Point(12, 256);
			this.lbl6.Name = "lbl6";
			this.lbl6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl6.Size = new System.Drawing.Size(108, 108);
			this.lbl6.TabIndex = 6;
			this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl6.Visible = false;
			// 
			// lbl8
			// 
			this.lbl8.BackColor = System.Drawing.Color.Black;
			this.lbl8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl8.ForeColor = System.Drawing.Color.White;
			this.lbl8.Location = new System.Drawing.Point(256, 256);
			this.lbl8.Name = "lbl8";
			this.lbl8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl8.Size = new System.Drawing.Size(108, 108);
			this.lbl8.TabIndex = 8;
			this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl8.Visible = false;
			// 
			// lbl7
			// 
			this.lbl7.BackColor = System.Drawing.Color.Black;
			this.lbl7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl7.ForeColor = System.Drawing.Color.White;
			this.lbl7.Location = new System.Drawing.Point(134, 256);
			this.lbl7.Name = "lbl7";
			this.lbl7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl7.Size = new System.Drawing.Size(108, 108);
			this.lbl7.TabIndex = 7;
			this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl7.Visible = false;
			// 
			// lblTurn
			// 
			this.lblTurn.BackColor = System.Drawing.Color.Black;
			this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurn.ForeColor = System.Drawing.Color.White;
			this.lblTurn.Location = new System.Drawing.Point(134, 377);
			this.lblTurn.Name = "lblTurn";
			this.lblTurn.Size = new System.Drawing.Size(108, 53);
			this.lblTurn.TabIndex = 9;
			this.lblTurn.Text = "X Turn";
			this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTurn.Visible = false;
			// 
			// btnStart
			// 
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(134, 134);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(108, 54);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "Start Game";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.StartGameClick);
			// 
			// txtPeerID
			// 
			this.txtPeerID.Location = new System.Drawing.Point(69, 100);
			this.txtPeerID.Name = "txtPeerID";
			this.txtPeerID.Size = new System.Drawing.Size(243, 20);
			this.txtPeerID.TabIndex = 11;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(204, 12);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(108, 54);
			this.btnConnect.TabIndex = 13;
			this.btnConnect.Text = "Connect to Server";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.ConnectToServer);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(69, 12);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(108, 54);
			this.btnCreate.TabIndex = 14;
			this.btnCreate.Text = "Create Server";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.CreateServer);
			// 
			// lblIP
			// 
			this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIP.Location = new System.Drawing.Point(69, 79);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(243, 18);
			this.lblIP.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 439);
			this.Controls.Add(this.lblIP);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtPeerID);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblTurn);
			this.Controls.Add(this.lbl8);
			this.Controls.Add(this.lbl7);
			this.Controls.Add(this.lbl6);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.lbl4);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbl0);
			this.Name = "MainForm";
			this.Text = "TicTacToeSquared";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtPeerID;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblTurn;
		private System.Windows.Forms.Label lbl7;
		private System.Windows.Forms.Label lbl8;
		private System.Windows.Forms.Label lbl6;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl0;
	}
}
