using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace SMTPmail
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button SendBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ServSMTP;
		private System.Windows.Forms.TextBox sFrom;
		private System.Windows.Forms.TextBox sTo;
		private System.Windows.Forms.TextBox sSubject;
		private System.Windows.Forms.TextBox sMessage;
		private System.Windows.Forms.ListBox LogList;
		private System.Windows.Forms.Label label6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ServSMTP = new System.Windows.Forms.TextBox();
            this.sFrom = new System.Windows.Forms.TextBox();
            this.sTo = new System.Windows.Forms.TextBox();
            this.sSubject = new System.Windows.Forms.TextBox();
            this.sMessage = new System.Windows.Forms.TextBox();
            this.LogList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(216, 280);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Send";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-8, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP Server";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(48, 72);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Message";
            // 
            // ServSMTP
            // 
            this.ServSMTP.Location = new System.Drawing.Point(80, 24);
            this.ServSMTP.Name = "ServSMTP";
            this.ServSMTP.Size = new System.Drawing.Size(208, 20);
            this.ServSMTP.TabIndex = 2;
            this.ServSMTP.Text = "smtp.gmail.com";
            // 
            // sFrom
            // 
            this.sFrom.Location = new System.Drawing.Point(80, 48);
            this.sFrom.Name = "sFrom";
            this.sFrom.Size = new System.Drawing.Size(208, 20);
            this.sFrom.TabIndex = 3;
            this.sFrom.Text = "csmasifa@gmail.com";
            // 
            // sTo
            // 
            this.sTo.Location = new System.Drawing.Point(80, 72);
            this.sTo.Name = "sTo";
            this.sTo.Size = new System.Drawing.Size(208, 20);
            this.sTo.TabIndex = 4;
            this.sTo.Text = "fitrianwahyuilahi45@gmail.com";
            // 
            // sSubject
            // 
            this.sSubject.Location = new System.Drawing.Point(80, 96);
            this.sSubject.Name = "sSubject";
            this.sSubject.Size = new System.Drawing.Size(208, 20);
            this.sSubject.TabIndex = 5;
            this.sSubject.Text = "Loging";
            // 
            // sMessage
            // 
            this.sMessage.Location = new System.Drawing.Point(8, 136);
            this.sMessage.Multiline = true;
            this.sMessage.Name = "sMessage";
            this.sMessage.Size = new System.Drawing.Size(501, 136);
            this.sMessage.TabIndex = 6;
            this.sMessage.Text = "your message";
            // 
            // LogList
            // 
            this.LogList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogList.Location = new System.Drawing.Point(0, 328);
            this.LogList.Name = "LogList";
            this.LogList.ScrollAlwaysVisible = true;
            this.LogList.Size = new System.Drawing.Size(521, 121);
            this.LogList.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Log Report";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(521, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogList);
            this.Controls.Add(this.sMessage);
            this.Controls.Add(this.sSubject);
            this.Controls.Add(this.sTo);
            this.Controls.Add(this.sFrom);
            this.Controls.Add(this.ServSMTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBtn);
            this.Name = "Form1";
            this.Text = "Send Mail via SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form2());
		}

		private void SendBtn_Click(object sender, System.EventArgs e)
		{
			// change cursor into wait cursor
			Cursor cr = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;

			// create server SMTP with port 25
			TcpClient SmtpServ = new TcpClient(ServSMTP.Text,25);
			string Data;
			byte[] szData;
			string CRLF = "\r\n";
			LogList.Items.Clear();			

			try
			{
				// initialization
				NetworkStream NetStrm = SmtpServ.GetStream();
				StreamReader  RdStrm= new StreamReader(SmtpServ.GetStream());
				LogList.Items.Add(RdStrm.ReadLine());

				
				// say hello to server and send response into log report
				Data = "HELLO server " + CRLF;				
				szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				LogList.Items.Add(RdStrm.ReadLine());

				// send sender data
				Data = "MAIL FROM: " + "<" + sFrom.Text + ">" + CRLF;
				szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				LogList.Items.Add(RdStrm.ReadLine());

				// send receiver data
				Data = "RCPT TO: " + "<" + sTo.Text + ">" + CRLF;
				szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				LogList.Items.Add(RdStrm.ReadLine());

				// send DATA
				Data = "DATA " + CRLF;
				szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				LogList.Items.Add(RdStrm.ReadLine());				

				// send content data
				Data = "SUBJECT: " + sSubject.Text + CRLF + sMessage.Text + CRLF + "." + CRLF;
				szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				LogList.Items.Add(RdStrm.ReadLine());				

				// quit from server SMTP
				Data = "QUIT " + CRLF;
				szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
				NetStrm.Write(szData,0,szData.Length);
				LogList.Items.Add(RdStrm.ReadLine());				

				// close connection
				NetStrm.Close();
				RdStrm.Close();
				LogList.Items.Add("Close connection");
				LogList.Items.Add("Send mail successly..");

				// back to normal cursor
				Cursor.Current = cr;

			}
			catch(InvalidOperationException err)
			{
				LogList.Items.Add("Error: "+ err.ToString());
			}


		}
	}
}
