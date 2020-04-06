using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RusWords.Add("Собака", "Собака");
            RusWords.Add("Кошка", "Кошка");

            EnWords.Add("Собака", "Dog");
            EnWords.Add("Кошка", "Cat");
        }

        Dictionary<string, string> RusWords = new Dictionary<string, string>();
        Dictionary<string, string> EnWords = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
          //  RusWords.Add("Собака", "Собака");
          //  RusWords.Add("Кошка", "Кошка");

          //  EnWords.Add("Собака", "Dog");
          //  EnWords.Add("Кошка", "Cat");
        }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
  
     //   }

        private void RU_Click(object sender, EventArgs e)
         {
            button3.Text = RusWords["Собака"];
            button4.Text = RusWords["Кошка"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Text = EnWords["Собака"];
            button4.Text = EnWords["Кошка"];
        }
    }
}
