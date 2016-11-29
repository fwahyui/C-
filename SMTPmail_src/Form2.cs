using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace SMTPmail
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("csmasifa@gmail.com");
                mail.To.Add("fitrianwahyuilahi45@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("csmasifa@gmail.com", "fwi17051988");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        }
}
