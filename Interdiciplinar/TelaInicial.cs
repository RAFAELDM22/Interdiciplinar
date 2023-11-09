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
    public partial class txt_cadastro : Form
    {
        public txt_cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaCadastro().Show();
        }

        private void btnTelaEstoque_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
        }
    }
}
