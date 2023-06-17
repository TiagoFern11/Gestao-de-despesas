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
    public partial class Despesas : Form
    {
        //instância da classe onde se encontra o método de conexão á base de dados
        Connect obj = new Connect();

        //http://www.macoratti.net/14/12/c_vdestq.htm

        public Despesas()
        {
            InitializeComponent();
            
        }
        

        private void preencheCategorias()
        {
            //atribui ao objeto con o método de conexão ao banco de dados 
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();

            try
            {
                SqlCommand comando = new SqlCommand("Select IdCategoria, Categoria From Categorias", obj.con);

                //retorna dados resultantes da consulta SQL 
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable(); //estrutura da tabela do BD ou de outra fonte

                //carrega dados na tabela de acordo com a instrução SQL passada
                table.Load(reader);
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row["Categoria"] = ""; //para não gerar valor nulo e evitar erro de execução

                //insere nova linha na coleção no local especificado
                //table.Rows.InsertAt(row, 0);

                //atribui o objeto DataTable a instância do SQL Server a ser conectada
                this.categoriaComboBox.DataSource = table;

                //obtemos o valor do membro (código da descrição)
                this.categoriaComboBox.ValueMember = "IdCategoria";

                //obtemos a descrição do membro
                this.categoriaComboBox.DisplayMember = "Categoria";
                reader.Close(); //fecha objeto
                reader.Dispose(); //liberamos o objeto da memória
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível preencher o ComboBox\n\nErro:" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.con.Close(); //fecha conexão    
                obj.con.Dispose(); //libertar o objeto da memória
            }

        }
        

        private void preenchersubcategorias()
        {
            obj.con.Close();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();

            try
            {
                int xx = categoriaComboBox.SelectedIndex +1;
                //MessageBox.Show(""+xx);
                SqlCommand comando = new SqlCommand("select IdSubCategorias, Subcategorias From SubCategorias where IdSubCategorias in (select Idsubcategoria From CatSub where IdCategoria = '" + xx + "')", obj.con);
                

                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                
                table.Load(reader);
                DataRow row = table.NewRow();
                row["Subcategorias"] = "";
                //table.Rows.InsertAt(row, 0);

                this.subcategoriasComboBox.DataSource = table;

                this.subcategoriasComboBox.ValueMember = "IdSubCategorias";
                this.subcategoriasComboBox.DisplayMember = "Subcategorias";

                //this.subcategoriasComboBox.ValueMember = "Idsubcategoria";

                //this.subcategoriasComboBox.DisplayMember = "Idsubcategoria";

                reader.Close();
                reader.Dispose();

                subcategoriasComboBox.Enabled = true;
                button3.Enabled = true;

                
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


        private void preencherlocalidades()
        {
            obj.con.Close();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();

            try
            {
                SqlCommand comando = new SqlCommand("select localidade From Localidades", obj.con);


                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();

                table.Load(reader);
                DataRow row = table.NewRow();
                row["localidade"] = "";

                //table.Rows.InsertAt(row, 0);

                this.localidadeComboBox.DataSource = table;

                this.localidadeComboBox.ValueMember = "localidade";

                this.localidadeComboBox.DisplayMember = "localidade";

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

        private void Despesas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Localidades' table. You can move, or remove it, as needed.
            //this.localidadesTableAdapter.Fill(this._BD_PAPDataSet.Localidades);
            // TODO: This line of code loads data into the '_BD_PAPDataSet._Utilizador_Gastos' table. You can move, or remove it, as needed.
            //this.utilizador_GastosTableAdapter.Fill(this._BD_PAPDataSet._Utilizador_Gastos);
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Contas' table. You can move, or remove it, as needed.
            //this.contasTableAdapter.Fill(this._BD_PAPDataSet.Contas);
            // TODO: This line of code loads data into the '_BD_PAPDataSet.SubCategorias' table. You can move, or remove it, as needed.
            //this.subCategoriasTableAdapter.Fill(this._BD_PAPDataSet.SubCategorias);
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Categorias' table. You can move, or remove it, as needed.
            //this.categoriasTableAdapter.Fill(this._BD_PAPDataSet.Categorias);
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Gastos' table. You can move, or remove it, as needed.
            //this.gastosTableAdapter.Fill(this._BD_PAPDataSet.Gastos);


            preencheCategorias();
            //preenchersubcategorias();
            preencherlocalidades();
            preenchercontas();
            //this.reportViewer1.RefreshReport();

            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoriaComboBox.SelectedIndex != 0 && subcategoriasComboBox.SelectedIndex != (-1) && contaComboBox.SelectedIndex != 0 && localidadeComboBox.SelectedIndex != 0)
            {
                if (quantiaTextBox.Text != "" && lugarTextBox.Text != "")
                {

                    string contalinhas;
                    try
                    {
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        contalinhas = "SELECT MAX(IdGasto) FROM Gastos";
                        obj.cmd.Connection = obj.con;
                        obj.cmd.CommandText = contalinhas;
                        int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                        obj.con.Close();
                        x++;

                        obj.con.Open();
                        string buscaid = "SELECT IdSubCategorias FROM SubCategorias where Subcategorias like '"+subcategoriasComboBox.Text+"'";
                        obj.cmd.Connection = obj.con;
                        obj.cmd.CommandText = buscaid;
                        int iddasubcategoria = Convert.ToInt16(obj.cmd.ExecuteScalar());
                        //MessageBox.Show("id da subcategoria selecionada " +iddasubcategoria);
                        obj.con.Close();

                        obj.con.Open();
                        string query = "Insert into Gastos(IdGasto,IdCategoria,IdSubCategoria,Lugar,Idlocalidade,Quantia) Values('" + x + "','" + categoriaComboBox.SelectedIndex+1 + "','" + iddasubcategoria + "','" + lugarTextBox.Text + "','" + localidadeComboBox.SelectedIndex+1 + "','" +quantiaTextBox.Text + "')";
                        SqlCommand sqlcom = new SqlCommand(query, obj.con);
                        SqlDataReader myreader;
                        obj.con.Close();
                        /*obj.con.Open();
                        myreader = sqlcom.ExecuteReader();
                        MessageBox.Show("Despesa inserida com sucesso");
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
                            //obj.con.Open();
                            int a = Convert.ToInt16(xxx);
                            /*
                            string daataa = (dataDateTimePicker.Value.Date).ToShortDateString();
                            //MessageBox.Show("daataa: " + daataa);
                            obj.con.Open();
                            string queryday = "SELECT DAY('"+ daataa + "') AS diadomess";
                            obj.cmd.Connection = obj.con;
                            obj.cmd.CommandText = queryday;
                            int diadomes = Convert.ToInt16(obj.cmd.ExecuteScalar());
                            //MessageBox.Show("dia do mes: " +diadomes);
                            obj.con.Close();

                            obj.con.Open();
                            string querymes = "SELECT MONTH('" + daataa + "') AS mess";
                            obj.cmd.Connection = obj.con;
                            obj.cmd.CommandText = querymes;
                            int mes = Convert.ToInt16(obj.cmd.ExecuteScalar());
                            //MessageBox.Show("mes: " + mes);
                            obj.con.Close();

                            obj.con.Open();
                            string queryano = "SELECT YEAR('" + daataa + "') AS anoo";
                            obj.cmd.Connection = obj.con;
                            obj.cmd.CommandText = queryano;
                            int ano = Convert.ToInt16(obj.cmd.ExecuteScalar());
                            //MessageBox.Show("ano: " + ano);
                            obj.con.Close();
                            //o dia e o mes estão trocados
                            string datatotal = ""+diadomes+"-"+mes+"-" + ano + "";
                            MessageBox.Show("datatotal: " + datatotal);
                            */
                            String dt = dataDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
                            MessageBox.Show("data trocada: " + dt);
                            
                            string queryy = "Insert into UtilizadorGastos(IdGasto,IdUtilizador,Data) Values(" + x + "," + a + ",'"+dt+"')";
                            SqlCommand sqlcomm = new SqlCommand(queryy, obj.con);
                            SqlDataReader myreaderr;

                            obj.con.Open();
                            myreaderr = sqlcomm.ExecuteReader();
                            MessageBox.Show("Data inserida com sucesso");
                            obj.con.Close();
                            obj.con.Open();
                            myreader = sqlcom.ExecuteReader();
                            MessageBox.Show("Despesa inserida com sucesso");
                            obj.con.Close();
                            obj.con.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            obj.con.Close();
                            obj.con.Dispose();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        obj.con.Close();
                        obj.con.Dispose();
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
                MessageBox.Show("Selecione a Categoria, Subcategoria, localidade ou a Conta", "GestMyMoney", MessageBoxButtons.RetryCancel);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            //cat.MdiParent = this.MdiParent;
            cat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contas a = new Contas();
            a.Show();
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(subcategoriasComboBox.Items.Count <=0)
            {
                //subcategoriasComboBox.Items.Clear();
            }*/
            preenchersubcategorias();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Localidades a = new Localidades();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubCategorias a = new SubCategorias();
            a.Show();
        }
    }
}
