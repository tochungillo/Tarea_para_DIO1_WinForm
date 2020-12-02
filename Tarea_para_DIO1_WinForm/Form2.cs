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
    public partial class ModalForm : Form
    {
        public ModalForm()
        {
            InitializeComponent();
        }

        private void HabilitarButton_Click(object sender, EventArgs e)
        {
            // habilitar la edición
            if (edicionGroupBox.Enabled) edicionGroupBox.Enabled = false;
            else edicionGroupBox.Enabled = true;
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            // cierra este form
            this.Close();
        }
    }
}
