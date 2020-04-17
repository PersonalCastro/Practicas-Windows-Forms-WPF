using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcetToBD_programming_
{
    public partial class Form1: Form
    {

        /*  DB  */
        public static MySqlConnection conex = new MySqlConnection();
        public static string serv = "Server=localhost;";
        public static string db = "Database=pruebaCM;";
        public static string usuario = "UID=Pablo;";
        public static string pwd = "Pwd=Pablo;";
        public string cadenaConexion = serv + db + usuario + pwd;

        /*      */
        public static int selectedConectionType;

        public Form1()
        {
            InitializeComponent();

            this.comboBoxEstado.Items.Clear();
            this.comboBoxEstado.Items.Add("Desconectado");
            this.comboBoxEstado.Items.Add("Conectado");
            this.comboBoxEstado.SelectedIndex = 0;

            getAllDataFromDb();
            //buttonRestartComboBoxQuery_Click();
        }

        public void Conectar()
        {
            try
            {
                conex.ConnectionString = this.cadenaConexion;
                conex.Open();
                //MessageBox.Show("La BD esta ahora conectada");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                throw;
            }

        }

        public void Desconectar()
        {
            conex.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void restartComboBoxQuery_Click(object sender, EventArgs e)
        {
            //Para refrescar los query posibles
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            if (!textBoxUser.Text.Equals("") &&
                !textBoxNombre.Text.Equals("") &&
                !textBoxApellido1.Text.Equals("") &&
                !textBoxApellido2.Text.Equals("") &&
                !textBoxPsswrd.Text.Equals("") &&
                !textBoxFoto.Text.Equals(""))
            {

                try
                {
                    Conectar();
                    string insert = "";
                    string id = textBoxUser.Text;
                    string nombre = textBoxNombre.Text;
                    string apellido1 = textBoxApellido1.Text;
                    string apellido2 = textBoxApellido2.Text;
                    string passw = textBoxPsswrd.Text;
                    string foto = textBoxFoto.Text;
                    string estado = comboBoxEstado.SelectedIndex.ToString();
                    insert = "INSERT INTO user VALUES('" + id + "', '" + nombre + "', '" + passw + "', '" + apellido1 + "', '" + apellido2 + "', '" + foto + "', '" + estado + "');";

                    MySqlCommand comando = conex.CreateCommand();
                    comando.CommandText = insert;
                    comando.ExecuteNonQuery();

                }
                catch(Exception)
                {

                }
                finally
                {
                    Desconectar();
                }

            }
        }

        private void buttonRestartComboBoxQuery_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();

                string query = "";
                query = "Select * From user Where state = '0'";

                Conectar();
                MySqlCommand comando = conex.CreateCommand();
                comando.CommandText = query;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                comboBoxQuery.Items.Add("Desconectados");
            }
            catch (Exception)
            {

            }
            finally
            {
                Desconectar();
            }

            try
            {
                DataTable dt = new DataTable();

                string query = "";
                query = "Select * From user Where state = '1'";

                Conectar();
                MySqlCommand comando = conex.CreateCommand();
                comando.CommandText = query;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                comboBoxQuery.Items.Add("Conectados");
            }
            catch (Exception)
            {

            }
            finally
            {
                Desconectar();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            selectedConectionType = comboBoxQuery.SelectedIndex;

            if (selectedConectionType == 0)
            {
                try
                {
                    DataTable dt = new DataTable();

                    string query = "";
                    query = "Select * From user Where state = '0'";

                    Conectar();
                    MySqlCommand comando = conex.CreateCommand();
                    comando.CommandText = query;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    dataGridViewData.DataSource = dt;

                }
                catch (Exception)
                {

                }
                finally
                {
                    Desconectar();
                }
            }
            else if (selectedConectionType == 1)
            {
                try
                {
                    DataTable dt = new DataTable();

                    string query = "";
                    query = "Select * From user Where state = '1'";

                    Conectar();
                    MySqlCommand comando = conex.CreateCommand();
                    comando.CommandText = query;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    dataGridViewData.DataSource = dt;

                }
                catch (Exception)
                {

                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                getAllDataFromDb();
            }
        
        }

        private void getAllDataFromDb()
        {

            try
            {
                DataTable dt = new DataTable();

                string query = "";
                query = "Select * From user";

                Conectar();
                MySqlCommand comando = conex.CreateCommand();
                comando.CommandText = query;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                dataGridViewData.DataSource = dt;

            }
            catch (Exception)
            {

            }
            finally
            {
                Desconectar();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
