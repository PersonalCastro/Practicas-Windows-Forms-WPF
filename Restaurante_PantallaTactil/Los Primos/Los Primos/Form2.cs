﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Los_Primos
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("8");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_pswdBox_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("4");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_password.AppendText("1");

        }
    }
}
