using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using Ferramentas;
using System.Data;

namespace Apresentacao
{
    public partial class FrmFuncionario : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmFuncionario()
        {
            InitializeComponent();
            //não gerar linhas automaticamente no datagrid
            DataGridFunc.AutoGenerateColumns = false;

        }
        //Variaveis que guardao as permissoes
        Boolean perInserir = false; Boolean perAtualizar = false; Boolean perExcluir = false; Boolean perConsultar = false;

        public void alterarBotoes(int op, Boolean inserir, Boolean atualizar, Boolean excluir, Boolean consultar)
        {
            // op = operacões que seram feitas com os botões
            // 1 = prepara os botões para inserir e localizar
            // 2 =  prepara para inserir/alterar um registro
            // 3 =  prepara a tela para inserir ou alterar

            DataGridFunc.Enabled = false;

            btnNovoFunc.Enabled = false;
            btnNovoFunc.BackColor = Color.Gainsboro;

            btnAtualizarFunc.Enabled = false;
            btnAtualizarFunc.BackColor = Color.Gainsboro;

            btnExcluirFunc.Enabled = false;
            btnExcluirFunc.BackColor = Color.Gainsboro;

            btnPesquisarFunc.Enabled = false;
            btnPesquisarFunc.BackColor = Color.Gainsboro;

            btnConsultarFunc.Enabled = false;
            btnConsultarFunc.BackColor = Color.Gainsboro;

            txtBoxPesqFunc.Enabled = false;

            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.Gainsboro;

            if (op == 1)
            {
                btnNovoFunc.Enabled = inserir;
                if (btnNovoFunc.Enabled == false) { btnNovoFunc.BackColor = Color.Gainsboro; }  else { btnNovoFunc.BackColor = Color.MediumSlateBlue; }
                btnPesquisarFunc.Enabled = true;
                if (btnPesquisarFunc.Enabled == false) { btnPesquisarFunc.BackColor = Color.Gainsboro; } else {btnPesquisarFunc.BackColor = Color.MediumSlateBlue; }
                txtBoxPesqFunc.Enabled = true;
            }
            if (op == 2)
            {
                DataGridFunc.Enabled = true;
                btnConsultarFunc.Enabled = true;
                if (btnConsultarFunc.Enabled == false) { btnConsultarFunc.BackColor = Color.Gainsboro; } else { btnConsultarFunc.BackColor = Color.MediumSlateBlue; }
            }
            if (op == 3)
            {
                DataGridFunc.Enabled = true;
                btnAtualizarFunc.Enabled = atualizar;
                if (btnAtualizarFunc.Enabled == false) { btnAtualizarFunc.BackColor = Color.Gainsboro; } else { btnAtualizarFunc.BackColor = Color.MediumSlateBlue; }
                btnConsultarFunc.Enabled = true;
                if (btnConsultarFunc.Enabled == false) { btnConsultarFunc.BackColor = Color.Gainsboro; } else { btnConsultarFunc.BackColor = Color.MediumSlateBlue; }
                btnExcluirFunc.Enabled = excluir;
                if (btnExcluirFunc.Enabled == false) { btnExcluirFunc.BackColor = Color.Gainsboro; } else { btnExcluirFunc.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = true;
                if (btnCancelar.Enabled == false) { btnCancelar.BackColor = Color.Gainsboro; } else { btnCancelar.BackColor = Color.MediumSlateBlue; }
            }
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Permissao_BLL permissaousuarioBLL = new Permissao_BLL();

            DataTable Tabela = new DataTable();

            Tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.FuncID, this.Name.ToString());

            //Carregar as permissoes
            if (Tabela.Rows.Count > 0) { perInserir = Convert.ToBoolean(Tabela.Rows[0][4]); }
            if (Tabela.Rows.Count > 0) {perAtualizar = Convert.ToBoolean(Tabela.Rows[0][5]);}
            if (Tabela.Rows.Count > 0) {perExcluir = Convert.ToBoolean(Tabela.Rows[0][6]);}
            if (Tabela.Rows.Count > 0) {perConsultar = Convert.ToBoolean(Tabela.Rows[0][7]);}

            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        private void btnMinimizarProd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharFunc_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnPesquisarFunc_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            //Chamar Função checa permissões
            alterarBotoes(3, perInserir, perAtualizar, perExcluir, perConsultar);
        }
        //Botão Excluir
        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridFunc.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Perguntar se ele quer realmente Excluir
            DialogResult Resultado = MessageBox.Show("Tem Certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
            {
                return;

            }

            //Pegar o funcionario Selecionado
            ClassFuncionario_DTO FuncionarioSelecionado = (DataGridFunc.SelectedRows[0].DataBoundItem as ClassFuncionario_DTO);
            ClassTelefone_BLL classTelefone_BLL = new ClassTelefone_BLL();
            classTelefone_BLL.ExcluirTelefone(0,FuncionarioSelecionado.ID_Funcionario);
            //Instanciar regra de negocios
            ClassFuncionario_BLL classFuncionario_BLL = new ClassFuncionario_BLL();
            //Chamar metodo de Excluir
            String Retorno = classFuncionario_BLL.ExcluirFuncionario(FuncionarioSelecionado);
            //Vereficar se excluiu com sucesso
            //Se o retorno for um numero significa que deu tudo certo se não deu algum erro
            try
            {
                Convert.ToInt32(Retorno);
                btnCancelar_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel excluir. Detalhes:" + Retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCancelar_Click(sender, e);
        }
        //Botão para consultar dados
        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridFunc.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o funcionario Selecionado
            ClassFuncionario_DTO FuncionarioSelecionado = (DataGridFunc.SelectedRows[0].DataBoundItem as ClassFuncionario_DTO);
            //Instanciar Formulario de cadastro
            FrmCadFuncionario cadastrodefuncionarios = new FrmCadFuncionario(ClassAcaoNaTela.Consultar, FuncionarioSelecionado);
            cadastrodefuncionarios.ShowDialog();
            btnCancelar_Click(sender,e);
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }
        //Botão para atualizar dados
        private void btnAtualizarFunc_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridFunc.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o funcionario Selecionado
            ClassFuncionario_DTO FuncionarioSelecionado = (DataGridFunc.SelectedRows[0].DataBoundItem as ClassFuncionario_DTO);
            //Instanciar Formulario de cadastro
            FrmCadFuncionario cadastrodefuncionario = new FrmCadFuncionario(ClassAcaoNaTela.Atualizar, FuncionarioSelecionado);
            DialogResult dialogResult = cadastrodefuncionario.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                //AtualizarGrid();
               
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
            btnCancelar_Click(sender, e);
        }
        //Botão para fazer Novo cadastro
        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            //Instanciar Formulario de cadastro
            FrmCadFuncionario cadastrodefuncionarios = new FrmCadFuncionario(ClassAcaoNaTela.Inserir, null);
            DialogResult dialogResult = cadastrodefuncionarios.ShowDialog();
            txtBoxPesqFunc.Text = "";
            if (dialogResult == DialogResult.Yes)
            {
                //AtualizarGrid();
                btnCancelar_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
        }
      
        //vai implementar o BindProperty do DataGrid no evento
        private void DataGridFunc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((DataGridFunc.Rows[e.RowIndex].DataBoundItem != null) &&
                    (DataGridFunc.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(DataGridFunc.Rows[e.RowIndex].DataBoundItem, DataGridFunc.Columns[e.ColumnIndex].DataPropertyName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //BindProperty 
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";
                //Se dentro do nome da propriedade tem o ponto Ex ClassCliente_DTO.Nome_Clie
                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfArray;
                    String propriedadeAntesDoPonto;
                    //vai pegar a variavel que estou passando vai dar um Substring da primeira letra posição 0 até a ultima letra antes do ponto
                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfArray = propriedade.GetType().GetProperties();
                        foreach (PropertyInfo propertyInfo in propertyInfArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno =
                                    CarregarPropriedade(
                                    propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1)
                                    );
                            }
                        }

                    }
                }
                //Se não achar o ponto
                else
                {
                    Type tpyPropertyType;
                    PropertyInfo pfoPropertyInfo;

                    if (propriedade != null)
                    {
                        tpyPropertyType = propriedade.GetType();
                        pfoPropertyInfo = tpyPropertyType.GetProperty(nomeDaPropriedade);

                        retorno = pfoPropertyInfo.GetValue(propriedade, null);
                    }

                }


                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }
        //Atualiza o gridview
        private void AtualizarGrid()
        {

            ClassFuncionario_BLL classFuncionario_Bll = new ClassFuncionario_BLL();
            ClassFuncionarioCollection_DTO funcionariocolecao = new ClassFuncionarioCollection_DTO();

            funcionariocolecao = classFuncionario_Bll.ConsultaPorNome(txtBoxPesqFunc.Text);
            //limpar dados que já estão no grid
            DataGridFunc.DataSource = null;
            //passando coleção para o Grid
            DataGridFunc.DataSource = funcionariocolecao;
            //Atualizando o Grid
            DataGridFunc.Update();
            DataGridFunc.Refresh();

        }
        private void MoverForm_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);
        }
        private void MoverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }
        private void MoverForm_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DataGridFunc.DataSource = null;
            txtBoxPesqFunc.Text = "";
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }
    }
}
