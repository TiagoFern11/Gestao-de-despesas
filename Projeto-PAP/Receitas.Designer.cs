namespace Projeto_PAP
{
    partial class Receitas
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
            this.contaLabel1 = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.quantiaLabel = new System.Windows.Forms.Label();
            this.descReceitaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.descReceitaTextBox = new System.Windows.Forms.TextBox();
            this.receitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD_PAPDataSet = new Projeto_PAP._BD_PAPDataSet();
            this.quantiaTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contaComboBox = new System.Windows.Forms.ComboBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.receitasTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.ReceitasTableAdapter();
            this.tableAdapterManager = new Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contaLabel1
            // 
            this.contaLabel1.AutoSize = true;
            this.contaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaLabel1.Location = new System.Drawing.Point(81, 147);
            this.contaLabel1.Name = "contaLabel1";
            this.contaLabel1.Size = new System.Drawing.Size(64, 24);
            this.contaLabel1.TabIndex = 20;
            this.contaLabel1.Text = "Conta:";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(93, 197);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(52, 24);
            this.dataLabel.TabIndex = 18;
            this.dataLabel.Text = "Data:";
            // 
            // quantiaLabel
            // 
            this.quantiaLabel.AutoSize = true;
            this.quantiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiaLabel.Location = new System.Drawing.Point(67, 102);
            this.quantiaLabel.Name = "quantiaLabel";
            this.quantiaLabel.Size = new System.Drawing.Size(80, 24);
            this.quantiaLabel.TabIndex = 28;
            this.quantiaLabel.Text = "Quantia:";
            // 
            // descReceitaLabel
            // 
            this.descReceitaLabel.AutoSize = true;
            this.descReceitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descReceitaLabel.Location = new System.Drawing.Point(167, 234);
            this.descReceitaLabel.Name = "descReceitaLabel";
            this.descReceitaLabel.Size = new System.Drawing.Size(193, 24);
            this.descReceitaLabel.TabIndex = 29;
            this.descReceitaLabel.Text = "Descrição da Receita:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.descReceitaLabel);
            this.panel1.Controls.Add(this.descReceitaTextBox);
            this.panel1.Controls.Add(this.quantiaLabel);
            this.panel1.Controls.Add(this.quantiaTextBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.contaLabel1);
            this.panel1.Controls.Add(this.contaComboBox);
            this.panel1.Controls.Add(this.dataLabel);
            this.panel1.Controls.Add(this.dataDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(655, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 440);
            this.panel1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Registar receitas";
            // 
            // descReceitaTextBox
            // 
            this.descReceitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitasBindingSource, "DescReceita", true));
            this.descReceitaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descReceitaTextBox.Location = new System.Drawing.Point(151, 261);
            this.descReceitaTextBox.Multiline = true;
            this.descReceitaTextBox.Name = "descReceitaTextBox";
            this.descReceitaTextBox.Size = new System.Drawing.Size(249, 59);
            this.descReceitaTextBox.TabIndex = 30;
            // 
            // receitasBindingSource
            // 
            this.receitasBindingSource.DataMember = "Receitas";
            this.receitasBindingSource.DataSource = this._BD_PAPDataSet;
            // 
            // _BD_PAPDataSet
            // 
            this._BD_PAPDataSet.DataSetName = "_BD_PAPDataSet";
            this._BD_PAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantiaTextBox
            // 
            this.quantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitasBindingSource, "Quantia", true));
            this.quantiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiaTextBox.Location = new System.Drawing.Point(151, 99);
            this.quantiaTextBox.Name = "quantiaTextBox";
            this.quantiaTextBox.Size = new System.Drawing.Size(99, 29);
            this.quantiaTextBox.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(365, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 32);
            this.button4.TabIndex = 27;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contaComboBox
            // 
            this.contaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaComboBox.FormattingEnabled = true;
            this.contaComboBox.Items.AddRange(new object[] {
            " "});
            this.contaComboBox.Location = new System.Drawing.Point(151, 144);
            this.contaComboBox.Name = "contaComboBox";
            this.contaComboBox.Size = new System.Drawing.Size(200, 32);
            this.contaComboBox.TabIndex = 21;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(151, 193);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(249, 29);
            this.dataDateTimePicker.TabIndex = 19;
            // 
            // receitasTableAdapter
            // 
            this.receitasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.CatSubTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.GastosTableAdapter = null;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.ReceitasTableAdapter = this.receitasTableAdapter;
            this.tableAdapterManager.RendimentosTableAdapter = null;
            this.tableAdapterManager.SubCategoriasTableAdapter = null;
            this.tableAdapterManager.TipoRendimentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadorGastosTableAdapter = null;
            this.tableAdapterManager.UtilizadorReceitasTableAdapter = null;
            this.tableAdapterManager.UtilizadorRendimentosTableAdapter = null;
            this.tableAdapterManager.UtilizadorTableAdapter = null;
            // 
            // Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receitas";
            this.Text = "Receitas";
            this.Load += new System.EventHandler(this.Receitas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox contaComboBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private _BD_PAPDataSet _BD_PAPDataSet;
        private System.Windows.Forms.BindingSource receitasBindingSource;
        private _BD_PAPDataSetTableAdapters.ReceitasTableAdapter receitasTableAdapter;
        private _BD_PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descReceitaTextBox;
        private System.Windows.Forms.TextBox quantiaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contaLabel1;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label quantiaLabel;
        private System.Windows.Forms.Label descReceitaLabel;
    }
}