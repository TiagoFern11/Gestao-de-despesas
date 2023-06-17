using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_PAP
{
    public partial class Rendimentos : Form
    {
        Connect obj = new Connect();
        public Rendimentos()
        {
            InitializeComponent();
        }
        
        private void tipoRendimentosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoRendimentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet);

        }

        private void Rendimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.UtilizadorRendimentos' table. You can move, or remove it, as needed.
            //this.utilizadorRendimentosTableAdapter.Fill(this._BD_PAPDataSet.UtilizadorRendimentos);
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Rendimentos' table. You can move, or remove it, as needed.
            //this.rendimentosTableAdapter.Fill(this._BD_PAPDataSet.Rendimentos);
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Contas' table. You can move, or remove it, as needed.
            //this.contasTableAdapter.Fill(this._BD_PAPDataSet.Contas);
            // TODO: This line of code loads data into the '_BD_PAPDataSet.TipoRendimentos' table. You can move, or remove it, as needed.
            //this.tipoRendimentosTableAdapter.Fill(this._BD_PAPDataSet.TipoRendimentos);
            TodosTiposRendimentos();
            TodosTiposContas();
            this.reportViewer1.RefreshReport();
        }

        private void TodosTiposRendimentos()
        {
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();

            try
            {
                SqlCommand comando = new SqlCommand("Select IdTipoRendimento, TipoRendimento From TipoRendimentos", obj.con);
                
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                
                table.Load(reader);
                //DataRow row = table.NewRow();
                //row["TipoRendimento"] = "";

                //insere nova linha na coleção no local especificado
                //table.Rows.InsertAt(row, 0);

                //atribui o objeto DataTable a instância do SQL Server a ser conectada
                this.tipoRendimentoComboBox.DataSource = table;

                //obtemos o valor do membro (código da descrição)
                this.tipoRendimentoComboBox.ValueMember = "IdTipoRendimento";

                //obtemos a descrição do membro
                this.tipoRendimentoComboBox.DisplayMember = "TipoRendimento";
                reader.Close(); 
                reader.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível preencher o ComboBox\n\nErro:" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.con.Close();    
                obj.con.Dispose(); 
            }

        }

        private void TodosTiposContas()
        {
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();

            try
            {
                SqlCommand comando = new SqlCommand("Select IdConta, Conta From Contas", obj.con);

                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();

                table.Load(reader);
                DataRow row = table.NewRow();
                row["Conta"] = "";

                //insere nova linha na coleção no local especificado
                //table.Rows.InsertAt(row, 0);

                //atribui o objeto DataTable a instância do SQL Server a ser conectada
                this.contaComboBox.DataSource = table;

                //obtemos o valor do membro (código da descrição)
                this.contaComboBox.ValueMember = "IdConta";

                //obtemos a descrição do membro
                this.contaComboBox.DisplayMember = "Conta";
                reader.Close();
                reader.Dispose();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível preencher o ComboBox\n\nErro:" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.con.Close();
                obj.con.Dispose();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (tipoRendimentoComboBox.SelectedIndex != 0 && contaComboBox.SelectedIndex != 0 && quantiaLabel.Text !="")
            {
                
                try
                {
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    string contalinhas = "SELECT MAX(Idrendimento) FROM Rendimentos";
                    obj.cmd.Connection = obj.con;
                    obj.cmd.CommandText = contalinhas;
                    int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                    obj.con.Close();
                    x++;

                    obj.con.Open();
                    string query = "Insert into Rendimentos(Idrendimento,IdTipoRendimento,IdConta,Quantia) Values('" + x + "','" + tipoRendimentoComboBox.SelectedIndex + "','" + contaComboBox.SelectedIndex + "','" + quantiaTextBox.Text + "')";
                    SqlCommand sqlcom = new SqlCommand(query, obj.con);
                    SqlDataReader myreader;
                    
                    obj.con.Close();

                    try
                    {
                        obj.con.Open();
                        string queryyy = "SELECT Idutilizador,Email FROM Utilizador WHERE Email LIKE '%" + SessaoSistema.EmailUsuario + "%' ";

                        SqlCommand cmd = new SqlCommand(queryyy, obj.con);
                        
                        SqlDataReader reader = cmd.ExecuteReader();

                        reader.Read();
                        string xxx = reader["Idutilizador"].ToString();
                        obj.con.Close();
                        obj.con.Open();
                        
                        string Dataselecionada = String.Format("{0:dd/MM/yyyy}", (dataDateTimePicker.Value).ToString());
                        string queryy = "Insert into UtilizadorRendimentos(IdUtilizador,IdRendimento,Data) Values('" + xxx + "','" + x + "','" + Dataselecionada + "')";
                        SqlCommand sqlcomm = new SqlCommand(queryy, obj.con);
                        SqlDataReader myreaderr;
                        
                        myreaderr = sqlcomm.ExecuteReader();
                        MessageBox.Show("Dados inseridos nas tabelas");

                        myreader = sqlcom.ExecuteReader();
                        MessageBox.Show("Rendimento inserido com sucesso");

                        obj.con.Close();
                        obj.con.Dispose();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Introduza tipo de rendimento ou a conta","Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //gastosBindingSource.EndEdit();
            //gastosTableAdapter.Update(_BD_PAPDataSet.Gastos);
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Contas a = new Contas();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiposRendimentos a = new TiposRendimentos();
            a.Show();
        }
    }
}
