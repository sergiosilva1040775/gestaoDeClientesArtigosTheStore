using gestaoDeClientesArtigosTheStore.DAL;
using gestaoDeClientesArtigosTheStore.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmGestaoClientes : Form
    {
        clienteDAL clienteDALs = new clienteDAL();
        public frmGestaoClientes()
        {
            InitializeComponent();
        }

        //private void LimparCor()
        //{


        //}

        private void carregarListaClientes()
        {

            List<cliente> cliente = clienteDALs.listarClientesActivos();

            dataGridView_Especialidades.DataSource = cliente;

            dataGridView_Especialidades.Columns["id"].Visible = false;
        }

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
                //case 10:
                //    textBox_PalavraChave.Focus();
                //    textBox_PalavraChave.BackColor = System.Drawing.Color.Red;
                //    break;
                default:
                    break;
            }
        }


        private void LimparConteudo()
        {
            textBox_Id.Clear();
            textBox_Nome.Clear();
            textBox_Morada.Clear();
            textBox_Contacto.Clear();
            textBox_Email.Clear();
            textBox_Contribuite.Clear();
            textBox_Localidade.Clear();
            textBoxNumeroCliente.Clear();
            textBox_Foto.Clear();

        }

        private void frmGestaoFuncionario_Load(object sender, EventArgs e)
        {
            LimparCor();
            LimparConteudo();
            carregarListaClientes();
        }

        //private void button_Adicionar_Click(object sender, EventArgs e)
        //{
        //    LimparCor();
        //    Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
        //    (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarClienteInsert(textBox_Nome.Text,
        //        textBox_Morada.Text,
        //        textBox_Contacto.Text,
        //        textBox_Email.Text,
        //        textBox_Contribuite.Text,
        //        textBox_Localidade.Text,
        //        textBoxNumeroCliente.Text,
        //        textBox_Foto.Text,
        //        textBox_PalavraChave.Text);
        //    if (codigoFTH > 0)
        //    {
        //        MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        mostrarErrosValidacao(codigoFTH);
        //    }
        //    else
        //    {
        //        //vehiclesDAL.vehicleCCGeral = vehicleCC;
        //        //(int codigoIn, string respostaIn) = vehiclesDAL.insertVehicle();
        //        //if (codigoIn == 1) { MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //        //else { MessageBox.Show(mensagemDeErrooFTH,this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //    }


        //}

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
            (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarClienteUpdate(textBox_Nome.Text,
                textBox_Morada.Text,
                textBox_Contacto.Text,
                textBox_Email.Text,
                textBox_Contribuite.Text,
                textBox_Localidade.Text, textBox_Id.Text);

            if (codigoFTH > 0)
            {
                MessageBox.Show(mensagemDeErrooFTH, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                clienteDALs.cliente = clienteCC;
                (int codigoIn, string respostaIn) = clienteDALs.actualizarCliente();
                if (codigoIn == 1)
                {
                    MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCor();
                    LimparConteudo();
                    carregarListaClientes();
                }
                else { MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.clienteHander clienteHanders = new Handlers.clienteHander();
            (int codigoFTH, Models.cliente clienteCC, string mensagemDeErrooFTH) = clienteHanders.ValidarClienteApagar(textBox_Id.Text);
            if (codigoFTH > 0)
            {
                MessageBox.Show(this.Text, mensagemDeErrooFTH, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mostrarErrosValidacao(codigoFTH);
            }
            else
            {
                clienteDALs.cliente = clienteCC;
                (int codigoIn, string respostaIn) = clienteDALs.desactivarCliente();
                if (codigoIn == 1)
                {
                    MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCor();
                    LimparConteudo();
                    carregarListaClientes();
                }
                else { MessageBox.Show(respostaIn, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }


        }

        private void button_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCor();
            LimparConteudo();
            carregarListaClientes();
        }

        private void dataGridView_Especialidades_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBox_Id.Text = dataGridView_Especialidades[0, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Nome.Text = dataGridView_Especialidades[1, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Morada.Text = dataGridView_Especialidades[2, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Contacto.Text = dataGridView_Especialidades[3, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Email.Text = dataGridView_Especialidades[4, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Contribuite.Text = dataGridView_Especialidades[5, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Localidade.Text = dataGridView_Especialidades[6, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBoxNumeroCliente.Text = dataGridView_Especialidades[7, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();
            textBox_Foto.Text = dataGridView_Especialidades[8, dataGridView_Especialidades.CurrentRow.Index].Value.ToString();


        }
    }
}
