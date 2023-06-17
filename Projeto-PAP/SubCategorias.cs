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
    public partial class SubCategorias : Form
    {
        Connect obj = new Connect();
        public SubCategorias()
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
                categoriaComboBox.DataSource = table;

                //obtemos o valor do membro (código da descrição)
                categoriaComboBox.ValueMember = "IdCategoria";

                //obtemos a descrição do membro
                categoriaComboBox.DisplayMember = "Categoria";
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

        private void SubCategorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.SubCategorias' table. You can move, or remove it, as needed.
            //this.subCategoriasTableAdapter.Fill(this._BD_PAPDataSet.SubCategorias);
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;


            preencheCategorias();
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categorias a = new Categorias();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contalinhas;
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                contalinhas = "select Max(IdSubCategorias) From SubCategorias";
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = contalinhas;
                int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                obj.con.Close();
                x++;
                string query = "Insert into SubCategorias(IdSubCategorias,Subcategorias) Values('" + x + "','" + textBox1.Text + "')";
                SqlCommand sqlcom = new SqlCommand(query, obj.con);
                SqlDataReader myreader;
                obj.con.Close();
                obj.con.Open();
                myreader = sqlcom.ExecuteReader();
                MessageBox.Show("SubCategoria inserida com sucesso");
                obj.con.Close();

                try
                {
                    obj.con.Open();
                    MessageBox.Show("categoria index: " + (categoriaComboBox.SelectedIndex + 1) + "categoria: " + categoriaComboBox.Text);
                    MessageBox.Show("categoria index: "+categoriaComboBox.SelectedIndex+1+"categoria: "+categoriaComboBox.Text);
                    string queryy = "Insert into CatSub(IdCategoria,Idsubcategoria) Values('" + (categoriaComboBox.SelectedIndex+1) + "','" + x + "')";
                    SqlCommand sqlcomm = new SqlCommand(queryy, obj.con);
                    SqlDataReader myreaderr;
                    myreaderr = sqlcomm.ExecuteReader();
                    MessageBox.Show("Registo de CAT SUB inserido com sucesso");
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

        private void subCategoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subCategoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet);

        }

        public class SubCategoriaa
        {
            public int IdSubCategorias { get; set; }
            public string Subcategorias { get; set; }
        }

        private List<SubCategoriaa> ObterLista(string nomeSubCategoria)
        {
            obj.con.ConnectionString = obj.locate;


            //Instância da lista que será retornada 
            List<SubCategoriaa> lista = new List<SubCategoriaa>();
            // query do Comando utilizando o parâmetro recebido pelo método  
            string query = "SELECT IdSubCategorias,SubCategorias FROM SubCategorias WHERE SubCategorias LIKE '%" + nomeSubCategoria + "%'";
            //Instância do comando 
            SqlCommand cmd = new SqlCommand(query, obj.con);
            //Abro conexão 
            obj.con.Open();
            //instância do leitor 
            SqlDataReader leitor = cmd.ExecuteReader();

            //Se há linhas 
            if (leitor.HasRows)
            {
                //enquanto lê 
                while (leitor.Read())
                {
                    //Instância de uma nova categoria
                    SubCategoriaa f = new SubCategoriaa();
                    //Recupero os valores  
                    f.IdSubCategorias = Convert.ToInt32(leitor["IdSubCategorias"]);
                    f.Subcategorias = leitor["Subcategorias"].ToString();
                    //Adiciono a lista 
                    lista.Add(f);
                }
            }
            //Fecho conexão 
            obj.con.Close();
            //Retorno a lista  
            return lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subCategoriasDataGridView.DataSource = ObterLista(textBox2.Text);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (categoriaComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Escolha a Categoria");
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (categoriaComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Escolha a Categoria");
                textBox1.Text = "";
            }
        }
    }
}
