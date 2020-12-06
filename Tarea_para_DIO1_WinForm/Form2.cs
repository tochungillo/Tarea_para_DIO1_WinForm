using Dapper;
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

namespace Tarea_para_DIO1_WinForm
{
    public partial class ModalForm : Form
    {
        public string connectionString;
        public string producto;
        public ModalForm()
        {
            InitializeComponent();
            productoListView.Items.Add(producto);
        }

        private void HabilitarButton_Click(object sender, EventArgs e)
        {
            // habilitar la edición
            if (edicionGroupBox.Enabled) edicionGroupBox.Enabled = false;
            else edicionGroupBox.Enabled = true;
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new
                {
                    cultureID = columnaComboBox.SelectedItem.ToString(),
                    patron = valorTextBox.Text
                };
                // ejecuta el procedure
                try
                {
                    connection.Execute("Production.update_procedure", parameters, commandType: CommandType.StoredProcedure);
                    MessageBox.Show("Se ha podido actualizar");
                } catch (SqlException sqle)
                {
                    MessageBox.Show("No se ha podido actualizar");
                }
            }
            // cierra este form
            this.Close();
        }
    }
}
