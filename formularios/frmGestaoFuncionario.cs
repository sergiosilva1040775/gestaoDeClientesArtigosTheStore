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

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.funcionarioHander funcionarioHander = new Handlers.funcionarioHander();
            (int codigoFTH, Models.funcionario  clienteCC, string mensagemDeErrooFTH) = funcionarioHander.ValidarFuncionarioInsert(textBox_numFuncionario.Text,textBox_Nome.Text,
                textBox_Contacto.Text,
                textBox_PalavraChave.Text);

            if (codigoFTH >= 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                //vehiclesDAL.vehicleCCGeral = vehicleCC;
                //(int codigoIn, string respostaIn) = vehiclesDAL.insertVehicle();
                //if (codigoIn == 1) { MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //else { MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.funcionarioHander funcionarioHander = new Handlers.funcionarioHander();
            (int codigoFTH, Models.funcionario clienteCC, string mensagemDeErrooFTH) = funcionarioHander.ValidarFuncionarioUpdate(textBox_Id.Text, textBox_numFuncionario.Text, textBox_Nome.Text,
                 textBox_Contacto.Text,
                 textBox_PalavraChave.Text);
            if (codigoFTH >= 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                //vehiclesDAL.vehicleCCGeral = vehicleCC;
                //(int codigoIn, string respostaIn) = vehiclesDAL.insertVehicle();
                //if (codigoIn == 1) { MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //else { MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.funcionarioHander funcionarioHander = new Handlers.funcionarioHander();
            (int codigoFTH, Models.funcionario clienteCC, string mensagemDeErrooFTH) = funcionarioHander.ValidarFuncionarioApagar (textBox_Id.Text);
            if (codigoFTH >= 0)
            {
                MessageBox.Show(this.Text, mensagemDeErrooFTH, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                //vehiclesDAL.vehicleCCGeral = vehicleCC;
                //(int codigoIn, string respostaIn) = vehiclesDAL.insertVehicle();
                //if (codigoIn == 1) {MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //else MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);}
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
    }
}
