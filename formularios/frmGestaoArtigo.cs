using gestaoDeClientesArtigosTheStore.DAL;
using gestaoDeClientesArtigosTheStore.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmGestaoArtigo : Form
    {
        artigoDAL artigoDAL = new artigoDAL();
        public frmGestaoArtigo()
        {
            InitializeComponent();
        }

        private void frmGestaoArtigo_Load(object sender, EventArgs e)
        {
            LimparConteudo();
            LimparCor();
            carregarListaArtigos();
        }

        private void carregarListaArtigos()
        {

            List<artigo> artigo = artigoDAL.listarArtigosActivos();

            dataGridView_Artigos.DataSource = artigo;

            dataGridView_Artigos.Columns["id_artigo"].Visible = false;
        }

        private void LimparCor()
        {
            textBox_ID.BackColor = System.Drawing.Color.White;
            textBox_descricao.BackColor = System.Drawing.Color.White;
            textBox_Valor_Unitario.BackColor = System.Drawing.Color.White;
            textBox_Stock.BackColor = System.Drawing.Color.White;
        }

        private void mostrarErrosValidacao(int codigoFTH)
        {
            switch (codigoFTH)
            {
                case 1:
                    textBox_ID.Focus();
                    textBox_ID.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    textBox_descricao.Focus();
                    textBox_descricao.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    textBox_Valor_Unitario.Focus();
                    textBox_Valor_Unitario.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    textBox_Stock.Focus();
                    textBox_Stock.BackColor = System.Drawing.Color.Red;
                    break;
                default:
                    break;
            }
        }


        private void LimparConteudo()
        {
            textBox_ID.Clear();
            textBox_descricao.Clear();
            textBox_Valor_Unitario.Clear();
            textBox_Stock.Clear();
        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparConteudo();
            LimparCor();
            carregarListaArtigos();
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo artigoCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoInsert(textBox_descricao.Text, textBox_Valor_Unitario.Text,
            textBox_Stock.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                artigoDAL.artigo = artigoCC;
                (int codigoIn, string respostaIn) = artigoDAL.inserirartigo();
                if (codigoIn == 1)
                {
                    carregarListaArtigos();
                    LimparConteudo();
                    LimparCor();
                    MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo artigoCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoUpdate(textBox_descricao.Text,
                textBox_Valor_Unitario.Text,
               textBox_Stock.Text,
          textBox_ID.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                artigoDAL.artigo = artigoCC; 
                (int codigoIn, string respostaIn) = artigoDAL.atualizarArtigoInformacaoGeral();
                if (codigoIn == 1)
                {
                    carregarListaArtigos();
                    LimparConteudo();
                    LimparCor();
                    MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo artigoCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoaApagar(textBox_ID.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                artigoDAL.artigo = artigoCC;
                (int codigoIn, string respostaIn) = artigoDAL.desactivarartigo ();
                if (codigoIn == 1)
                {
                    carregarListaArtigos();
                    LimparConteudo();
                    LimparCor();
                    MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void dataGridView_Artigos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_ID.Text = dataGridView_Artigos[0, dataGridView_Artigos.CurrentRow.Index].Value.ToString();
            textBox_descricao.Text = dataGridView_Artigos[1, dataGridView_Artigos.CurrentRow.Index].Value.ToString();
            textBox_Valor_Unitario.Text = dataGridView_Artigos[2, dataGridView_Artigos.CurrentRow.Index].Value.ToString();
            textBox_Stock.Text = dataGridView_Artigos[3, dataGridView_Artigos.CurrentRow.Index].Value.ToString();
        }

        private void textBox_Valor_Unitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
