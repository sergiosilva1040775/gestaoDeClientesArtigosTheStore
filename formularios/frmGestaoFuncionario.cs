using System;
using System.Windows.Forms;


namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmGestaoFuncionario : Form
    {
        public frmGestaoFuncionario()
        {
            InitializeComponent();
        }

        //private void LimparCor()
        //{


        //}

        //private void LimparConteudo()
        //{


        //}

        private void LimparCor()
        {
            textBox_Id.BackColor = System.Drawing.Color.White;
            textBox_Nome.BackColor = System.Drawing.Color.White;
            textBox_Morada.BackColor = System.Drawing.Color.White;
            textBox_Contacto.BackColor = System.Drawing.Color.White;
            textBox_Email.BackColor = System.Drawing.Color.White;
            textBox_Contribuite.BackColor = System.Drawing.Color.White;
            textBox_Localidade.BackColor = System.Drawing.Color.White;
            textBoxNumeroCliente.BackColor = System.Drawing.Color.White;
            textBox_Foto.BackColor = System.Drawing.Color.White;
            textBox_PalavraChave.BackColor = System.Drawing.Color.White;

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
                    textBox_Nome.Focus();
                    textBox_Nome.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    textBox_Morada.Focus();
                    textBox_Morada.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    textBox_Contacto.Focus();
                    textBox_Contacto.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    textBox_Email.Focus();
                    textBox_Email.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    textBox_Contribuite.Focus();
                    textBox_Contribuite.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    textBox_Localidade.Focus();
                    textBox_Localidade.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    textBoxNumeroCliente.Focus();
                    textBoxNumeroCliente.BackColor = System.Drawing.Color.Red;
                    break;
                case 9:
                    textBox_Foto.Focus();
                    textBox_Foto.BackColor = System.Drawing.Color.Red;
                    break;
                case 10:
                    textBox_PalavraChave.Focus();
                    textBox_PalavraChave.BackColor = System.Drawing.Color.Red;
                    break;
                default:
                    break;
            }
        }


        private void LimparConteudo()
        {


        }

        private void frmGestaoFuncionario_Load(object sender, EventArgs e)
        {
            LimparCor();
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
            (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarClienteInsert(textBox_Nome.Text,
                textBox_Morada.Text,
                textBox_Contacto.Text,
                textBox_Email.Text,
                textBox_Contribuite.Text,
                textBox_Localidade.Text,
                textBoxNumeroCliente.Text,
                textBox_Foto.Text,
                textBox_PalavraChave.Text);

            if (codigoFTH >= 0)
            {
                MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
            (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarClienteUpdate(textBox_Id.Text,
                textBox_Nome.Text,
                textBox_Morada.Text,
                textBox_Contacto.Text,
                textBox_Email.Text,
                textBox_Contribuite.Text,
                textBox_Localidade.Text,
                textBoxNumeroCliente.Text,
                textBox_Foto.Text,
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
            Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
            (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarClienteApagar(textBox_Id.Text);
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
    }
}
