using gestaoDeClientesArtigosTheStore.DAL;
using gestaoDeClientesArtigosTheStore.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmCompras_LinhasCompras : Form
    {
        clienteDAL clienteDALs = new clienteDAL();
        public frmCompras_LinhasCompras()
        {
            InitializeComponent();
        }

        private void carregarListaClientes()
        {

            List<cliente> cliente = clienteDALs.listarFuncionarioActivos();
            comboBox_Cliente.DataSource  = cliente;
            comboBox_Cliente.DisplayMember = "nome";
            comboBox_Cliente.SelectedText = "id";
        }

        private void frmCompras_LinhasCompras_Load(object sender, EventArgs e)
        {
            carregarListaClientes();
        }
    }
}
