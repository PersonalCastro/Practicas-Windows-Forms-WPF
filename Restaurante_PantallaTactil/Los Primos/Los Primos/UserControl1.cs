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
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1.exit();

        }

        private void label_Title_Click(object sender, EventArgs e)
        {
            Form1.exit();

        }

        private void UserControl1_VisibleChanged(object sender, EventArgs e)
        {

            if (TerminarPedido.pagarEnCaja)
            {
                label1.Text = "Recoja el ticket de su pedido y pague en caja";
            }
            else
            {
                label1.Text = "Pase la tarjeta por el lector de tarjetas";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1.exit();

        }
    }
}
