using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class Form1 : Form
    {
        public int size;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = false;
            size = 3;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            size = 4; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (size == 3)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            
        }
    }
}
