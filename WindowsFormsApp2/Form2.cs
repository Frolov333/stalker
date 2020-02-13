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
    public struct pers
    {
        public int part;
        public string name;
        public pers(int part1, string name1)
        {
            part = part1;
            name = name1;
        }
    }

    public partial class Form2 : Form
    {
        pers[] lyudi = new pers[100];
        public Form2()
        {
            InitializeComponent();
            lyudi[0] = new pers(2, "sidor");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    } // private void button1_Click(object sender, EventArgs e)
  //  {
  //        for(int i = 0; i < 4; i++)
   //         {
   //        if (pers[i].part < Convert.ToInt32(ComboBox1.Text))
   //         }
  //  }
//}   
