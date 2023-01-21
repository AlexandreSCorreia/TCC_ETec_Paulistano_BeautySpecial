using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using System.Data;
using Ferramentas;

namespace Apresentacao
{
    public partial class FrmProdutos : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmProdutos()
        {
            InitializeComponent();
            //não gerar linhas automaticamente no datagrid
            dataGridProd.AutoGenerateColumns = false;
        }

        //Variaveis que guardao as permissoes
        Boolean perInserir = false; Boolean perAtualizar = false; Boolean perExcluir = false; Boolean perConsultar = false;

        public void alterarBotoes(int op, Boolean inserir, Boolean atualizar, Boolean excluir, Boolean consultar)
        {
            // op = operacões que seram feitas com os botões
            // 1 = prepara os botões para inserir e localizar
            // 2 =  prepara para inserir/alterar um registro
            // 3 =  prepara a tela para inserir ou alterar

            dataGridProd.Enabled = false;

            btnNovoProd.Enabled = false;
            btnNovoProd.BackColor = Color.Gainsboro;

            btnAtualizarProd.Enabled = false;
            btnAtualizarProd.BackColor = Color.Gainsboro;

            btnExcluirProd.Enabled = false;
            btnExcluirProd.BackColor = Color.Gainsboro;

            btnPesquisarProd.Enabled = false;
            btnPesquisarProd.BackColor = Color.Gainsboro;

            btnConsultarProd.Enabled = false;
            btnConsultarProd.BackColor = Color.Gainsboro;

            txtBoxPesqProd.Enabled = false;

            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.Gainsboro;

            if (op == 1)
            {
                btnNovoProd.Enabled = inserir;
                if (btnNovoProd.Enabled == false) { btnNovoProd.BackColor = Color.Gainsboro; } else {btnNovoProd.BackColor = Color.MediumSlateBlue; }
                btnPesquisarProd.Enabled = true;
                if (btnPesquisarProd.Enabled == false) {btnPesquisarProd.BackColor = Color.Gainsboro; } else {btnPesquisarProd.BackColor = Color.MediumSlateBlue; }
                txtBoxPesqProd.Enabled = true;
            }
            if (op == 2)
            {
                dataGridProd.Enabled = true;
                btnConsultarProd.Enabled = true;
                if (btnConsultarProd.Enabled == false) {btnConsultarProd.BackColor = Color.Gainsboro; } else {btnConsultarProd.BackColor = Color.MediumSlateBlue; }
            }
            if (op == 3)
            {
                dataGridProd.Enabled = true;
                btnAtualizarProd.Enabled = atualizar;
                if (btnAtualizarProd.Enabled == false) {btnAtualizarProd.BackColor = Color.Gainsboro; } else {btnAtualizarProd.BackColor = Color.MediumSlateBlue; }
                btnConsultarProd.Enabled = true;
                if (btnConsultarProd.Enabled == false) {btnConsultarProd.BackColor = Color.Gainsboro; } else {btnConsultarProd.BackColor = Color.MediumSlateBlue; }
                btnExcluirProd.Enabled = excluir;
                if (btnExcluirProd.Enabled == false) {btnExcluirProd.BackColor = Color.Gainsboro; } else {btnExcluirProd.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = true;
                if (btnCancelar.Enabled == false) {btnCancelar.BackColor = Color.Gainsboro; } else {btnCancelar.BackColor = Color.MediumSlateBlue; }
            }
        }
        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            Permissao_BLL permissaousuarioBLL = new Permissao_BLL();

            DataTable Tabela = new DataTable();

            Tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.FuncID, this.Name.ToString());

            //Carregar as permissoes
            if(Tabela.Rows.Count > 0) { perInserir = Convert.ToBoolean(Tabela.Rows[0][4]);}
            if(Tabela.Rows.Count > 0) {perAtualizar = Convert.ToBoolean(Tabela.Rows[0][5]);}
            if(Tabela.Rows.Count > 0) {perExcluir = Convert.ToBoolean(Tabela.Rows[0][6]);}
            if(Tabela.Rows.Count > 0) {perConsultar = Convert.ToBoolean(Tabela.Rows[0][7]);}

            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        private void btnMinimizarProd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharProd_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AtualizarGrid()
        {

            ClassProduto_BLL classProduto_Bll = new ClassProduto_BLL();
            ClassProdutoCollection_DTO produtocolecao = new ClassProdutoCollection_DTO();

            produtocolecao = classProduto_Bll.ConsultaPorNome(txtBoxPesqProd.Text);


            //limpar dados que já estão no grid
            dataGridProd.DataSource = null;
            dataGridProd.DataSource = produtocolecao;

            dataGridProd.Update();
            dataGridProd.Refresh();

        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            //Chamar Função checa permissões
            alterarBotoes(3, perInserir, perAtualizar, perExcluir, perConsultar);
        }


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

        private void dataGridProd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridProd.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridProd.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dataGridProd.Rows[e.RowIndex].DataBoundItem, dataGridProd.Columns[e.ColumnIndex].DataPropertyName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (dataGridProd.SelectedRows.Count.Equals(0))
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

            //Pegar o produto selecionado
            ClassProduto_DTO ProdutoSelecionado = (dataGridProd.SelectedRows[0].DataBoundItem as ClassProduto_DTO);
            //Instanciar regra de negocios
            ClassProduto_BLL classProduto_BLL = new ClassProduto_BLL();
            //Chamar metodo de Excluir
            String Retorno = classProduto_BLL.ExcluirProduto(ProdutoSelecionado);
            //Vereficar se excluiu com sucesso
            //Se o retorno for um numero significa que deu tudo certo se não deu algum erro
            try
            {
                Int32 IDProduto = Convert.ToInt32(Retorno);
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

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            //Instanciar Formulario de cadastro
            FrmCadProdutos cadastrodeprodutos = new FrmCadProdutos(ClassAcaoNaTela.Inserir, null);
            DialogResult dialogResult = cadastrodeprodutos.ShowDialog();
            txtBoxPesqProd.Text = "";
            if (dialogResult.Equals(DialogResult.Yes))
            {
                btnCancelar_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
        }

        private void btnAtualizarProd_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (dataGridProd.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o produto selecionado
            ClassProduto_DTO ProdutoSelecionado = (dataGridProd.SelectedRows[0].DataBoundItem as ClassProduto_DTO);
            //Instanciar Formulario de cadastro
            FrmCadProdutos cadastrodeprodutos = new FrmCadProdutos(ClassAcaoNaTela.Atualizar, ProdutoSelecionado);
            DialogResult dialogResult = cadastrodeprodutos.ShowDialog();

            if (dialogResult.Equals(DialogResult.Yes))
            {
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
            btnCancelar_Click(sender, e);
        }

        private void btnConsultarProd_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (dataGridProd.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o produto selecionado
            ClassProduto_DTO  ProdutoSelecionado = (dataGridProd.SelectedRows[0].DataBoundItem as ClassProduto_DTO);
            //Instanciar Formulario de cadastro
            FrmCadProdutos cadastrodeprodutos = new FrmCadProdutos(ClassAcaoNaTela.Consultar, ProdutoSelecionado);
            cadastrodeprodutos.ShowDialog();
            btnCancelar_Click(sender, e);
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);
        }

        private void MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }

        private void MoveForm_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void txtBoxPesqProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                AtualizarGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridProd.DataSource = null;
            txtBoxPesqProd.Text = "";
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }
    }
}
