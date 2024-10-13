using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DA_ENTREGA2
{
    public partial class pantallaPrincipal : Form
    {

        private MySqlConnection connection;
        private string nombreUsuario;

        public pantallaPrincipal(string userName)
        {
            InitializeComponent();
            conectarDB();
            nombreUsuario = userName;
        }

        private void pantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(72, 190, 96);
            showDataLangile();
            showDataErabiltzaile();
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

        public void showDataLangile()
        {
            if (connection == null)
            {
                conectarDB(); //Asi me aseguro de que la conexion este abierta
            }

            string query = "SELECT * FROM datuatzipena.langile";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                try
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    langileTable.DataSource = ds.Tables[0];
                }
                catch (Exception ex) {
                    MessageBox.Show($"Ha habido un error al cargar los datos de las tablas{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void showDataErabiltzaile()
        {
            if(connection == null)
            {
                conectarDB();
            }


            string query = "SELECT * FROM datuatzipena.erabiltzaile";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                try
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridErabiltzaile.DataSource = ds.Tables[0];
                }
                catch (Exception ex) {
                    MessageBox.Show($"Ha ocurrido un problema al cargar la tabla de 'erabiltzaile'{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void eliminar()
        {
            if(connection == null)
            {
                conectarDB();
            }

            if (langileTable.SelectedRows.Count > 0) {

                //Recogo el id de la fila selecionada en la tabla de la interfaz
                int idSeleccionado = Convert.ToInt32(langileTable.SelectedRows[0].Cells["id"].Value);

                string query = $"UPDATE datuatzipena.langile SET eliminado = 1 WHERE id = @id";
                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@id", idSeleccionado);
                    try
                    {
                        comando.ExecuteNonQuery();
                        string sqlQuery = $"SELECT arduraduna FROM datuatzipena.langile WHERE id = @id";
                        using(MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", idSeleccionado);
                            try
                            {
                                using(MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        Boolean arduraduna = Convert.ToBoolean(reader["arduraduna"]);
                                        reader.Close();
                                        if(arduraduna == true)
                                        {
                                            //Damos la opcion de elegir si quiere eliminar arduraduna o no
                                            DialogResult resultado = MessageBox.Show("Este usuario es arduraduna. ¿Queres eliminarlo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                            if (resultado == DialogResult.Yes) {
                                                hardDelete(idSeleccionado);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ha ocurrido un problema al leer los 'arduradunas'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No ha detectado ningun arduraduna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("El usuario ha sido eliminado correctamente. No tendra acceso alguno a la aplicacion");
                        registrarEliminacion(idSeleccionado);

                    }
                    
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Ha ocurrido un error al borrar el usuario{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {

            añadirEmpleado pantallaEmpleado = new añadirEmpleado(nombreUsuario);

            pantallaEmpleado.Show();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            showDataLangile();
            showDataErabiltzaile();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        public void hardDelete(int id)
        {
            if(connection == null)
            {
                conectarDB();
            }

            string query = $"DELETE FROM datuatzipena.erabiltzaile WHERE langilea_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido borrados correctamente de la tabla erabiltzaile" +
                        "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show($"No se ha podido borrar el registro{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string commandQuery = $"DELETE FROM datuatzipena.langile WHERE id = @id";
            using (MySqlCommand comando = new MySqlCommand(commandQuery, connection))
            {
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido borrados correctamente de la tabla langile", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex) {
                    MessageBox.Show($"No se ha podido borrar el registro{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void registrarEliminacion(int filaEliminada)
        {
            string fecha = DateTime.Now.ToString("yyyy/MM/dd");
            string pathFile = @"C:\GOIERRI\archivos_clase\Datuen_atzipena\C#\1ebal\ENTREGA2\Entrega2_DA_MiloJon_ViyuelaIgor\aldaketak.txt";

            if (File.Exists(pathFile))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(pathFile, true)) {
                        string lineaEliminacion = $"{fecha} El usuario: {nombreUsuario}, ha borrado la fila con ID = {filaEliminada}";
                        sw.WriteLine(lineaEliminacion);
                    }
                }
                catch (DirectoryNotFoundException de)
                {
                    MessageBox.Show($"No se ha podido encontrar el directorio para guardar los registros de cambio {de.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException ua)
                {
                    MessageBox.Show($"No tienes acceso al archivo {ua.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe en la ruta especificada");
            }
        }
    }
}
