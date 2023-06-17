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
    public partial class Receitas : Form
    {
        Connect obj = new Connect();
        public Receitas()
        {
            InitializeComponent();
        }

        private void receitasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet);

        }
        private void preenchercontas()
        {
            obj.con.Close();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();

            try
            {
                //SqlCommand comando = new SqlCommand("Select Categoria From Categorias where Categoria like'this.contaComboBox.DisplayMember == 'Conta''", obj.con);
                SqlCommand comando = new SqlCommand("Select IdConta,Conta From Contas", obj.con);

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

        private void Receitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Receitas' table. You can move, or remove it, as needed.
            //this.receitasTableAdapter.Fill(this._BD_PAPDataSet.Receitas);
            preenchercontas();
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contaComboBox.SelectedIndex != 0)
            {
                if (quantiaTextBox.Text != "" && descReceitaTextBox.Text != "")
                {
                    string contalinhas;
                    try
                    {
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        contalinhas = "SELECT MAX(Idreceita) FROM Receitas";
                        obj.cmd.Connection = obj.con;
                        obj.cmd.CommandText = contalinhas;
                        int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                        obj.con.Close();
                        x++;
                        

                        obj.con.Open();
                        string query = "Insert into Receitas(Idreceita,Quantia,DescReceita,IdConta) Values('" + x + "','" + quantiaTextBox.Text + "','" + descReceitaTextBox.Text + "','"+contaComboBox.SelectedIndex+1+"')";
                        SqlCommand sqlcom = new SqlCommand(query, obj.con);
                        SqlDataReader myreader;
                        obj.con.Close();
                        /*obj.con.Open();
                        myreader = sqlcom.ExecuteReader();
                        MessageBox.Show("Receita inserida com sucesso");
                        obj.con.Close();*/

                        try
                        {
                            obj.con.ConnectionString = obj.locate;

                            string queryyy = "SELECT Idutilizador,Email FROM Utilizador WHERE Email LIKE '%" + SessaoSistema.EmailUsuario + "%' ";

                            SqlCommand cmd = new SqlCommand(queryyy, obj.con);
                            obj.con.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            reader.Read();
                            string xxx = reader["Idutilizador"].ToString();
                            obj.con.Close();
                            obj.con.Open();

                            String dt = dataDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
                            MessageBox.Show("data trocada: " + dt);
                            string queryy = "Insert into UtilizadorReceitas(Idreceitas,Idutilizador,Data) Values('" + x + "','" + xxx + "','" + dt + "')";
                            SqlCommand sqlcomm = new SqlCommand(queryy, obj.con);
                            SqlDataReader myreaderr;


                            myreaderr = sqlcomm.ExecuteReader();
                            MessageBox.Show("Data inserida com sucesso");
                            obj.con.Close();
                            obj.con.Open();

                            myreader = sqlcom.ExecuteReader();
                            MessageBox.Show("Receita inserida com sucesso");
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

                    //gastosBindingSource.EndEdit();
                    //gastosTableAdapter.Update(_BD_PAPDataSet.Gastos);
                }
                else
                {
                    MessageBox.Show("Introduza Valores Válidos", "GestMyMoney", MessageBoxButtons.RetryCancel);
                }
            }
            else
            {
                MessageBox.Show("Selecione a Conta", "GestMyMoney", MessageBoxButtons.RetryCancel);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contas a = new Contas();
            a.Show();
        }
    }
}
