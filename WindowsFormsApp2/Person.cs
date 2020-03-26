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
    public partial class Person : Form
    {
        public Person(pers p)
        {
            InitializeComponent();

            label1.Text = p.name;
            label3.Text = p.role;
            label2.Text = "Появился в " + p.part.ToString() + " части";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Person_Load(object sender, EventArgs e)
        {

        }
    }
}
