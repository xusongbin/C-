using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RHF6CLN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.Clear();
            comboBox1.Items.Add("RHF6CLN2_LF");
            comboBox1.Items.Add("RHF6CLN2_HF");
            comboBox1.Items.Add("RHF6CLN3_LF");
            comboBox1.Items.Add("RHF6CLN3_HF");
            comboBox1.SelectedIndex = 0;

            this.Text = "RHF6CLN TEST";
        }

        public void Form1_Show()
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2(this, comboBox1.Text);
            f2.ShowDialog();

            // Debug.WriteLine(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
