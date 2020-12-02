namespace Tarea_para_DIO1_WinForm
{
    partial class ModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloLabel = new System.Windows.Forms.Label();
            this.HabilitarButton = new System.Windows.Forms.Button();
            this.edicionGroupBox = new System.Windows.Forms.GroupBox();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.porLabel = new System.Windows.Forms.Label();
            this.columnaComboBox = new System.Windows.Forms.ComboBox();
            this.columnaLabel = new System.Windows.Forms.Label();
            this.productoListView = new System.Windows.Forms.ListView();
            this.edicionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(29, 23);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(461, 54);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Detalles del producto";
            // 
            // HabilitarButton
            // 
            this.HabilitarButton.Location = new System.Drawing.Point(38, 169);
            this.HabilitarButton.Name = "HabilitarButton";
            this.HabilitarButton.Size = new System.Drawing.Size(150, 42);
            this.HabilitarButton.TabIndex = 2;
            this.HabilitarButton.Text = "Habilitar edición";
            this.HabilitarButton.UseVisualStyleBackColor = true;
            this.HabilitarButton.Click += new System.EventHandler(this.HabilitarButton_Click);
            // 
            // edicionGroupBox
            // 
            this.edicionGroupBox.Controls.Add(this.actualizarButton);
            this.edicionGroupBox.Controls.Add(this.valorTextBox);
            this.edicionGroupBox.Controls.Add(this.porLabel);
            this.edicionGroupBox.Controls.Add(this.columnaComboBox);
            this.edicionGroupBox.Controls.Add(this.columnaLabel);
            this.edicionGroupBox.Enabled = false;
            this.edicionGroupBox.Location = new System.Drawing.Point(38, 217);
            this.edicionGroupBox.Name = "edicionGroupBox";
            this.edicionGroupBox.Size = new System.Drawing.Size(750, 114);
            this.edicionGroupBox.TabIndex = 3;
            this.edicionGroupBox.TabStop = false;
            this.edicionGroupBox.Text = "Modo edición";
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(337, 73);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(87, 24);
            this.actualizarButton.TabIndex = 4;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(465, 26);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(279, 22);
            this.valorTextBox.TabIndex = 3;
            // 
            // porLabel
            // 
            this.porLabel.AutoSize = true;
            this.porLabel.Location = new System.Drawing.Point(430, 29);
            this.porLabel.Name = "porLabel";
            this.porLabel.Size = new System.Drawing.Size(29, 17);
            this.porLabel.TabIndex = 2;
            this.porLabel.Text = "por";
            // 
            // columnaComboBox
            // 
            this.columnaComboBox.FormattingEnabled = true;
            this.columnaComboBox.Location = new System.Drawing.Point(217, 26);
            this.columnaComboBox.Name = "columnaComboBox";
            this.columnaComboBox.Size = new System.Drawing.Size(207, 24);
            this.columnaComboBox.TabIndex = 1;
            // 
            // columnaLabel
            // 
            this.columnaLabel.AutoSize = true;
            this.columnaLabel.Location = new System.Drawing.Point(6, 29);
            this.columnaLabel.Name = "columnaLabel";
            this.columnaLabel.Size = new System.Drawing.Size(205, 17);
            this.columnaLabel.TabIndex = 0;
            this.columnaLabel.Text = "Sustituir el valor de la columna:";
            // 
            // productoListView
            // 
            this.productoListView.HideSelection = false;
            this.productoListView.Location = new System.Drawing.Point(38, 109);
            this.productoListView.Name = "productoListView";
            this.productoListView.Size = new System.Drawing.Size(744, 54);
            this.productoListView.TabIndex = 4;
            this.productoListView.UseCompatibleStateImageBehavior = false;
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 355);
            this.Controls.Add(this.productoListView);
            this.Controls.Add(this.edicionGroupBox);
            this.Controls.Add(this.HabilitarButton);
            this.Controls.Add(this.TituloLabel);
            this.Name = "ModalForm";
            this.Text = "Detalles del producto";
            this.edicionGroupBox.ResumeLayout(false);
            this.edicionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Button HabilitarButton;
        private System.Windows.Forms.GroupBox edicionGroupBox;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label porLabel;
        private System.Windows.Forms.ComboBox columnaComboBox;
        private System.Windows.Forms.Label columnaLabel;
        private System.Windows.Forms.ListView productoListView;
    }
}