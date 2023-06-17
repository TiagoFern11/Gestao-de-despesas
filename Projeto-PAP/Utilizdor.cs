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
    public partial class Utilizdor : Form
    {
        Connect obj = new Connect();
        public Utilizdor()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login a = new login();
            a.Show();
        }
        
        private void Utilizdor_Load(object sender, EventArgs e)
        {
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;
            try
            {
                obj.con.ConnectionString = obj.locate;


                string query = "SELECT Nome,Sobrenome,Email,Palavrapasse FROM Utilizador WHERE Email LIKE '%" + SessaoSistema.EmailUsuario + "%' and Palavrapasse LIKE '%" + SessaoSistema.PasswordUsuario + "%' ";

                SqlCommand cmd = new SqlCommand(query, obj.con);
                obj.con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                label1.Text = (reader["Nome"].ToString()) + " " + (reader["Sobrenome"].ToString());

                //reader.Read();
                label2.Text = reader["Email"].ToString();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível preencher o ComboBox\n\nErro:" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obj.con.Close();
                obj.con.Dispose();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {/*
            try
            {
                Connect obj = new Connect();
                obj.con.ConnectionString = obj.locate;
                obj.con.Open();
                string contalinhas = "select count(*) From Utilizador";
                obj.cmd.Connection = obj.con;
                obj.cmd.CommandText = contalinhas;
                int x = Convert.ToInt16(obj.cmd.ExecuteScalar());
                obj.con.Close();
                x++;
                string query = "Update Utilizador Set Nome= ('" + x + "')";
                SqlCommand sqlcom = new SqlCommand(query, obj.con);
                SqlDataReader myreader;
                obj.con.Close();
                obj.con.Open();
                myreader = sqlcom.ExecuteReader();
                MessageBox.Show("Registo inserido com sucesso");
                obj.con.Close();

                this.Hide();
                Form1 form = new Form1();
                form.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlterarDadosUti a = new AlterarDadosUti();
            a.Show();
        }
    }
}
