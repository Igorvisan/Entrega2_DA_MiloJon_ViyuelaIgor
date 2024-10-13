using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DA_ENTREGA2
{
    public partial class añadirEmpleado : Form
    {
        private MySqlConnection connection;
        private string nombreUser;
        public añadirEmpleado(string nombreUsuario)
        {
            InitializeComponent();
            nombreUser = nombreUsuario;
            
        }

        private void añadirEmpleado_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(142, 200, 40);
        }

        public void conectarDB()
        {
            string stringConnection = "server=localhost;user id=root;password=;database=datuatzipena";

            connection = new MySqlConnection(stringConnection);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha habido un problema al conectarse a la base de datos{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addEmpleado()
        {
            string nombreNuevo = nameText.Text;
            string contraseñaNuevo = passwordText.Text;
            Boolean arduradunaNuevo = Convert.ToBoolean(checkBoxArduraduna.Checked);

            if(connection == null)
            {
                conectarDB();
            }

            MySqlTransaction transaction = connection.BeginTransaction();

            string query = $"INSERT INTO datuatzipena.langile (arduraduna, izena, contraseña) VALUES (@arduraduna, @izena, @contraseña)";
            using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@arduraduna", arduradunaNuevo);
                command.Parameters.AddWithValue("@izena", nombreNuevo);
                command.Parameters.AddWithValue("@contraseña", contraseñaNuevo);

                try
                {
                    command.ExecuteNonQuery();
                    if(arduradunaNuevo == true)
                    {
                        string queryErabiltzaile = "INSERT INTO datuatzipena.erabiltzaile (langilea_id, erabiltzailea, pasahitza)" + "SELECT LAST_INSERT_ID(), izena, contraseña FROM datuatzipena.langile" + " WHERE id = LAST_INSERT_ID()"; //Ayudita con chat GPT
                        using(MySqlCommand comando = new MySqlCommand(queryErabiltzaile, connection, transaction))
                        {
                            try
                            {
                                comando.ExecuteNonQuery();
                            }
                            catch (Exception ex) {
                                transaction.Rollback();
                                MessageBox.Show($"Ha ocurrido un error al introducir el nuevo erabiltzaile{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    transaction.Commit(); //confirmar transaccion si todo ha salido bien
                    MessageBox.Show($"Los datos: {arduradunaNuevo}, {nombreNuevo}, {contraseñaNuevo} se han añadido connectamente");
                    registroDeAdicion();
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); //Si el primer insert no ha funcionado
                    MessageBox.Show($"No se ha podido hacer el INSERT correctamente vuelvalo a intentar mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmpleado();
        }

        public void registroDeAdicion()
        {
            string pathFile = @"C:\GOIERRI\archivos_clase\Datuen_atzipena\C#\1ebal\ENTREGA2\Entrega2_DA_MiloJon_ViyuelaIgor\aldaketak.txt";
            string fecha = DateTime.Now.ToString("yyyy/MM/dd");

            if (File.Exists(pathFile))
            {
                try
                {
                    using(StreamWriter sw = new StreamWriter(pathFile, true))
                    {
                        string registroAdicion = $"{fecha} El usuario: {nombreUser}, ha añadido un nuevo registro";
                        sw.WriteLine(registroAdicion);  
                    }
                }
                catch (DirectoryNotFoundException de)
                {
                    MessageBox.Show($"No se ha podido encontrar el directorio para guardar los registros de cambio {de.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException ua)
                {
                    MessageBox.Show($"No tienes acceso al archivo {ua.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
