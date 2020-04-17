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
    public partial class UserControl_Shawarma: UserControl
    {

        private static bool pedidoRealizado;

        public static void pedidoRealizado_done()
        {
            pedidoRealizado = true;
        }


        public UserControl_Shawarma()
        {
            InitializeComponent();
            pedidoRealizado = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BOTON POLLO
            pedidoRealizado = false;
            Menu_Tipos.actualOrder_add("pollo");
            if (Menu_Tipos.actualOrder_kind().Contains("shawarma"))
            {
                info_shawarma1.Visible = true;
                info_shawarma1.BringToFront();

            }
            else if (Menu_Tipos.actualOrder_kind().Contains("durum"))
            {
                info_durum1.Visible = true;
                info_durum1.BringToFront();
            }
            else if (Menu_Tipos.actualOrder_kind().Contains("hamburguesa"))
            {
                info_Hamburguesa1.Visible = true;
                info_Hamburguesa1.BringToFront();
            }
            else if (Menu_Tipos.actualOrder_kind().Contains("tarrina"))
            {
                info_Tarrina1.Visible = true;
                info_Tarrina1.BringToFront();
            }
        }

        private void button_ternera_Click(object sender, EventArgs e)
        {
            pedidoRealizado = false;

            //BOTON Ternera
            Menu_Tipos.actualOrder_add("ternera");
            if (Menu_Tipos.actualOrder_kind().Contains("shawarma"))
            {
                info_shawarma1.Visible = true;
                info_shawarma1.BringToFront();

            }
            else if (Menu_Tipos.actualOrder_kind().Contains("durum"))
            {
                info_durum1.Visible = true;
                info_durum1.BringToFront();
            }
            else if (Menu_Tipos.actualOrder_kind().Contains("hamburguesa"))
            {
                info_Hamburguesa1.Visible = true;
                info_Hamburguesa1.BringToFront();
            }
            else if (Menu_Tipos.actualOrder_kind().Contains("tarrina"))
            {
                info_Tarrina1.Visible = true;
                info_Tarrina1.BringToFront();
            }
        }

        private void button_cordero_Click(object sender, EventArgs e)
        {
            pedidoRealizado = false;

            //BOTON Cordero
            Menu_Tipos.actualOrder_add("cordero");
            if (Menu_Tipos.actualOrder_kind().Contains("shawarma"))
            {
                info_shawarma1.Visible = true;
                info_shawarma1.BringToFront();

            }
            else if (Menu_Tipos.actualOrder_kind().Contains("durum"))
            {
                info_durum1.Visible = true;
                info_durum1.BringToFront();
            }
            else if (Menu_Tipos.actualOrder_kind().Contains("hamburguesa"))
            {
                info_Hamburguesa1.Visible = true;
                info_Hamburguesa1.BringToFront();
            }
            else if (Menu_Tipos.actualOrder_kind().Contains("tarrina"))
            {
                info_Tarrina1.Visible = true;
                info_Tarrina1.BringToFront();
            }

        }

        private void button_Vuelta_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void info_shawarma1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_Shawarma_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_Shawarma_VisibleChanged(object sender, EventArgs e)
        {

            info_shawarma1.Visible = false;
            info_durum1.Visible = false;
            info_Hamburguesa1.Visible = false;
            info_Tarrina1.Visible = false;


        }

        private void info_durum1_Load(object sender, EventArgs e)
        {

        }

        private void info_Hamburguesa1_Load(object sender, EventArgs e)
        {

        }

        private void info_Tarrina1_Load(object sender, EventArgs e)
        {

        }

        public static void close_window()
        {
            
        }

        private void info_Tarrina1_VisibleChanged(object sender, EventArgs e)
        {
            if (pedidoRealizado)
            {
                this.Visible = false;
            }
        }

        private void info_Hamburguesa1_VisibleChanged(object sender, EventArgs e)
        {
            if (pedidoRealizado)
            {
                this.Visible = false;
            }
        }

        private void info_durum1_VisibleChanged(object sender, EventArgs e)
        {
            if (pedidoRealizado)
            {
                this.Visible = false;
            }
        }

        private void info_shawarma1_VisibleChanged(object sender, EventArgs e)
        {
            if (pedidoRealizado)
            {
                this.Visible = false;
            }
        }
    }
}
