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
    public partial class TiposRendimentos : Form
    {
        Connect obj = new Connect();
        public TiposRendimentos()
        {
            InitializeComponent();
        }

        private void tipoRendimentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoRendimentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet1);

        }

        private void TiposRendimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet1.TipoRendimentos' table. You can move, or remove it, as needed.
            //this.tipoRendimentosTableAdapter.Fill(this._BD_PAPDataSet1.TipoRendimentos);
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
                contalinhas = "select count(*) From TipoRendimentos";
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = contalinhas;
                int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                obj.con.Close();
                x++;
                string query = "Insert into TipoRendimentos(IdTipoRendimento, TipoRendimento) Values('" + x + "','" + textBox1.Text + "')";
                SqlCommand sqlcom = new SqlCommand(query, obj.con);
                SqlDataReader myreader;
                obj.con.Close();
                obj.con.Open();
                myreader = sqlcom.ExecuteReader();
                MessageBox.Show("Tipo de Rendimento inserido com sucesso");
                obj.con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class TipoRendimentoo
        {
            public int IdTipoRendimento { get; set; }
            public string TipoRendimento { get; set; }
        }

        private List<TipoRendimentoo> ObterLista(string nomeTipoRendimento)
        {
            obj.con.ConnectionString = obj.locate;


            //Instância da lista que será retornada 
            List<TipoRendimentoo> lista = new List<TipoRendimentoo>();
            // query do Comando utilizando o parâmetro recebido pelo método  
            string query = "SELECT IdTipoRendimento,TipoRendimento FROM TipoRendimentos WHERE TipoRendimento LIKE '%" + nomeTipoRendimento + "%'";
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
                    TipoRendimentoo f = new TipoRendimentoo();
                    //Recupero os valores  
                    f.IdTipoRendimento = Convert.ToInt32(leitor["IdTipoRendimento"]);
                    f.TipoRendimento = leitor["TipoRendimento"].ToString();
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
            tipoRendimentosDataGridView.DataSource = ObterLista(textBox2.Text);
        }
    }
}
