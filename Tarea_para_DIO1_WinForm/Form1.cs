using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_para_DIO1_WinForm
{
    public partial class MainForm : Form
    {
        // conection string
        string connectionStringLocalhost = ConfigurationManager.ConnectionStrings[].ConnectionString;
        string connectionStringAzure = ConfigurationManager.ConnectionStrings[].ConnectionString;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // asignación de valores por defecto
            BusquedaComboBox.SelectedIndex = 0;
            paginacionComboBox.SelectedIndex = 0;
            baseDeDatosComboBox.SelectedIndex = 0;
            enRadioButton.Checked = true;
            frRadioButton.Checked = false;
        }

        private void productosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form detalles = new ModalForm();
            detalles.Show();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            List<ProductModel> products = new List<ProductModel>();
            string connectionString;
            if (baseDeDatosComboBox.Text.Equals("azure database")) connectionString = connectionStringAzure;
            else connectionString = connectionStringLocalhost;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // parametros del wehere
                if (disponiblesCheckBox.Checked)
                    var parameters = new { cultureID = "fr", patron = patronTextBox.Text };
                else
                    var parameters = new { cultureID = "en", patron = patronTextBox.Text };
                // hay 4 procedures que mostraran lo que el usuario elija
                if (disponiblesCheckBox.Checked)
                {
                    if (BusquedaComboBox.Text.Equals("nombre de modelo")) connection.Execute("Production.modelo_disponibles_consulta", parameters, CommandType.StoredProcedure);
                    else connection.Execute("Production.producto_disponibles_consulta", parameters, CommandType.StoredProcedure);
                }
                else
                {
                    if (BusquedaComboBox.Text.Equals("nombre de modelo")) connection.Execute("Production.modelo_todos_consulta", parameters, CommandType.StoredProcedure);
                    else connection.Execute("Production.producto_todos_consulta", parameters, CommandType.StoredProcedure);
                }
            }
            foreach (ProductModel pm in products)
            {
                productosListView.Items.Add(pm.ToString());
            }
        }
    }
}
