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
        cartaoDAL cartaoDALs = new cartaoDAL();
        compraDAL compraDALs = new compraDAL();
        linhaCompraDAL linhaCompraDALs = new linhaCompraDAL();
        public frmCompras_LinhasCompras()
        {
            InitializeComponent();
        }

        private void carregarListaClientes()
        {

            List<cliente> cliente = clienteDALs.listarFuncionarioActivos();
            comboBox_Cliente.DataSource = cliente;
            comboBox_Cliente.DisplayMember = "nome";
            comboBox_Cliente.ValueMember = "id";
        }

        private void frmCompras_LinhasCompras_Load(object sender, EventArgs e)
        {
            carregarListaClientes();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            textBox_ID.Clear();
            textBox_NumeroCartao.Clear();
            dataGridView_ComprasEfectuadas.DataSource = null;
            dataGridView_ProdutosComprados.DataSource = null;

            if (comboBox_Cliente.Text.Length != 0)
            {
                Models.cliente clienteCC = new Models.cliente();
                clienteCC.id = Convert.ToInt16(comboBox_Cliente.SelectedValue);
                cartaoDALs.cliente = clienteCC;

                (string numeroCartao, string numeroPontos) = cartaoDALs.obterPontosCartao();
                if (numeroCartao.Length != 0)
                {
                    textBox_ID.Text = numeroPontos;
                    textBox_NumeroCartao.Text =numeroCartao ;
                    compraDALs.cliente = clienteCC;
                    List<compra> ListarCompra = new List<compra>();
                    ListarCompra = compraDALs.listarComprasComprador();
                    dataGridView_ComprasEfectuadas.DataSource = ListarCompra;
                    dataGridView_ComprasEfectuadas.Columns["id_cliente"].Visible = false;
                    dataGridView_ComprasEfectuadas.Columns["id_funcionario"].Visible = false;
                    dataGridView_ComprasEfectuadas.Columns["id_compras"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Cliente sem cartão");
                }


            }
            else { MessageBox.Show("Deverá seleccionar um cliente"); }
        }





        private void dataGridView_ComprasEfectuadas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string idCompra;
            idCompra = dataGridView_ComprasEfectuadas[0, dataGridView_ComprasEfectuadas.CurrentRow.Index].Value.ToString();        
            Models.linhaCompra linhaCompraCC = new Models.linhaCompra();
            linhaCompraCC.id_compra = Convert.ToInt16(idCompra);
            linhaCompraDALs.linhaCompra = linhaCompraCC;
            List<linhaCompra> ListarlinhaCompra = new List<linhaCompra>();
            ListarlinhaCompra = linhaCompraDALs.listarlinhaCompraById();
            dataGridView_ProdutosComprados.DataSource = ListarlinhaCompra;
            dataGridView_ProdutosComprados.Columns["id"].Visible = false;
            dataGridView_ProdutosComprados.Columns["id_compra"].Visible = false;
            //dataGridView_ComprasEfectuadas.Columns["artigo"].Visible = false;
        }

        private void dataGridView_ComprasEfectuadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
