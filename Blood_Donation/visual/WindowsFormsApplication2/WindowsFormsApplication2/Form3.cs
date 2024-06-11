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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox5.Text = "Male";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox5.Text = "Female";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox5.Text = "Other";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Jalgaon")
            {
                textBox9.Text = "Jalgaon";
            }else
            if (comboBox1.SelectedItem == "Dhule")
            {
                textBox9.Text = "Dhule";
            }else
            if (comboBox1.SelectedItem == "Surat")
            {
                textBox9.Text = "Surat";
            }else
            if (comboBox1.SelectedItem == "Ahemdabad")
            {
                textBox9.Text = "Ahemdabad";
            }else
            if (comboBox1.SelectedItem == "Patna")
            {
                textBox9.Text = "Patna";
            }else
            if (comboBox1.SelectedItem == "Banaras")
            {
                textBox9.Text = "Banaras";
            }else
            if (comboBox1.SelectedItem == "Indore")
            {
                textBox9.Text = "Indore";
            }else
            if (comboBox1.SelectedItem == "Bhopal")
            {
                textBox9.Text = "Bhopal";
            }else
            if (comboBox1.SelectedItem == "Godavari")
            {
                textBox9.Text = "Godavari";
            }else
            if (comboBox1.SelectedItem == "Prakasam")
            {
                textBox9.Text = "Prakasam";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Maharashtra")
            {
                textBox10.Text = "Maharashtra";
            }else
                if (comboBox2.SelectedItem == "gujrat")
            {
                textBox10.Text ="gujrat";
            }else
            if (comboBox2.SelectedItem == "Uttar Pradesh")
            {
                textBox10.Text = "Uttar Pradesh";
            }else
            if (comboBox2.SelectedItem == "Madhya Pradesh")
            {
                textBox10.Text = "Madhya Pradesh";
            }else
            if (comboBox2.SelectedItem == "Andhra Pradesh")
            {
                textBox10.Text = "Andhra Pradesh";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDataSet.personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.bloodDataSet.personal);
            textBox12.Text = Form2.i;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            personalBindingSource.AddNew();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            personalBindingSource.EndEdit();
            personalTableAdapter.Update(bloodDataSet.personal);
            MessageBox.Show("Record Saved");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
