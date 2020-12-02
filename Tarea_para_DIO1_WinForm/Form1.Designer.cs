namespace Tarea_para_DIO1_WinForm
{
    partial class MainForm
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.paginacionLabel = new System.Windows.Forms.Label();
            this.paginacionComboBox = new System.Windows.Forms.ComboBox();
            this.productosListView = new System.Windows.Forms.ListView();
            this.requisitosGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FrRadioButton = new System.Windows.Forms.RadioButton();
            this.enRadioButton = new System.Windows.Forms.RadioButton();
            this.filtrosCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.BusquedaComboBox = new System.Windows.Forms.ComboBox();
            this.patronTextBox = new System.Windows.Forms.TextBox();
            this.patronLabel = new System.Windows.Forms.Label();
            this.busquedaLabel = new System.Windows.Forms.Label();
            this.descripcionLenguajeLabel = new System.Windows.Forms.Label();
            this.filtrosLabel = new System.Windows.Forms.Label();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.baseDeDatosComboBox = new System.Windows.Forms.ComboBox();
            this.requisitosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(12, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(363, 54);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Tarea para DI01";
            // 
            // paginacionLabel
            // 
            this.paginacionLabel.AutoSize = true;
            this.paginacionLabel.Location = new System.Drawing.Point(19, 495);
            this.paginacionLabel.Name = "paginacionLabel";
            this.paginacionLabel.Size = new System.Drawing.Size(78, 17);
            this.paginacionLabel.TabIndex = 1;
            this.paginacionLabel.Text = "Paginación";
            // 
            // paginacionComboBox
            // 
            this.paginacionComboBox.FormattingEnabled = true;
            this.paginacionComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "50"});
            this.paginacionComboBox.Location = new System.Drawing.Point(103, 492);
            this.paginacionComboBox.Name = "paginacionComboBox";
            this.paginacionComboBox.Size = new System.Drawing.Size(71, 24);
            this.paginacionComboBox.TabIndex = 2;
            // 
            // productosListView
            // 
            this.productosListView.HideSelection = false;
            this.productosListView.Location = new System.Drawing.Point(12, 90);
            this.productosListView.Name = "productosListView";
            this.productosListView.Size = new System.Drawing.Size(565, 381);
            this.productosListView.TabIndex = 3;
            this.productosListView.UseCompatibleStateImageBehavior = false;
            this.productosListView.SelectedIndexChanged += new System.EventHandler(this.productosListView_SelectedIndexChanged);
            // 
            // requisitosGroupBox
            // 
            this.requisitosGroupBox.Controls.Add(this.checkBox1);
            this.requisitosGroupBox.Controls.Add(this.FrRadioButton);
            this.requisitosGroupBox.Controls.Add(this.enRadioButton);
            this.requisitosGroupBox.Controls.Add(this.filtrosCheckedListBox);
            this.requisitosGroupBox.Controls.Add(this.BusquedaComboBox);
            this.requisitosGroupBox.Controls.Add(this.patronTextBox);
            this.requisitosGroupBox.Controls.Add(this.patronLabel);
            this.requisitosGroupBox.Controls.Add(this.busquedaLabel);
            this.requisitosGroupBox.Controls.Add(this.descripcionLenguajeLabel);
            this.requisitosGroupBox.Controls.Add(this.filtrosLabel);
            this.requisitosGroupBox.Location = new System.Drawing.Point(594, 83);
            this.requisitosGroupBox.Name = "requisitosGroupBox";
            this.requisitosGroupBox.Size = new System.Drawing.Size(323, 388);
            this.requisitosGroupBox.TabIndex = 4;
            this.requisitosGroupBox.TabStop = false;
            this.requisitosGroupBox.Text = "Requisitos DI01";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(287, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Productos disponibles (SellEndDate null)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrRadioButton
            // 
            this.FrRadioButton.AutoSize = true;
            this.FrRadioButton.Location = new System.Drawing.Point(89, 51);
            this.FrRadioButton.Name = "FrRadioButton";
            this.FrRadioButton.Size = new System.Drawing.Size(38, 21);
            this.FrRadioButton.TabIndex = 8;
            this.FrRadioButton.TabStop = true;
            this.FrRadioButton.Text = "fr";
            this.FrRadioButton.UseVisualStyleBackColor = true;
            // 
            // enRadioButton
            // 
            this.enRadioButton.AutoSize = true;
            this.enRadioButton.Location = new System.Drawing.Point(24, 51);
            this.enRadioButton.Name = "enRadioButton";
            this.enRadioButton.Size = new System.Drawing.Size(45, 21);
            this.enRadioButton.TabIndex = 7;
            this.enRadioButton.TabStop = true;
            this.enRadioButton.Text = "en";
            this.enRadioButton.UseVisualStyleBackColor = true;
            // 
            // filtrosCheckedListBox
            // 
            this.filtrosCheckedListBox.FormattingEnabled = true;
            this.filtrosCheckedListBox.Items.AddRange(new object[] {
            "Categoria"});
            this.filtrosCheckedListBox.Location = new System.Drawing.Point(21, 108);
            this.filtrosCheckedListBox.Name = "filtrosCheckedListBox";
            this.filtrosCheckedListBox.Size = new System.Drawing.Size(285, 106);
            this.filtrosCheckedListBox.TabIndex = 6;
            // 
            // BusquedaComboBox
            // 
            this.BusquedaComboBox.FormattingEnabled = true;
            this.BusquedaComboBox.Items.AddRange(new object[] {
            "nombre de producto",
            "nombre de modelo"});
            this.BusquedaComboBox.Location = new System.Drawing.Point(108, 238);
            this.BusquedaComboBox.Name = "BusquedaComboBox";
            this.BusquedaComboBox.Size = new System.Drawing.Size(198, 24);
            this.BusquedaComboBox.TabIndex = 5;
            // 
            // patronTextBox
            // 
            this.patronTextBox.Location = new System.Drawing.Point(21, 346);
            this.patronTextBox.Name = "patronTextBox";
            this.patronTextBox.Size = new System.Drawing.Size(285, 22);
            this.patronTextBox.TabIndex = 4;
            // 
            // patronLabel
            // 
            this.patronLabel.AutoSize = true;
            this.patronLabel.Location = new System.Drawing.Point(21, 326);
            this.patronLabel.Name = "patronLabel";
            this.patronLabel.Size = new System.Drawing.Size(137, 17);
            this.patronLabel.TabIndex = 3;
            this.patronLabel.Text = "Patrón de busqueda";
            // 
            // busquedaLabel
            // 
            this.busquedaLabel.AutoSize = true;
            this.busquedaLabel.Location = new System.Drawing.Point(21, 241);
            this.busquedaLabel.Name = "busquedaLabel";
            this.busquedaLabel.Size = new System.Drawing.Size(81, 17);
            this.busquedaLabel.TabIndex = 2;
            this.busquedaLabel.Text = "Buscar por:";
            // 
            // descripcionLenguajeLabel
            // 
            this.descripcionLenguajeLabel.AutoSize = true;
            this.descripcionLenguajeLabel.Location = new System.Drawing.Point(21, 31);
            this.descripcionLenguajeLabel.Name = "descripcionLenguajeLabel";
            this.descripcionLenguajeLabel.Size = new System.Drawing.Size(178, 17);
            this.descripcionLenguajeLabel.TabIndex = 1;
            this.descripcionLenguajeLabel.Text = "Lenguaje de la descripción";
            // 
            // filtrosLabel
            // 
            this.filtrosLabel.AutoSize = true;
            this.filtrosLabel.Location = new System.Drawing.Point(21, 88);
            this.filtrosLabel.Name = "filtrosLabel";
            this.filtrosLabel.Size = new System.Drawing.Size(133, 17);
            this.filtrosLabel.TabIndex = 0;
            this.filtrosLabel.Text = "Filtros (navegación)";
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Location = new System.Drawing.Point(814, 491);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(75, 24);
            this.ConsultaButton.TabIndex = 5;
            this.ConsultaButton.Text = "consulta";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            // 
            // baseDeDatosComboBox
            // 
            this.baseDeDatosComboBox.FormattingEnabled = true;
            this.baseDeDatosComboBox.Items.AddRange(new object[] {
            "localhost database",
            "azure database"});
            this.baseDeDatosComboBox.Location = new System.Drawing.Point(620, 491);
            this.baseDeDatosComboBox.Name = "baseDeDatosComboBox";
            this.baseDeDatosComboBox.Size = new System.Drawing.Size(184, 24);
            this.baseDeDatosComboBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 538);
            this.Controls.Add(this.baseDeDatosComboBox);
            this.Controls.Add(this.ConsultaButton);
            this.Controls.Add(this.requisitosGroupBox);
            this.Controls.Add(this.productosListView);
            this.Controls.Add(this.paginacionComboBox);
            this.Controls.Add(this.paginacionLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "MainForm";
            this.Text = "Tarea para D01";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.requisitosGroupBox.ResumeLayout(false);
            this.requisitosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label paginacionLabel;
        private System.Windows.Forms.ComboBox paginacionComboBox;
        private System.Windows.Forms.ListView productosListView;
        private System.Windows.Forms.GroupBox requisitosGroupBox;
        private System.Windows.Forms.Label patronLabel;
        private System.Windows.Forms.Label busquedaLabel;
        private System.Windows.Forms.Label descripcionLenguajeLabel;
        private System.Windows.Forms.Label filtrosLabel;
        private System.Windows.Forms.CheckedListBox filtrosCheckedListBox;
        private System.Windows.Forms.ComboBox BusquedaComboBox;
        private System.Windows.Forms.TextBox patronTextBox;
        private System.Windows.Forms.RadioButton enRadioButton;
        private System.Windows.Forms.RadioButton FrRadioButton;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.ComboBox baseDeDatosComboBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

