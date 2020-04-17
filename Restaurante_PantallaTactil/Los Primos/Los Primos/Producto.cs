using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Los_Primos
{

    public class Producto
    {

        public int id;
        public string nombre;
        public string tipo;
        public string size;
        public double precio;
        public bool ofertado;
        public double precio_oferta;

        ArrayList productos;

        public Producto()
        {
            productos = new ArrayList();
            productos = generateProducts();
        }



        public Producto(int id_aux, string nombre_aux, string tipo_aux, string size_aux, double precio_aux, bool ofertado_aux, double precio_oferta_aux)
        {
            id = id_aux;
            nombre = nombre_aux;
            tipo = tipo_aux;
            size = size_aux;
            precio = precio_aux;
            ofertado = ofertado_aux;
            precio_oferta = precio_oferta_aux;
        }


        public static ArrayList generateProducts()
        {
            ArrayList productos = new ArrayList();

            //shawarma
            productos.Add(new Producto(1,"shawarma","pollo","pequeño",3.5,false,0));
            productos.Add(new Producto(2, "shawarma", "pollo", "mediano", 4, false, 0));
            productos.Add(new Producto(3, "shawarma", "pollo", "grande", 5, false, 0));

            productos.Add(new Producto(4, "shawarma", "ternera", "pequeño", 4, false, 0));
            productos.Add(new Producto(5, "shawarma", "ternera", "mediano", 4.5, false, 0));
            productos.Add(new Producto(6, "shawarma", "ternera", "grande", 5.5, false, 0));

            productos.Add(new Producto(7, "shawarma", "cordero", "pequeño", 4.5, false, 0));
            productos.Add(new Producto(8, "shawarma", "cordero", "mediano", 5, false, 0));
            productos.Add(new Producto(9, "shawarma", "cordero", "grande", 6, false, 0));


            //durum
            productos.Add(new Producto(11, "durum", "pollo", "pequeño", 3.5, false, 0));
            productos.Add(new Producto(12, "durum", "pollo", "mediano", 4, false, 0));
            productos.Add(new Producto(13, "durum", "pollo", "grande", 4.5, false, 0));

            productos.Add(new Producto(14, "durum", "ternera", "pequeño", 4, false, 0));
            productos.Add(new Producto(15, "durum", "ternera", "mediano", 4.5, false, 0));
            productos.Add(new Producto(16, "durum", "ternera", "grande", 5, false, 0));

            productos.Add(new Producto(17, "durum", "cordero", "pequeño", 4.5, false, 0));
            productos.Add(new Producto(18, "durum", "cordero", "mediano", 5, false, 0));
            productos.Add(new Producto(19, "durum", "cordero", "grande", 5.5, false, 0));


            //Hamburguesa
            productos.Add(new Producto(21, "hamburguesa", "pollo", "pequeño", 2.5, false, 0));
            productos.Add(new Producto(22, "hamburguesa", "pollo", "mediano", 3, false, 0));
            productos.Add(new Producto(23, "hamburguesa", "pollo", "grande", 3.5, false, 0));

            productos.Add(new Producto(24, "hamburguesa", "ternera", "pequeño", 2.5, false, 0));
            productos.Add(new Producto(25, "hamburguesa", "ternera", "mediano", 3.5, false, 0));
            productos.Add(new Producto(26, "hamburguesa", "ternera", "grande", 4, false, 0));

            productos.Add(new Producto(27, "hamburguesa", "cordero", "pequeño", 2.5, false, 0));
            productos.Add(new Producto(28, "hamburguesa", "cordero", "mediano", 3.5, false, 0));
            productos.Add(new Producto(29, "hamburguesa", "cordero", "grande", 4, false, 0));


            //Tarrina
            productos.Add(new Producto(31, "tarrina", "pollo", "pequeño", 3.5, false, 0));
            productos.Add(new Producto(32, "tarrina", "pollo", "mediano", 4, false, 0));
            productos.Add(new Producto(33, "tarrina", "pollo", "grande", 5, false, 0));

            productos.Add(new Producto(34, "tarrina", "ternera", "pequeño", 4, false, 0));
            productos.Add(new Producto(35, "tarrina", "ternera", "mediano", 4.5, false, 0));
            productos.Add(new Producto(36, "tarrina", "ternera", "grande", 5.5, false, 0));

            productos.Add(new Producto(37, "tarrina", "cordero", "pequeño", 4, false, 0));
            productos.Add(new Producto(38, "tarrina", "cordero", "mediano", 4.5, false, 0));
            productos.Add(new Producto(39, "tarrina", "cordero", "grande", 5.5, false, 0));

            //Bebida


            //Piezas


            return productos;
        }

        public Producto getProductById(int id_aux)
        {
            Producto aux = new Producto();

            foreach(Producto producto in this.productos)
            {
                if (producto.id == id_aux)
                {
                    aux = producto;
                }
            }

            return aux;
        }

    }
}
