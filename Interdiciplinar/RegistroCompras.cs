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
    public partial class RegistroCompras : Form
    {
        public RegistroCompras()
        {
            InitializeComponent();
        }

        private void RegistroCompras_Load(object sender, EventArgs e)
        {
            CarregarDadosBanco();
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            dgvCompras.DataSource = dt;

        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            if (txtdata.Text == "" || txtValor.Text == "")
            {

                MessageBox.Show("Por favor digite em um campo");
            }
            else
            {
                MySqlConnection conexaoMYSQL = new MySqlConnection(Program.conexao);
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("Insert into Compra (data_compra, valor_total) values ('" + txtdata.Text + "','" + txtValor.Text, conexaoMYSQL);
                comando.ExecuteNonQuery();
                CarregarDadosBanco();
            }
        }
    }
}
