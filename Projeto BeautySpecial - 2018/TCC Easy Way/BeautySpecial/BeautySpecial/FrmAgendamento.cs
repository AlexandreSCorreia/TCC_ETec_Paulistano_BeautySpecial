using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
//chamando pastas referenciadas
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;
using System.Collections.Generic;

namespace Apresentacao
{
    public partial class FrmAgendamento : Form
    {
        bool mover = false;
        Point posicao_Inicial;
        ClassServico_BLL classServico_BLL = new ClassServico_BLL();
        public FrmAgendamento()
        {
            InitializeComponent();

            
            //não gerar linhas automaticamente no datagrid
            DataGridAgend.AutoGenerateColumns = false;
            
        }
        private void btnMinimizarAgend_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnFecharAgend_Click(object sender, EventArgs e)
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
        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            DataAgend.Value = DateTime.Now.Date;
            AtualizarGrid();
            CarregarCombos();
        }
        //Atualiza o gridview
        private void AtualizarGrid()
        {

            ClassAgendamento_BLL classAgendamento_Bll = new ClassAgendamento_BLL();
            ClassAgendamento_Collection_DTO agendamentocolecao = new ClassAgendamento_Collection_DTO();
            String Pesquisa = DataAgend.Value.Date.ToString("yyyy-MM-dd");
            agendamentocolecao = classAgendamento_Bll.ConsultaPorNome(Pesquisa);
            //limpar dados que já estão no grid
            DataGridAgend.DataSource = null;
            //passando coleção para o Grid
            DataGridAgend.DataSource = agendamentocolecao;
            //Atualizando o Grid
            DataGridAgend.Update();
            DataGridAgend.Refresh();
          
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
        private void btnSalvarAgend_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            ClassAgendamento_BLL classAgendamento_BLL = new ClassAgendamento_BLL();
            Int32 ID_Cliente = ((ClassCliente_DTO)cmbClienteAgend.SelectedItem).ID_Cliente;
            Int32 ID_Servico = ((ClassServico_DTO)cmbtServAgend.SelectedItem).ID_Servico;
            Int32 ID_Funcionario = ((ClassFuncionario_DTO)cmbBoxProfAgend.SelectedItem).ID_Funcionario;
            Int32 ID_HoraSalao = ((ClassHoraSalao)cmbBoxHorAgend.SelectedItem).ID_HoraSalao;
            String Duracao = mkdTxtBoxDuracAgend.Text;
            ClassAgendamento_DTO classAgendamento_DTO = new ClassAgendamento_DTO(ID_Cliente,ID_Servico,ID_Funcionario,Duracao,Convert.ToDateTime(DataAgend.Text),ID_HoraSalao,txtBoxObsAgend.Text);
            String IDAgendamento = classAgendamento_BLL.InserirAgendamento(classAgendamento_DTO);
            cmbBoxHorAgend.Items.RemoveAt(cmbBoxHorAgend.SelectedIndex);
            try
            {
                Int32 ID = Convert.ToInt32(IDAgendamento);
                MessageBox.Show("Agendamento efetuado com sucesso ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao agendar. Detalhes: \n" + IDAgendamento+ "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }
        public void CarregarCombos()
        {
            cmbtServAgend.Items.Clear();
            cmbtServAgend.Items.Add("--Selecione--");
            foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
            {
                cmbtServAgend.Items.Add(classServico_DTO);
            }
            cmbtServAgend.Text = "--Selecione--";

            cmbBoxProfAgend.Items.Clear();
            cmbBoxProfAgend.Items.Add("--Selecione--");
            var classFuncionario_BLL = new ClassFuncionario_BLL();
            foreach (ClassFuncionario_DTO classFuncionario_DTO in classFuncionario_BLL.ConsultaPorNome(""))
            {
                cmbBoxProfAgend.Items.Add(classFuncionario_DTO);
            }
            cmbBoxProfAgend.Text = "--Selecione--";

            cmbClienteAgend.Items.Clear();
            cmbClienteAgend.Items.Add("--Selecione--");
            var classCliente_BLL = new ClassCliente_BLL();
            foreach (ClassCliente_DTO classCliente_DTO in classCliente_BLL.ConsultaPorNome(""))
            {
                cmbClienteAgend.Items.Add(classCliente_DTO);
            }
            cmbClienteAgend.Text = "--Selecione--";

            cmbBoxHorAgend.Items.Clear();
            var classAgendamento_BLL = new ClassAgendamento_BLL();
            string Total = "";
           /* DateTime dtInicio;
            DateTime dtFinal;
            TimeSpan horaTotal;*/
            int x = DataGridAgend.RowCount;
            bool ValorNoGrid = false;
            cmbBoxHorAgend.Items.Clear();
            foreach (ClassHoraSalao classHoraSalao in classAgendamento_BLL.ConsultaHorarioSalao())
            {
                for (int l = 0; l < x; l++)
                {
                    if (DataGridAgend.RowCount > 0)
                    {
                        if (DataGridAgend.Rows[l].Cells[4].FormattedValue.Equals(classHoraSalao.ID_HoraSalao.ToString()))
                        {
                            ValorNoGrid = true;
                           /* dtInicio = DateTime.Parse(classHoraSalao.Horario_Sal + ":00");
                            dtFinal = DateTime.Parse(DataGridAgend.Rows[l].Cells[2].FormattedValue.ToString() + ":00");
                            horaTotal = new TimeSpan(dtFinal.Ticks + dtInicio.Ticks);
                            Total = horaTotal.ToString(@"hh\:mm");*/
                        }
                        /*if (classHoraSalao.Horario_Sal == Total)
                        {
                            ValorNoGrid = true;
                            Total = "";
                        }*/

                    }
                }


                if (ValorNoGrid == false)
                {
                    cmbBoxHorAgend.Items.Add(classHoraSalao);
                }
                ValorNoGrid = false;

            }
            cmbBoxHorAgend.Text = "--Selecione--";


        }
        private void DataGridAgend_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((DataGridAgend.Rows[e.RowIndex].DataBoundItem != null) &&
                    (DataGridAgend.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(DataGridAgend.Rows[e.RowIndex].DataBoundItem, DataGridAgend.Columns[e.ColumnIndex].DataPropertyName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void LimparCampos()
        {
            cmbClienteAgend.SelectedIndex = -1;
            cmbBoxProfAgend.SelectedIndex = -1;
            cmbtServAgend.SelectedIndex = -1;
            cmbBoxHorAgend.SelectedIndex = -1;
            txtBoxObsAgend.Text = "";
            mkdTxtBoxDuracAgend.Text = "";

        }
        public bool Validar()
        {
            bool valida = true;

            if (cmbClienteAgend.Text.Equals(String.Empty))
            {
                valida = false;
                cmbClienteAgend.Focus();
                lblMsgClienteAgend.ForeColor = Color.Red;
            }
            if (!cmbClienteAgend.Text.Equals(String.Empty))
            {
                lblMsgClienteAgend.ForeColor = Color.Black;
            }


            if (cmbClienteAgend.Text.Equals("--Selecione--"))
            {
                valida = false;
                cmbClienteAgend.Focus();
                lblMsgClienteAgend.ForeColor = Color.Red;
            }
            if (!cmbClienteAgend.Text.Equals("--Selecione--"))
            {
                lblMsgClienteAgend.ForeColor = Color.Black;
            }



            if (cmbtServAgend.Text.Equals(String.Empty))
            {
                valida = false;
                cmbtServAgend.Focus();
                lblMsgServicoAgend.ForeColor = Color.Red;
            }
            if (!cmbtServAgend.Text.Equals(String.Empty))
            {
                lblMsgServicoAgend.ForeColor = Color.Black;
            }


            if (cmbtServAgend.Text.Equals("--Selecione--"))
            {
                valida = false;
                cmbtServAgend.Focus();
                lblMsgServicoAgend.ForeColor = Color.Red;
            }
            if (!cmbtServAgend.Text.Equals("--Selecione--"))
            {
                lblMsgServicoAgend.ForeColor = Color.Black;
            }


            if (cmbBoxProfAgend.Text.Equals(String.Empty))
            {
                valida = false;
                cmbBoxProfAgend.Focus();
                lblMsgProfissionalAgend.ForeColor = Color.Red;
            }
            if (!cmbBoxProfAgend.Text.Equals(String.Empty))
            {
                lblMsgProfissionalAgend.ForeColor = Color.Black;
            }

            if (cmbBoxProfAgend.Text.Equals("--Selecione--"))
            {
                valida = false;
                cmbBoxProfAgend.Focus();
                lblMsgProfissionalAgend.ForeColor = Color.Red;
            }
            if (!cmbBoxProfAgend.Text.Equals("--Selecione--"))
            {
                lblMsgProfissionalAgend.ForeColor = Color.Black;
            }

            if (cmbBoxHorAgend.Text.Equals(String.Empty))
            {
                valida = false;
                cmbBoxHorAgend.Focus();
                lblMsgHorarioAgend.ForeColor = Color.Red;
            }
            if (!cmbBoxHorAgend.Text.Equals(String.Empty))
            {
                lblMsgHorarioAgend.ForeColor = Color.Black;
            }


            if (cmbBoxHorAgend.Text.Equals("--Selecione--"))
            {
                valida = false;
                cmbBoxHorAgend.Focus();
                lblMsgHorarioAgend.ForeColor = Color.Red;
            }
            if (!cmbBoxHorAgend.Text.Equals("--Selecione--"))
            {
                lblMsgHorarioAgend.ForeColor = Color.Black;
            }

            if (mkdTxtBoxDuracAgend.Text.Trim().Equals(":") || mkdTxtBoxDuracAgend.Text.Trim().Equals(String.Empty))
            {
                valida = false;
                mkdTxtBoxDuracAgend.Focus();
                lblMsgDuracao.ForeColor = Color.Red;
            }
            if (!mkdTxtBoxDuracAgend.Text.Trim().Equals(":") || mkdTxtBoxDuracAgend.Text.Trim().Equals(String.Empty))
            {
                lblMsgDuracao.ForeColor = Color.Black;
            }

            return valida;

        }
        private void dateTimePickerAgend_ValueChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void btnAddServAgend_Click(object sender, EventArgs e)
        {
            new FrmCadServicos(ClassAcaoNaTela.Inserir, null).ShowDialog();
            CarregarCombos();
        }
        private void cmbtServAgend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtServAgend.SelectedItem != null)
            {
                if (cmbtServAgend.Text != "--Selecione--")
                {
                    mkdTxtBoxDuracAgend.Text = (((ClassServico_DTO)cmbtServAgend.SelectedItem).Duracao_Serv);
                }
            }
            
        }

        private void DataGridAgend_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Verificar se tem alguma linha selecionada
            if (DataGridAgend.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Perguntar se ele quer realmente Excluir
            DialogResult Resultado = MessageBox.Show("Tem Certeza que deseja excluir o agendamento?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
            {
                return;

            }

            //Pegar o Cliente Selecionado
            ClassAgendamento_DTO AgendamentoSelecionado = (DataGridAgend.SelectedRows[0].DataBoundItem as ClassAgendamento_DTO);
            //Instanciar regra de negocios
            ClassAgendamento_BLL classAgendamento_BLL = new ClassAgendamento_BLL();
            //Chamar metodo de Excluir
            String Retorno = classAgendamento_BLL.ExcluirAgendamento(AgendamentoSelecionado);
            //Vereficar se excluiu com sucesso
            //Se o retorno for um numero significa que deu tudo certo se não deu algum erro
            try
            {
                Convert.ToInt32(Retorno);
                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel excluir. Detalhes:" + Retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddClienteAgend_Click(object sender, EventArgs e)
        {
            new FrmCadCliente(ClassAcaoNaTela.Inserir, null).ShowDialog();
            CarregarCombos();
        }
    }
    
}
