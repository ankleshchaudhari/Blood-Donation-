using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "anklesh" && textBox2.Text == "12345")
            {
                MessageBox.Show("Login Successfully");
                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username 0r Password");
            }
        }
    }
}
