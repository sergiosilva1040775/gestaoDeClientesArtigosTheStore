using System;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.formularios
{
    public partial class frmGestaoArtigo : Form
    {
        public frmGestaoArtigo()
        {
            InitializeComponent();
        }

        private void frmGestaoArtigo_Load(object sender, EventArgs e)
        {
            LimparConteudo();
            LimparCor();
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
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            LimparCor();
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo clienteCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoInsert(textBox_descricao.Text, textBox_Valor_Unitario.Text,
            textBox_Stock.Text);

            if (codigoFTH > 0)
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
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo clienteCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoUpdate(textBox_ID.Text, textBox_descricao.Text, textBox_Valor_Unitario.Text,
            textBox_Stock.Text);

            if (codigoFTH > 0)
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
            Handlers.artigoHander artigoHander = new Handlers.artigoHander();
            (int codigoFTH, Models.artigo clienteCC, string mensagemDeErrooFTH) = artigoHander.ValidarArtigoaApagar(textBox_ID.Text);

            if (codigoFTH > 0)
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
    }
}
