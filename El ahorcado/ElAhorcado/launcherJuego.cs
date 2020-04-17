using System;
using System.Collections;
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
    public partial class launcherJuego: Form
    {
        private interfazDeJuego nuevaInterfaz;
        private NuevaPalabra nuevaPalabra;
        private string admin;
        private string password;
        public ArrayList nuevasPalabras;

        public launcherJuego()
        {
            InitializeComponent();
            nuevaPalabra = new NuevaPalabra(this);

            nuevasPalabras = new ArrayList();
            admin = "root";
            password = "root";
            this.comboBoxdificultades.SelectedIndex = 0;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            nuevaInterfaz = new interfazDeJuego(this, nuevasPalabras, this.comboBoxdificultades.SelectedIndex);

            nuevaInterfaz.generarRespuesta();
            Console.WriteLine(nuevaInterfaz.respuesta);
            nuevaInterfaz.Visible = true;
            nuevaPalabra.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxAdmin.Text.Equals(admin) && this.textBoxPassword.Text.Equals(password))
            {
                nuevaPalabra.Visible = true;

            }
        }
    }
}
