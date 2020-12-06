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
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.maxElegidoTextBox = new System.Windows.Forms.TextBox();
            this.minElegidoTextBox = new System.Windows.Forms.TextBox();
            this.elegidoTextBox = new System.Windows.Forms.TextBox();
            this.maxElegidoLabel = new System.Windows.Forms.Label();
            this.minElegidoLabel = new System.Windows.Forms.Label();
            this.elegidoLabel = new System.Windows.Forms.Label();
            this.lenguajeComboBox = new System.Windows.Forms.ComboBox();
            this.disponiblesCheckBox = new System.Windows.Forms.CheckBox();
            this.BusquedaComboBox = new System.Windows.Forms.ComboBox();
            this.patronTextBox = new System.Windows.Forms.TextBox();
            this.patronLabel = new System.Windows.Forms.Label();
            this.busquedaLabel = new System.Windows.Forms.Label();
            this.descripcionLenguajeLabel = new System.Windows.Forms.Label();
            this.filtrosLabel = new System.Windows.Forms.Label();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.baseDeDatosComboBox = new System.Windows.Forms.ComboBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.actualPageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.requisitosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(3, -3);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(363, 54);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Tarea para DI01";
            // 
            // paginacionLabel
            // 
            this.paginacionLabel.AutoSize = true;
            this.paginacionLabel.Location = new System.Drawing.Point(12, 70);
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
            this.paginacionComboBox.Location = new System.Drawing.Point(96, 67);
            this.paginacionComboBox.Name = "paginacionComboBox";
            this.paginacionComboBox.Size = new System.Drawing.Size(71, 24);
            this.paginacionComboBox.TabIndex = 2;
            this.paginacionComboBox.SelectedIndexChanged += new System.EventHandler(this.paginacionComboBox_SelectedIndexChanged);
            // 
            // productosListView
            // 
            this.productosListView.HideSelection = false;
            this.productosListView.Location = new System.Drawing.Point(12, 97);
            this.productosListView.Name = "productosListView";
            this.productosListView.Size = new System.Drawing.Size(565, 381);
            this.productosListView.TabIndex = 3;
            this.productosListView.UseCompatibleStateImageBehavior = false;
            this.productosListView.SelectedIndexChanged += new System.EventHandler(this.productosListView_SelectedIndexChanged);
            // 
            // requisitosGroupBox
            // 
            this.requisitosGroupBox.Controls.Add(this.filtroComboBox);
            this.requisitosGroupBox.Controls.Add(this.maxElegidoTextBox);
            this.requisitosGroupBox.Controls.Add(this.minElegidoTextBox);
            this.requisitosGroupBox.Controls.Add(this.elegidoTextBox);
            this.requisitosGroupBox.Controls.Add(this.maxElegidoLabel);
            this.requisitosGroupBox.Controls.Add(this.minElegidoLabel);
            this.requisitosGroupBox.Controls.Add(this.elegidoLabel);
            this.requisitosGroupBox.Controls.Add(this.lenguajeComboBox);
            this.requisitosGroupBox.Controls.Add(this.disponiblesCheckBox);
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
            // filtroComboBox
            // 
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Items.AddRange(new object[] {
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
            "SubCategory"});
            this.filtroComboBox.Location = new System.Drawing.Point(22, 118);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(284, 24);
            this.filtroComboBox.TabIndex = 18;
            this.filtroComboBox.SelectedIndexChanged += new System.EventHandler(this.filtroComboBox_SelectedIndexChanged);
            // 
            // maxElegidoTextBox
            // 
            this.maxElegidoTextBox.Location = new System.Drawing.Point(132, 192);
            this.maxElegidoTextBox.Name = "maxElegidoTextBox";
            this.maxElegidoTextBox.Size = new System.Drawing.Size(124, 22);
            this.maxElegidoTextBox.TabIndex = 17;
            this.maxElegidoTextBox.TextChanged += new System.EventHandler(this.maxElegidoTextBox_TextChanged);
            // 
            // minElegidoTextBox
            // 
            this.minElegidoTextBox.Location = new System.Drawing.Point(132, 149);
            this.minElegidoTextBox.Name = "minElegidoTextBox";
            this.minElegidoTextBox.Size = new System.Drawing.Size(124, 22);
            this.minElegidoTextBox.TabIndex = 16;
            this.minElegidoTextBox.TextChanged += new System.EventHandler(this.minElegidoTextBox_TextChanged);
            // 
            // elegidoTextBox
            // 
            this.elegidoTextBox.Location = new System.Drawing.Point(145, 166);
            this.elegidoTextBox.Name = "elegidoTextBox";
            this.elegidoTextBox.Size = new System.Drawing.Size(159, 22);
            this.elegidoTextBox.TabIndex = 15;
            this.elegidoTextBox.TextChanged += new System.EventHandler(this.elegidoTextBox_TextChanged);
            // 
            // maxElegidoLabel
            // 
            this.maxElegidoLabel.AutoSize = true;
            this.maxElegidoLabel.Location = new System.Drawing.Point(32, 195);
            this.maxElegidoLabel.Name = "maxElegidoLabel";
            this.maxElegidoLabel.Size = new System.Drawing.Size(33, 17);
            this.maxElegidoLabel.TabIndex = 14;
            this.maxElegidoLabel.Text = "max";
            // 
            // minElegidoLabel
            // 
            this.minElegidoLabel.AutoSize = true;
            this.minElegidoLabel.Location = new System.Drawing.Point(32, 152);
            this.minElegidoLabel.Name = "minElegidoLabel";
            this.minElegidoLabel.Size = new System.Drawing.Size(30, 17);
            this.minElegidoLabel.TabIndex = 13;
            this.minElegidoLabel.Text = "min";
            // 
            // elegidoLabel
            // 
            this.elegidoLabel.AutoSize = true;
            this.elegidoLabel.Location = new System.Drawing.Point(19, 169);
            this.elegidoLabel.Name = "elegidoLabel";
            this.elegidoLabel.Size = new System.Drawing.Size(63, 17);
            this.elegidoLabel.TabIndex = 11;
            this.elegidoLabel.Text = "modeloA";
            // 
            // lenguajeComboBox
            // 
            this.lenguajeComboBox.FormattingEnabled = true;
            this.lenguajeComboBox.Items.AddRange(new object[] {
            "en",
            "fr"});
            this.lenguajeComboBox.Location = new System.Drawing.Point(205, 28);
            this.lenguajeComboBox.Name = "lenguajeComboBox";
            this.lenguajeComboBox.Size = new System.Drawing.Size(103, 24);
            this.lenguajeComboBox.TabIndex = 10;
            // 
            // disponiblesCheckBox
            // 
            this.disponiblesCheckBox.AutoSize = true;
            this.disponiblesCheckBox.Location = new System.Drawing.Point(21, 283);
            this.disponiblesCheckBox.Name = "disponiblesCheckBox";
            this.disponiblesCheckBox.Size = new System.Drawing.Size(287, 21);
            this.disponiblesCheckBox.TabIndex = 9;
            this.disponiblesCheckBox.Text = "Productos disponibles (SellEndDate null)";
            this.disponiblesCheckBox.UseVisualStyleBackColor = true;
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
            this.ConsultaButton.Location = new System.Drawing.Point(842, 483);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(75, 24);
            this.ConsultaButton.TabIndex = 5;
            this.ConsultaButton.Text = "consulta";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // baseDeDatosComboBox
            // 
            this.baseDeDatosComboBox.FormattingEnabled = true;
            this.baseDeDatosComboBox.Items.AddRange(new object[] {
            "localhost database",
            "azure database"});
            this.baseDeDatosComboBox.Location = new System.Drawing.Point(694, 483);
            this.baseDeDatosComboBox.Name = "baseDeDatosComboBox";
            this.baseDeDatosComboBox.Size = new System.Drawing.Size(142, 24);
            this.baseDeDatosComboBox.TabIndex = 6;
            this.baseDeDatosComboBox.SelectedIndexChanged += new System.EventHandler(this.baseDeDatosComboBox_SelectedIndexChanged);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(208, 484);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 7;
            this.prevButton.Text = "< Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(292, 484);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Location = new System.Drawing.Point(243, 70);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(103, 17);
            this.totalPagesLabel.TabIndex = 9;
            this.totalPagesLabel.Text = "products found";
            // 
            // actualPageLabel
            // 
            this.actualPageLabel.AutoSize = true;
            this.actualPageLabel.Location = new System.Drawing.Point(490, 70);
            this.actualPageLabel.Name = "actualPageLabel";
            this.actualPageLabel.Size = new System.Drawing.Size(87, 17);
            this.actualPageLabel.TabIndex = 10;
            this.actualPageLabel.Text = "0 of 0 pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "base de datos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actualPageLabel);
            this.Controls.Add(this.totalPagesLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
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
        private System.Windows.Forms.ComboBox BusquedaComboBox;
        private System.Windows.Forms.TextBox patronTextBox;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.ComboBox baseDeDatosComboBox;
        private System.Windows.Forms.CheckBox disponiblesCheckBox;
        private System.Windows.Forms.ComboBox lenguajeComboBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label totalPagesLabel;
        private System.Windows.Forms.Label actualPageLabel;
        private System.Windows.Forms.Label elegidoLabel;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.TextBox maxElegidoTextBox;
        private System.Windows.Forms.TextBox minElegidoTextBox;
        private System.Windows.Forms.TextBox elegidoTextBox;
        private System.Windows.Forms.Label maxElegidoLabel;
        private System.Windows.Forms.Label minElegidoLabel;
        private System.Windows.Forms.Label label1;
    }
}

