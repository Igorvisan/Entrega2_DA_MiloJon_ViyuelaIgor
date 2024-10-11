using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DA_ENTREGA2
{
    public partial class Form1 : Form
    {

        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(106, 231, 131);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicioSesion();
        }

        public void inicioSesion()
        {
            string connectionString = "server=localhost;user id=root;password=;database=datuatzipena";

            connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string userName = nameText.Text;
                    string password = passwordText.Text;


                    string query = $"SELECT izena, contraseña, arduraduna FROM datuatzipena.langile WHERE izena = @izena";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@izena", userName);
                        try
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string contraseña = reader["contraseña"].ToString();
                                    Boolean arduraduna = Convert.ToBoolean(reader["arduraduna"]); 

                                    if (password == contraseña && arduraduna != false)
                                    {
                                        pantallaPrincipal pantallaPricipal = new pantallaPrincipal(userName);
                                        pantallaPricipal.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La contraseña es incorrecta o no eres usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ha habido un error al leer la informacion {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se ha podido conectar a la base de datos {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
    }
}
