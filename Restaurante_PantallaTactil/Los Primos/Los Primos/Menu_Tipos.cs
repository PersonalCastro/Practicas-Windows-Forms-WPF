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
using System.IO;

namespace Los_Primos
{

    /*Iconos diseñados por <a href="https://www.flaticon.es/autores/smashicons" title="Smashicons">Smashicons</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>*/
    public partial class Menu_Tipos: UserControl
    {




        private static ArrayList carritoCompra_id = new ArrayList();
        private ArrayList allProducts = new ArrayList();

        public static void addid_product(int id)
        {
            carritoCompra_id.Add(id);
        }

        public static ArrayList getIdProducts()
        {
            return carritoCompra_id;
        }

        public static void eliminateProduct(int idRemoved)
        {
            Console.WriteLine("bb" + idRemoved);
            carritoCompra_id.RemoveAt(idRemoved);
        }



        private static string actualOrder;

        public static void actualOrder_add(string actualOrder_add)
        {
            actualOrder += "_" + actualOrder_add;
        }

        public static void actualOrder_cleanTipe()
        {
            if(actualOrder != null && !actualOrder.Equals(""))
            {
                actualOrder = actualOrder.Substring(0, actualOrder.IndexOf("_") + 1);

            }
        }

        public static string actualOrder_kind()
        {
            return actualOrder;
        }


        private static bool paraLlevar;

        public static void tipoDePedido_Aqui_o_Llevar(bool paraLlevar_aux)
        {
            paraLlevar = paraLlevar_aux;
        }



        private static Menu_Tipos _instance;
        private Form1 thisForm;

        public static Menu_Tipos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Menu_Tipos();

                }
                return _instance;
            }
        }



        public Menu_Tipos()
        {
            InitializeComponent();

            allProducts = Producto.generateProducts();

            userControl_Shawarma1.Visible = false;
            terminarPedido1.Visible = false;

        }

        public Menu_Tipos(Form1 thisForm)
        {
            InitializeComponent();

            this.thisForm = thisForm;

        }

        private void Menu_Tipos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BUTON SHawarma
            actualOrder = "shawarma_";
            userControl_Shawarma1.Visible = true;
            userControl_Shawarma1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Vuelta_Click(object sender, EventArgs e)
        {
            actualOrder = "";
            tomar_o_llevar1.Visible = true;
            tomar_o_llevar1.BringToFront();
        }

        private void buttonDurum_Click(object sender, EventArgs e)
        {
            //BUTON DURUM
            actualOrder = "durum_";
            userControl_Shawarma1.Visible = true;
            userControl_Shawarma1.BringToFront();
        }

        private void buttonHamburguesa_Click(object sender, EventArgs e)
        {
            //BUTON hamburgesa
            actualOrder = "hamburguesa_";
            userControl_Shawarma1.Visible = true;
            userControl_Shawarma1.BringToFront();
        }

        private void buttonTarrina_Click(object sender, EventArgs e)
        {
            //BUTON Tarrinica
            actualOrder = "tarrina_";
            userControl_Shawarma1.Visible = true;
            userControl_Shawarma1.BringToFront();
        }

        private void buttonBebida_Click(object sender, EventArgs e)
        {
            //BUTON bebia
            actualOrder = "bebida_";

        }

        private void buttonPiezas_Click(object sender, EventArgs e)
        {
            //BUTON Piecitas
            actualOrder = "piezas_";

        }

        private void tomar_o_llevar1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            terminarPedido1.Visible = true;
            userControl_Shawarma1.BringToFront();

        }

        private void userControl_Shawarma1_Load(object sender, EventArgs e)
        {

        }

        private void metodoDePago1_Load(object sender, EventArgs e)
        {

        }

        private void terminarPedido1_Load(object sender, EventArgs e)
        {

        }


    }
}
