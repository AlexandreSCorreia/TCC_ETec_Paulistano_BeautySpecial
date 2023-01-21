using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmControleComanda : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmControleComanda()
        {
            InitializeComponent();
            //não gerar linhas automaticamente no datagrid
            DataGridContCom.AutoGenerateColumns = false;
        }
        //Variaveis que guardao as permissoes
        Boolean perInserir = false; Boolean perAtualizar = false; Boolean perExcluir = false; Boolean perConsultar = false;
        //validando Permissões
        public void alterarBotoes(int op, Boolean inserir, Boolean atualizar, Boolean excluir, Boolean consultar)
        {
            // op = operacões que seram feitas com os botões
            // 1 = prepara os botões para inserir e localizar
            // 2 =  prepara para inserir/alterar um registro
            // 3 =  prepara a tela para inserir ou alterar

            DataGridContCom.Enabled = false;
            btnNovoContCom.Enabled = false;
            btnNovoContCom.BackColor = Color.Gainsboro;
            btnAtualizarContCom.Enabled = false;
            btnAtualizarContCom.BackColor = Color.Gainsboro;
            btnExcluirContCom.Enabled = false;
            btnExcluirContCom.BackColor = Color.Gainsboro;
            btnPesquisarContCom.Enabled = false;
            btnPesquisarContCom.BackColor = Color.Gainsboro;
            btnConsultarContCom.Enabled = false;
            btnConsultarContCom.BackColor = Color.Gainsboro;
            txtBoxPesqContCom.Enabled = false;
            btnCancelarContCom.Enabled = false;
            btnCancelarContCom.BackColor = Color.Gainsboro;

            if (op == 1)
            {
                btnNovoContCom.Enabled = inserir;
                if (btnNovoContCom.Enabled == false) { btnNovoContCom.BackColor = Color.Gainsboro; } else { btnNovoContCom.BackColor = Color.MediumSlateBlue; }
                btnPesquisarContCom.Enabled = true;
                if (btnPesquisarContCom.Enabled == false) { btnPesquisarContCom.BackColor = Color.Gainsboro; } else { btnPesquisarContCom.BackColor = Color.MediumSlateBlue; }
                txtBoxPesqContCom.Enabled = true;
            }
            if (op == 2)
            {
                DataGridContCom.Enabled = true;

                btnConsultarContCom.Enabled = true;
                if (btnConsultarContCom.Enabled == false) { btnConsultarContCom.BackColor = Color.Gainsboro; } else { btnConsultarContCom.BackColor = Color.MediumSlateBlue; }
            }
            if (op == 3)
            {
                DataGridContCom.Enabled = true;

                btnAtualizarContCom.Enabled = atualizar;
                if (btnAtualizarContCom.Enabled == false) { btnAtualizarContCom.BackColor = Color.Gainsboro; } else { btnAtualizarContCom.BackColor = Color.MediumSlateBlue; }
                btnConsultarContCom.Enabled = true;
                if (btnConsultarContCom.Enabled == false) { btnConsultarContCom.BackColor = Color.Gainsboro; } else { btnConsultarContCom.BackColor = Color.MediumSlateBlue; }
                btnExcluirContCom.Enabled = excluir;
                if (btnExcluirContCom.Enabled == false) { btnExcluirContCom.BackColor = Color.Gainsboro; } else { btnExcluirContCom.BackColor = Color.MediumSlateBlue; }
                btnCancelarContCom.Enabled = true;
                if (btnCancelarContCom.Enabled == false) { btnCancelarContCom.BackColor = Color.Gainsboro; } else { btnCancelarContCom.BackColor = Color.MediumSlateBlue; }
            }
        }
     
        private void FrmControleComanda_Load(object sender, EventArgs e)
        {
            //buscando Permissões
            Permissao_BLL permissaousuarioBLL = new Permissao_BLL();
            DataTable Tabela = new DataTable();
            Tabela = permissaousuarioBLL.LocalizarPermissao(SessaoUsuario.Session.Instance.FuncID, this.Name.ToString());
            //Carregar as permissoes
            if (Tabela.Rows.Count > 0) { perInserir = Convert.ToBoolean(Tabela.Rows[0][4]); }
            if (Tabela.Rows.Count > 0) { perAtualizar = Convert.ToBoolean(Tabela.Rows[0][5]); }
            if (Tabela.Rows.Count > 0) { perExcluir = Convert.ToBoolean(Tabela.Rows[0][6]); }
            if (Tabela.Rows.Count > 0) { perConsultar = Convert.ToBoolean(Tabela.Rows[0][7]); }
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

        private void btnPesquisarContCom_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            //Chamar Função checa permissões
            alterarBotoes(3, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        //Botão Excluir
        private void btnExcluirContCom_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridContCom.SelectedRows.Count.Equals(0))
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

           //Pegar o Comanda Selecionado
            ClassComanda_DTO ComandaSelecionado = (DataGridContCom.SelectedRows[0].DataBoundItem as ClassComanda_DTO);
            //Instanciar regra de negocios
            ClassComanda_BLL classComanda_BLL = new ClassComanda_BLL();
            //Chamar metodo de Excluir
            String Retorno = classComanda_BLL.ExcluirComanda(ComandaSelecionado);
            //Vereficar se excluiu com sucesso
            //Se o retorno for um numero significa que deu tudo certo se não deu algum erro
            try
            {
                Convert.ToInt32(Retorno);
                btnCancelarContCom_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel excluir. Detalhes:" + Retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCancelarContCom_Click(sender, e);
        }

        //Botão para fazer Novo cadastro
        private void btnNovoContCom_Click(object sender, EventArgs e)
        {
            //Instanciar Formulario de cadastro
            FrmCadComanda frmComanda = new FrmCadComanda(ClassAcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmComanda.ShowDialog();
            txtBoxPesqContCom.Text = "";
            if (dialogResult == DialogResult.Yes)
            {
                btnCancelarContCom_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
        }

        //Botão para atualizar dados
        private void btnAtualizarContCom_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridContCom.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar a comanda selecionado
            ClassComanda_DTO ComandaSelecionado = (DataGridContCom.SelectedRows[0].DataBoundItem as ClassComanda_DTO);
            //Instanciar Formulario de cadastro
            FrmCadComanda cadastrodecomanda = new FrmCadComanda(ClassAcaoNaTela.Atualizar, ComandaSelecionado);
            DialogResult dialogResult = cadastrodecomanda.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
            }
            btnCancelarContCom_Click(sender, e);
        }
        //Botão para consultar dados
        private void btnConsultarContCom_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridContCom.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar a comanda selecionado
            ClassComanda_DTO ComandaSelecionado = (DataGridContCom.SelectedRows[0].DataBoundItem as ClassComanda_DTO);
            //Instanciar Formulario de cadastro
            FrmCadComanda cadastrodecomanda = new FrmCadComanda(ClassAcaoNaTela.Consultar, ComandaSelecionado);
            cadastrodecomanda.ShowDialog();
            btnCancelarContCom_Click(sender, e);
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        //Atualiza o gridview
        private void AtualizarGrid()
        {

            ClassComanda_BLL classComanda_Bll = new ClassComanda_BLL();
            List<ClassComanda_DTO> comandacolecao = new List<ClassComanda_DTO>();
            comandacolecao = classComanda_Bll.ConsultaPorNome(txtBoxPesqContCom.Text);
            if (comandacolecao != null)
            {
                //limpar dados que já estão no grid
                DataGridContCom.DataSource = null;
                //passando coleção para o Grid
                DataGridContCom.DataSource = comandacolecao;
                //Atualizando o Grid
                DataGridContCom.Update();
                DataGridContCom.Refresh();
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
        private void DataGridContCom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((DataGridContCom.Rows[e.RowIndex].DataBoundItem != null) &&
                    (DataGridContCom.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(DataGridContCom.Rows[e.RowIndex].DataBoundItem, DataGridContCom.Columns[e.ColumnIndex].DataPropertyName);

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

        private void btnCancelarContCom_Click(object sender, EventArgs e)
        {
            DataGridContCom.DataSource = null;
            txtBoxPesqContCom.Text = "";
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }
    }
}
