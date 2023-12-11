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
    public partial class TelaVendas : Form
    {
        public TelaVendas()
        {
            InitializeComponent();
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarDadosBanco();
        }

        private void CarregarDadosBanco()
        {
            MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Compra", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvVendas.DataSource = dt;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtData.Text == "" || txtValor.Text == "")
            {

                MessageBox.Show("Por favor digite em um campo");
            }
            else
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
                mySql.Open();
                MySqlCommand comando = new MySqlCommand("Insert into Venda (data_venda, valor_total) values ('" + txtData.Text + "','" + txtValor.Text + "'," mySql);
                comando.ExecuteNonQuery();
                CarregarDadosBanco();
            }
        }
    }
}
