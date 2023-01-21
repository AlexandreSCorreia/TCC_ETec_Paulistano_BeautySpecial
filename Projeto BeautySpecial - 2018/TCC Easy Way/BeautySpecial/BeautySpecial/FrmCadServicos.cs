using System;
using System.Windows.Forms;
using System.Drawing;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
namespace Apresentacao
{
    public partial class FrmCadServicos : Form
    {
        //Declarando variaveis
        ClassAcaoNaTela acaoNaTelaSelecionada;
        Int32 IDServico;
        String Duracao = String.Empty;
        decimal preco = 0;

        bool mover = false;
        Point posicao_Inicial;

        //Construtor
        public FrmCadServicos(ClassAcaoNaTela acaoNaTela,ClassServico_DTO classServico)
        {
            acaoNaTelaSelecionada = acaoNaTela;
            InitializeComponent();

            if (acaoNaTela == ClassAcaoNaTela.Inserir)
            {
                this.Text = "Inserir novo serviço";

            }
            else if (acaoNaTela == ClassAcaoNaTela.Atualizar)
            {
                this.Text = "Atualizar serviço";
                //Passando os valores para os TextBox
                IDServico = classServico.ID_Servico;
                txtBoxNomeServ.Text = classServico.Nome_Serv.ToString();
                txtBoxPrecServ.Text = classServico.Preco_Serv.ToString();
                mkdTxtBoxDuracServ.Text = classServico.Duracao_Serv.ToString();
                txtBoxDescServ.Text = classServico.Descricao_Serv.ToString();



            }
            else if (acaoNaTela == ClassAcaoNaTela.Consultar)
            {
                this.Text = "Consultar serviço";
                //Passando os valores para os TextBox
                txtBoxNomeServ.Text = classServico.Nome_Serv.ToString();
                txtBoxPrecServ.Text = classServico.Preco_Serv.ToString();
                mkdTxtBoxDuracServ.Text = classServico.Duracao_Serv.ToString();
                txtBoxDescServ.Text = classServico.Descricao_Serv.ToString();


                //Desabilitar campos na tela
                txtBoxNomeServ.TabStop = false;
                txtBoxPrecServ.TabStop = false;
                mkdTxtBoxDuracServ.TabStop = false;
                txtBoxDescServ.TabStop = false;
                txtBoxNomeServ.ReadOnly = true;
                txtBoxPrecServ.ReadOnly = true;
                mkdTxtBoxDuracServ.ReadOnly = true;
                txtBoxDescServ.ReadOnly = true;

                btnSalvarServ.Visible = false;
            }
        }

        private void btnMinimizarServ_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelarCadServ_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnFecharServ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarServ_Click(object sender, EventArgs e)
        {
            //instância da classe servico_bll
            ClassServico_BLL classServico_BLL = new ClassServico_BLL();
            Duracao = TirarFormatacao(mkdTxtBoxDuracServ);
            if (!Validar())
            {
                return;
            }

            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Inserir)
            {

                //instância da classe servico_dto e passando parametros para o contrutor
                ClassServico_DTO classServico_DTO = new ClassServico_DTO(txtBoxNomeServ.Text,Convert.ToDecimal(txtBoxPrecServ.Text),mkdTxtBoxDuracServ.Text,txtBoxDescServ.Text);
                String ID_Servico = classServico_BLL.InserirServico(classServico_DTO);
                try
                {
                    Int32 ID = Convert.ToInt32(ID_Servico);
                    MessageBox.Show("Serviço cadastrado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar. Detalhes: " + "\n" + ID_Servico+ "\n"+ ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionada == ClassAcaoNaTela.Atualizar)
            {
                ClassServico_DTO classServico_DTO = new ClassServico_DTO(IDServico,txtBoxNomeServ.Text, Convert.ToDecimal(txtBoxPrecServ.Text), mkdTxtBoxDuracServ.Text, txtBoxDescServ.Text);
                String ID_Servico = classServico_BLL.AtualizarServico(classServico_DTO);
                try
                {
                    IDServico = Convert.ToInt32(ID_Servico);
                    MessageBox.Show("Atualização concluida com êxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Atualizar. Detalhes: " + ID_Servico + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
                
            }
        }

        private void btnFecharCaix_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void MoverForm_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);

        }
        private void MoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void MoverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }
        public string TirarFormatacao(MaskedTextBox _mask)
        {
            _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String retString = _mask.Text;
            _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return retString;
        }

        public bool Validar()
        {
            bool valida = true;
           
            if (txtBoxNomeServ.Text.Equals(String.Empty))
            {
                valida = false;
                txtBoxNomeServ.Focus();
                lblMsgNomeServ.ForeColor = Color.Red;
            }
            if (!txtBoxNomeServ.Text.Equals(String.Empty))
            {
                valida = true;
                lblMsgNomeServ.ForeColor = Color.Black;
            }

            if (Duracao.Equals(String.Empty))
            {
                valida = false;
                mkdTxtBoxDuracServ.Focus();
                lblMsgDuracaoServ.ForeColor = Color.Red;
            }
            if (!Duracao.Equals(String.Empty))
            {
                valida = true;
                lblMsgDuracaoServ.ForeColor = Color.Black;
            }


            if (preco.Equals(0))
            {
                valida = false;
                txtBoxPrecServ.Focus();
                lblMsgPrecoServ.ForeColor = Color.Red;
            }
            if (!txtBoxPrecServ.Text.Equals(String.Empty))
            {
                valida = true;
                lblMsgPrecoServ.ForeColor = Color.Black;
            }
            return valida;
        }

        public static void Moeda(ref TextBox textBox)
        {
            string numero = String.Empty;
            double valor = 0;
            try
            {
                numero = textBox.Text.Replace(",", "").Replace(".", "");
                if (numero.Equals(""))
                    numero = "";
                numero = numero.PadLeft(3, '0');
                if (numero.Length > 3 & numero.Substring(0, 1) == "0")
                    numero = numero.Substring(1, numero.Length - 1);
                valor = Convert.ToDouble(numero) / 100;
                textBox.Text = string.Format("{0:N}", valor);
                textBox.SelectionStart = textBox.Text.Length;
            }
            catch (Exception)
            {
            }

        }

        private void txtBoxPrecServ_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtBoxPrecServ);
        }
        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }

        private void mkdTxtBoxDuracServ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mkdTxtBoxDuracServ.Select(mkdTxtBoxDuracServ.Text.Length, 0);

        }
    }
}

