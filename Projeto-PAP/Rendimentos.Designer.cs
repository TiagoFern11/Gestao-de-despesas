namespace Projeto_PAP
{
    partial class Rendimentos
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
            this.tipoRendimentoLabel = new System.Windows.Forms.Label();
            this.contaLabel = new System.Windows.Forms.Label();
            this.quantiaLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this._BD_PAPDataSet = new Projeto_PAP._BD_PAPDataSet();
            this.tipoRendimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoRendimentosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.TipoRendimentosTableAdapter();
            this.tableAdapterManager = new Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager();
            this.contasTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.ContasTableAdapter();
            this.rendimentosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.RendimentosTableAdapter();
            this.tipoRendimentoComboBox = new System.Windows.Forms.ComboBox();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contaComboBox = new System.Windows.Forms.ComboBox();
            this.rendimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantiaTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.utilizadorRendimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadorRendimentosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.UtilizadorRendimentosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRendimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendimentosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorRendimentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoRendimentoLabel
            // 
            this.tipoRendimentoLabel.AutoSize = true;
            this.tipoRendimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoRendimentoLabel.Location = new System.Drawing.Point(43, 219);
            this.tipoRendimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoRendimentoLabel.Name = "tipoRendimentoLabel";
            this.tipoRendimentoLabel.Size = new System.Drawing.Size(206, 29);
            this.tipoRendimentoLabel.TabIndex = 1;
            this.tipoRendimentoLabel.Text = "Tipo Rendimento:";
            // 
            // contaLabel
            // 
            this.contaLabel.AutoSize = true;
            this.contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaLabel.Location = new System.Drawing.Point(172, 270);
            this.contaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contaLabel.Name = "contaLabel";
            this.contaLabel.Size = new System.Drawing.Size(82, 29);
            this.contaLabel.TabIndex = 3;
            this.contaLabel.Text = "Conta:";
            // 
            // quantiaLabel
            // 
            this.quantiaLabel.AutoSize = true;
            this.quantiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiaLabel.Location = new System.Drawing.Point(151, 362);
            this.quantiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantiaLabel.Name = "quantiaLabel";
            this.quantiaLabel.Size = new System.Drawing.Size(102, 29);
            this.quantiaLabel.TabIndex = 5;
            this.quantiaLabel.Text = "Quantia:";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(188, 318);
            this.dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(68, 29);
            this.dataLabel.TabIndex = 28;
            this.dataLabel.Text = "Data:";
            // 
            // _BD_PAPDataSet
            // 
            this._BD_PAPDataSet.DataSetName = "_BD_PAPDataSet";
            this._BD_PAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoRendimentosBindingSource
            // 
            this.tipoRendimentosBindingSource.DataMember = "TipoRendimentos";
            this.tipoRendimentosBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // tipoRendimentosTableAdapter
            // 
            this.tipoRendimentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.CatSubTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.GastosTableAdapter = null;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.ReceitasTableAdapter = null;
            this.tableAdapterManager.RendimentosTableAdapter = this.rendimentosTableAdapter;
            this.tableAdapterManager.SubCategoriasTableAdapter = null;
            this.tableAdapterManager.TipoRendimentosTableAdapter = this.tipoRendimentosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadorGastosTableAdapter = null;
            this.tableAdapterManager.UtilizadorReceitasTableAdapter = null;
            this.tableAdapterManager.UtilizadorRendimentosTableAdapter = null;
            this.tableAdapterManager.UtilizadorTableAdapter = null;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // rendimentosTableAdapter
            // 
            this.rendimentosTableAdapter.ClearBeforeFill = true;
            // 
            // tipoRendimentoComboBox
            // 
            this.tipoRendimentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoRendimentosBindingSource, "TipoRendimento", true));
            this.tipoRendimentoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoRendimentoComboBox.FormattingEnabled = true;
            this.tipoRendimentoComboBox.Location = new System.Drawing.Point(265, 215);
            this.tipoRendimentoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoRendimentoComboBox.Name = "tipoRendimentoComboBox";
            this.tipoRendimentoComboBox.Size = new System.Drawing.Size(273, 37);
            this.tipoRendimentoComboBox.TabIndex = 2;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // contaComboBox
            // 
            this.contaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Conta", true));
            this.contaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaComboBox.FormattingEnabled = true;
            this.contaComboBox.Location = new System.Drawing.Point(265, 266);
            this.contaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.contaComboBox.Name = "contaComboBox";
            this.contaComboBox.Size = new System.Drawing.Size(273, 37);
            this.contaComboBox.TabIndex = 4;
            // 
            // rendimentosBindingSource
            // 
            this.rendimentosBindingSource.DataMember = "Rendimentos";
            this.rendimentosBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // quantiaTextBox
            // 
            this.quantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rendimentosBindingSource, "Quantia", true));
            this.quantiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiaTextBox.Location = new System.Drawing.Point(265, 356);
            this.quantiaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantiaTextBox.Name = "quantiaTextBox";
            this.quantiaTextBox.Size = new System.Drawing.Size(132, 34);
            this.quantiaTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(548, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 39);
            this.button2.TabIndex = 26;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(407, 353);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 39);
            this.button3.TabIndex = 28;
            this.button3.Text = "Criar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataLabel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dataDateTimePicker);
            this.panel1.Controls.Add(this.tipoRendimentoComboBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tipoRendimentoLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.contaComboBox);
            this.panel1.Controls.Add(this.quantiaLabel);
            this.panel1.Controls.Add(this.contaLabel);
            this.panel1.Controls.Add(this.quantiaTextBox);
            this.panel1.Location = new System.Drawing.Point(619, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 393);
            this.panel1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 39);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rendimentos";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utilizadorRendimentosBindingSource, "Data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(265, 313);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(328, 34);
            this.dataDateTimePicker.TabIndex = 29;
            // 
            // utilizadorRendimentosBindingSource
            // 
            this.utilizadorRendimentosBindingSource.DataMember = "FK_Rendimentos_UtilizadorRendimentos";
            this.utilizadorRendimentosBindingSource.DataSource = this.rendimentosBindingSource;
            // 
            // utilizadorRendimentosTableAdapter
            // 
            this.utilizadorRendimentosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_PAP.ReportRendimentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(215, 200);
            this.reportViewer1.TabIndex = 30;
            this.reportViewer1.Visible = false;
            // 
            // Rendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 796);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rendimentos";
            this.Text = "Rendimentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rendimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRendimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendimentosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorRendimentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _BD_PAPDataSet _BD_PAPDataSet;
        private System.Windows.Forms.BindingSource tipoRendimentosBindingSource;
        private _BD_PAPDataSetTableAdapters.TipoRendimentosTableAdapter tipoRendimentosTableAdapter;
        private _BD_PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _BD_PAPDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private System.Windows.Forms.ComboBox tipoRendimentoComboBox;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private _BD_PAPDataSetTableAdapters.RendimentosTableAdapter rendimentosTableAdapter;
        private System.Windows.Forms.ComboBox contaComboBox;
        private System.Windows.Forms.BindingSource rendimentosBindingSource;
        private System.Windows.Forms.TextBox quantiaTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource utilizadorRendimentosBindingSource;
        private _BD_PAPDataSetTableAdapters.UtilizadorRendimentosTableAdapter utilizadorRendimentosTableAdapter;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tipoRendimentoLabel;
        private System.Windows.Forms.Label contaLabel;
        private System.Windows.Forms.Label quantiaLabel;
        private System.Windows.Forms.Label dataLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}