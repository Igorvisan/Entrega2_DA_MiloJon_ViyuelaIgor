using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DA_ENTREGA2
{
    public partial class pantallaPrincipal : Form
    {

        private MySqlConnection connection;

        public pantallaPrincipal(string userName)
        {
            InitializeComponent();
            conectarDB();
        }

        private void pantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(72, 190, 96);
            showDataLangile();

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

        private void addButton_Click(object sender, EventArgs e)
        {

            añadirEmpleado pantallaEmpleado = new añadirEmpleado();

            pantallaEmpleado.Show();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            showDataLangile();
        }
    }
}
