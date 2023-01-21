using System;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using System.Data;
using Ferramentas;

namespace Apresentacao
{
    public partial class FrmServicos : Form
    {
        bool mover = false;
        Point posicao_Inicial;

        public FrmServicos()
        {
            InitializeComponent();
            //não gerar linhas automaticamente no datagrid
            dataGridServ.AutoGenerateColumns = false;
        }
        //Variaveis que guardao as permissoes
        Boolean perInserir = false; Boolean perAtualizar = false; Boolean perExcluir = false; Boolean perConsultar = false;

        public void alterarBotoes(int op, Boolean inserir, Boolean atualizar, Boolean excluir, Boolean consultar)
        {
            // op = operacões que seram feitas com os botões
            // 1 = prepara os botões para inserir e localizar
            // 2 =  prepara para inserir/alterar um registro
            // 3 =  prepara a tela para inserir ou alterar

            dataGridServ.Enabled = false;

            btnNovoServ.Enabled = false;
            btnNovoServ.BackColor = Color.Gainsboro;

            btnAtualizarServ.Enabled = false;
            btnAtualizarServ.BackColor = Color.Gainsboro;

            btnExcluirServ.Enabled = false;
            btnExcluirServ.BackColor = Color.Gainsboro;

            btnPesquisarServ.Enabled = false;
            btnPesquisarServ.BackColor = Color.Gainsboro;

            btnConsultarServ.Enabled = false;
            btnConsultarServ.BackColor = Color.Gainsboro;

            txtBoxPesqServ.Enabled = false;

            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.Gainsboro;

            if (op == 1)
            {
                btnNovoServ.Enabled = inserir;
                if (btnNovoServ.Enabled == false) {btnNovoServ.BackColor = Color.Gainsboro; } else {btnNovoServ.BackColor = Color.MediumSlateBlue; }
                btnPesquisarServ.Enabled = true;
                if (btnPesquisarServ.Enabled == false) {btnPesquisarServ.BackColor = Color.Gainsboro; } else {btnPesquisarServ.BackColor = Color.MediumSlateBlue; }
                txtBoxPesqServ.Enabled = true;
            }
            if (op == 2)
            {
                dataGridServ.Enabled = true;
                btnConsultarServ.Enabled = true;
                if (btnConsultarServ.Enabled == false) {btnConsultarServ.BackColor = Color.Gainsboro; } else {btnConsultarServ.BackColor = Color.MediumSlateBlue; }
            }
            if (op == 3)
            {
                dataGridServ.Enabled = true;
                btnAtualizarServ.Enabled = atualizar;
                if (btnAtualizarServ.Enabled == false) {btnAtualizarServ.BackColor = Color.Gainsboro; } else {btnAtualizarServ.BackColor = Color.MediumSlateBlue; }
                btnConsultarServ.Enabled = true;
                if (btnConsultarServ.Enabled == false) {btnConsultarServ.BackColor = Color.Gainsboro; } else {btnConsultarServ.BackColor = Color.MediumSlateBlue; }
                btnExcluirServ.Enabled = excluir;
                if (btnExcluirServ.Enabled == false) {btnExcluirServ.BackColor = Color.Gainsboro; } else {btnExcluirServ.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = true;
                if (btnCancelar.Enabled == false) {btnCancelar.BackColor = Color.Gainsboro; } else {btnCancelar.BackColor = Color.MediumSlateBlue; }
            }
        }

        private void FrmServicos_Load(object sender, EventArgs e)
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

        private void btnFecharProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarProd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AtualizarGrid()
        {

            ClassServico_BLL classServico_Bll = new ClassServico_BLL();
            ClassServicoCollection_DTO servicocolecao = new ClassServicoCollection_DTO();

            servicocolecao = classServico_Bll.ConsultaPorNome(txtBoxPesqServ.Text);


            //limpar dados que já estão no grid
            dataGridServ.DataSource = null;
            dataGridServ.DataSource = servicocolecao;

            dataGridServ.Update();
            dataGridServ.Refresh();

        }

        private void btnPesquisarServ_Click(object sender, EventArgs e)
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
        //vai implementar o BindProperty do DataGrid no evento
        private void dataGridServ_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridServ.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridServ.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dataGridServ.Rows[e.RowIndex].DataBoundItem, dataGridServ.Columns[e.ColumnIndex].DataPropertyName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
    
      

        private void btnExcluirServ_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (dataGridServ.SelectedRows.Count.Equals(0))
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

            //Pegar o Serviço Selecionado
            ClassServico_DTO ServicoSelecionado = (dataGridServ.SelectedRows[0].DataBoundItem as ClassServico_DTO);
            //Instanciar regra de negocios
            ClassServico_BLL classServico_BLL = new ClassServico_BLL();
            //Chamar metodo de Excluir
            String Retorno = classServico_BLL.ExcluirServico(ServicoSelecionado);
            //Vereficar se excluiu com sucesso
            //Se o retorno for um numero significa que deu tudo certo se não deu algum erro
            try
            {
                Int32 IDServico =Convert.ToInt32(Retorno);
                btnCancelar_Click(sender,e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel excluir. Detalhes:" + Retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCancelar_Click(sender, e);
        }

        private void btnNovoServ_Click(object sender, EventArgs e)
        {
              
            //Instanciar Formulario de cadastro
            FrmCadServicos cadastrodeservicos = new FrmCadServicos(ClassAcaoNaTela.Inserir, null);
            DialogResult dialogResult = cadastrodeservicos.ShowDialog();
            txtBoxPesqServ.Text = "";
            if (dialogResult == DialogResult.Yes)
            {
                btnCancelar_Click(sender, e);
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
        }

        private void btnAtualizarServ_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (dataGridServ.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            //Pegar o Serviço Selecionado
            ClassServico_DTO ServicoSelecionado = (dataGridServ.SelectedRows[0].DataBoundItem as ClassServico_DTO);
            //Instanciar Formulario de cadastro
            FrmCadServicos cadastrodeservicos = new FrmCadServicos(ClassAcaoNaTela.Atualizar, ServicoSelecionado);
            DialogResult dialogResult = cadastrodeservicos.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                //Chamar Função checa permissões
                alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);

            }
            btnCancelar_Click(sender, e);
        }

        private void btnConsultarServ_Click(object sender, EventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (dataGridServ.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pegar o serviço selecionado
            ClassServico_DTO ServicoSelecionado = (dataGridServ.SelectedRows[0].DataBoundItem as ClassServico_DTO);
            //Instanciar Formulario de cadastro
            FrmCadServicos cadastrodeservicos = new FrmCadServicos(ClassAcaoNaTela.Consultar, ServicoSelecionado);
            cadastrodeservicos.ShowDialog();
            btnCancelar_Click(sender, e);
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }

        private void label23_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void label23_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_Inicial.X, novo.Y - this.posicao_Inicial.Y);
            }
        }

        private void label23_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_Inicial = new Point(e.X, e.Y);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridServ.DataSource = null;
            txtBoxPesqServ.Text = "";
            //Chamar Função checa permissões
            alterarBotoes(1, perInserir, perAtualizar, perExcluir, perConsultar);
        }
    }

}
    


