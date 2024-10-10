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
        private string server;
        private string dataBase;
        private string UID;
        private string password;

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
            string connectionString = "server=localhost;user id=root;password=;database=datuatzipena";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string userName = nameText.Text;
                    string password = passwordText.Text;

                    string query = $"SELECT izena, contraseña FROM datuatzipena.langile WHERE izena = @izena";
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

                                    if(password == contraseña)
                                    {
                                        pantallaPrincipal pantallaPricipal = new pantallaPrincipal();
                                        pantallaPricipal.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Los datos introducidos no coinciden con los datos en nuestra base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        catch (Exception ex) {
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
}
