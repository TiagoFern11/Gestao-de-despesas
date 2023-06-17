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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            try
            {

                Despesas a = new Despesas();
                a.MdiParent = this;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n\nErro:" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            configuracoes a = new configuracoes();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
            Utilizdor a = new Utilizdor();
            a.MdiParent = this;
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            Rendimentos a = new Rendimentos();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            Receitas a = new Receitas();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            VisaoGeral a = new VisaoGeral();
            a.MdiParent = this;
            a.Show();
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Tiago\Desktop\nova pap\Projeto-PAP\Mod.FOR08 - Relatório Final da PAP (1).docx");
        }
    }
}
