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

    /*Iconos diseñados por <a href="https://www.flaticon.es/autores/fjstudio" title="fjstudio">fjstudio</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>*/
    /*Iconos diseñados por <a href="https://www.flaticon.es/autores/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>*/
    public partial class Tomar_o_llevar: UserControl
    {
        public Tomar_o_llevar()
        {
            InitializeComponent();
        }

        private void Tomar_o_llevar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Tipos.tipoDePedido_Aqui_o_Llevar(false);
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Tipos.tipoDePedido_Aqui_o_Llevar(true);
            this.Visible = false;
        }
    }
}
