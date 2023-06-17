namespace Projeto_PAP
{
    partial class VisaoGeral
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD_PAPDataSet1 = new Projeto_PAP._BD_PAPDataSet();
            this.RendimentosSelectCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDespesas = new Projeto_PAP.DataSetDespesas();
            this.ReceitasSelectCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RendimentosSelectCommandTableAdapter = new Projeto_PAP.DataSetDespesasTableAdapters.RendimentosSelectCommandTableAdapter();
            this.ReceitasSelectCommandTableAdapter = new Projeto_PAP.DataSetDespesasTableAdapters.ReceitasSelectCommandTableAdapter();
            this.GastosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.GastosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.contacomboBox = new System.Windows.Forms.ComboBox();
            this.NomeContalabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalDespesaslabel = new System.Windows.Forms.Label();
            this.TotalReceitaslabel = new System.Windows.Forms.Label();
            this._BD_PAPDataSet2 = new Projeto_PAP._BD_PAPDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.SaldoTotallabel = new System.Windows.Forms.Label();
            this.Verificarbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RendimentosSelectCommandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceitasSelectCommandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GastosBindingSource
            // 
            this.GastosBindingSource.DataMember = "Gastos";
            this.GastosBindingSource.DataSource = this._BD_PAPDataSet1;
            // 
            // _BD_PAPDataSet1
            // 
            this._BD_PAPDataSet1.DataSetName = "_BD_PAPDataSet1";
            this._BD_PAPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RendimentosSelectCommandBindingSource
            // 
            this.RendimentosSelectCommandBindingSource.DataMember = "RendimentosSelectCommand";
            this.RendimentosSelectCommandBindingSource.DataSource = this.DataSetDespesas;
            // 
            // DataSetDespesas
            // 
            this.DataSetDespesas.DataSetName = "DataSetDespesas";
            this.DataSetDespesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceitasSelectCommandBindingSource
            // 
            this.ReceitasSelectCommandBindingSource.DataMember = "ReceitasSelectCommand";
            this.ReceitasSelectCommandBindingSource.DataSource = this.DataSetDespesas;
            // 
            // reportViewer3
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GastosBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projeto_PAP.ReportDespesas.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(63, 299);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1211, 608);
            this.reportViewer3.TabIndex = 0;
            // 
            // RendimentosSelectCommandTableAdapter
            // 
            this.RendimentosSelectCommandTableAdapter.ClearBeforeFill = true;
            // 
            // ReceitasSelectCommandTableAdapter
            // 
            this.ReceitasSelectCommandTableAdapter.ClearBeforeFill = true;
            // 
            // GastosTableAdapter
            // 
            this.GastosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione uma conta:";
            // 
            // contacomboBox
            // 
            this.contacomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacomboBox.FormattingEnabled = true;
            this.contacomboBox.Location = new System.Drawing.Point(111, 99);
            this.contacomboBox.Name = "contacomboBox";
            this.contacomboBox.Size = new System.Drawing.Size(274, 37);
            this.contacomboBox.TabIndex = 2;
            // 
            // NomeContalabel
            // 
            this.NomeContalabel.AutoSize = true;
            this.NomeContalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeContalabel.Location = new System.Drawing.Point(17, 17);
            this.NomeContalabel.Name = "NomeContalabel";
            this.NomeContalabel.Size = new System.Drawing.Size(156, 36);
            this.NomeContalabel.TabIndex = 3;
            this.NomeContalabel.Text = "Na Conta: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tem registado";
            // 
            // TotalDespesaslabel
            // 
            this.TotalDespesaslabel.AutoSize = true;
            this.TotalDespesaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDespesaslabel.Location = new System.Drawing.Point(28, 126);
            this.TotalDespesaslabel.Name = "TotalDespesaslabel";
            this.TotalDespesaslabel.Size = new System.Drawing.Size(218, 36);
            this.TotalDespesaslabel.TabIndex = 5;
            this.TotalDespesaslabel.Text = "€ em Despesas";
            // 
            // TotalReceitaslabel
            // 
            this.TotalReceitaslabel.AutoSize = true;
            this.TotalReceitaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReceitaslabel.Location = new System.Drawing.Point(28, 188);
            this.TotalReceitaslabel.Name = "TotalReceitaslabel";
            this.TotalReceitaslabel.Size = new System.Drawing.Size(202, 36);
            this.TotalReceitaslabel.TabIndex = 6;
            this.TotalReceitaslabel.Text = "€ em Receitas";
            // 
            // _BD_PAPDataSet2
            // 
            this._BD_PAPDataSet2.DataSetName = "_BD_PAPDataSet";
            this._BD_PAPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ficando assim com o saldo de:";
            // 
            // SaldoTotallabel
            // 
            this.SaldoTotallabel.AutoSize = true;
            this.SaldoTotallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoTotallabel.Location = new System.Drawing.Point(434, 135);
            this.SaldoTotallabel.Name = "SaldoTotallabel";
            this.SaldoTotallabel.Size = new System.Drawing.Size(32, 36);
            this.SaldoTotallabel.TabIndex = 8;
            this.SaldoTotallabel.Text = "€";
            // 
            // Verificarbutton
            // 
            this.Verificarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verificarbutton.Location = new System.Drawing.Point(108, 142);
            this.Verificarbutton.Name = "Verificarbutton";
            this.Verificarbutton.Size = new System.Drawing.Size(277, 48);
            this.Verificarbutton.TabIndex = 9;
            this.Verificarbutton.Text = "Verificar";
            this.Verificarbutton.UseVisualStyleBackColor = true;
            this.Verificarbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NomeContalabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SaldoTotallabel);
            this.panel1.Controls.Add(this.TotalDespesaslabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TotalReceitaslabel);
            this.panel1.Location = new System.Drawing.Point(455, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 254);
            this.panel1.TabIndex = 10;
            // 
            // VisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 1008);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Verificarbutton);
            this.Controls.Add(this.contacomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisaoGeral";
            this.Text = "VisaoGeral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisaoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RendimentosSelectCommandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceitasSelectCommandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource RendimentosSelectCommandBindingSource;
        private DataSetDespesas DataSetDespesas;
        private System.Windows.Forms.BindingSource ReceitasSelectCommandBindingSource;
        private DataSetDespesasTableAdapters.RendimentosSelectCommandTableAdapter RendimentosSelectCommandTableAdapter;
        private DataSetDespesasTableAdapters.ReceitasSelectCommandTableAdapter ReceitasSelectCommandTableAdapter;
        private System.Windows.Forms.BindingSource GastosBindingSource;
        private _BD_PAPDataSet _BD_PAPDataSet1;
        private _BD_PAPDataSetTableAdapters.GastosTableAdapter GastosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contacomboBox;
        private System.Windows.Forms.Label NomeContalabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalDespesaslabel;
        private System.Windows.Forms.Label TotalReceitaslabel;
        private _BD_PAPDataSet _BD_PAPDataSet2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SaldoTotallabel;
        private System.Windows.Forms.Button Verificarbutton;
        private System.Windows.Forms.Panel panel1;
    }
}