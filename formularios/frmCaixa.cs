using gestaoDeClientesArtigosTheStore.DAL;
using gestaoDeClientesArtigosTheStore.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmCaixa : Form
    {

        funcionarioDAL funcionarioDAL = new funcionarioDAL();
        artigoDAL artigoDAL = new artigoDAL();
        cartaoDAL cartaoDAL = new cartaoDAL();
        clienteDAL clienteDAL = new clienteDAL();

        public frmCaixa()
        {
            InitializeComponent();

        }
        private void carregarListas()
        {
            List<funcionario> funcionario = funcionarioDAL.listarFuncionarioActivos();
            comboBox_NumeroFuncionario.DataSource = funcionario;
            comboBox_NumeroFuncionario.DisplayMember = "nome";
            comboBox_NumeroFuncionario.ValueMember = "id";
            comboBox_NumeroFuncionario.SelectedIndex = -1;
            textBox_NumFuncionario.Clear();

            List<cliente> cliente = clienteDAL.listarClientesActivos();
            comboBox_Cliente.DataSource = cliente;
            comboBox_Cliente.DisplayMember = "nome";
            comboBox_Cliente.ValueMember = "id";
            comboBox_Cliente.SelectedIndex = -1;
            textBox_Id_Cliente.Clear();
            textBox_numeroPontos.Clear();
            textBox_NumeroCartao.Clear();

            List<artigo> artigo = artigoDAL.listarArtigosActivos();
            comboBox_Descricao.DataSource = artigo;
            comboBox_Descricao.DisplayMember = "descricao";
            comboBox_Descricao.ValueMember = "id_artigo";

        }
        private void frmCaixa_Load(object sender, EventArgs e)
        {
            carregarListas();

        }

        private void comboBox_NumeroFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox_NumeroFuncionario.Text.Length != 0)
            {
                textBox_NumFuncionario.Text = comboBox_NumeroFuncionario.SelectedValue.ToString();

            }
        }

        private void button_pesquisar_cliente_Click(object sender, EventArgs e)
        {
            Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
            (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarSelectClienteByContacto(textBox_Contacto.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
            else
            {
                clienteDAL.cliente = clienteCC;
                string resultado = clienteDAL.obterClienteByContacto();
                if (resultado.Length == 0)
                {
                    MessageBox.Show("Erro na pesquisa, cliente com este contacto não encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Id_Cliente.Clear();
                    comboBox_Cliente.SelectedIndex = -1;
                    textBox_numeroPontos.Clear();
                    textBox_NumeroCartao.Clear();
                }
                else {                  
                    comboBox_Cliente.SelectedValue= resultado;
                    textBox_Id_Cliente.Text= resultado;
                    carregarInformacaoCartao(resultado);
                }
            }
        }

        private void carregarInformacaoCartao(string Id_Cliente)
        {
            Models.cliente clienteCC = new Models.cliente();
            clienteCC.id = Convert.ToInt16(Id_Cliente);
            cartaoDAL.cliente = clienteCC;
            (string numeroCartao, string numeroPontos) = cartaoDAL.obterPontosCartao();
            if (numeroCartao.Length != 0)
            {
                textBox_numeroPontos.Text = numeroPontos;
                textBox_NumeroCartao.Text = numeroCartao;
            }
            else
            {
                textBox_numeroPontos.Text = "Cliente sem cartão";
                textBox_NumeroCartao.Text = "Cliente sem cartão";

            }


        }
        private void comboBox_Cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Cliente.Text.Length != 0)
            {
                textBox_Id_Cliente.Text = comboBox_Cliente.SelectedValue.ToString();       
                int Id_Cliente;
                bool success = int.TryParse(textBox_Id_Cliente.Text, out Id_Cliente);
                if (success)
                {
                    carregarInformacaoCartao(Id_Cliente.ToString());
                }
            }
        }
    }
}

