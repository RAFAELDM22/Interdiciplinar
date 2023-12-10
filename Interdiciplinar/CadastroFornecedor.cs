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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Cliente", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCliente.DataSource = dt;

        }

        private void dgvFornecedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNomeFornecedor.Text = dgvFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContatoFornecedor.Text = dgvFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            groupBox2.Visible = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text == "" || txtContatoFornecedor.Text == "" || txtCnpjFornecedor.Text == "")
            {

                MessageBox.Show("Por favor complete todos os campos");
            }
            else
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
                mySql.Open();
                MySqlCommand comando = new MySqlCommand("Insert into Fornecedor (nome, cnpj, telefone) values ('" + txtNomeFornecedor.Text + "','" + txtContatoFornecedor.Text + "', '" + txtCnpjFornecedor.Text + "');", mySql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Fornecedor registrado com sucesso!");
                txtNomeFornecedor.Text = "";
                txtContatoFornecedor.Text = "";
                txtCnpjFornecedor.Text = "";
                CarregarDadosBanco();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update Fornecedor set nome='" + txtNomeFornecedor.Text + "', telefone='" + txtContatoFornecedor.Text + "', cnpj='" + txtCnpjFornecedor.Text + "', conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            txtNomeFornecedor.Text = "";
            txtContatoFornecedor.Text = "";
            txtCnpjFornecedor.Text = "";
            CarregarDadosBanco();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);

            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("delete from Cliente where Fornecedor= " + txtCnpjFornecedor.Text + ";", conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados excluídos com sucesso!");
            txtNomeFornecedor.Text = "";
            txtContatoFornecedor.Text = "";
            txtCnpjFornecedor.Text = "";
            groupBox2.Visible = false;
            CarregarDadosBanco();
        }
    }
}
