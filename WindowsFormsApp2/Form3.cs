using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("ilyafrolov484@gmail.com");
            MailAddress toAddress = new MailAddress("ilyafrolov484@gmail.com");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Новый отзыв";
                mailMessage.Body =
                    "Тема:" + comboBox1.Text + Environment.NewLine +
                    "Почта:" + textBox2.Text + Environment.NewLine +
                    "Сообщение: " + Environment.NewLine + textBox1.Text;

              //  if (adress != "")

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(
                    fromMailAddress.Address,
                    "LGBTF61278125");

                #region Ошибки

                if (textBox1.Text.Length <6)
                {
                    MessageBox.Show("Где сообщение?");
                    return;
                }

                if (textBox2.Text.Length < 20)
                    {
                        MessageBox.Show("Укажите почту");
                        return;
                    }

                smtpClient.Send(mailMessage);
                MessageBox.Show("Отправлено");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string adress = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
            }
        }
    }
}


#endregion