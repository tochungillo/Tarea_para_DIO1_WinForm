using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        string connectionStringLocalhost = ConfigurationManager.ConnectionStrings["AdventureWorksOLTazure"].ConnectionString;
        string connectionStringAzure = ConfigurationManager.ConnectionStrings["AdventureWorksOLTlocalhost"].ConnectionString;
        string connectionString;
        // paginacion
        int productsPerPage;
        int numberOfPages;
        int currentPage = 0;
        // valores de los filtros
        string[] nombreFiltros = {
            "NombreModelo",
            "NombreProducto",
            "Description",
            "ProductionNumber",
            "Color",
            "ListPrice",
            "Size",
            "ProductLine",
            "Class",
            "Style",
            "Category",
            "SubCategory"};
        string[,] filtros = new string[12,2];

        public MainForm()
        {
            InitializeComponent();
        }

        public void Consulta()
        {
            List<ProductModel> products = new List<ProductModel>();
            string connectionString;
            // saber que base de datos quiere usar
            if (baseDeDatosComboBox.SelectedIndex == 1) connectionString = connectionStringAzure;
            // he decidido que por defecto se conecte a localhost
            else connectionString = connectionStringLocalhost;
            //conectarse a la base de datos
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // parametros del wehere
                var parameters = new
                {
                    cultureID = lenguajeComboBox.SelectedIndex.ToString(),
                    patron = patronTextBox.Text
                };
                string procedure;
                // es true, sigunifica muestra SellEndDate = null
                if (disponiblesCheckBox.Checked)
                {
                    // el patron que le introduzcan sera nombre del modelo
                    if (BusquedaComboBox.SelectedIndex == 1) procedure = "Production.modelo_disponibles_consulta";
                    // el patron que le introduzcan sera nombre del producto
                    else procedure = "Production.producto_disponibles_consulta";
                }
                // es false, significa muestra todos ademas muestra sellStart y sellEnd
                else
                {
                    if (BusquedaComboBox.SelectedIndex == 1) procedure = "Production.modelo_todos_consulta";
                    else procedure = "Production.producto_todos_consulta";
                }
                // ejecuta el procedure
                //connection.Execute(procedure, parameters, commandType: CommandType.StoredProcedure);
            }
            foreach (ProductModel pm in products)
            {
                productosListView.Items.Add(pm.ToString());
            }
        }

        public void UpdateProductsListView()
        {
            totalPagesLabel.Text = $"{currentPage + 1} of {numberOfPages} pages";

            Consulta();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // asignación de valores por defecto
            BusquedaComboBox.SelectedIndex = 0;
            paginacionComboBox.SelectedIndex = 0;
            baseDeDatosComboBox.SelectedIndex = 0;
            lenguajeComboBox.SelectedIndex = 0;
            connectionString = connectionStringLocalhost;

            // por defecto no hay filtros activos
            elegidoLabel.Visible = false;
            elegidoTextBox.Visible = false;

            minElegidoLabel.Visible = false;
            minElegidoTextBox.Visible = false;
            maxElegidoLabel.Visible = false;
            maxElegidoTextBox.Visible = false;

            /* PAGINACION */
            productosListView.Scrollable = true;
            productosListView.View = View.Details;
            ColumnHeader columnHeader = new ColumnHeader();
            columnHeader.Text = "";
            columnHeader.Name = "col1";
            productosListView.Columns.Add(columnHeader);
            columnHeader.Width = productosListView.Width - 50;
            productosListView.HeaderStyle = ColumnHeaderStyle.None;
            // inicializar las labels
            totalPagesLabel.Text = "0 films found";
            actualPageLabel.Text = "0 pages";
        }

        private void productosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModalForm detalles = new ModalForm();
            detalles.connectionString = connectionString;
            detalles.producto = productosListView.SelectedItems.ToString();
            detalles.Show();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void paginacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando se selecciona otra cantidad de resultados por pagina
            productsPerPage = int.Parse(paginacionComboBox.Text);
            // obtener la cantidad de resultados de la consulta


            Consulta();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentPage--;
            // cuando es la primera pagina, no se puede retroceder mas
            if (currentPage == 0)
            {
                prevButton.Enabled = false;
            }
            nextButton.Enabled = true;
            Consulta();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // siguiente pagina
            currentPage++;
            if (currentPage == numberOfPages -1)
            {
                nextButton.Enabled = false;
            }
            prevButton.Enabled = true;
            Consulta();
        }

        private void baseDeDatosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // saber que base de datos quiere usar
            if (baseDeDatosComboBox.SelectedIndex == 1) connectionString = connectionStringAzure;
            // he decidido que por defecto se conecte a localhost
            else connectionString = connectionStringLocalhost;
        }

        private void filtroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtroComboBox.SelectedIndex == 5 || filtroComboBox.SelectedIndex == 6)
            {
                elegidoLabel.Visible = false;
                elegidoTextBox.Visible = false;

                minElegidoLabel.Visible = true;
                minElegidoTextBox.Visible = true;
                maxElegidoLabel.Visible = true;
                maxElegidoTextBox.Visible = true;
                minElegidoLabel.Text = $"min {filtroComboBox.SelectedItem.ToString()}";
                maxElegidoLabel.Text = $"max {filtroComboBox.SelectedItem.ToString()}";
            } else
            {
                minElegidoLabel.Visible = false;
                minElegidoTextBox.Visible = false;
                maxElegidoLabel.Visible = false;
                maxElegidoTextBox.Visible = false;

                elegidoLabel.Visible = true;
                elegidoTextBox.Visible = true;
                elegidoLabel.Text = $"{filtroComboBox.SelectedItem.ToString()}";
            }
        }

        private void minElegidoTextBox_TextChanged(object sender, EventArgs e)
        {
            filtros[filtroComboBox.SelectedIndex,0] = minElegidoTextBox.Text;
            filtroComboBox.SelectedItem = $"{nombreFiltros[filtroComboBox.SelectedIndex]}, min {filtros[filtroComboBox.SelectedIndex,0]} max {filtros[filtroComboBox.SelectedIndex,1]}";
        }

        private void maxElegidoTextBox_TextChanged(object sender, EventArgs e)
        {
            filtros[filtroComboBox.SelectedIndex,1] = minElegidoTextBox.Text;
            filtroComboBox.SelectedItem = $"{nombreFiltros[filtroComboBox.SelectedIndex]}, min {filtros[filtroComboBox.SelectedIndex,0]} max {filtros[filtroComboBox.SelectedIndex,1]}";
        }

        private void elegidoTextBox_TextChanged(object sender, EventArgs e)
        {
            filtros[filtroComboBox.SelectedIndex,0] = minElegidoTextBox.Text;
            filtroComboBox.SelectedItem = $"{nombreFiltros[filtroComboBox.SelectedIndex]}, value {filtros[filtroComboBox.SelectedIndex,0]}";
        }
    }
}
