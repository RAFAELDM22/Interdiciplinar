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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarDadosBanco();
        }
        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Produto", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProduto.DataSource = dt;

        }

        private void dgvProduto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNomeProduto.Text = dgvProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescrição.Text = dgvProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantidade.Text = dgvProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPreco.Text = dgvProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
            groupBox2.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "" || txtDescrição.Text == "" || txtQuantidade.Text == "" || txtPreco.Text == "")
            {

                MessageBox.Show("Por favor complete todos os campos");
            }
            else
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
                mySql.Open();
                MySqlCommand comando = new MySqlCommand("Insert into Produto (nome, descrição, quantidade, preço) values ('" + txtNomeProduto.Text + "','" + txtDescrição.Text + "', '" + txtQuantidade.Text + "', '" + txtPreco.Text + "');", mySql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto registrado com sucesso!");
                txtNomeProduto.Text = "";
                txtDescrição.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
                CarregarDadosBanco();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update Produto set nome='" + txtNomeProduto.Text + "', descrição='" + txtDescrição.Text + "', quantidade='" + txtQuantidade.Text + "', preço ='" + txtPreco.Text +"', conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            txtNomeProduto.Text = "";
            txtDescrição.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            CarregarDadosBanco();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult caixaMensagem = MessageBox.Show("Deseja realmente excluir esse cliente?", MessageBoxButtons.YesNo);

            if (caixaMensagem == DialogResult.Yes)
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);

                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("delete from Cliente where Produto= " + txtNomeProduto.Text + ";", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluídos com sucesso!");
                txtNomeProduto.Text = "";
                txtDescrição.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
                groupBox2.Visible = false;
                CarregarDadosBanco();
            }
        }

       
    }
}
