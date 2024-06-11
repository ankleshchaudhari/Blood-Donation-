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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {

            Form5 f5= new Form5();
            f5.Show();

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox6.Text = "Yes";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox6.Text = "No";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox7.Text = "Yes";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                textBox7.Text = "No";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox7.Text = "Sometime";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox8.Text = "Yes";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                textBox8.Text = "No";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDataSet1.body' table. You can move, or remove it, as needed.
            this.bodyTableAdapter.Fill(this.bloodDataSet1.body);

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            bodyBindingSource.AddNew();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            bodyBindingSource.EndEdit();
            bodyTableAdapter.Update(bloodDataSet1.body);
            MessageBox.Show("Record Saved");
        }
    }
}
