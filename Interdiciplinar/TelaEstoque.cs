using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Interdiciplinar
{
    public partial class TelaEstoque : Form
    {
        public TelaEstoque()
        {
            
            InitializeComponent();
        }

      
      

       
        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Venda", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEstoque.DataSource = dt;

        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update Estoque set quantidade_em_estoque=" + txtQntd.Text + ", idproduto= " + txtProdt.Text + " where idEstoque=" + txtProdt.Text, conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            txtQntd.Text = "";
            txtProdt.Text = "";
            CarregarDadosBanco();
        }

        
    }
}
