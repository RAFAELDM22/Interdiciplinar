using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interdiciplinar
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CadastroProduto().Show();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
