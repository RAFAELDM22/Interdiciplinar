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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

       
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            txtNomeCliente.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContatoCliente.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            groupBox2.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "" || txtContatoCliente.Text == "" || txtCNPJ.Text == "")
            {

                MessageBox.Show("Por favor complete todos os campos");
            }
            else
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("Insert into Cliente (nome, cnpj, telefone) values ('" + txtNomeCliente.Text + "','" + txtContatoCliente.Text + "', '" + txtCNPJ.Text+"');", mySql);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente registrado com sucesso!");
                txtNomeCliente.Text = "";
                txtContatoCliente.Text = "";
                txtCNPJ.Text = "";
                CarregarDadosBanco();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();
            MySqlCommand comando = new MySqlCommand("update Cliente set nome='" + txtNomeCliente.Text + "', telefone='" + txtContatoCliente.Text + "', cnpj='" + txtCNPJ.Text + "', conexaoMYSQL);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!!!");
            txtNomeCliente.Text = "";
            txtContatoCliente.Text = "";
            txtCNPJ.Text = "";
            CarregarDadosBanco();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult caixaMensagem = MessageBox.Show("Deseja realmente excluir esse cliente?", MessageBoxButtons.YesNo);

            if (caixaMensagem == DialogResult.Yes)
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
               
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("delete from Cliente where Cliente= " + txtCNPJ.Text + ";", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluídos com sucesso!");
                txtNomeCliente.Text = "";
                txtContatoCliente.Text = "";
                txtCNPJ.Text = "";
                groupBox2.Visible = false;
                CarregarDadosBanco();
            }
        }
    }
}
