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
    /*  Iconos diseñados por <a href="https://www.flaticon.es/autores/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a> 
        Iconos diseñados por <a href="https://www.flaticon.es/autores/monkik" title="monkik">monkik</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>*/
    public partial class MetodoDePago: UserControl
    {
        public MetodoDePago()
        {
            InitializeComponent();
        }

        private void MetodoDePago_Load(object sender, EventArgs e)
        {

        }

        private void button_Vuelta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TerminarPedido.pagarEnCaja = false;
            userControl11.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TerminarPedido.pagarEnCaja = true;
            userControl11.Visible = true;

        }

        private void MetodoDePago_VisibleChanged(object sender, EventArgs e)
        {
            userControl11.Visible = false;

        }
    }
}
