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
    public partial class registar : Form
    {
        Connect obj = new Connect();
        public registar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contalinhas;
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("select count(*) From Utilizador where Email='" + textBox1.Text + "' and Palavrapasse ='" + textBox2.Text + "'", obj.con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            
            if (textBox3.Text !="Nome" && textBox5.Text!="Sobrenome" && textBox4.Text !="Email" && textBox1.Text!="Passe" && textBox2.Text !="Passe")
            {
                if (textBox3.Text !="" && textBox5.Text != "" && textBox4.Text != "" && textBox1.Text != "" && textBox2.Text != "")
                {
                    if (textBox1.Text == textBox2.Text)
                    {
                        
                        try
                        {
                            Connect obj = new Connect();
                            obj.con.ConnectionString = obj.locate;
                            obj.con.Open();
                            contalinhas = "SELECT MAX(Idutilizador) FROM Utilizadores";
                            obj.cmd.Connection = obj.con;
                            obj.cmd.CommandText = contalinhas;
                            int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                            obj.con.Close();
                            x++;
                            string query = "Insert into Utilizador(Idutilizador,Nome,Sobrenome,DataNascimento,saldoAtual,Palavrapasse,Email) Values('" + x + "','" + textBox3.Text + "','" + textBox5.Text + "','" + "01/01/2001" + "','" + "0" + "','" + textBox1.Text + "','" + textBox4.Text + "')";
                            SqlCommand sqlcom = new SqlCommand(query, obj.con);
                            SqlDataReader myreader;
                            obj.con.Close();
                            obj.con.Open();
                            myreader = sqlcom.ExecuteReader();
                            MessageBox.Show("Registo inserido com sucesso");
                            obj.con.Close();

                            this.Hide();
                            login form = new login();
                            form.Show();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    
                        //MessageBox.Show("Este Email já se encontra registado", "GestMyMoney", MessageBoxButtons.OK);
                        

                    }
                    else
                    {
                        MessageBox.Show("Palavras Passe não coincidem", "GestMyMoney", MessageBoxButtons.OK);
                        obj.con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Introduza Valores", "GestMyMoney", MessageBoxButtons.RetryCancel);
                    obj.con.Close();
                }
            }
            else
            {
                MessageBox.Show("Introduza Valores Válidos", "GestMyMoney", MessageBoxButtons.RetryCancel);
                obj.con.Close();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login form = new login();
            form.Show();
        }

        private void registar_Load(object sender, EventArgs e)
        {
            int TamanhoTotal = this.Width - panel14.Width;
            //int TamanhoAltura = this.Height - panel14.Height;
            panel14.Left = TamanhoTotal / 2;
            //panel14.Top = TamanhoAltura / 2;
        }
    }
}
