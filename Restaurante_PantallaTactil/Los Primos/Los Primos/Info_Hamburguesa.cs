using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Los_Primos
{
    public partial class Info_Hamburguesa: UserControl
    {

        private ArrayList shawarmas;
        private string tipoCarne;
        private Producto aux;
        private double precioActual;


        public Info_Hamburguesa()
        {
            InitializeComponent();

            shawarmas = Producto.generateProducts();

        }

        private void button_Vuelta_Click(object sender, EventArgs e)
        {
            aux = null;

            this.Visible = false;
            Menu_Tipos.actualOrder_cleanTipe();
        }

        private void Info_Hamburguesa_VisibleChanged(object sender, EventArgs e)
        {
            label_precio.Text = "Precio: (Selecciona el tamaño)";
            tipoCarne = Menu_Tipos.actualOrder_kind();
            Console.WriteLine(tipoCarne);
        }

        private void button_peque_Click(object sender, EventArgs e)
        {
            aux = null;

            if (tipoCarne.Contains("pollo"))
            {
                aux = (Producto) shawarmas[9 + 9 + 0];

            }
            else if (tipoCarne.Contains("ternera"))
            {
                aux = (Producto) shawarmas[9 + 9 + 0 + 3];

            }
            else if (tipoCarne.Contains("cordero"))
            {
                aux = (Producto) shawarmas[9 + 9 + 0 + 3 + 3];

            }


            label_precio.Text = "Precio: " + aux.precio;
            precioActual = aux.precio;
            this.n_pedidos.Text = "1";
        }

        private void button_medi_Click(object sender, EventArgs e)
        {
            aux = null;

            if (tipoCarne.Contains("pollo"))
            {
                aux = (Producto) shawarmas[9 + 9 + 1];

            }
            else if (tipoCarne.Contains("ternera"))
            {
                aux = (Producto) shawarmas[9 + 9 + 1 + 3];

            }
            else if (tipoCarne.Contains("cordero"))
            {
                aux = (Producto) shawarmas[9 + 9 + 1 + 3 + 3];

            }


            label_precio.Text = "Precio: " + aux.precio;
            precioActual = aux.precio;
            this.n_pedidos.Text = "1";
        }

        private void button_grand_Click(object sender, EventArgs e)
        {
            aux = null;

            if (tipoCarne.Contains("pollo"))
            {
                aux = (Producto) shawarmas[9 + 9 + 2];

            }
            else if (tipoCarne.Contains("ternera"))
            {
                aux = (Producto) shawarmas[9 + 9 + 2 + 3];

            }
            else if (tipoCarne.Contains("cordero"))
            {
                aux = (Producto) shawarmas[9 + 9 + 2 + 3 + 3];

            }


            label_precio.Text = "Precio: " + aux.precio;
            precioActual = aux.precio;
            this.n_pedidos.Text = "1";
        }

        private void button_addToCart_Click(object sender, EventArgs e)
        {
            if (aux != null)
            {
                for (int i = 0 ; i < Int16.Parse(this.n_pedidos.Text) ; i++)
                {
                    Menu_Tipos.addid_product(aux.id);
                }
                UserControl_Shawarma.pedidoRealizado_done();
                aux = null;
                this.Visible = false;
                Menu_Tipos.actualOrder_cleanTipe();
            }
        }

        private void Info_Hamburguesa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.n_pedidos.Text != "1")
            {
                this.n_pedidos.Text = (Int16.Parse(this.n_pedidos.Text) - 1).ToString();
                if (aux != null)
                {
                    label_precio.Text = "Precio: " + (precioActual * Int16.Parse(n_pedidos.Text)).ToString();
                }
            }
        }

        private void n_pedidos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.n_pedidos.Text = (Int16.Parse(this.n_pedidos.Text) + 1).ToString();
            if (aux != null)
            {
                label_precio.Text = "Precio: " + (precioActual * Int16.Parse(n_pedidos.Text)).ToString();
            }
        }
    }
}
