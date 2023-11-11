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

        

        
        private void txt_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new TelaCadastro().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
        }
    }
}
