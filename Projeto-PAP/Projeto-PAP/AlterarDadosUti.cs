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
    public partial class AlterarDadosUti : Form
    {
        Connect obj = new Connect();
        public AlterarDadosUti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != ""&& textBox3.Text != "" && textBox2.Text == textBox3.Text )
            {
                try
                {
                    obj.con.ConnectionString = obj.locate;


                    string query = "SELECT Email, Palavrapasse FROM Utilizador WHERE Email LIKE '%" + SessaoSistema.EmailUsuario + "%' and Palavrapasse LIKE '%" + SessaoSistema.PasswordUsuario + "%' ";

                    SqlCommand cmd = new SqlCommand(query, obj.con);
                    obj.con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    //MessageBox.Show("passe antiga:",reader["Palavrapasse"].ToString());
                    
                    //label5.Text = reader["Palavrapasse"].ToString();
                    
                    if (textBox1.Text== reader["Palavrapasse"].ToString())
                    {
                        obj.con.Close();
                        try
                        {
                            obj.con.ConnectionString = obj.locate;
                            obj.con.Open();
                            string quer = "UPDATE Utilizador SET Palavrapasse ='" + textBox3.Text+"'";
                            SqlCommand sqlcom = new SqlCommand(quer, obj.con);
                            sqlcom.ExecuteNonQuery();
                            MessageBox.Show("Palavra Passe alterada com sucesso");
                            obj.con.Close();
                            obj.con.Dispose();
                            SessaoSistema.PasswordUsuario = textBox3.Text;
                            //this.Close();
                            //login a = new login();
                            //a.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível alterar a palavra passe\n\nErro:" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("A palavra passe antiga não está correta");
                    }

                   
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
            else
            {
                MessageBox.Show("As palavras passe não coincidem");
            }
        }

        private void AlterarDadosUti_Load(object sender, EventArgs e)
        {

        }
    }
}
