﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITerminalWindows
{
    public partial class FormConsultaEleitor : Form
    {
        public FormConsultaEleitor()
        {
            InitializeComponent();
        }

        private void FormConsultaEleitor_Load(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo("");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo(textBoxBuscar.Text);
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor())
            {
                frm.ShowDialog();
            }
        }
    }
}
