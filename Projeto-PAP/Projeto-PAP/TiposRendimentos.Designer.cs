namespace Projeto_PAP
{
    partial class TiposRendimentos
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._BD_PAPDataSet1 = new Projeto_PAP._BD_PAPDataSet();
            this.tipoRendimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoRendimentosTableAdapter = new Projeto_PAP._BD_PAPDataSetTableAdapters.TipoRendimentosTableAdapter();
            this.tableAdapterManager = new Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager();
            this.tipoRendimentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRendimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRendimentosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pesquisar tipo de Rendimentos";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(598, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(293, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 29);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adicionar tipos de Rendimentos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(598, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(293, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 29);
            this.textBox1.TabIndex = 8;
            // 
            // _BD_PAPDataSet1
            // 
            this._BD_PAPDataSet1.DataSetName = "_BD_PAPDataSet1";
            this._BD_PAPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoRendimentosBindingSource
            // 
            this.tipoRendimentosBindingSource.DataMember = "TipoRendimentos";
            this.tipoRendimentosBindingSource.DataSource = this._BD_PAPDataSet1;
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
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.GastosTableAdapter = null;
            this.tableAdapterManager.LocalidadesTableAdapter = null;
            this.tableAdapterManager.ReceitasTableAdapter = null;
            this.tableAdapterManager.RendimentosTableAdapter = null;
            this.tableAdapterManager.SubCategoriasTableAdapter = null;
            this.tableAdapterManager.TipoRendimentosTableAdapter = this.tipoRendimentosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP._BD_PAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadorGastosTableAdapter = null;
            this.tableAdapterManager.UtilizadorReceitasTableAdapter = null;
            this.tableAdapterManager.UtilizadorRendimentosTableAdapter = null;
            this.tableAdapterManager.UtilizadorTableAdapter = null;
            // 
            // tipoRendimentosDataGridView
            // 
            this.tipoRendimentosDataGridView.AutoGenerateColumns = false;
            this.tipoRendimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoRendimentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tipoRendimentosDataGridView.DataSource = this.tipoRendimentosBindingSource;
            this.tipoRendimentosDataGridView.Location = new System.Drawing.Point(238, 227);
            this.tipoRendimentosDataGridView.Name = "tipoRendimentosDataGridView";
            this.tipoRendimentosDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tipoRendimentosDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTipoRendimento";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdTipoRendimento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoRendimento";
            this.dataGridViewTextBoxColumn2.HeaderText = "TipoRendimento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipos de Rendimentos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tipoRendimentosDataGridView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 450);
            this.panel1.TabIndex = 16;
            // 
            // TiposRendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 474);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TiposRendimentos";
            this.Text = "TiposRendimentos";
            this.Load += new System.EventHandler(this.TiposRendimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this._BD_PAPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRendimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoRendimentosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private _BD_PAPDataSet _BD_PAPDataSet1;
        private System.Windows.Forms.BindingSource tipoRendimentosBindingSource;
        private _BD_PAPDataSetTableAdapters.TipoRendimentosTableAdapter tipoRendimentosTableAdapter;
        private _BD_PAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tipoRendimentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}