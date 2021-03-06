﻿using System;
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

            label1.Text = DateTime.Now.ToLongDateString();

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

        private void Персонаж_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
