using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DA_ENTREGA2
{
    public partial class pantallaPrincipal : Form
    {
        private MySqlConnection connection;

        public pantallaPrincipal()
        {
            InitializeComponent();
            conectarDB();
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
                MessageBox.Show("La conexio  ha sido un exito", "Success", MessageBoxButtons.OK);
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
            if (connection == null)
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
                    erabiltzaileTable.DataSource = ds.Tables[0];
                }
                catch (Exception ex) {
                    MessageBox.Show($"Ha habido un error al cargar los datos de las tablas{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
