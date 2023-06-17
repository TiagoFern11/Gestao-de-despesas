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
    public partial class Contas : Form
    {
        Connect obj = new Connect();
        public Contas()
        {
            InitializeComponent();
        }

        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet);

        }

        private void Contas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Contas' table. You can move, or remove it, as needed.
            //this.contasTableAdapter.Fill(this._BD_PAPDataSet.Contas);
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;
            contasDataGridView.DataSource = ObterLista(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contalinhas;
            if (valorTextBox.Text != "" && textBox1.Text != "")
            {

                try
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    contalinhas = "select Max(IdGasto) From Contas";
                    obj.cmd.Connection = obj.con;
                    obj.cmd.CommandText = contalinhas;
                    int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                    obj.con.Close();
                    x++;
                    string query = "Insert into Contas(IdConta,Conta,Valor) Values('" + x + "','" + textBox1.Text + "','" + valorTextBox.Text + "')";
                    SqlCommand sqlcom = new SqlCommand(query, obj.con);
                    SqlDataReader myreader;
                    obj.con.Close();
                    obj.con.Open();
                    myreader = sqlcom.ExecuteReader();
                    MessageBox.Show("Conta inserida com sucesso");
                    obj.con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Introduza a conta e o valor");
            }
        }

        public class Contaa
        {
            public int IdConta { get; set; }
            public string Conta { get; set; }
            public string Valor { get; set; }
        }

        private List<Contaa> ObterLista(string nomeConta)
        {
            obj.con.ConnectionString = obj.locate;


            //Instância da lista que será retornada 
            List<Contaa> lista = new List<Contaa>();
            // query do Comando utilizando o parâmetro recebido pelo método  
            string query = "SELECT IdConta,Conta, Valor FROM Contas WHERE Conta LIKE '%" + nomeConta + "%'";
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
                    Contaa f = new Contaa();
                    //Recupero os valores  
                    f.IdConta = Convert.ToInt32(leitor["IdConta"]);
                    f.Conta = leitor["Conta"].ToString();
                    f.Valor = leitor["Valor"].ToString();
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
            contasDataGridView.DataSource = ObterLista(textBox2.Text);
        }
    }
}
