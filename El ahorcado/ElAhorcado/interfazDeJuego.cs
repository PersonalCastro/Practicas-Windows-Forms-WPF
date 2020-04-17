using ElAhorcado.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElAhorcado
{
    public partial class interfazDeJuego: Form
    {
        private launcherJuego antiguoForm;
        private ArrayList caracteresErrados;
        private ArrayList caracteresAcertados;
        private int intentos;
        private int pistas;

        public ArrayList diccionario;
        public string respuesta;
        private string respuestaAvance;
        private int cantidadAciertos;




        public interfazDeJuego(launcherJuego antiguoFormRecivido, ArrayList nuevasPalabras, int numeroPistas)
        {
            antiguoForm = new launcherJuego();
            antiguoForm = antiguoFormRecivido;


            caracteresErrados = new ArrayList();
            caracteresAcertados = new ArrayList();
            intentos = 4;

            if (numeroPistas.Equals(0))
            {
                pistas = 2;
            }
            else if (numeroPistas.Equals(1))
            {
                pistas = 1;
            }
            else if (numeroPistas.Equals(2))
            {
                pistas = 0;
            }

            diccionario = new ArrayList();
            cantidadAciertos = 0;
            respuesta = "";
            respuestaAvance = "";
            generarDiccionario(nuevasPalabras);
            Debug.WriteLine(diccionario.Count);

            InitializeComponent();

            this.KeyPreview = true;
            this.button1.Enabled = true;
            this.labelpistas.Text = this.labelpistas.Text.Substring(0, (this.labelpistas.Text.Length - 1)) + pistas;
        }

        private void generarDiccionario(ArrayList nuevasPalabras)
        {

            this.diccionario.Add("REGORDETE");
            this.diccionario.Add("COLEGIO");
            this.diccionario.Add("PIZZA");
            this.diccionario.Add("BARRETINA");
            this.diccionario.Add("BIENESTAR");
            this.diccionario.Add("AMIGO");
            this.diccionario.Add("GOBIERNO");
            this.diccionario.Add("OLVIDARSE");
            this.diccionario.Add("PROBLEMAS");
            this.diccionario.Add("REMATE");

            foreach (string nuevaPalabra in nuevasPalabras)
            {
                this.diccionario.Add(nuevaPalabra);
            }

        }

        public void generarRespuesta()
        {
            Random rnd = new Random();
            int selectRespuesta = rnd.Next(0, diccionario.Count);

            respuesta = (string) diccionario[selectRespuesta];

            foreach(char caracter in respuesta)
            {
                this.labelrespuesta.Text += "_ ";
            }
            this.labelrespuesta.Text = this.labelrespuesta.Text.Substring(0, (this.labelrespuesta.Text.Length - 1));

        }


        private void interfazDeJuego_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void interfazDeJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.antiguoForm.Close();
        }

        private void interfazDeJuego_KeyPressed(object sender, KeyPressEventArgs key)
        {


        }

        void comprobarLetraIntroducida(char keyPressed)
        {
            bool letraYaIntroducida = this.letraYaIntroducida(keyPressed);
            if (!letraYaIntroducida)
            {
                bool letraAcertada = this.letraAcertada(keyPressed);
                if (letraAcertada)
                {
                    this.labelAciertos.Text += keyPressed;
                    this.caracteresAcertados.Add(keyPressed);
                    this.aciertoRealizado();
                }
                else
                {
                    this.falloRealizado();
                    this.labelFallos.Text += keyPressed;
                    this.caracteresErrados.Add(keyPressed);

                }
            }

        }

        bool letraYaIntroducida(char keyPresssed)
        {
            bool yaInsertada = false;
            foreach (char caracter in this.caracteresErrados)
            {
                if (caracter.Equals(keyPresssed))
                {
                    yaInsertada = true;
                }
            }

            foreach (char caracter in this.caracteresAcertados)
            {
                if (caracter.Equals(keyPresssed))
                {
                    yaInsertada = true;
                }
            }

            return yaInsertada;
        }

        bool letraAcertada(char keyPresssed)
        {
            bool letraAcertada = false;

            foreach (char letra in this.respuesta)
            {
                if (letra.Equals(keyPresssed))
                {
                    letraAcertada = true;
                }
            }

            return letraAcertada;
        }

        void aciertoRealizado()
        {
            this.respuestaAvance = "";
            bool letraExistente = false;
            this.labelrespuesta.Text = "";
            foreach (char caracter in this.respuesta)
            {
                letraExistente = false;

                foreach (char caracterYaIntroducido in this.caracteresAcertados)
                {
                    if (caracter.Equals(caracterYaIntroducido))
                    {
                        this.respuestaAvance += caracterYaIntroducido + " ";
                        cantidadAciertos++;
                        letraExistente = true;
                    }

                }

                if (!letraExistente)
                {
                    this.respuestaAvance += "_ ";

                }

            }
            
            this.labelrespuesta.Text = this.respuestaAvance;

            if (cantidadAciertos.Equals(this.respuesta.Length))
            {
                this.Visible = false;
                PantallaFinal nuevaInterfaz = new PantallaFinal(antiguoForm, "Has Ganado");
                nuevaInterfaz.Visible = true;
            }
            cantidadAciertos = 0;
        }

        void falloRealizado()
        {
            if (this.intentos.Equals(4))
            {
               // Image myImage = Resources._2;
                this.pictureBoxAhorcado.Image = Resources._2;
            }
            else if (this.intentos.Equals(3))
            {
                this.pictureBoxAhorcado.Image = Resources._3;
            }
            else if (this.intentos.Equals(2))
            {
                this.pictureBoxAhorcado.Image = Resources._4;
            }
            else if (this.intentos.Equals(1))
            {
                this.pictureBoxAhorcado.Image = Resources._5;
            }

            this.intentos--;
            this.labelIntentosRestantes.Text = this.labelIntentosRestantes.Text.Substring(0, (this.labelIntentosRestantes.Text.Length - 1)) + this.intentos;

            if (this.intentos.Equals(0))
            {

                this.Visible = false;
                PantallaFinal nuevaInterfaz = new PantallaFinal(antiguoForm, "Has Perdido");
                nuevaInterfaz.Visible = true;

            }

        }

        private void Hola(object sender, DrawToolTipEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random rnd = new Random();
            int selectRespuesta = rnd.Next(0, this.respuesta.Length);
            char letraSeleccionadas = this.respuesta[selectRespuesta];

            if (this.labelpistas.Text.Contains("2"))
            {
                this.labelpistas.Text = this.labelpistas.Text.Substring(0, (this.labelpistas.Text.Length - 1)) + 1;


                this.labelPistasDadas.Text += letraSeleccionadas + " ";
            }
            else if (this.labelpistas.Text.Contains("1"))
            {
                this.labelpistas.Text = this.labelpistas.Text.Substring(0, (this.labelpistas.Text.Length - 1)) + 0;

                while(this.labelPistasDadas.Text[this.labelPistasDadas.Text.Length - 1].Equals(letraSeleccionadas))
                {
                    selectRespuesta = rnd.Next(0, this.respuesta.Length);
                    letraSeleccionadas = this.respuesta[selectRespuesta];
                }
                this.labelPistasDadas.Text += letraSeleccionadas;
            }
            Console.WriteLine("boton pulsado");

        }

        private void interfazBuenaDeJuego_KeyPressed(object sender, KeyPressEventArgs key)
        {

            char keyPressed = 'a';
            Console.WriteLine("Letra tocada");
            if (key.KeyChar.Equals('a') || key.KeyChar.Equals('A'))
            {
                keyPressed = 'A';
            }
            else if (key.KeyChar.Equals('b') || key.KeyChar.Equals('B'))
            {
                keyPressed = 'B';
            }
            else if (key.KeyChar.Equals('c') || key.KeyChar.Equals('C'))
            {
                keyPressed = 'C';
            }
            else if (key.KeyChar.Equals('d') || key.KeyChar.Equals('D'))
            {
                keyPressed = 'D';
            }
            else if (key.KeyChar.Equals('e') || key.KeyChar.Equals('E'))
            {
                keyPressed = 'E';
            }
            else if (key.KeyChar.Equals('f') || key.KeyChar.Equals('F'))
            {
                keyPressed = 'F';
            }
            else if (key.KeyChar.Equals('g') || key.KeyChar.Equals('G'))
            {
                keyPressed = 'G';
            }
            else if (key.KeyChar.Equals('h') || key.KeyChar.Equals('H'))
            {
                keyPressed = 'H';
            }
            else if (key.KeyChar.Equals('i') || key.KeyChar.Equals('I'))
            {
                keyPressed = 'I';
            }
            else if (key.KeyChar.Equals('j') || key.KeyChar.Equals('J'))
            {
                keyPressed = 'J';
            }
            else if (key.KeyChar.Equals('k') || key.KeyChar.Equals('K'))
            {
                keyPressed = 'K';
            }
            else if (key.KeyChar.Equals('l') || key.KeyChar.Equals('L'))
            {
                keyPressed = 'L';
            }
            else if (key.KeyChar.Equals('m') || key.KeyChar.Equals('M'))
            {
                keyPressed = 'M';
            }
            else if (key.KeyChar.Equals('n') || key.KeyChar.Equals('N'))
            {
                keyPressed = 'N';
            }
            else if (key.KeyChar.Equals('ñ') || key.KeyChar.Equals('Ñ'))
            {
                keyPressed = 'Ñ';
            }
            else if (key.KeyChar.Equals('o') || key.KeyChar.Equals('O'))
            {
                keyPressed = 'O';
            }
            else if (key.KeyChar.Equals('p') || key.KeyChar.Equals('P'))
            {
                keyPressed = 'P';
            }
            else if (key.KeyChar.Equals('q') || key.KeyChar.Equals('Q'))
            {
                keyPressed = 'Q';
            }
            else if (key.KeyChar.Equals('r') || key.KeyChar.Equals('R'))
            {
                keyPressed = 'R';
            }
            else if (key.KeyChar.Equals('s') || key.KeyChar.Equals('S'))
            {
                keyPressed = 'S';
            }
            else if (key.KeyChar.Equals('t') || key.KeyChar.Equals('T'))
            {
                keyPressed = 'T';
            }
            else if (key.KeyChar.Equals('u') || key.KeyChar.Equals('U'))
            {
                keyPressed = 'U';
            }
            else if (key.KeyChar.Equals('v') || key.KeyChar.Equals('V'))
            {
                keyPressed = 'V';
            }
            else if (key.KeyChar.Equals('w') || key.KeyChar.Equals('W'))
            {
                keyPressed = 'W';
            }
            else if (key.KeyChar.Equals('x') || key.KeyChar.Equals('X'))
            {
                keyPressed = 'X';
            }
            else if (key.KeyChar.Equals('y') || key.KeyChar.Equals('Y'))
            {
                keyPressed = 'Y';
            }
            else if (key.KeyChar.Equals('z') || key.KeyChar.Equals('Z'))
            {
                keyPressed = 'Z';
                this.labelAciertos.Text += "EEEEH";

            }

            this.comprobarLetraIntroducida(keyPressed);
        }
    }
}
