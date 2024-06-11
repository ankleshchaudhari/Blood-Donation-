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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDataSet2.bloodbank' table. You can move, or remove it, as needed.
            this.bloodbankTableAdapter.Fill(this.bloodDataSet2.bloodbank);

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bloodbankBindingSource.EndEdit();
            bloodbankTableAdapter.Update(bloodDataSet2.bloodbank);
            MessageBox.Show("Your Application has Submitted");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Blood bank(jalgaon)")
            {
                textBox1.Text = "Indira blood bank(jalgaon)";
                textBox2.Text = "0258722781";
                textBox3.Text = "indira@gmail.com";
                textBox4.Text = "Patware colony,Nakane road";
                textBox5.Text = "Jalgaon";
                textBox6.Text = "Maharashtra";

            }else 
            if (comboBox1.SelectedItem == "Blood bank(dhule)")
            {
                textBox1.Text = "Medical blood bank(dhule)";
                textBox2.Text = "0256722234";
                textBox3.Text = "medical@gmail.com";
                textBox4.Text = "Ganesh colony,Dhule road";
                textBox5.Text = "Dhule";
                textBox6.Text = "Maharashtra";

            }else 
            if (comboBox1.SelectedItem == "Blood bank(surat)")
            {
                textBox1.Text = "Civil blood bank(surat)";
                textBox2.Text = "0256721779";
                textBox3.Text = "bbcivil@gmailcom";
                textBox4.Text = "shiv clolony,Ambedkar road";
                textBox5.Text = "Surat";
                textBox6.Text = "Gujrat";
            }else
            if (comboBox1.SelectedItem == "Blood bank(ahemdabad)")
            {
                textBox1.Text = "Support blood bank(ahemdabad)";
                textBox2.Text = "25002400";
                textBox3.Text = "supportbb@gmailcom";
                textBox4.Text = "Arjun nagar,Garware Road";
                textBox5.Text = "Ahemdabad";
                textBox6.Text = "Gujrat";
            }else
            if (comboBox1.SelectedItem == "Blood bank(patna)")
            {
                textBox1.Text = "Navjivan blood bank(patna)";
                textBox2.Text = "35003400";
                textBox3.Text = "navjivanbb@gmailcom";
                textBox4.Text = "Deepak clolony,MG road";
                textBox5.Text = "Patna";
                textBox6.Text = "Uttar Pradesh";
            }else
                if (comboBox1.SelectedItem == "Blood bank(banaras)")
                {
                    textBox1.Text = "Donar blood bank()";
                    textBox2.Text = "45004400";
                    textBox3.Text = "bbdonar@gmailcom";
                    textBox4.Text = "Pale nagar,FC road";
                    textBox5.Text = "Banaras";
                    textBox6.Text = "Uttar Pradesh";
                }else
                    if (comboBox1.SelectedItem == "Blood bank(indore)")
                    {
                        textBox1.Text = "Service blood bank(indore)";
                        textBox2.Text = "55005400";
                        textBox3.Text = "service@gmailcom";
                        textBox4.Text = "shah nagar,Shree road";
                        textBox5.Text = "Indore";
                        textBox6.Text = "Madhya Pradesh";
                    }else
                        if (comboBox1.SelectedItem == "Blood bank(bhopal)")
                        {
                            textBox1.Text = "RK blood bank()";
                            textBox2.Text = "65006400";
                            textBox3.Text = "bbrk@gmailcom";
                            textBox4.Text = "Rajiv nagar,College road";
                            textBox5.Text = "Bhopal";
                            textBox6.Text = "Madhya Pradesh";
                        }else
                        if (comboBox1.SelectedItem == "Blood bank(godavari)")
                        {
                            textBox1.Text = "Saver blood bank()";
                            textBox2.Text = "75007400";
                            textBox3.Text = "Savier@gmailcom";
                            textBox4.Text = "Rajiv nagar,College road";
                            textBox5.Text = "Godavari";
                            textBox6.Text = "AndhraPradesh";
                        }else
                            if (comboBox1.SelectedItem == "Blood bank(prakasam)")
                        {
                            textBox1.Text = "blood bank(Prakasam)";
                            textBox2.Text = "85008400";
                            textBox3.Text = "prakasambb@gmailcom";
                            textBox4.Text = "Adarsh nagar,Patel road";
                            textBox5.Text = "Prakasam";
                            textBox6.Text = "AndhraPradesh";
                        }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            bloodbankBindingSource.AddNew();
        }
    }
}
