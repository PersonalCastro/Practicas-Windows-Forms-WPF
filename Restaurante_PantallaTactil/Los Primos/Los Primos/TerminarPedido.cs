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
    public partial class TerminarPedido: UserControl
    {
        private double precioFinal = 0;
        private ImageList imgs;
        public static bool pagarEnCaja = false;


        public TerminarPedido()
        {
            InitializeComponent();
            metodoDePago1.Visible = false;

        }

        private void button_Vuelta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TerminarPedido_Load(object sender, EventArgs e)
        {

        }

        private void TerminarPedido_VisibleChanged(object sender, EventArgs e)
        {
            precioFinal = 0;

            listView1.Clear();


            listView1.View = View.Details;

            listView1.Columns.Add("Imagen_Producto", 150);
            listView1.Columns.Add("Producto", 150);
            listView1.Columns.Add("Tipo de carne", 150);
            listView1.Columns.Add("Tamaño", 150);
            listView1.Columns.Add("Precio", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);


            ArrayList idsPedidos = Menu_Tipos.getIdProducts();

            ArrayList productosPedidos = new ArrayList();

            Producto productos = new Producto();

            foreach (int id_producto in idsPedidos)
            {

                productosPedidos.Add(productos.getProductById(id_producto));

            }

            images();

            foreach (Producto producto in productosPedidos)
            {

                listView1.SmallImageList = imgs;



                ListViewItem item = new ListViewItem();

                if(producto.id < 10)
                {
                    item = new ListViewItem("1", 0);
                }
                else if(producto.id < 20)
                {
                    item = new ListViewItem("2", 1);
                }
                else if (producto.id < 30)
                {
                    item = new ListViewItem("3", 2);
                }
                else
                {
                    item = new ListViewItem("4", 3);
                }


                item.SubItems.Add(producto.nombre);
                item.SubItems.Add(producto.tipo);
                item.SubItems.Add(producto.size);
                item.SubItems.Add(producto.precio.ToString());


                listView1.Items.Add(item);


                precioFinal += producto.precio;
            }


            //Crear                 lista
            //cambiar               precioFinal = 0;

            label_precio.Text = "Precio final: " + precioFinal;
            button_addToCart.Text = "ELEGIR MÉTODO DE PAGO";

        }

        private void images()
        {
            imgs = new ImageList();
            imgs.ImageSize = new Size(150, 100);

            String[] paths = { };
            paths = Directory.GetFiles("C:/Users/PersonalCastro/Desktop/trabajo_DI/productos");

            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }


        private void button_addToCart_Click(object sender, EventArgs e)
        {
            if (precioFinal != 0)
            {
                
                metodoDePago1.Visible = true;
                button_addToCart.Text = "ELEGIR MÉTODO DE PAGO";
            }
            else
            {

                button_addToCart.Text = "Debes añadir algún producto";

            }

        }

        private void metodoDePago1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            ArrayList idsPedidos = Menu_Tipos.getIdProducts();

            ArrayList productosPedidos = new ArrayList();

            Producto productos = new Producto();

            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                Menu_Tipos.eliminateProduct(lista.Index);
                Console.WriteLine(lista.Index);
                lista.Remove();
            }

            //
            foreach (int id_producto in idsPedidos)
            {

                productosPedidos.Add(productos.getProductById(id_producto));

            }

            precioFinal = 0;
            foreach (Producto producto in productosPedidos)
            {
                precioFinal += producto.precio;
            }

            label_precio.Text = "Precio final: " + precioFinal;

        }

        private void label_precio_Click(object sender, EventArgs e)
        {
        }

        private void metodoDePago1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
