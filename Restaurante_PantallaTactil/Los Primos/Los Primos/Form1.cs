using System;
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
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();

            var myControl = new MenuPrincipal(this);

            panel_CU.Controls.Add(myControl);
            panel_CU.BringToFront();


        }

        private void label_SelectOrder_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form2 adminUser = new Form2();

            adminUser.Visible = true;


        }

        internal static void changeToMenuSelections()
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuPrincipal1_Load(object sender, EventArgs e)
        {

        }

        private void menuPrincipal1_Click(object sender, EventArgs e)
        {
        }

        private void panel_CU_Paint(object sender, PaintEventArgs e)
        {
        }

        public static void exit()
        {
            Application.Restart();

        }

    }
}
