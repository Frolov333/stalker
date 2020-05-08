using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Person : Form
    {
        pers p;
        public Person(pers p)
        {
            InitializeComponent();
            
            label1.Text = p.name;
            label3.Text ="Роль" + p.role;
            label2.Text = "Появился в " + p.part.ToString() + " части";
            pictureBox1.Image = p.pictureBox1.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Person_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(p.adress,
                "C:\\Users\\" + Environment.UserName + "\\Downloads\\" + p.name + ".pdf");
            MessageBox.Show("Сохранено в " + p.name + ".pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("ilyafrolov484@gmail.com");
            MailAddress toAddress = new MailAddress("beavisabra@gmail.com");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Список персонажей";
                mailMessage.Body = "Вот он";
                mailMessage.Body =

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(
                    fromMailAddress.Address,
                    "LGBTF61278125");
                

               // smtpClient.Send(mailMessage);
                MessageBox.Show("Отправлено");            }
        }
    }
}
