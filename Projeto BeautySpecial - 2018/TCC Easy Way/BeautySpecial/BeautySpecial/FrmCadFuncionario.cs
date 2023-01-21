using System;
using System.Windows.Forms;
using System.Drawing;
//chamando pastas referenciadas
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using System.Data;

namespace Apresentacao
{
    public partial class FrmCadFuncionario : Form
    {
        //Declarando variáveis
        ClassAcaoNaTela acaoNaTelaSelecionada;
        //Instancia da regra de negócio
        ClassFuncionario_BLL classFuncionario_BLL = new ClassFuncionario_BLL();
        ClassTelefone_BLL classTelefone_BLL = new ClassTelefone_BLL();
        ClassLogin_BLL classLogin_BLL = new ClassLogin_BLL();
        ClassTipo_Telefone_BLL tipo_Telefone_BLL = new ClassTipo_Telefone_BLL();
        ClassGrupo_BLL classGrupo_BLL = new ClassGrupo_BLL();
        Int32 ID_Funcionario = 0; Int32 ID_Cargo = 0; Int32 ID_Endereco = 0; Int32 ID_Telefone = 0; Int32 ID_Tipo_Telefone = 0;
        //Declarando variaveis
        string CEP = String.Empty, CPF = String.Empty, DDD = String.Empty, Telefone = String.Empty, Numero = String.Empty, HREntrada = String.Empty, HRSaida = String.Empty;
        String DDD2 = String.Empty; String IDLog; String Sorteio;

        bool mover = false;
        Point posicao_Inicial;


        public FrmCadFuncionario(ClassAcaoNaTela acaoNaTela, ClassFuncionario_DTO classFuncionario_DTO)
        {
            InitializeComponent();

            this.DateTimeAdmsFunc.Value = DateTime.Now.Date;
            this.DateTimeDatNascFunc.Value = DateTime.Now.Date;

            cmbBoxGrupo.Items.Clear();
            cmbBoxGrupo.Items.Add("--Selecione");
            foreach (ClassGrupo_DTO classServico_DTO in classGrupo_BLL.ConsultaGrupo(""))
            {
                cmbBoxGrupo.Items.Add(classServico_DTO);
            }
            cmbBoxGrupo.Text = "--Selecione--";

            cmbBoxTipoTelFunc.Items.Clear();
            foreach (ClassTipo_Telefone_DTO tipo_Telefone_DTO in tipo_Telefone_BLL.ConsultaTipoTelefone())
            {
                cmbBoxTipoTelFunc.Items.Add(tipo_Telefone_DTO);

            }
            

            cmbBoxTipoTelFunc2.Items.Clear();
            foreach (ClassTipo_Telefone_DTO tipo_Telefone_DTO in tipo_Telefone_BLL.ConsultaTipoTelefone())
            {
                cmbBoxTipoTelFunc2.Items.Add(tipo_Telefone_DTO);
            }
           


            acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == ClassAcaoNaTela.Inserir)
            {
                this.Text = "Inserir novo funcionário";

                cmbBoxTipoTelFunc.SelectedIndex = 0;
                cmbBoxTipoTelFunc2.SelectedIndex = 0;
                cmbBoxGrupo.SelectedIndex = 0;
            }
            else if (acaoNaTela == ClassAcaoNaTela.Atualizar)
            {
                this.Text = "Atualizar funcionário";
                //Passando os valores para os textbox
                //Endereço
                if (!(classFuncionario_DTO.classEndereco_DTO.ID_Endereco == 0)) { ID_Endereco = classFuncionario_DTO.classEndereco_DTO.ID_Endereco; }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.CEP_Ende) != null) { mkdTxtBoxCEPFunc.Text = classFuncionario_DTO.classEndereco_DTO.CEP_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Endereco_Ende) != null) { txtBoxEndFunc.Text = classFuncionario_DTO.classEndereco_DTO.Endereco_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Numero_Ende) != null) { mkdTxtBoxNumFunc.Text = classFuncionario_DTO.classEndereco_DTO.Numero_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Complemento_Ende) != null) { txtBoxComplFunc.Text = classFuncionario_DTO.classEndereco_DTO.Complemento_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Bairro_Ende) != null) { txtBoxBairroFunc.Text = classFuncionario_DTO.classEndereco_DTO.Bairro_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Cidade_Ende) != null) { txtBoxCidFunc.Text = classFuncionario_DTO.classEndereco_DTO.Cidade_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.UF_Ende) != null) { cmbBoxUFFunc.Text = classFuncionario_DTO.classEndereco_DTO.UF_Ende.ToString(); }
                //Funcionário
                if (!(classFuncionario_DTO.ID_Funcionario == 0)) { ID_Funcionario = classFuncionario_DTO.ID_Funcionario; }
                if (Convert.ToString(classFuncionario_DTO.Nome_Func) != null) { txtBoxNomeFunc.Text = classFuncionario_DTO.Nome_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.RG_Func) != null) { txtBoxRGFunc.Text = classFuncionario_DTO.RG_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.CPF_Func) != null) { mkdTxtBoxCPFFunc.Text = classFuncionario_DTO.CPF_Func.ToString(); }
                if(Convert.ToString(classFuncionario_DTO.Email_Func)!=null) {txtBoxEmailFunc.Text = classFuncionario_DTO.Email_Func.ToString();}
                if (Convert.ToString(classFuncionario_DTO.classGrupo_DTO.Descricao_Grup) != null) { cmbBoxGrupo.Text = classFuncionario_DTO.classGrupo_DTO.Descricao_Grup.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.DataNasc_Func) != null) { DateTimeDatNascFunc.Text = classFuncionario_DTO.DataNasc_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.DataAdmissao_Func) != null) { DateTimeAdmsFunc.Text = classFuncionario_DTO.DataAdmissao_Func.ToString(); }
                //Cargo
                if (!(classFuncionario_DTO.classCargo_DTO.ID_Cargo == 0)) { ID_Cargo = classFuncionario_DTO.classCargo_DTO.ID_Cargo; }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Funcao_Carg) != null) { txtBoxFuncaoFunc.Text = classFuncionario_DTO.classCargo_DTO.Funcao_Carg.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Salario_Carg) != null) { TxtBoxSalFunc.Text = classFuncionario_DTO.classCargo_DTO.Salario_Carg.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Horario_Entrada_Carg) != null) { msktxtBoxHrEntrFunc.Text = classFuncionario_DTO.classCargo_DTO.Horario_Entrada_Carg.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Horario_Saida_Carg) != null) { msktxtBoxHrSaidFunc.Text = classFuncionario_DTO.classCargo_DTO.Horario_Saida_Carg.ToString(); }
                //Telefone
                if (!(classFuncionario_DTO.classTelefone_DTO.ID_Telefone == 0)) { ID_Telefone = classFuncionario_DTO.classTelefone_DTO.ID_Telefone; }
                if (!(classFuncionario_DTO.classTelefone_DTO.DDD_Tele == 0)) { mkdTxtBoxDDDFunc.Text = classFuncionario_DTO.classTelefone_DTO.DDD_Tele.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classTelefone_DTO.Telefone_Tele) != null) { mkdTxtBoxTeleFunc.Text = classFuncionario_DTO.classTelefone_DTO.Telefone_Tele.ToString(); }
                //Tipo de telefone
                if (!(classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone == 0)) { ID_Tipo_Telefone = classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone; }
                if (Convert.ToString(classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele) != null) { cmbBoxTipoTelFunc.Text = classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele.ToString(); }
                //Login
                DataTable Tabela = new DataTable();
                Tabela = classLogin_BLL.BuscarFuncionarioLog(classFuncionario_DTO.ID_Funcionario);
                if (Tabela.Rows.Count > 0)
                {
                    txtSenhaUsu.UseSystemPasswordChar = true;
                    checkPermlog.Checked = true;
                    txtSenhaUsu.Text = Tabela.Rows[0][1].ToString();
                }
               
            }
            else if (acaoNaTela == ClassAcaoNaTela.Consultar)
            {
                this.Text = "Consultar funcionário";
                //Passando os valores para os textbox
                //Endereço
                if (!(classFuncionario_DTO.classEndereco_DTO.ID_Endereco == 0)) { ID_Endereco = classFuncionario_DTO.classEndereco_DTO.ID_Endereco; }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.CEP_Ende) != null) { mkdTxtBoxCEPFunc.Text = classFuncionario_DTO.classEndereco_DTO.CEP_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Endereco_Ende) != null) { txtBoxEndFunc.Text = classFuncionario_DTO.classEndereco_DTO.Endereco_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Numero_Ende) != null) { mkdTxtBoxNumFunc.Text = classFuncionario_DTO.classEndereco_DTO.Numero_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Complemento_Ende) != null) { txtBoxComplFunc.Text = classFuncionario_DTO.classEndereco_DTO.Complemento_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Bairro_Ende) != null) { txtBoxBairroFunc.Text = classFuncionario_DTO.classEndereco_DTO.Bairro_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.Cidade_Ende) != null) { txtBoxCidFunc.Text = classFuncionario_DTO.classEndereco_DTO.Cidade_Ende.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classEndereco_DTO.UF_Ende) != null) { cmbBoxUFFunc.Text = classFuncionario_DTO.classEndereco_DTO.UF_Ende.ToString(); }
                //Funcionário
                if (!(classFuncionario_DTO.ID_Funcionario == 0)) { ID_Funcionario = classFuncionario_DTO.ID_Funcionario; }
                if (Convert.ToString(classFuncionario_DTO.Nome_Func) != null) { txtBoxNomeFunc.Text = classFuncionario_DTO.Nome_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.RG_Func) != null) { txtBoxRGFunc.Text = classFuncionario_DTO.RG_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.CPF_Func) != null) { mkdTxtBoxCPFFunc.Text = classFuncionario_DTO.CPF_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.Email_Func) != null) { txtBoxEmailFunc.Text = classFuncionario_DTO.Email_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classGrupo_DTO.Descricao_Grup) != null) { cmbBoxGrupo.Text = classFuncionario_DTO.classGrupo_DTO.Descricao_Grup.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.DataNasc_Func) != null) { DateTimeDatNascFunc.Text = classFuncionario_DTO.DataNasc_Func.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.DataAdmissao_Func) != null) { DateTimeAdmsFunc.Text = classFuncionario_DTO.DataAdmissao_Func.ToString(); }
                //Cargo
                if (!(classFuncionario_DTO.classCargo_DTO.ID_Cargo == 0)) { ID_Cargo = classFuncionario_DTO.classCargo_DTO.ID_Cargo; }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Funcao_Carg) != null) { txtBoxFuncaoFunc.Text = classFuncionario_DTO.classCargo_DTO.Funcao_Carg.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Salario_Carg) != null) { TxtBoxSalFunc.Text = classFuncionario_DTO.classCargo_DTO.Salario_Carg.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Horario_Entrada_Carg) != null) { msktxtBoxHrEntrFunc.Text = classFuncionario_DTO.classCargo_DTO.Horario_Entrada_Carg.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classCargo_DTO.Horario_Saida_Carg) != null) { msktxtBoxHrSaidFunc.Text = classFuncionario_DTO.classCargo_DTO.Horario_Saida_Carg.ToString(); }
                //Telefone
                if (!(classFuncionario_DTO.classTelefone_DTO.ID_Telefone == 0)) { ID_Telefone = classFuncionario_DTO.classTelefone_DTO.ID_Telefone; }
                if (!(classFuncionario_DTO.classTelefone_DTO.DDD_Tele == 0)) { mkdTxtBoxDDDFunc.Text = classFuncionario_DTO.classTelefone_DTO.DDD_Tele.ToString(); }
                if (Convert.ToString(classFuncionario_DTO.classTelefone_DTO.Telefone_Tele) != null) { mkdTxtBoxTeleFunc.Text = classFuncionario_DTO.classTelefone_DTO.Telefone_Tele.ToString(); }
                //Tipo de telefone
                if (!(classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone == 0)) { ID_Tipo_Telefone = classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.ID_Tipo_Telefone; }
                if (Convert.ToString(classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele) != null) { cmbBoxTipoTelFunc.Text = classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone.Descricao_TTele.ToString(); }
                //Login
                DataTable Tabela = new DataTable();
                Tabela = classLogin_BLL.BuscarFuncionarioLog(classFuncionario_DTO.ID_Funcionario);
                if (Tabela.Rows.Count > 0)
                {
                    txtSenhaUsu.UseSystemPasswordChar = true;
                    checkPermlog.Checked = true;
                    txtSenhaUsu.Text = Tabela.Rows[0][1].ToString();
                }

                //Desabilitar campos na tela
                mkdTxtBoxCEPFunc.TabStop = false;
                txtBoxEndFunc.TabStop = false;
                mkdTxtBoxNumFunc.TabStop = false;
                txtBoxComplFunc.TabStop = false;
                txtBoxBairroFunc.TabStop = false;
                txtBoxCidFunc.TabStop = false;
                cmbBoxUFFunc.TabStop = false;
                txtBoxNomeFunc.TabStop = false;
                txtBoxRGFunc.TabStop = false;
                mkdTxtBoxCPFFunc.TabStop = false;
                txtBoxEmailFunc.TabStop = false;
                DateTimeDatNascFunc.TabStop = false;
                DateTimeAdmsFunc.TabStop = false;
                txtBoxFuncaoFunc.TabStop = false;
                TxtBoxSalFunc.TabStop = false;
                msktxtBoxHrEntrFunc.TabStop = false;
                msktxtBoxHrSaidFunc.TabStop = false;
                cmbBoxTipoTelFunc.TabStop = false;
                mkdTxtBoxDDDFunc.TabStop = false;
                mkdTxtBoxTeleFunc.TabStop = false;
                btnSalvarFunc.Visible = false;
                btnAtivaTelefone.Visible = false;
                checkPermlog.Enabled = false;

                txtSenhaUsu.Enabled = true;
                txtSenhaUsu.ReadOnly = true;
                mkdTxtBoxCEPFunc.ReadOnly = true;
                txtBoxEndFunc.ReadOnly = true;
                mkdTxtBoxNumFunc.ReadOnly = true;
                txtBoxComplFunc.ReadOnly = true;
                txtBoxBairroFunc.ReadOnly = true;
                txtBoxCidFunc.ReadOnly = true;
                cmbBoxUFFunc.Enabled = false;
                txtBoxNomeFunc.ReadOnly = true;
                txtBoxRGFunc.ReadOnly = true;
                mkdTxtBoxCPFFunc.ReadOnly = true;
                txtBoxEmailFunc.ReadOnly = true;
                cmbBoxGrupo.Enabled = false;
                DateTimeDatNascFunc.Enabled = false;
                DateTimeAdmsFunc.Enabled = false;
                txtBoxFuncaoFunc.ReadOnly = true;
                TxtBoxSalFunc.ReadOnly = true;
                msktxtBoxHrEntrFunc.ReadOnly = true;
                msktxtBoxHrSaidFunc.ReadOnly = true;
                cmbBoxTipoTelFunc.Enabled = false;
                mkdTxtBoxDDDFunc.ReadOnly = true;
                mkdTxtBoxTeleFunc.ReadOnly = true;
                btnCancelarCadFunc.Text = "Fechar";
                btnCancelarCadFunc.Focus();
            }
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
           
        }
        private void btnMinimizarFunc_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnFecharFunc_Click(object sender, EventArgs e)
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
        private void btnCancelarCadFunc_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
           
            DDD = TirarFormatacao(mkdTxtBoxDDDFunc);
            DDD2 = TirarFormatacao(mkdTxtBoxDDDFunc2);
            Telefone = TirarFormatacao(mkdTxtBoxTeleFunc);
            Numero = TirarFormatacao(mkdTxtBoxNumFunc);
            HREntrada = msktxtBoxHrEntrFunc.Text;
            HRSaida = msktxtBoxHrSaidFunc.Text;

            

            if (!Validar())
            {
                return;
            }

            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Inserir)
            {
                //passando valores para o construtor
                ClassFuncionario_DTO classFuncionario_DTO = new ClassFuncionario_DTO(mkdTxtBoxCEPFunc.Text.Trim(), txtBoxEndFunc.Text, Convert.ToInt32(Numero), txtBoxComplFunc.Text, txtBoxBairroFunc.Text, txtBoxCidFunc.Text, cmbBoxUFFunc.Text,
                txtBoxNomeFunc.Text, txtBoxRGFunc.Text, mkdTxtBoxCPFFunc.Text.Trim(), txtBoxEmailFunc.Text,Convert.ToDateTime(DateTimeAdmsFunc.Text),Convert.ToDateTime(DateTimeDatNascFunc.Text),
                ((ClassGrupo_DTO)cmbBoxGrupo.SelectedItem).ID_Grupo,
                txtBoxFuncaoFunc.Text, Convert.ToDecimal(TxtBoxSalFunc.Text), HREntrada, HRSaida);
                String IDFuncionario = classFuncionario_BLL.InserirFuncionario(classFuncionario_DTO);

                classFuncionario_DTO.classTelefone_DTO = new ClassTelefone_DTO(0, Convert.ToInt32(IDFuncionario), Convert.ToInt32(DDD), mkdTxtBoxTeleFunc.Text);

                ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelFunc.SelectedItem).ID_Tipo_Telefone);

                classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                String IDTelefone = classTelefone_BLL.InserirTelefone(classFuncionario_DTO.classTelefone_DTO);

                if (btnAtivaTelefone.Enabled.Equals(false) && mkdTxtBoxDDDFunc2.TextLength > 0 && mkdTxtBoxTeleFunc2.TextLength > 0)
                {
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelFunc2.SelectedItem).ID_Tipo_Telefone);
                    classFuncionario_DTO.classTelefone_DTO = new ClassTelefone_DTO(0, Convert.ToInt32(IDFuncionario), Convert.ToInt32(DDD2), mkdTxtBoxTeleFunc2.Text);
                    classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone2 = classTelefone_BLL.InserirTelefone(classFuncionario_DTO.classTelefone_DTO);
                }
                
                if (checkPermlog.Checked == true)
                {
                    ClassLogin_DTO classLogin_DTO = new ClassLogin_DTO();
                    classLogin_DTO.classFuncionario_DTO = new ClassFuncionario_DTO();
                    classLogin_DTO.ClassCliente_DTO = new ClassCliente_DTO();
                    classLogin_DTO.ClassCliente_DTO.ID_Cliente = 0;
                    classLogin_DTO.classFuncionario_DTO.ID_Funcionario = Convert.ToInt32(IDFuncionario);
                    classLogin_DTO.Senha_Log = txtSenhaUsu.Text;
                    IDLog = classLogin_BLL.InserirLogin(classLogin_DTO);
                }
                try
                {
                    Int32 IDLogin = Convert.ToInt32(IDLog);
                    Int32 ID = Convert.ToInt32(IDFuncionario);
                    Int32 IDT = Convert.ToInt32(IDTelefone);
                    MessageBox.Show("Funcionário cadastrado com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar. Detalhes: \n" + ID_Funcionario + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }

            else if (acaoNaTelaSelecionada == ClassAcaoNaTela.Atualizar)
            {
                
                //passando valores para o construtor
                ClassFuncionario_DTO classFuncionario_DTO = new ClassFuncionario_DTO(ID_Endereco, mkdTxtBoxCEPFunc.Text, txtBoxEndFunc.Text, Convert.ToInt32(Numero), txtBoxComplFunc.Text, txtBoxBairroFunc.Text, txtBoxCidFunc.Text, cmbBoxUFFunc.Text,
                ID_Funcionario, txtBoxNomeFunc.Text, txtBoxRGFunc.Text, mkdTxtBoxCPFFunc.Text.Trim(), txtBoxEmailFunc.Text, Convert.ToDateTime(DateTimeAdmsFunc.Text), Convert.ToDateTime(DateTimeDatNascFunc.Text),
                ((ClassGrupo_DTO)cmbBoxGrupo.SelectedItem).ID_Grupo,
                ID_Cargo, txtBoxFuncaoFunc.Text, Convert.ToDecimal(TxtBoxSalFunc.Text), HREntrada, HRSaida);
                String IDFuncionario = classFuncionario_BLL.AtualizarFuncionario(classFuncionario_DTO);


                if (ID_Telefone.Equals(0))
                {
                    classFuncionario_DTO.classTelefone_DTO = new ClassTelefone_DTO(0, Convert.ToInt32(IDFuncionario), Convert.ToInt32(mkdTxtBoxDDDFunc.Text.Replace("(", "").Replace(")", "").Trim()), mkdTxtBoxTeleFunc.Text.Replace("-", "").Trim());
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelFunc.SelectedItem).ID_Tipo_Telefone);
                    classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone = classTelefone_BLL.InserirTelefone(classFuncionario_DTO.classTelefone_DTO);
                }
                else
                {
                    classFuncionario_DTO.classTelefone_DTO = new ClassTelefone_DTO(ID_Telefone, Convert.ToInt32(DDD), mkdTxtBoxTeleFunc.Text);
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelFunc.SelectedItem).ID_Tipo_Telefone);
                    classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone = classTelefone_BLL.AtualizarTelefone(classFuncionario_DTO.classTelefone_DTO);
                }          

                if (btnAtivaTelefone.Enabled.Equals(false) && mkdTxtBoxDDDFunc2.TextLength > 0 && mkdTxtBoxTeleFunc2.TextLength > 0)
                {
                    ID_Tipo_Telefone = Convert.ToInt32(((ClassTipo_Telefone_DTO)cmbBoxTipoTelFunc2.SelectedItem).ID_Tipo_Telefone);
                    classFuncionario_DTO.classTelefone_DTO = new ClassTelefone_DTO(0, Convert.ToInt32(IDFuncionario), Convert.ToInt32(DDD2), mkdTxtBoxTeleFunc2.Text);
                    classFuncionario_DTO.classTelefone_DTO.classTipo_Telefone = new ClassTipo_Telefone_DTO(ID_Tipo_Telefone);
                    String IDTelefone2 = classTelefone_BLL.InserirTelefone(classFuncionario_DTO.classTelefone_DTO);
                }
                DataTable Tabela = new DataTable();
                Tabela = classLogin_BLL.BuscarFuncionarioLog(Convert.ToInt32(IDFuncionario));
                if (checkPermlog.Checked == true)
                {
                    if (Tabela.Rows.Count <= 0)
                    {
                        ClassLogin_DTO classLogin_DTO = new ClassLogin_DTO();
                        classLogin_DTO.ClassCliente_DTO = new ClassCliente_DTO();
                        classLogin_DTO.ClassCliente_DTO.ID_Cliente = 0;
                        classLogin_DTO.classFuncionario_DTO.ID_Funcionario = Convert.ToInt32(IDFuncionario);
                        classLogin_DTO.Senha_Log = txtSenhaUsu.Text;
                        IDLog = classLogin_BLL.InserirLogin(classLogin_DTO);
                    }
                }
                else
                {
                    IDLog = classLogin_BLL.ExcluirLogin(Convert.ToInt32(IDFuncionario));
                }
            
                try
                {
                    Int32 IDLogin = Convert.ToInt32(IDLog);
                    Int32 ID = Convert.ToInt32(IDFuncionario);
                    MessageBox.Show("Funcionário foi atualizado com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar. Detalhes: \n" + IDFuncionario + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

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
            //Horário de saida
            if (HRSaida.Equals(string.Empty) || HRSaida.Trim().Equals(":"))
            {
                valida = false;
                //selecionando tab Cargo
                tabControlCadFunc.SelectTab(tabPageCargo);
                msktxtBoxHrSaidFunc.Focus();
                lblMsgHrSaida.ForeColor = Color.Red;
            }
            if (!HRSaida.Equals(string.Empty) || HRSaida.Trim().Equals(":"))
            {
                lblMsgHrSaida.ForeColor = Color.Black;
            }
            //Horário de entrada
            if (HREntrada.Equals(String.Empty) || HREntrada.Trim().Equals(":"))
            {
                valida = false;
                //selecionando tab Cargo
                tabControlCadFunc.SelectTab(tabPageCargo);
                msktxtBoxHrEntrFunc.Focus();
                lblMsgHrEntrada.ForeColor = Color.Red;
            }
            if (!HREntrada.Equals(String.Empty) || HREntrada.Trim().Equals(":"))
            {
                lblMsgHrEntrada.ForeColor = Color.Black;
            }
            //Salário
            if (TxtBoxSalFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Cargo
                tabControlCadFunc.SelectTab(tabPageCargo);
                TxtBoxSalFunc.Focus();
                lblMsgSalario.ForeColor = Color.Red;
            }
            if (!TxtBoxSalFunc.Text.Equals(String.Empty))
            {
                lblMsgSalario.ForeColor = Color.Black;
            }
            //Função
            if (txtBoxFuncaoFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Cargo
                tabControlCadFunc.SelectTab(tabPageCargo);
                txtBoxFuncaoFunc.Focus();
                lblMsgFuncao.ForeColor = Color.Red;
            }
            if (!txtBoxFuncaoFunc.Text.Equals(String.Empty))
            {
                lblMsgFuncao.ForeColor = Color.Black;
            }

            //UF
            if (cmbBoxUFFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Endereço
                tabControlCadFunc.SelectTab(tabPageEndereco);
                cmbBoxUFFunc.Focus();
                lblMsgUF.ForeColor = Color.Red;
            }
            if (!cmbBoxUFFunc.Text.Equals(String.Empty))
            {
                lblMsgUF.ForeColor = Color.Black;
            }
            //Cidade
            if (txtBoxCidFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Endereço
                tabControlCadFunc.SelectTab(tabPageEndereco);
                txtBoxCidFunc.Focus();
                lblMsgCidade.ForeColor = Color.Red;
            }
            if (!txtBoxCidFunc.Text.Equals(String.Empty))
            {
                lblMsgCidade.ForeColor = Color.Black;
            }
            //Bairro
            if (txtBoxBairroFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Endereço
                tabControlCadFunc.SelectTab(tabPageEndereco);
                txtBoxBairroFunc.Focus();
                lblMsgBairro.ForeColor = Color.Red;
            }
            if (!txtBoxBairroFunc.Text.Equals(String.Empty))
            {
                lblMsgBairro.ForeColor = Color.Black;
            }
            //Número
            if (Numero.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Endereço
                tabControlCadFunc.SelectTab(tabPageEndereco);
                mkdTxtBoxNumFunc.Focus();
                lblMsgNumero.ForeColor = Color.Red;
            }
            if (!Numero.Equals(String.Empty))
            {
                lblMsgNumero.ForeColor = Color.Black;
            }
            //Endereço
            if (txtBoxEndFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Endereço
                tabControlCadFunc.SelectTab(tabPageEndereco);
                txtBoxEndFunc.Focus();
                lblMsgEndereco.ForeColor = Color.Red;
            }
            if (!txtBoxEndFunc.Text.Equals(String.Empty))
            {
                lblMsgEndereco.ForeColor = Color.Black;
            }
            //CEP
            if (mkdTxtBoxCEPFunc.Text.Trim().Replace("-","").Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Endereço
                tabControlCadFunc.SelectTab(tabPageEndereco);
                mkdTxtBoxCEPFunc.Focus();
                lblMsgCep.ForeColor = Color.Red;
            }
            if (!mkdTxtBoxCEPFunc.Text.Trim().Replace("-", "").Equals(String.Empty))
            {
                lblMsgCep.ForeColor = Color.Black;
            }
            //tipo de telefone 
            if (cmbBoxTipoTelFunc.Text.Equals("--Selecione--"))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                cmbBoxTipoTelFunc.Focus();
                lblMsgTipoTele.ForeColor = Color.Red;
            }
            if (!cmbBoxTipoTelFunc.Text.Equals("--Selecione--") || cmbBoxTipoTelFunc.Text.Equals(String.Empty))
            {
                lblMsgTipoTele.ForeColor = Color.Black;
            }
            //DDD 
            if (DDD.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                mkdTxtBoxDDDFunc.Focus();
                lblMsgDDD.ForeColor = Color.Red;
            }
            if (!DDD.Equals(String.Empty))
            {
                lblMsgDDD.ForeColor = Color.Black;
            }

            if (Telefone.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                mkdTxtBoxTeleFunc.Focus();
                lblMsgTelefone.ForeColor = Color.Red;
            }
            if (!Telefone.Equals(String.Empty))
            {
                lblMsgTelefone.ForeColor = Color.Black;
            }
            //Dasta Nascimento
            if (DateTimeDatNascFunc.Text.Equals(DateTime.Now.Date.ToString("dd/MM/yyyy")))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                DateTimeDatNascFunc.Focus();
                lblMsgDatNascFunc.ForeColor = Color.Red;
            }
            if (!DateTimeDatNascFunc.Text.Equals(DateTime.Now.Date.ToString("dd/MM/yyyy")))
            {
                lblMsgDatNascFunc.ForeColor = Color.Black;
            }


            if (txtBoxEmailFunc.Text.Equals(String.Empty) || !txtBoxEmailFunc.Text.Contains("@") && !txtBoxEmailFunc.Text.Contains("."))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                txtBoxEmailFunc.Focus();
                lblMsgEmail.ForeColor = Color.Red;
            }
            if (!txtBoxEmailFunc.Text.Equals(String.Empty) && txtBoxEmailFunc.Text.Contains("@") && txtBoxEmailFunc.Text.Contains("."))
            {
                lblMsgEmail.ForeColor = Color.Black;
            }

            if (mkdTxtBoxCEPFunc.Text.Trim().Replace(".","").Replace("-","").Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                mkdTxtBoxCPFFunc.Focus();
                lblMsgCPF.ForeColor = Color.Red;
            }
            if (!mkdTxtBoxCEPFunc.Text.Trim().Replace(".", "").Replace("-", "").Equals(String.Empty))
            {
                lblMsgCPF.ForeColor = Color.Black;
            }

            if (txtBoxRGFunc.Text.Equals(String.Empty))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                txtBoxRGFunc.Focus();
                lblMsgRG.ForeColor = Color.Red;
            }
            if (!txtBoxRGFunc.Text.Equals(String.Empty))
            {
                lblMsgRG.ForeColor = Color.Black;
            }

            if (txtBoxNomeFunc.Text.Equals(string.Empty))
            {
                valida = false;
                //selecionando tab Dados Pessoais
                tabControlCadFunc.SelectTab(tabPageDadosPessoais);
                txtBoxNomeFunc.Focus();
                lblMsgNome.ForeColor = Color.Red;
            }
            if (!txtBoxNomeFunc.Text.Equals(string.Empty))
            {
                lblMsgNome.ForeColor = Color.Black;
            }
            return valida;

        }
        private void lblLinkProximo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //selecionando tab Endereço
            tabControlCadFunc.SelectTab(tabPageEndereco);
        }
        private void btnAtivaTelefone_Click(object sender, EventArgs e)
        {
            lblTipoTelFunc2.Visible = true;
            cmbBoxTipoTelFunc2.Visible = true;
            lblDDDFunc2.Visible = true;
            mkdTxtBoxDDDFunc2.Visible = true;
            lblTelefone2.Visible = true;
            mkdTxtBoxTeleFunc2.Visible = true;
            btnAtivaTelefone.Enabled = false;
        }
        private void cmbBoxTipoTelFunc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTipoTelFunc2.Text != "--Selecione--")
            {
                mkdTxtBoxDDDFunc2.Enabled = true;
                mkdTxtBoxTeleFunc2.Enabled = true;
            }
        }

       
        private void linkLblProxEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //selecionando tab Cargo
            tabControlCadFunc.SelectTab(tabPageCargo);
        }
        private void linkLblVoltarCarg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //selecionando tab Endereço
            tabControlCadFunc.SelectTab(tabPageEndereco);
        }

        private void cmbBoxTipoTelFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBoxTipoTelFunc.Text.Equals("Celular"))
            {
                if (this.mkdTxtBoxTeleFunc.Mask == "0000-9999")
                {
                    this.mkdTxtBoxTeleFunc.Text = "";
                }
                this.mkdTxtBoxTeleFunc.Mask = "00000-9999";
            }
            else if (cmbBoxTipoTelFunc.Text.Equals("Residencial"))
            {
                if (this.mkdTxtBoxTeleFunc.Mask == "00000-9999")
                {
                    this.mkdTxtBoxTeleFunc.Text = "";
                }
                this.mkdTxtBoxTeleFunc.Mask = "0000-9999";
            }
        }

        private void checkPermlog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPermlog.Checked == true)
            {
               Random rnd = new Random();
                Int32 num1;
                num1 = rnd.Next(6);
                Sorteio = Convert.ToString(num1);

                switch (Sorteio)
                {
                    case "0":
                        txtSenhaUsu.Text = "BeUtySpV111";
                        break;

                    case "1":
                        txtSenhaUsu.Text = "Spe203cialBea";
                        break;

                    case "2":
                        txtSenhaUsu.Text = "2B85eau111Sp";
                        break;

                    case "3":
                        txtSenhaUsu.Text = "Specc88753Dalg";
                        break;

                    case "4":
                        txtSenhaUsu.Text = "sp8897Autyz7T";
                        break;

                    case "5":
                        txtSenhaUsu.Text = "Sis7Rt2kjmmk";
                        break;


                }
            }
        }

        private void checkPermlog_Click(object sender, EventArgs e)
        {
            if (checkPermlog.Checked == false)
            {
                txtSenhaUsu.Text = "";
            }
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            try
            {
                checkPermlog.Checked = false;
                IDLog = classLogin_BLL.ExcluirLogin(Convert.ToInt32(ID_Funcionario));
                txtSenhaUsu.Text = "";
                txtSenhaUsu.UseSystemPasswordChar = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao tirar a senha. \n Detalhes:" + ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            


        }

        private void cmbBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxTipoTelFunc2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cmbBoxTipoTelFunc2.Text.Equals("Celular"))
            {
                if (this.mkdTxtBoxTeleFunc2.Mask == "0000-9999")
                {
                    this.mkdTxtBoxTeleFunc2.Text = "";
                }

                this.mkdTxtBoxTeleFunc2.Mask = "00000-9999";
            }
            else if (cmbBoxTipoTelFunc2.Text.Equals("Residencial"))
            {
                if (this.mkdTxtBoxTeleFunc2.Mask == "00000-9999")
                {
                    this.mkdTxtBoxTeleFunc2.Text = "";
                }

                this.mkdTxtBoxTeleFunc2.Mask = "0000-9999";
            }
        }

        private void linkLblVoltarEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //selecionando tab dados pessoais
            tabControlCadFunc.SelectTab(tabPageDadosPessoais);
        }

        private void cmbBoxTipoTelFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTipoTelFunc.Text != "--Selecione--")
            {
                mkdTxtBoxDDDFunc.Enabled = true;
                mkdTxtBoxTeleFunc.Enabled = true;
            }
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
        private void TxtBoxSalFunc_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref TxtBoxSalFunc);
        }

        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
    }
}
