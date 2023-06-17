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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            //panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Left;

        }

        private void login_Load(object sender, EventArgs e)
        {
            
            int TamanhoTotal = this.Width-panel8.Width;
            int TamanhoAltura = this.Height - panel8.Height;
            panel8.Left = TamanhoTotal/2;
            panel8.Top = TamanhoAltura/2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BD\\BD-PAP.mdf;Integrated Security=True;Connect Timeout=30;Trusted_Connection=True;");
            SqlDataAdapter sqa = new SqlDataAdapter("select count(*) From Utilizador where Email='" + textBox1.Text + "' and Palavrapasse ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();

                SessaoSistema.EmailUsuario = textBox1.Text;
                SessaoSistema.PasswordUsuario = textBox2.Text;
            }
            else
            {
                MessageBox.Show("email ou a palavra passe estão incorretos, tente novamente", "GestMyMoney", MessageBoxButtons.OK);
            }
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //Application.Run(new registar());
            registar a = new registar();
            //a.MdiParent = this;
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
