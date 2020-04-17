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
    public partial class NuevaPalabra: Form
    {

        private launcherJuego antiguoForm;

        public NuevaPalabra(launcherJuego antiguoFormRecivido)
        {

            antiguoForm = antiguoFormRecivido;


            InitializeComponent();
            this.labelerror.Visible = false;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (!this.textBox1.Text.Equals(""))
            {
                this.labelerror.Visible = false;
                bool palabraYaExistente = false;
                foreach (string palabra in this.antiguoForm.nuevasPalabras)
                {
                    if (this.textBox1.Text.ToUpper().Equals(palabra))
                    {
                        palabraYaExistente = true;
                    }
                }

                if (!palabraYaExistente)
                {
                    this.antiguoForm.nuevasPalabras.Add(this.textBox1.Text.ToUpper());
                    Console.WriteLine(this.textBox1.Text.ToUpper());
                }
                else
                {
                    this.labelerror.Visible = true;
                }

                this.textBox1.Text = "";
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.labelerror.Visible = false;
        }
    }
}
