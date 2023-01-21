using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using System.Data;
using Ferramentas;

namespace Apresentacao
{
    public partial class FrmCliente : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmCliente()
        {
            InitializeComponent();
            //não gerar linhas automaticamente no datagrid
            DataGridCli.AutoGenerateColumns = false;
        }

        //Variaveis que guardao as permissoes
        Boolean perInserir = false; Boolean perAtualizar = false; Boolean perExcluir = false; Boolean perConsultar = false;

        public void alterarBotoes(int op, Boolean inserir, Boolean atualizar, Boolean excluir, Boolean consultar)
        {
            // op = operacões que seram feitas com os botões
            // 1 = prepara os botões para inserir e localizar
            // 2 =  prepara para inserir/alterar um registro
            // 3 =  prepara a tela para inserir ou alterar

            DataGridCli.Enabled = false;
            btnNovoCli.Enabled = false;
            btnNovoCli.BackColor = Color.Gainsboro;
            btnAtualizarCli.Enabled = false;
            btnAtualizarCli.BackColor = Color.Gainsboro;
            btnExcluirCli.Enabled = false;
            btnExcluirCli.BackColor = Color.Gainsboro;
            btnPesquisarCli.Enabled = false;
            btnPesquisarCli.BackColor = Color.Gainsboro;
            btnConsultarCli.Enabled = false;
            btnConsultarCli.BackColor = Color.Gainsboro;
            txtBoxPesqCli.Enabled = false;
            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.Gainsboro;

            if (op == 1)
            {
                btnNovoCli.Enabled = inserir;
                if (btnNovoCli.Enabled == false) { btnNovoCli.BackColor = Color.Gainsboro; } else { btnNovoCli.BackColor = Color.MediumSlateBlue; }
                btnPesquisarCli.Enabled = true;
                if (btnPesquisarCli.Enabled == false) { btnPesquisarCli.BackColor = Color.Gainsboro; } else { btnPesquisarCli.BackColor = Color.MediumSlateBlue; }
                txtBoxPesqCli.Enabled = true;
            }
            if (op == 2)
            {
                DataGridCli.Enabled = true;

                btnConsultarCli.Enabled = true;
                if (btnConsultarCli.Enabled == false) { btnConsultarCli.BackColor = Color.Gainsboro; } else { btnConsultarCli.BackColor = Color.MediumSlateBlue; }
            }
            if (op == 3)
            {
                DataGridCli.Enabled = true;

                btnAtualizarCli.Enabled = atualizar;
                if (btnAtualizarCli.Enabled == false) { btnAtualizarCli.BackColor = Color.Gainsboro; } else { btnAtualizarCli.BackColor = Color.MediumSlateBlue; }
                btnConsultarCli.Enabled = true;
                if (btnConsultarCli.Enabled == false) { btnConsultarCli.BackColor = Color.Gainsboro; } else { btnConsultarCli.BackColor = Color.MediumSlateBlue; }
                btnExcluirCli.Enabled = excluir;
                if (btnExcluirCli.Enabled == false) { btnExcluirCli.BackColor = Color.Gainsboro; } else { btnExcluirCli.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = true;
                if (btnCancelar.Enabled == false) { btnCancelar.BackColor = Color.Gainsboro; } else { btnCancelar.BackColor = Color.MediumSlateBlue; }
            }
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Permissao_BLL permissaousuarioBLL = new Permissao_BLL();

            DataTable Tabela = new DataTable();

            Tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.FuncID, this.Name.ToString());

            //Carregar as permissoes
            if (Tabela.Rows.Count > 0) { perInserir = Convert.ToBoolean(Tabela.Rows[0][4]); }
            if(Tabela.Rows.Count > 0) { perAtualizar = Convert.ToBoolean(Tabela.Rows[0][5]); }
            if(Tabela.Rows.Count > 0) {perExcluir = Convert.ToBoolean(Tabela.Rows[0][6]);}
            if(Tabela.Rows.Count > 0) {perConsultar = Convert.ToBoolean(Tabela.Rows[0][7]);}
            
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        private void btnMinimizarProd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharCli_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnPesquisarCli_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            //Chamar Função checa permissões
            alterarBotoes(3, perInserir, perAtualizar, perExcluir, perConsultar);

        }

        //Botão Excluir
        private void btnExcluirCli_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridCli.SelectedRows.Count.Equals(0))
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

            //Pegar o Cliente Selecionado
            ClassCliente_DTO ClienteSelecionado = (DataGridCli.SelectedRows[0].DataBoundItem as ClassCliente_DTO);
            ClassTelefone_BLL classTelefone_BLL = new ClassTelefone_BLL();
            classTelefone_BLL.ExcluirTelefone(ClienteSelecionado.ID_Cliente, 0);
            //Instanciar regra de negocios
            ClassCliente_BLL classCliente_BLL = new ClassCliente_BLL();
            //Chamar metodo de Excluir
            String Retorno = classCliente_BLL.ExcluirCliente(ClienteSelecionado);
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
        //Botão para fazer Novo cadastro
        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            //Instanciar Formulario de cadastro
            FrmCadCliente cadastrodeclientes = new FrmCadCliente(ClassAcaoNaTela.Inserir, null);
            DialogResult dialogResult = cadastrodeclientes.ShowDialog();
            txtBoxPesqCli.Text = "";
            if (dialogResult == DialogResult.Yes)
            {
                btnCancelar_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
        }
        //Botão para atualizar dados
        private void btnAtualizarCli_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridCli.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o Cliente Selecionado
            ClassCliente_DTO ClienteSelecionado = (DataGridCli.SelectedRows[0].DataBoundItem as ClassCliente_DTO);
            //Instanciar Formulario de cadastro
            FrmCadCliente cadastrodeclientes = new FrmCadCliente(ClassAcaoNaTela.Atualizar, ClienteSelecionado);
            DialogResult dialogResult = cadastrodeclientes.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
            btnCancelar_Click(sender, e);
        }
        //Botão para consultar dados
        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridCli.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o Cliente Selecionado
            ClassCliente_DTO ClienteSelecionado = (DataGridCli.SelectedRows[0].DataBoundItem as ClassCliente_DTO);
            //Instanciar Formulario de cadastro
            FrmCadCliente cadastrodeclientes = new FrmCadCliente(ClassAcaoNaTela.Consultar, ClienteSelecionado);
            cadastrodeclientes.ShowDialog();
            btnCancelar_Click(sender, e);
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }
        //Atualiza o gridview
        private void AtualizarGrid()
        {

            ClassCliente_BLL classCliente_Bll = new ClassCliente_BLL();
            ClassClienteCollection_DTO clientecolecao = new ClassClienteCollection_DTO();

            clientecolecao = classCliente_Bll.ConsultaPorNome(txtBoxPesqCli.Text);

            if (clientecolecao != null)
            {
                //limpar dados que já estão no grid
                DataGridCli.DataSource = null;
                //passando coleção para o Grid
                DataGridCli.DataSource = clientecolecao;
                //Atualizando o Grid
                DataGridCli.Update();
                DataGridCli.Refresh();
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
            //vai implementar o BindProperty do DataGrid no evento
            private void DataGridCli_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                try
                {
                    if ((DataGridCli.Rows[e.RowIndex].DataBoundItem != null) &&
                        (DataGridCli.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                    {
                        e.Value = CarregarPropriedade(DataGridCli.Rows[e.RowIndex].DataBoundItem, DataGridCli.Columns[e.ColumnIndex].DataPropertyName);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
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
            DataGridCli.DataSource = null;
            txtBoxPesqCli.Text = "";
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

       
    }
 }


