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
        linhaCompraDAL linhaCompraDAL = new linhaCompraDAL();
        compraDAL compraDAL = new compraDAL();
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
            textBox_ArtigoId.Clear();
            textBox_Preco.Clear();
            textBox_Quantidade.Clear();
            comboBox_Descricao.SelectedIndex = -1;


        }
        private void frmCaixa_Load(object sender, EventArgs e)
        {
            carregarListas();
            textBox2.Text = DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd")
                + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");

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
                else
                {

                    comboBox_Cliente.SelectedValue = resultado;
                    textBox_Id_Cliente.Text = resultado;
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

        private void carregarInformacaoArtigo(string id_artigo)
        {
            Models.artigo artigoCC = new Models.artigo();
            artigoCC.id_artigo = Convert.ToInt16(id_artigo);
            artigoDAL.artigo = artigoCC;
            artigo artigo = new artigo();
            artigo = artigoDAL.listarArtigosActivosById();
            textBox_ArtigoId.Text = artigo.id_artigo.ToString();
            textBox_Preco.Text = artigo.valor_unitario.ToString();




        }

        private void comboBox_Descricao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Descricao.Text.Length != 0)
            {
                textBox_Quantidade.Clear();
                textBox_ArtigoId.Text = comboBox_Descricao.SelectedValue.ToString();
                int Id_Cliente;
                bool success = int.TryParse(textBox_ArtigoId.Text.ToString(), out Id_Cliente);
                if (success)
                {
                    textBox_ArtigoId.Text = comboBox_Descricao.SelectedValue.ToString();
                    carregarInformacaoArtigo(Id_Cliente.ToString());
                }


            }
        }

        private void button_pesquisar_artigos_Click(object sender, EventArgs e)
        {
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo artigoCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoSelectbyId(textBox_ArtigoId.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                carregarInformacaoArtigo(artigoCC.id_artigo.ToString());
            }
        }

        private bool adicionarLinhaCompra()
        {
            Handlers.linhaCompraHandler linhaCompraHandler = new Handlers.linhaCompraHandler();
            (int codigoFTH, Models.linhaCompra linhaCompraCC, string mensagemDeErrooFTH) = linhaCompraHandler.ValidarLinhaCompraInsert(
                textBox2.Text, textBox_ArtigoId.Text, textBox_Quantidade.Text, textBox3.Text);
            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                linhaCompraDAL.linhaCompra = linhaCompraCC;
                (int registo, string erro) = linhaCompraDAL.inserirlinhaCompra();
                if (erro.Length != 0)
                {
                    MessageBox.Show(erro, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        private bool adicionarCompra()
        {
            Handlers.compraHander compraHandler = new Handlers.compraHander();
            (int codigoFTH, Models.compra CompraCC, string mensagemDeErrooFTH) = compraHandler.ValidarCompraSelectInicial(
                textBox2.Text, textBox_Id_Cliente.Text, textBox_NumFuncionario.Text);
            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                compraDAL.compra = CompraCC;
                (int registo, string erro) = compraDAL.inserirCompra();
                if (erro.Length != 0)
                {
                    MessageBox.Show(erro, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0") { if (adicionarCompra()) {
                   textBox4.Text = "1";
                  if(adicionarLinhaCompra())
                    {
                        //Update stock
                    }
                } 
            }

            else { if (adicionarLinhaCompra()) {
                    //Update stock
                    textBox4.Text = "1"; 
                } }


        }


        private bool actualizarStock(double quantidade, string id_artigo)
        {

            return true;
        }
        private void textBox_Quantidade_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Double.Parse(textBox_Quantidade.Text) * Double.Parse(textBox_Preco.Text)).ToString();
        }

        private void comboBox_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_FecharCompra_Click(object sender, EventArgs e)
        {
            //fechar compras pontos e valor 
        }

        private int calcularPontos(double valorFinal)
        {

            return 0;
        }

        private bool actualizarStock(double numeroPontos, string id_compra, double valorFinal)
        {

            return true;
        }
    }
}

