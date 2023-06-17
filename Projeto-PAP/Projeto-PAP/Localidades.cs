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
    public partial class Localidades : Form
    {
        Connect obj = new Connect();
        public Localidades()
        {
            InitializeComponent();
        }

        private void localidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.localidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._BD_PAPDataSet);

        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BD_PAPDataSet.Localidades' table. You can move, or remove it, as needed.
            //this.localidadesTableAdapter.Fill(this._BD_PAPDataSet.Localidades);
            int TamanhoTotal = this.Width - panel1.Width;
            int TamanhoAltura = this.Height - panel1.Height;
            panel1.Left = TamanhoTotal / 2;
            panel1.Top = TamanhoAltura / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
