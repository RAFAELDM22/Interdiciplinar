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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "Rafael"  && txt_senha.Text == "12345")
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