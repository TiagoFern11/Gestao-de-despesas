using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class configuracoes : Form
    {
        public configuracoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contas a = new Contas();
            a.MdiParent = this.MdiParent;
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiposRendimentos a = new TiposRendimentos();
            a.MdiParent = this.MdiParent;
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categorias a = new Categorias();
            a.MdiParent = this.MdiParent;
            a.Show();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            SubCategorias a = new SubCategorias();
            a.MdiParent = this.MdiParent;
            a.Show();
        }

        private void configuracoes_Load(object sender, EventArgs e)
        {
            int TamanhoTotal = this.Width - panel1.Width;
            //int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = 20;
            //panel1.Top = TamanhoAltura / 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Localidades a = new Localidades();
            a.MdiParent = this.MdiParent;
            a.Show();
        }
    }
}
