﻿using System;
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
    public partial class TelaRegistro : Form
    {
        public TelaRegistro()
        {
            InitializeComponent();
        }
        private Form FormularioFilho;
        private void AbrirFormularioFilho(Form formularioFilho)

        {
            if (FormularioFilho != null)
            {
                FormularioFilho.Close();
            }

            FormularioFilho = formularioFilho;

            formularioFilho.TopLevel = false;
            formularioFilho.FormBorderStyle = FormBorderStyle.None;
            formularioFilho.Dock = DockStyle.Fill;
            panel2.Controls.Add(FormularioFilho);
            panel2.Tag = FormularioFilho;

            formularioFilho.BringToFront();
            formularioFilho.Show();

        }
        private void TelaRegistro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormularioFilho(new RegistroCompras());
        }

        private void txtVendas_Click(object sender, EventArgs e)
        {
            AbrirFormularioFilho(new TelaVendas());
        }
    }
}
