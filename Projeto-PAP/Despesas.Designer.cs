namespace Projeto_PAP
{
    partial class Despesas
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
            this.components = new System.ComponentModel.Container();
            this.quantiaLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.contaLabel1 = new System.Windows.Forms.Label();
            this.localidadeLabel = new System.Windows.Forms.Label();
            this.subcategoriasLabel = new System.Windows.Forms.Label();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.lugarLabel = new System.Windows.Forms.Label();
            this._BD_PAPDataSet = new Projeto_PAP._BD_PAPDataSet();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.GastosTableAdapter();
            this.tableAdapterManager = new Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager();
            this.categoriasTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.CategoriasTableAdapter();
            this.contasTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.ContasTableAdapter();
            this.subCategoriasTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.SubCategoriasTableAdapter();
            this.utilizadorGastosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.UtilizadorGastosTableAdapter();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadorGastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contaComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantiaTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.localidadeComboBox = new System.Windows.Forms.ComboBox();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lugarTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoriasComboBox = new System.Windows.Forms.ComboBox();
            this.localidadesTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.LocalidadesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetDespesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDespesas = new Projeto_PAP.DataSetDespesas();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorGastosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDespesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // quantiaLabel
            // 
            this.quantiaLabel.AutoSize = true;
            this.quantiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiaLabel.Location = new System.Drawing.Point(72, 64);
            this.quantiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantiaLabel.Name = "quantiaLabel";
            this.quantiaLabel.Size = new System.Drawing.Size(102, 29);
            this.quantiaLabel.TabIndex = 7;
            this.quantiaLabel.Text = "Quantia:";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(111, 442);
            this.dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(68, 29);
            this.dataLabel.TabIndex = 18;
            this.dataLabel.Text = "Data:";
            // 
            // contaLabel1
            // 
            this.contaLabel1.AutoSize = true;
            this.contaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaLabel1.Location = new System.Drawing.Point(95, 378);
            this.contaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contaLabel1.Name = "contaLabel1";
            this.contaLabel1.Size = new System.Drawing.Size(82, 29);
            this.contaLabel1.TabIndex = 20;
            this.contaLabel1.Text = "Conta:";
            // 
            // localidadeLabel
            // 
            this.localidadeLabel.AutoSize = true;
            this.localidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadeLabel.Location = new System.Drawing.Point(43, 325);
            this.localidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.localidadeLabel.Name = "localidadeLabel";
            this.localidadeLabel.Size = new System.Drawing.Size(131, 29);
            this.localidadeLabel.TabIndex = 28;
            this.localidadeLabel.Text = "localidade:";
            // 
            // subcategoriasLabel
            // 
            this.subcategoriasLabel.AutoSize = true;
            this.subcategoriasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcategoriasLabel.Location = new System.Drawing.Point(0, 187);
            this.subcategoriasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subcategoriasLabel.Name = "subcategoriasLabel";
            this.subcategoriasLabel.Size = new System.Drawing.Size(173, 29);
            this.subcategoriasLabel.TabIndex = 13;
            this.subcategoriasLabel.Text = "Sub Categoria:";
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.Location = new System.Drawing.Point(53, 122);
            this.categoriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(124, 29);
            this.categoriaLabel.TabIndex = 12;
            this.categoriaLabel.Text = "Categoria:";
            // 
            // lugarLabel
            // 
            this.lugarLabel.AutoSize = true;
            this.lugarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugarLabel.Location = new System.Drawing.Point(95, 256);
            this.lugarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lugarLabel.Name = "lugarLabel";
            this.lugarLabel.Size = new System.Drawing.Size(80, 29);
            this.lugarLabel.TabIndex = 3;
            this.lugarLabel.Text = "Lugar:";
            // 
            // _BD_PAPDataSet
            // 
            this._BD_PAPDataSet.DataSetName = "_BD_PAPDataSet";
            this._BD_PAPDataSet.EnforceConstraints = false;
            this._BD_PAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "Gastos";
            this.gastosBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // gastosTableAdapter
            // 
            this.gastosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.CatSubTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.GastosTableAdapter = this.gastosTableAdapter;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.ReceitasTableAdapter = null;
            this.tableAdapterManager.RendimentosTableAdapter = null;
            this.tableAdapterManager.SubCategoriasTableAdapter = this.subCategoriasTableAdapter;
            this.tableAdapterManager.TipoRendimentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadorGastosTableAdapter = this.utilizadorGastosTableAdapter;
            this.tableAdapterManager.UtilizadorReceitasTableAdapter = null;
            this.tableAdapterManager.UtilizadorRendimentosTableAdapter = null;
            this.tableAdapterManager.UtilizadorTableAdapter = null;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // subCategoriasTableAdapter
            // 
            this.subCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // utilizadorGastosTableAdapter
            // 
            this.utilizadorGastosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // subCategoriasBindingSource
            // 
            this.subCategoriasBindingSource.DataMember = "SubCategorias";
            this.subCategoriasBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // utilizadorGastosBindingSource
            // 
            this.utilizadorGastosBindingSource.DataMember = "UtilizadorGastos";
            this.utilizadorGastosBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utilizadorGastosBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(188, 437);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(308, 34);
            this.dataDateTimePicker.TabIndex = 19;
            // 
            // contaComboBox
            // 
            this.contaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Conta", true));
            this.contaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaComboBox.FormattingEnabled = true;
            this.contaComboBox.Items.AddRange(new object[] {
            " "});
            this.contaComboBox.Location = new System.Drawing.Point(188, 374);
            this.contaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.contaComboBox.Name = "contaComboBox";
            this.contaComboBox.Size = new System.Drawing.Size(265, 37);
            this.contaComboBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(173, 795);
            this.splitter1.TabIndex = 23;
            this.splitter1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(473, 374);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 39);
            this.button4.TabIndex = 27;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quantiaTextBox);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.localidadeLabel);
            this.panel1.Controls.Add(this.localidadeComboBox);
            this.panel1.Controls.Add(this.lugarTextBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.quantiaLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lugarLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.categoriaComboBox);
            this.panel1.Controls.Add(this.contaLabel1);
            this.panel1.Controls.Add(this.categoriaLabel);
            this.panel1.Controls.Add(this.contaComboBox);
            this.panel1.Controls.Add(this.subcategoriasComboBox);
            this.panel1.Controls.Add(this.dataLabel);
            this.panel1.Controls.Add(this.subcategoriasLabel);
            this.panel1.Controls.Add(this.dataDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(797, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 591);
            this.panel1.TabIndex = 28;
            // 
            // quantiaTextBox
            // 
            this.quantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastosBindingSource, "Quantia", true));
            this.quantiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiaTextBox.Location = new System.Drawing.Point(192, 69);
            this.quantiaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantiaTextBox.Name = "quantiaTextBox";
            this.quantiaTextBox.Size = new System.Drawing.Size(132, 34);
            this.quantiaTextBox.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(469, 315);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 39);
            this.button5.TabIndex = 30;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // localidadeComboBox
            // 
            this.localidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.localidadesBindingSource, "localidade", true));
            this.localidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadeComboBox.FormattingEnabled = true;
            this.localidadeComboBox.Location = new System.Drawing.Point(192, 315);
            this.localidadeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.localidadeComboBox.Name = "localidadeComboBox";
            this.localidadeComboBox.Size = new System.Drawing.Size(265, 37);
            this.localidadeComboBox.TabIndex = 29;
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "Localidades";
            this.localidadesBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // lugarTextBox
            // 
            this.lugarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gastosBindingSource, "Lugar", true));
            this.lugarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugarTextBox.Location = new System.Drawing.Point(188, 252);
            this.lugarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lugarTextBox.Name = "lugarTextBox";
            this.lugarTextBox.Size = new System.Drawing.Size(265, 34);
            this.lugarTextBox.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(473, 187);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 39);
            this.button3.TabIndex = 26;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(473, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 39);
            this.button2.TabIndex = 25;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subCategoriasBindingSource, "Subcategorias", true));
            this.categoriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            " "});
            this.categoriaComboBox.Location = new System.Drawing.Point(188, 118);
            this.categoriaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(265, 37);
            this.categoriaComboBox.TabIndex = 13;
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
            // 
            // subcategoriasComboBox
            // 
            this.subcategoriasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "Categoria", true));
            this.subcategoriasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcategoriasComboBox.FormattingEnabled = true;
            this.subcategoriasComboBox.Items.AddRange(new object[] {
            " "});
            this.subcategoriasComboBox.Location = new System.Drawing.Point(188, 183);
            this.subcategoriasComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subcategoriasComboBox.Name = "subcategoriasComboBox";
            this.subcategoriasComboBox.Size = new System.Drawing.Size(265, 37);
            this.subcategoriasComboBox.TabIndex = 14;
            // 
            // localidadesTableAdapter
            // 
            this.localidadesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Maroon;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "ReportDespesas.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetDespesasBindingSource
            // 
            this.dataSetDespesasBindingSource.DataSource = this.dataSetDespesas;
            this.dataSetDespesasBindingSource.Position = 0;
            // 
            // dataSetDespesas
            // 
            this.dataSetDespesas.DataSetName = "DataSetDespesas";
            this.dataSetDespesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nova Despesa";
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 795);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Despesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Despesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorGastosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDespesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDespesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _BD_PAPDataSet _BD_PAPDataSet;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private _BD_PAPDataSetTableAdapters.GastosTableAdapter gastosTableAdapter;
        private _BD_PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _BD_PAPDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private _BD_PAPDataSetTableAdapters.SubCategoriasTableAdapter subCategoriasTableAdapter;
        private System.Windows.Forms.BindingSource subCategoriasBindingSource;
        private _BD_PAPDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private _BD_PAPDataSetTableAdapters.UtilizadorGastosTableAdapter utilizadorGastosTableAdapter;
        private System.Windows.Forms.BindingSource utilizadorGastosBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox contaComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private _BD_PAPDataSetTableAdapters.LocalidadesTableAdapter localidadesTableAdapter;
        private System.Windows.Forms.TextBox quantiaTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox localidadeComboBox;
        private System.Windows.Forms.TextBox lugarTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.ComboBox subcategoriasComboBox;
        private System.Windows.Forms.Label quantiaLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label contaLabel1;
        private System.Windows.Forms.Label localidadeLabel;
        private System.Windows.Forms.Label subcategoriasLabel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.Label lugarLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetDespesasBindingSource;
        private DataSetDespesas dataSetDespesas;
        private System.Windows.Forms.Label label1;
    }
}