using System;
using System.Windows.Forms;
using System.Drawing;
//chamando pastas referenciadas
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using System.Data;

namespace Apresentacao
{
    public partial class FrmCadCliente : Form
    {
        ClassAcaoNaTela acaoNaTelaSelecionada;
        ClassTipo_Telefone_BLL tipo_Telefone_BLL = new ClassTipo_Telefone_BLL();
        ClassLogin_BLL ClassLogin_BLL = new ClassLogin_BLL();
        //Declarando variaveis
        Int32 ID_Cliente;  Int32 ID_Endereco;  Int32 ID_Telefone;  Int32 ID_Tipo_Telefone;
        string CEP = String.Empty, CPF = String.Empty, DDD = String.Empty, Telefone = String.Empty, Numero = String.Empty, HREntrada = String.Empty, HRSaida = String.Empty;


        

        bool mover = false;
        Point posicao_Inicial;

        //Construtor
        public FrmCadCliente(ClassAcaoNaTela acaoNaTela, ClassCliente_DTO classCliente_DTO)
        {

            InitializeComponent();

            DateTimeDatNascCLi.Value = DateTime.Now.Date;
            cmbBoxTipoTelCli.Items.Clear();
            foreach (ClassTipo_Telefone_DTO tipo_Telefone_DTO in tipo_Telefone_BLL.ConsultaTipoTelefone())
            {
                cmbBoxTipoTelCli.Items.Add(tipo_Telefone_DTO);

            }

            cmbBoxTipoTelCli2.Items.Clear();
            foreach (ClassTipo_Telefone_DTO tipo_Telefone_DTO in tipo_Telefone_BLL.ConsultaTipoTelefone())
            {
                cmbBoxTipoTelCli2.Items.Add(tipo_Telefone_DTO);
            }

            acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == ClassAcaoNaTela.Inserir)
            {
                this.Text = "Inserir novo cliente";
                cmbBoxTipoTelCli.SelectedIndex = 0;
                cmbBoxTipoTelCli2.SelectedIndex = 0;


            }
            else if (acaoNaTela == ClassAcaoNaTela.Atualizar)
            {
                this.Text = "Atualizar cliente";
                //Passando os valores para os TextBox
                if (!(classCliente_DTO.classEndereco_DTO.ID_Endereco == 0)) { ID_Endereco = classCliente_DTO.classEndereco_DTO.ID_Endereco; }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.CEP_Ende) != null) { mkdTxtBoxCEPCli.Text = classCliente_DTO.classEndereco_DTO.CEP_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Endereco_Ende) != null) { txtBoxEndCli.Text = classCliente_DTO.classEndereco_DTO.Endereco_Ende.ToString(); }
                if (!(classCliente_DTO.classEndereco_DTO.Numero_Ende == 0)) { mkdTxtBoxNumCli.Text = classCliente_DTO.classEndereco_DTO.Numero_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Complemento_Ende) != null) { txtBoxComplCli.Text = classCliente_DTO.classEndereco_DTO.Complemento_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Bairro_Ende) != null) { txtBoxBairroCli.Text = classCliente_DTO.classEndereco_DTO.Bairro_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Cidade_Ende) != null) { txtBoxCidCli.Text = classCliente_DTO.classEndereco_DTO.Cidade_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.UF_Ende) != null) { cmbBoxUFCli.Text = classCliente_DTO.classEndereco_DTO.UF_Ende.ToString(); }
                if (!(classCliente_DTO.ID_Cliente == 0)) { ID_Cliente = classCliente_DTO.ID_Cliente; }
                if (Convert.ToString(classCliente_DTO.Nome_Clie) != null)  { textBoxNomeCli.Text = classCliente_DTO.Nome_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.RG_Clie) != null) { txtBoxRGCli.Text = classCliente_DTO.RG_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.CPF_Clie) != null) { mkdTxtBoxCPFCli.Text = classCliente_DTO.CPF_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.Email_Clie) != null)  { txtBoxEmailCLi.Text = classCliente_DTO.Email_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.DataNasc_Clie) != null) { DateTimeDatNascCLi.Text = classCliente_DTO.DataNasc_Clie.ToString(); }
                if (!(classCliente_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone == 0))  { ID_Tipo_Telefone = classCliente_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone; }
                if (Convert.ToString(classCliente_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele) != null)  { cmbBoxTipoTelCli.Text = classCliente_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele.ToString(); }
                if (!(classCliente_DTO.classTelefone_DTO.ID_Telefone == 0))   { ID_Telefone = classCliente_DTO.classTelefone_DTO.ID_Telefone; }
                if (Convert.ToString(classCliente_DTO.classTelefone_DTO.DDD_Tele) != null)  { mkdTxtBoxDDDCli.Text = classCliente_DTO.classTelefone_DTO.DDD_Tele.ToString(); }
                if (Convert.ToString(classCliente_DTO.classTelefone_DTO.Telefone_Tele) != null)  { mkdTxtBoxTeleCli.Text = classCliente_DTO.classTelefone_DTO.Telefone_Tele.ToString(); }
                //Login
                DataTable Tabela = new DataTable();
                Tabela = ClassLogin_BLL.BuscarClienteLog(ID_Cliente);
                if (Tabela.Rows.Count > 0)
                {
                    txtSenhaClie.UseSystemPasswordChar = true;
                    txtSenhaClie.Text = Tabela.Rows[0][1].ToString();
                }
            }
            else if (acaoNaTela == ClassAcaoNaTela.Consultar)
            {
                this.Text = "Consultar cliente";
                //Passando os valores para os TextBox
                if (!(classCliente_DTO.classEndereco_DTO.ID_Endereco == 0)) { ID_Endereco = classCliente_DTO.classEndereco_DTO.ID_Endereco; }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.CEP_Ende) != null) { mkdTxtBoxCEPCli.Text = classCliente_DTO.classEndereco_DTO.CEP_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Endereco_Ende) != null) { txtBoxEndCli.Text = classCliente_DTO.classEndereco_DTO.Endereco_Ende.ToString(); }
                if (!(classCliente_DTO.classEndereco_DTO.Numero_Ende == 0)) { mkdTxtBoxNumCli.Text = classCliente_DTO.classEndereco_DTO.Numero_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Complemento_Ende) != null) { txtBoxComplCli.Text = classCliente_DTO.classEndereco_DTO.Complemento_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Bairro_Ende) != null) { txtBoxBairroCli.Text = classCliente_DTO.classEndereco_DTO.Bairro_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.Cidade_Ende) != null) { txtBoxCidCli.Text = classCliente_DTO.classEndereco_DTO.Cidade_Ende.ToString(); }
                if (Convert.ToString(classCliente_DTO.classEndereco_DTO.UF_Ende) != null) { cmbBoxUFCli.Text = classCliente_DTO.classEndereco_DTO.UF_Ende.ToString(); }
                if (!(classCliente_DTO.ID_Cliente == 0)) { ID_Cliente = classCliente_DTO.ID_Cliente; }
                if (Convert.ToString(classCliente_DTO.Nome_Clie) != null) { textBoxNomeCli.Text = classCliente_DTO.Nome_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.RG_Clie) != null) { txtBoxRGCli.Text = classCliente_DTO.RG_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.CPF_Clie) != null) { mkdTxtBoxCPFCli.Text = classCliente_DTO.CPF_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.Email_Clie) != null) { txtBoxEmailCLi.Text = classCliente_DTO.Email_Clie.ToString(); }
                if (Convert.ToString(classCliente_DTO.DataNasc_Clie) != null) { DateTimeDatNascCLi.Text = classCliente_DTO.DataNasc_Clie.ToString(); }
                if (!(classCliente_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone == 0)) { ID_Tipo_Telefone = classCliente_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone; }
                if (Convert.ToString(classCliente_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele) != null) { cmbBoxTipoTelCli.Text = classCliente_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele.ToString(); }
                if (!(classCliente_DTO.classTelefone_DTO.ID_Telefone == 0)) { ID_Telefone = classCliente_DTO.classTelefone_DTO.ID_Telefone; }
                if (Convert.ToString(classCliente_DTO.classTelefone_DTO.DDD_Tele) != null) { mkdTxtBoxDDDCli.Text = classCliente_DTO.classTelefone_DTO.DDD_Tele.ToString(); }
                if (Convert.ToString(classCliente_DTO.classTelefone_DTO.Telefone_Tele) != null) { mkdTxtBoxTeleCli.Text = classCliente_DTO.classTelefone_DTO.Telefone_Tele.ToString(); }
                //Login
                DataTable Tabela = new DataTable();
                Tabela = ClassLogin_BLL.BuscarClienteLog(ID_Cliente);
                if (Tabela.Rows.Count > 0)
                {
                    txtSenhaClie.UseSystemPasswordChar = true;
                    txtSenhaClie.Text = Tabela.Rows[0][1].ToString();
                }

                //Desabilitar campos na tela
                mkdTxtBoxCEPCli.TabStop = false;
                txtBoxEndCli.TabStop = false;
                mkdTxtBoxNumCli.TabStop = false;
                txtBoxComplCli.TabStop = false;
                txtBoxBairroCli.TabStop = false;
                txtBoxCidCli.TabStop = false;
                cmbBoxUFCli.TabStop = false;
                cmbBoxUFCli.Enabled = false;
                textBoxNomeCli.TabStop = false;
                txtBoxRGCli.TabStop = false;
                mkdTxtBoxCPFCli.TabStop = false;
                txtBoxEmailCLi.TabStop = false;
                DateTimeDatNascCLi.TabStop = false;
                cmbBoxTipoTelCli.TabStop = false;
                mkdTxtBoxDDDCli.TabStop = false;
                mkdTxtBoxTeleCli.TabStop = false;
                btnSalvarCli.Visible = false;
                btnAtivaTelefone.Enabled = false;
                btnAtivaTelefone.Visible = false;

                mkdTxtBoxCEPCli.ReadOnly = true;
                txtBoxEndCli.ReadOnly = true;
                mkdTxtBoxNumCli.ReadOnly = true;
                txtBoxComplCli.ReadOnly = true;
                txtBoxBairroCli.ReadOnly = true;
                txtBoxCidCli.ReadOnly = true;
                textBoxNomeCli.ReadOnly = true;
                txtBoxRGCli.ReadOnly = true;
                mkdTxtBoxCPFCli.ReadOnly = true;
                txtBoxEmailCLi.ReadOnly = true;
                DateTimeDatNascCLi.Enabled = false;
                cmbBoxTipoTelCli.Enabled = false;
                mkdTxtBoxDDDCli.ReadOnly = true;
                mkdTxtBoxTeleCli.ReadOnly = true;
                btnCancelarCadCli.Focus();
                btnCancelarCadCli.Text = "Cancelar";

            }
        }

       

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            
        }


        private void btnMinimizarCli_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvarCli_Click(object sender, EventArgs e)
        {
            //Instanciando regra de negócio
            ClassTelefone_BLL classTelefone_BLL = new ClassTelefone_BLL();
            ClassCliente_BLL classCliente_BLL = new ClassCliente_BLL();
            //Tirando mascaras do MaskTextBox
            CEP = TirarFormatacao(mkdTxtBoxCEPCli);
            CPF = TirarFormatacao(mkdTxtBoxCPFCli);
            DDD = TirarFormatacao(mkdTxtBoxDDDCli);
            Telefone = TirarFormatacao(mkdTxtBoxTeleCli);
            Numero = TirarFormatacao(mkdTxtBoxNumCli);
            if (!Validar())
            {
                return;
            }

            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Inserir)
            {
                //passando valores para o construtor
               ClassCliente_DTO classCliente_DTO = new ClassCliente_DTO(CEP.Trim(), txtBoxEndCli.Text, Convert.ToInt32(Numero.Trim()), txtBoxComplCli.Text, txtBoxBairroCli.Text,
               txtBoxCidCli.Text,cmbBoxUFCli.Text, textBoxNomeCli.Text, txtBoxRGCli.Text.Trim(), CPF.Trim(), txtBoxEmailCLi.Text,Convert.ToDateTime(DateTimeDatNascCLi.Text));
                String IDCliente = classCliente_BLL.InserirCliente(classCliente_DTO);

                classCliente_DTO.classTelefone_DTO = new ClassTelefone_DTO(Convert.ToInt32(IDCliente),0, Convert.ToInt32(mkdTxtBoxDDDCli.Text.Replace("(", "").Replace(")", "").Trim()), mkdTxtBoxTeleCli.Text.Replace("-", "").Trim());
                ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelCli.SelectedItem).ID_Tipo_Telefone);
                classCliente_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                String IDTelefone = classTelefone_BLL.InserirTelefone(classCliente_DTO.classTelefone_DTO);

                if (btnAtivaTelefone.Enabled.Equals(false) && mkdTxtBoxDDDCli2.TextLength > 0 && mkdTxtBoxTeleCli2.TextLength > 0)
                {
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelCli2.SelectedItem).ID_Tipo_Telefone);
                    classCliente_DTO.classTelefone_DTO = new ClassTelefone_DTO(Convert.ToInt32(IDCliente),0, Convert.ToInt32(mkdTxtBoxDDDCli2.Text.Replace("(", "").Replace(")", "").Trim()), mkdTxtBoxTeleCli2.Text.Replace("-", "").Trim());
                    classCliente_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone2 = classTelefone_BLL.InserirTelefone(classCliente_DTO.classTelefone_DTO);
                }
                ClassLogin_BLL classLogin_BLL = new ClassLogin_BLL();
                ClassLogin_DTO classLogin_DTO = new ClassLogin_DTO();
                classLogin_DTO.ClassCliente_DTO = new ClassCliente_DTO();
                classLogin_DTO.classFuncionario_DTO = new ClassFuncionario_DTO();
                classLogin_DTO.classFuncionario_DTO.ID_Funcionario = 0;
                classLogin_DTO.ClassCliente_DTO.ID_Cliente = Convert.ToInt32(IDCliente);
                classLogin_DTO.Senha_Log = txtSenhaClie.Text;
                String IDLog = classLogin_BLL.InserirLogin(classLogin_DTO);
                try
                {
                    Int32 ID_login = Convert.ToInt32(IDLog);
                    Int32 ID = Convert.ToInt32(IDCliente);
                    Int32 IDT = Convert.ToInt32(IDTelefone);
                    MessageBox.Show("Cliente cadastrado com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar. Detalhes: \n" + ID_Cliente + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
    
            else if (acaoNaTelaSelecionada == ClassAcaoNaTela.Atualizar)
            {
                ClassCliente_DTO classCliente_DTO = new ClassCliente_DTO(ID_Endereco,CEP.Trim(), txtBoxEndCli.Text, Convert.ToInt32(Numero.Trim()), txtBoxComplCli.Text, txtBoxBairroCli.Text,
                txtBoxCidCli.Text,cmbBoxUFCli.Text, ID_Cliente, textBoxNomeCli.Text, txtBoxRGCli.Text.Trim(), CPF.Trim(), txtBoxEmailCLi.Text, Convert.ToDateTime(DateTimeDatNascCLi.Text));
                String IDCliente = classCliente_BLL.AtualizarCliente(classCliente_DTO);

                if (ID_Telefone.Equals(0))
                {
                    classCliente_DTO.classTelefone_DTO = new ClassTelefone_DTO(Convert.ToInt32(IDCliente),0, Convert.ToInt32(mkdTxtBoxDDDCli.Text.Replace("(", "").Replace(")", "").Trim()), mkdTxtBoxTeleCli.Text.Replace("-", "").Trim());
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelCli.SelectedItem).ID_Tipo_Telefone);
                    classCliente_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone = classTelefone_BLL.InserirTelefone(classCliente_DTO.classTelefone_DTO);
                }
                else
                {
                    classCliente_DTO.classTelefone_DTO = new ClassTelefone_DTO(ID_Telefone, Convert.ToInt32(mkdTxtBoxDDDCli.Text.Replace("(", "").Replace(")", "").Trim()), mkdTxtBoxTeleCli.Text.Replace("-", "").Trim());
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelCli.SelectedItem).ID_Tipo_Telefone);
                    classCliente_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone = classTelefone_BLL.AtualizarTelefone(classCliente_DTO.classTelefone_DTO);
                }

                if (btnAtivaTelefone.Enabled.Equals(false) && mkdTxtBoxDDDCli2.TextLength > 0 && mkdTxtBoxTeleCli2.TextLength > 0)
                {
                    classCliente_DTO.classTelefone_DTO = new ClassTelefone_DTO(ID_Telefone, Convert.ToInt32(mkdTxtBoxDDDCli2.Text.Replace("(", "").Replace(")", "").Trim()), mkdTxtBoxTeleCli2.Text.Replace("-", "").Trim());
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelCli2.SelectedItem).ID_Tipo_Telefone);

                    classCliente_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone2 = classTelefone_BLL.AtualizarTelefone(classCliente_DTO.classTelefone_DTO);
                }
                try
                {
                    Int32 ID = Convert.ToInt32(IDCliente);
                    MessageBox.Show("Cliente foi atualizado com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar. Detalhes: \n" + IDCliente + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }

        }


        private void lblLinkProximo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //selecionando tab Endereço
            tabControlCadClie.SelectTab(tabPageEndereco);
        }

        private void lblLinkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //selecionando tab Dados de Pessoa
            tabControlCadClie.SelectTab(tabPageDadosPessoais);
        }

        private void btnFecharCadCli_Click(object sender, EventArgs e)
        {
            //fechando formulario
            DialogResult = DialogResult.Cancel;
        }
        public string TirarFormatacao(MaskedTextBox _mask)
            {
                _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                String retString = _mask.Text;
                _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                return retString;
            }

        private void btnFecharCaix_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBoxTipoTelCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTipoTelCli.Text != "--Selecione--")
            {
                mkdTxtBoxDDDCli.Enabled = true;
                mkdTxtBoxTeleCli.Enabled = true;
            }
        }

        private void cmbBoxTipoTelCli2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTipoTelCli2.Text != "--Selecione--")
            {
                mkdTxtBoxDDDCli2.Enabled = true;
                mkdTxtBoxTeleCli2.Enabled = true;
            }
        }

        private void textBoxNomeCli_Leave(object sender, EventArgs e)
        {
            //Nome
            if (textBoxNomeCli.Text.Length <= 0)
            {
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgNomeCli.Visible = true;
            }
            if (!(textBoxNomeCli.Text.Length <= 0))
            {
                lblMsgNomeCli.Visible = false;
            }
            if (textBoxNomeCli.Text.Trim().Length > 0)
            {
                txtSenhaClie.Text = textBoxNomeCli.Text.Substring(0, 3) + DateTimeDatNascCLi.Text.Replace("/","");

            }
        }

        private void DateTimeDatNascCLi_Leave(object sender, EventArgs e)
        {
            //Data de Nascimento
            if (DateTimeDatNascCLi.Text.Equals(DateTime.Now.Date.ToString("dd/MM/yyyy")))
            {
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgDatNascCli.ForeColor = Color.Red;
            }
            if (!DateTimeDatNascCLi.Text.Equals(DateTime.Now.Date.ToString("dd/MM/yyyy")))
            {
                lblMsgDatNascCli.ForeColor = Color.Black;
            }

            txtSenhaClie.Text = textBoxNomeCli.Text.Substring(0, 3) + DateTimeDatNascCLi.Text.Replace("/","");
        }

        private void txtBoxRGCli_Leave(object sender, EventArgs e)
        {
            //RG
            if (txtBoxRGCli.Text.Trim().Length <= 0)
            {
                //selecionando tab informaçoes pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgRGCli.ForeColor = Color.Red;
            }
            if (!(txtBoxRGCli.Text.Trim().Length <= 0))
            {
                lblMsgRGCli.ForeColor = Color.Black;
            }
        }

        private void mkdTxtBoxCPFCli_Leave(object sender, EventArgs e)
        {
            //CPF
            if (TirarFormatacao(mkdTxtBoxCPFCli).Trim().Length<=0)
            {
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgCPFCli.ForeColor = Color.Red;
            }
            if (!(TirarFormatacao(mkdTxtBoxCPFCli).Trim().Length <= 0))
            {
                lblMsgCPFCli.ForeColor = Color.Black;
            }
        }

        private void cmbBoxTipoTelCli_Leave(object sender, EventArgs e)
        {
            //tipo de telefone 
            if (cmbBoxTipoTelCli.Text.Equals("--Selecione--"))
            {
                //selecionando informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgTipoTeleCli.ForeColor = Color.Red;
            }
            if (!cmbBoxTipoTelCli.Text.Equals("--Selecione--"))
            {
                lblMsgTipoTeleCli.ForeColor = Color.Black;
            }
        }

        private void mkdTxtBoxDDDCli_Leave(object sender, EventArgs e)
        {
            //DDD 
            if (TirarFormatacao(mkdTxtBoxDDDCli).Trim().Length<=0)
            {
                //selecionando informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgDDDCli.ForeColor = Color.Red;
            }
            if (!(TirarFormatacao(mkdTxtBoxDDDCli).Trim().Length<=0))
            {
                lblMsgDDDCli.ForeColor = Color.Black;
            }
        }

        private void mkdTxtBoxTeleCli_Leave(object sender, EventArgs e)
        {

            if (TirarFormatacao(mkdTxtBoxTeleCli).Trim().Length<=0)
            {
                //selecionando informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgTelefoneCli.ForeColor = Color.Red;
            }
            if (!(TirarFormatacao(mkdTxtBoxTeleCli).Trim().Length<=0))
            {
                lblMsgTelefoneCli.ForeColor = Color.Black;
            }
        }

        private void txtBoxEmailCLi_Leave(object sender, EventArgs e)
        {
            //E-mail
            if (txtBoxEmailCLi.Text.Trim().Length<=0 || !txtBoxEmailCLi.Text.Contains("@") && !txtBoxEmailCLi.Text.Contains("."))
            {
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                lblMsgEmailCli.ForeColor = Color.Red;
            }
            if (!(txtBoxEmailCLi.Text.Trim().Length<=0) || txtBoxEmailCLi.Text.Contains("@") && txtBoxEmailCLi.Text.Contains("."))
            {
                lblMsgEmailCli.ForeColor = Color.Black;
            }
        }

        private void mkdTxtBoxCEPCli_Leave(object sender, EventArgs e)
        {
            //CEP
            if (TirarFormatacao(mkdTxtBoxCEPCli).Trim().Length<=0)
            {
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                lblMsgCEPCli.ForeColor = Color.Red;
            }
            if (!(TirarFormatacao(mkdTxtBoxCEPCli).Trim().Length<=0))
            {
                lblMsgCEPCli.ForeColor = Color.Black;
            }
        }

        private void txtBoxEndCli_Leave(object sender, EventArgs e)
        {
            //Endereço
            if (txtBoxEndCli.Text.Length<=0)
            {
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                lblMsgEnderecoCli.ForeColor = Color.Red;
            }
            if (!(txtBoxEndCli.Text.Length<=0))
            {
                lblMsgEnderecoCli.ForeColor = Color.Black;
            }
        }

        private void mkdTxtBoxNumCli_Leave(object sender, EventArgs e)
        {
            //Número
            if (Numero.Length<=0)
            {
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                lblMsgNumeroCli.ForeColor = Color.Red;
            }
            if (!(Numero.Length<=0))
            {
                lblMsgNumeroCli.ForeColor = Color.Black;
            }
        }

     

        private void txtBoxBairroCli_Leave(object sender, EventArgs e)
        {
            //Bairro
            if (txtBoxBairroCli.Text.Length<=0)
            {
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                lblMsgBairroCli.ForeColor = Color.Red;
            }
            if (!(txtBoxBairroCli.Text.Length<=0))
            {
                lblMsgBairroCli.ForeColor = Color.Black;
            }
        }

        private void txtBoxCidCli_Leave(object sender, EventArgs e)
        {
            //Cidade
            if (txtBoxCidCli.Text.Length<=0)
            {
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                lblMsgCidadeCli.ForeColor = Color.Red;
            }
            if (!(txtBoxCidCli.Text.Length<=0))
            {
                lblMsgCidadeCli.ForeColor = Color.Black;
            }
        }

        private void cmbBoxUFCli_Leave(object sender, EventArgs e)
        {
            //UF
            if (cmbBoxUFCli.Text.Equals(String.Empty))
            {
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                lblMsgUFCli.ForeColor = Color.Red;
            }
            if (!cmbBoxUFCli.Text.Equals(String.Empty))
            {
                lblMsgUFCli.ForeColor = Color.Black;
            }
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

        private void mkdTxtBoxTeleCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBoxTipoTelCli.Text.Equals("Celular"))
            {
                this.mkdTxtBoxTeleCli.Mask = "00000-9999";
            }
            else if (cmbBoxTipoTelCli.Text.Equals("Residencial"))
            {
                this.mkdTxtBoxTeleCli.Mask = "0000-9999";
            }
        }
        private void mkdTxtBoxTeleCli2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBoxTipoTelCli2.Text.Equals("Celular"))
            {
                this.mkdTxtBoxTeleCli2.Mask = "00000-9999";
            }
            else if (cmbBoxTipoTelCli2.Text.Equals("Residencial"))
            {
                this.mkdTxtBoxTeleCli2.Mask = "0000-9999";
            }
        }


        private void btnAtivaTelefone_Click(object sender, EventArgs e)
        {
            lblTipoTelFunc2.Visible = true;
            cmbBoxTipoTelCli2.Visible = true;
            lblDDDFunc2.Visible = true;
            mkdTxtBoxDDDCli2.Visible = true;
            lblTelefone2.Visible = true;
            mkdTxtBoxTeleCli2.Visible = true;
            btnAtivaTelefone.Enabled = false;
        }

        public bool Validar()
        {
            bool valida = true;
            //Nome
            if (textBoxNomeCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                textBoxNomeCli.Focus();
                lblMsgNomeCli.ForeColor = Color.Red;
            }
            if (!textBoxNomeCli.Text.Equals(String.Empty))
            {
                lblMsgNomeCli.ForeColor = Color.Black;
            }
            //RG
            if (txtBoxRGCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab informaçoes pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                txtBoxRGCli.Focus();
                lblMsgRGCli.ForeColor = Color.Red;
            }
            if (!txtBoxRGCli.Text.Equals(String.Empty))
            {
                lblMsgRGCli.ForeColor = Color.Black;
            }
            //CPF
            if (CPF.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                mkdTxtBoxCPFCli.Focus();
                lblMsgCPFCli.ForeColor = Color.Red;
            }
            if (!CPF.Equals(String.Empty))
            {
                lblMsgCPFCli.ForeColor = Color.Black;
            }
            //E-mail
            if (txtBoxEmailCLi.Text.Equals(String.Empty) || !txtBoxEmailCLi.Text.Contains("@") && !txtBoxEmailCLi.Text.Contains("."))
            {
                valida = false;
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                txtBoxEmailCLi.Focus();
                lblMsgEmailCli.ForeColor = Color.Red;
            }
            if (!txtBoxEmailCLi.Text.Equals(String.Empty) || txtBoxEmailCLi.Text.Contains("@") && txtBoxEmailCLi.Text.Contains("."))
            {
                lblMsgEmailCli.ForeColor = Color.Black;
            }
            //Data de Nascimento
            if (DateTimeDatNascCLi.Text.Equals(DateTime.Now.Date.ToString("dd/MM/yyyy")))
            {
                valida = false;
                //selecionando tab informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                DateTimeDatNascCLi.Focus();
                lblMsgDatNascCli.ForeColor = Color.Red;
            }
            if (!DateTimeDatNascCLi.Text.Equals(DateTime.Now.Date.ToString("dd/MM/yyyy")))
            {
                lblMsgDatNascCli.ForeColor = Color.Black;
            }
            //UF
            if (cmbBoxUFCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                cmbBoxUFCli.Focus();
                lblMsgUFCli.ForeColor = Color.Red;
            }
            if (!cmbBoxUFCli.Text.Equals(String.Empty))
            {
                lblMsgUFCli.ForeColor = Color.Black;
            }
            //Cidade
            if (txtBoxCidCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                txtBoxCidCli.Focus();
                lblMsgCidadeCli.ForeColor = Color.Red;
            }
            if (!txtBoxCidCli.Text.Equals(String.Empty))
            {
                lblMsgCidadeCli.ForeColor = Color.Black;
            }
            //Bairro
            if (txtBoxBairroCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                txtBoxBairroCli.Focus();
                lblMsgBairroCli.ForeColor = Color.Red;
            }
            if (!txtBoxBairroCli.Text.Equals(String.Empty))
            {
                lblMsgBairroCli.ForeColor = Color.Black;
            }
            //Número
            if (Numero.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                mkdTxtBoxNumCli.Focus();
                lblMsgNumeroCli.ForeColor = Color.Red;
            }
            if (!Numero.Equals(String.Empty))
            {
                lblMsgNumeroCli.ForeColor = Color.Black;
            }
            //Endereço
            if (txtBoxEndCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                txtBoxEndCli.Focus();
                lblMsgEnderecoCli.ForeColor = Color.Red;
            }
            if (!txtBoxEndCli.Text.Equals(String.Empty))
            {
                lblMsgEnderecoCli.ForeColor = Color.Black;
            }
            //CEP
            if (CEP.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações de endereço
                tabControlCadClie.SelectTab(tabPageEndereco);
                mkdTxtBoxCEPCli.Focus();
                lblMsgCEPCli.ForeColor = Color.Red;
            }
            if (!CEP.Equals(String.Empty))
            {
                lblMsgCEPCli.ForeColor = Color.Black;
            }
            //tipo de telefone 
            if (cmbBoxTipoTelCli.Text.Equals("--Selecione--"))
            {
                valida = false;
                //selecionando informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                cmbBoxTipoTelCli.Focus();
                lblMsgTipoTeleCli.ForeColor = Color.Red;
            }
            if (!cmbBoxTipoTelCli.Text.Equals("--Selecione--"))
            {
                lblMsgTipoTeleCli.ForeColor = Color.Black;
            }
            //DDD 
            if (DDD.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                mkdTxtBoxDDDCli.Focus();
                lblMsgDDDCli.ForeColor = Color.Red;
            }
            if (!DDD.Equals(String.Empty))
            {
                lblMsgDDDCli.ForeColor = Color.Black;
            }

            if (mkdTxtBoxTeleCli.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando informações pessoais
                tabControlCadClie.SelectTab(tabPageDadosPessoais);
                mkdTxtBoxTeleCli.Focus();
                lblMsgTelefoneCli.ForeColor = Color.Red;
            }
            if (!mkdTxtBoxTeleCli.Text.Equals(String.Empty))
            {
                lblMsgTelefoneCli.ForeColor = Color.Black;
            }
            return valida;

        }
    }
}

