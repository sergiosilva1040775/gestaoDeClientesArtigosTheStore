using gestaoDeClientesArtigosTheStore.DAL;
using gestaoDeClientesArtigosTheStore.Handlers;
using gestaoDeClientesArtigosTheStore.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmGestaoFuncionario : Form
    {
        public frmGestaoFuncionario()
        {
            InitializeComponent();
        }

        funcionarioDAL funcionarioDAL = new funcionarioDAL();

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.funcionarioHander funcionarioHander = new Handlers.funcionarioHander();
            (int codigoFTH, Models.funcionario funcionarioCC, string mensagemDeErrooFTH) = funcionarioHander.ValidarFuncionarioInsert(textBox_numFuncionario.Text,textBox_Nome.Text,
                textBox_Contacto.Text,
                textBox_PalavraChave.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                funcionarioDAL .funcionario  = funcionarioCC;
                (int codigoIn, string respostaIn) = funcionarioDAL.inserirfuncionario();
                if (codigoIn == 1)
                {
                    carregarListaFuncionario();
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
            Handlers.funcionarioHander funcionarioHander = new Handlers.funcionarioHander();
            (int codigoFTH, Models.funcionario funcionarioCC, string mensagemDeErrooFTH) = funcionarioHander.ValidarFuncionarioUpdate(textBox_Id.Text, textBox_numFuncionario.Text, textBox_Nome.Text,
                 textBox_Contacto.Text,
                 textBox_PalavraChave.Text);
            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                funcionarioDAL.funcionario = funcionarioCC;
                (int codigoIn, string respostaIn) = funcionarioDAL.actualizarfuncionario ();
                if (codigoIn == 1)
                {
                    carregarListaFuncionario();
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
            Handlers.funcionarioHander funcionarioHander = new Handlers.funcionarioHander();
            (int codigoFTH, Models.funcionario funcionarioCC, string mensagemDeErrooFTH) = funcionarioHander.ValidarFuncionarioApagar (textBox_Id.Text);
            if (codigoFTH > 0)
            {
                MessageBox.Show(this.Text, mensagemDeErrooFTH, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                funcionarioDAL.funcionario = funcionarioCC;
                (int codigoIn, string respostaIn) = funcionarioDAL.desactivarfuncionario ();
                if (codigoIn == 1)
                {
                    carregarListaFuncionario();
                    LimparConteudo();
                    LimparCor();
                    MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparConteudo();
            LimparCor();
        }

        private void frmGestaoFuncionario_Load(object sender, EventArgs e)
        {
            LimparConteudo();
            LimparCor();
            carregarListaFuncionario();
        }
        private void carregarListaFuncionario()
        {

            List<funcionario > funcionario = funcionarioDAL.listarFuncionarioActivos ();

            dataGridView_Funcionarios.DataSource = funcionario;

            dataGridView_Funcionarios.Columns["id"].Visible = false;
            dataGridView_Funcionarios.Columns["pass"].Visible = false;
        }

        private void LimparCor()
        {
            textBox_Id.BackColor = System.Drawing.Color.White;
            textBox_Nome.BackColor = System.Drawing.Color.White;         
            textBox_Contacto.BackColor = System.Drawing.Color.White;
            textBox_PalavraChave.BackColor = System.Drawing.Color.White;
            textBox_numFuncionario.BackColor = System.Drawing.Color.White;

        }

        private void mostrarErrosValidacao(int codigoFTH)
        {
            switch (codigoFTH)
            {
                case 1:
                    textBox_Id.Focus();
                    textBox_Id.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    textBox_numFuncionario .Focus();
                    textBox_numFuncionario.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    textBox_Nome.Focus();
                    textBox_Nome.BackColor = System.Drawing.Color.Red;   
                    break;
                case 4:
                    textBox_Contacto.Focus();
                    textBox_Contacto.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:  
                    textBox_PalavraChave.Focus();
                    textBox_PalavraChave.BackColor = System.Drawing.Color.Red;
                    break;
                default:
                    break;
            }
        }


        private void LimparConteudo()
        {
            textBox_Id.Clear();
            textBox_Nome.Clear();           
            textBox_Contacto.Clear();
            textBox_PalavraChave.Clear();
            textBox_numFuncionario.Clear();

        }

        private void dataGridView_Funcionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Id.Text = dataGridView_Funcionarios[0, dataGridView_Funcionarios.CurrentRow.Index].Value.ToString();

            textBox_numFuncionario.Text = dataGridView_Funcionarios["numfuncionario", dataGridView_Funcionarios.CurrentRow.Index].Value.ToString();
            textBox_Nome.Text = dataGridView_Funcionarios["nome", dataGridView_Funcionarios.CurrentRow.Index].Value.ToString();
            textBox_Contacto.Text = dataGridView_Funcionarios["contacto", dataGridView_Funcionarios.CurrentRow.Index].Value.ToString();

        }
    }
}
