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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string i;
        private void Next_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                i = radioButton1.Text.ToString();  
            }else
                if (radioButton2.Checked == true)
                {
                    i = radioButton2.Text.ToString();
                }else
                if (radioButton3.Checked == true)
                {
                    i = radioButton3.Text.ToString();
                }else
                if (radioButton4.Checked == true)
                {
                    i = radioButton4.Text.ToString();
                }else
                if (radioButton5.Checked == true)
                {
                    i = radioButton5.Text.ToString();
                }else
                if (radioButton6.Checked == true)
                {
                    i = radioButton6.Text.ToString();
                }else
                if (radioButton7.Checked == true)
                {
                    i = radioButton7.Text.ToString();
                }else
                if (radioButton8.Checked == true)
                {
                    i = radioButton8.Text.ToString();
                }
                Form3 f3 = new Form3();
                f3.Show();
                    
                
            
            
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Previous_Click(object sender, EventArgs e)
        {

            Form1 f1= new Form1();
            f1.Show();
        }

        private void radioButton1_PaddingChanged(object sender, EventArgs e)
        {

        }
    }
}
