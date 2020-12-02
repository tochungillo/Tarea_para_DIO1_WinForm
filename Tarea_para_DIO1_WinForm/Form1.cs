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
            FrRadioButton.Checked = false;
        }

        private void productosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form detalles = new ModalForm();
            detalles.Show();
        }
    }
}
