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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "Admin@123")
            {

                MessageBox.Show("Usuario Valido");
                txt_cadastro txt_login = new txt_cadastro();
                txt_login.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
                
            }
        }
    }
}
