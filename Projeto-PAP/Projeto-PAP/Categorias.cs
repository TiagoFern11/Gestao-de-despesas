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
    public partial class Categorias : Form
    {
        Connect obj = new Connect();

        public Categorias()
        {
            InitializeComponent();
            //categoriasDataGridView.DataSource = ObterLista1();
        }

        /*
        private List<Categoriaa> ObterLista1(string nomeCategoria)
        {
            
            obj.con.ConnectionString = obj.locate;


            //Instância da lista que será retornada 
            List<Categoriaa> lista1 = new List<Categoriaa>();
            // query do Comando utilizando o parâmetro recebido pelo método  
            string query = "SELECT IdCategoria,Categoria FROM Categorias ORDER BY Categoria ASC";
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
                    Categoriaa f = new Categoriaa();
                    //Recupero os valores  
                    f.IdCategoria = Convert.ToInt32(leitor["IdCategoria"]);
                    f.Categoria = leitor["Categoria"].ToString();
                    //Adiciono a lista 
                    lista1.Add(f);
                }
            }
            //Fecho conexão 
            obj.con.Close();
            //Retorno a lista  
            return lista1;
            
        }
        */


        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet);

        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Categorias' table. You can move, or remove it, as needed.
            //this.categoriasTableAdapter.Fill(this._BD_PAPDataSet.Categorias);

            categoriasDataGridView.DataSource = ObterLista(textBox2.Text);
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contalinhas;
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                contalinhas = "select count(*) From Utilizador";
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = contalinhas;
                int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                obj.con.Close();
                x++;
                string query = "Insert into Categorias(IdCategoria,Categoria) Values('" + x + "','" + textBox1.Text + "')";
                SqlCommand sqlcom = new SqlCommand(query, obj.con);
                SqlDataReader myreader;
                obj.con.Close();
                obj.con.Open();
                myreader = sqlcom.ExecuteReader();
                MessageBox.Show("Categoria inserida com sucesso");
                obj.con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class Categoriaa
        {
            public int IdCategoria { get; set; }
            public string Categoria { get; set; }
        }

        private List<Categoriaa> ObterLista(string nomeCategoria)
        {
            obj.con.ConnectionString = obj.locate;


            //Instância da lista que será retornada 
            List<Categoriaa> lista = new List<Categoriaa>();
            // query do Comando utilizando o parâmetro recebido pelo método  
            string query = "SELECT IdCategoria,Categoria FROM Categorias WHERE Categoria LIKE '%" + nomeCategoria + "%'";
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
                    Categoriaa f = new Categoriaa();
                    //Recupero os valores  
                    f.IdCategoria = Convert.ToInt32(leitor["IdCategoria"]);
                    f.Categoria = leitor["Categoria"].ToString();
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
            //Seto o retorno do método ObterLista como data source  
            //do DataGridView passando o txtBuscar como parâmetro 
            //ou seja o método vai retornar um list dos dados que  
            //"contenham" o que foi digitado no Textbox 
            categoriasDataGridView.DataSource = ObterLista(textBox2.Text);
        }
    }
}
