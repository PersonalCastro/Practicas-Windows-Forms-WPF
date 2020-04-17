using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Los_Primos
{
    public partial class MenuPrincipal: UserControl
    {

        private static MenuPrincipal _instance;
        private Form1 thisForm;

        public static MenuPrincipal Instance 
        {
            get 
            {
                if(_instance == null)
                {
                    _instance = new MenuPrincipal();

                }
                return _instance;
            }
        }

        public MenuPrincipal()
        {
            InitializeComponent();

        }

        public MenuPrincipal(Form1 thisForm)
        {
            InitializeComponent();

            this.thisForm = thisForm;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form2 adminUser = new Form2();

            adminUser.Visible = true;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label_Title_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }

        private void label_SelectOrder_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!this.thisForm.panel_CU.Controls.Contains(Menu_Tipos.Instance))
            {
                this.thisForm.panel_CU.Controls.Add(Menu_Tipos.Instance);
                Menu_Tipos.Instance.Dock = DockStyle.Fill;
                Menu_Tipos.Instance.BringToFront();

            }
            else
            {
                Menu_Tipos.Instance.BringToFront();
            }
        }
    }
}
