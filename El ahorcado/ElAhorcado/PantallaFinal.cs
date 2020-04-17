using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElAhorcado
{
    public partial class PantallaFinal: Form
    {

        private launcherJuego antiguoForm;
        private string estadoFinal;

        public PantallaFinal(launcherJuego antiguoFormRecivido, String ganado_perdido)
        {
            antiguoForm = new launcherJuego();
            antiguoForm = antiguoFormRecivido;
            InitializeComponent();

            this.labelRespuesta.Text = ganado_perdido;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.antiguoForm.Visible = true;
            this.Visible = false;
        }

        private void PantallaFinal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.antiguoForm.Close();
        }
    }
}
