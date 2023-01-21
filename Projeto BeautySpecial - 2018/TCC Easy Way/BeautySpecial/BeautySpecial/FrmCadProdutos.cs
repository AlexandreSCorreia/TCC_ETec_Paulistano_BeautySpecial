using System;
using System.Windows.Forms;
using System.Drawing;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using System.Collections.Generic;
using System.Reflection;
using System.Data;

namespace Apresentacao
{
    public partial class FrmCadProdutos : Form
    {
        //Declarando variaveis
        ClassAcaoNaTela acaoNaTelaSelecionada;
        ClassServico_BLL classServico_BLL = new ClassServico_BLL();
        Int32 IDProduto;
        decimal preco = 0;
        Int32 i = 0;
        bool mover = false;
        Point posicao_Inicial;

        //Construtor

        public FrmCadProdutos(ClassAcaoNaTela acaoNaTela, ClassProduto_DTO classProduto)
        {

            InitializeComponent();

            acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == ClassAcaoNaTela.Inserir)
            {
                this.Text = "Inserir novo produto";

                cmbServProv.Items.Clear();
                cmbServProv.Items.Add("--Selecione--");
                foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
                {
                    cmbServProv.Items.Add(classServico_DTO);
                }
                cmbServProv.Text = "--Selecione--";

            }
            else if (acaoNaTela == ClassAcaoNaTela.Atualizar)
            {
                this.Text = "Atualizar produto";
                //Passando os valores para os TextBox
                IDProduto = classProduto.ID_Produto;
                txtBoxNomeProd.Text = classProduto.Nome_Prod.ToString();
                txtBoxPrecProd.Text = classProduto.Preco_Prod.ToString();
                txtBoxMarcProd.Text = classProduto.Marca_Prod.ToString();
                txtBoxDescProd.Text = classProduto.Descricao_Prod.ToString();
                txtBoxQuantProd.Text = classProduto.Quantidade_Prod.ToString();

                ClassProduto_BLL classProduto_Bll = new ClassProduto_BLL();
                DataTable dataTable = new DataTable();
                dataTable = classProduto_Bll.ConsultaPorNome(IDProduto);


                int tServ = 0;
                tServ = dataTable.Rows.Count;

                if (tServ > 0)
                {
                    //Carrega as permissões que o usuario ja possui no banco de dados
                    for (int Linha = 0; Linha < tServ;)
                    {
                        DataGridServCom.Rows.Add();
                        DataGridServCom.Rows[Linha].Cells[0].Value = dataTable.Rows[Linha][0];
                        DataGridServCom.Rows[Linha].Cells[1].Value = dataTable.Rows[Linha][1];
                        Linha++;
                    }

                    dataTable.Dispose();
                }

                ClassProdutoCollection_DTO produtocolecao = new ClassProdutoCollection_DTO();

                foreach (DataRow linha in dataTable.Rows)
                {
                    //criar um produto vazio
                    ClassProduto_DTO classProduto_DTO = new ClassProduto_DTO();
                    classProduto_DTO.classServico_DTO = new ClassServico_DTO();
                    //colocar dados na linha 
                    if (linha["ID_Servico"] != DBNull.Value) { classProduto_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(linha["ID_Servico"]); }
                    if (linha["Nome_Serv"] != DBNull.Value) { classProduto_DTO.classServico_DTO.Nome_Serv = Convert.ToString(linha["Nome_Serv"]); }
                    //adicionar objeto preenchido na coleção
                    produtocolecao.Add(classProduto_DTO);
                }


                int x = DataGridServCom.RowCount;
                List<ClassServico_DTO> Servico = new List<ClassServico_DTO>();

                foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
                {
                    for (int l = 0; l < x; l++)
                    {
                        if (DataGridServCom.RowCount > 0)
                        {

                            if (!produtocolecao.Exists(e => e.classServico_DTO.ID_Servico.Equals(classServico_DTO.ID_Servico)))
                            {
                                cmbServProv.SelectedIndex = cmbServProv.FindString(classServico_DTO.Nome_Serv);
                                if ((cmbServProv.FindString(classServico_DTO.Nome_Serv) == -1))
                                {
                                    cmbServProv.Items.Add(classServico_DTO);
                                }
                            }
                        }

                    }

                }
                int LinhasGrid = DataGridServCom.RowCount;
                i = LinhasGrid;
            }

            else if (acaoNaTela == ClassAcaoNaTela.Consultar)
            {
                this.Text = "Consultar produto";
                //Passando os valores para os TextBox
                IDProduto = classProduto.ID_Produto;
                txtBoxNomeProd.Text = classProduto.Nome_Prod.ToString();
                txtBoxPrecProd.Text = classProduto.Preco_Prod.ToString();
                txtBoxMarcProd.Text = classProduto.Marca_Prod.ToString();
                txtBoxDescProd.Text = classProduto.Descricao_Prod.ToString();
                txtBoxQuantProd.Text = classProduto.Quantidade_Prod.ToString();
                ClassProduto_BLL classProduto_Bll = new ClassProduto_BLL();
                DataTable dataTable = new DataTable();
                dataTable = classProduto_Bll.ConsultaPorNome(IDProduto);

                int tServ = 0;
                tServ = dataTable.Rows.Count;

                if (tServ > 0)
                {
                    //Carrega as permissões que o usuario ja possui no banco de dados
                    for (int Linha = 0; Linha < tServ;)
                    {
                        DataGridServCom.Rows.Add();
                        DataGridServCom.Rows[Linha].Cells[0].Value = dataTable.Rows[Linha][0];
                        DataGridServCom.Rows[Linha].Cells[1].Value = dataTable.Rows[Linha][1];
                        Linha++;
                    }

                    dataTable.Dispose();
                }

                //Desabilitar campos na tela
                txtBoxNomeProd.TabStop = false;
                txtBoxPrecProd.TabStop = false;
                txtBoxMarcProd.TabStop = false;
                txtBoxQuantProd.TabStop = false;
                txtBoxDescProd.TabStop = false;
                txtBoxNomeProd.ReadOnly = true;
                txtBoxPrecProd.ReadOnly = true;
                txtBoxMarcProd.ReadOnly = true;
                txtBoxQuantProd.ReadOnly = true;
                txtBoxDescProd.ReadOnly = true;
                DataGridServCom.Enabled = false;
                cmbServProv.Visible = false;
                btnAddServCadCom.Visible = false;
                btnSalvarProd.Visible = false;
                btnFecharProd.Focus();
            }

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

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if (txtBoxPrecProd.Text.Contains(".") && txtBoxPrecProd.Text.Contains(","))
            {
                preco = Convert.ToDecimal(txtBoxPrecProd.Text.Replace(".", "").Replace(",", "."));

            }


            if (!Validar())
            {
                return;
            }

            //instância da classe _bll
            ClassProduto_BLL classProduto_BLL = new ClassProduto_BLL();
            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Inserir)
            {
                //instância da classe servico_dto e passando parametros para o contrutor
                ClassProduto_DTO classProduto_DTO = new ClassProduto_DTO(txtBoxNomeProd.Text,txtBoxMarcProd.Text,txtBoxDescProd.Text,Convert.ToDecimal(txtBoxPrecProd.Text),Convert.ToInt32(txtBoxQuantProd.Text));
                String ID_Produto = classProduto_BLL.InserirProduto(classProduto_DTO);
                int x = DataGridServCom.RowCount;
                //Preencher o modelo e gravar no banco
                for (int i = 0; i < x; i++)
                {
                    ClassProduto_DTO classProduto1 = new ClassProduto_DTO();
                    classProduto1.classServico_DTO = new ClassServico_DTO();
                    classProduto1.classServico_DTO.ID_Servico = Convert.ToInt32(DataGridServCom.Rows[i].Cells[0].Value);
                    classProduto1.ID_Produto = Convert.ToInt32(ID_Produto);
                    classProduto_BLL.InserirServicosProduto(classProduto1);
                }
                try
                {
                    Int32 ID = Convert.ToInt32(ID_Produto);
                    MessageBox.Show("Produto cadastrado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar. Detalhes: " + "\n" + ID_Produto + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == ClassAcaoNaTela.Atualizar)
            {
                ClassProduto_DTO classProduto_DTO = new ClassProduto_DTO(IDProduto, txtBoxNomeProd.Text, txtBoxMarcProd.Text, txtBoxDescProd.Text, Convert.ToDecimal(txtBoxPrecProd.Text), Convert.ToInt32(txtBoxQuantProd.Text));
                String ID_Produto = classProduto_BLL.AtualizarProduto(classProduto_DTO);
                int Excluir = DataGridServCom.RowCount;
                //Preencher o modelo e gravar no banco
                for (int i = 0; i < Excluir; i++)
                {
                    ClassProduto_DTO classProduto1 = new ClassProduto_DTO();
                    classProduto1.classServico_DTO = new ClassServico_DTO();
                    classProduto1.classServico_DTO.ID_Servico = Convert.ToInt32(DataGridServCom.Rows[i].Cells[0].Value);
                    classProduto1.ID_Produto = Convert.ToInt32(ID_Produto);
                    classProduto_BLL.ExcluirServicoProduto(classProduto1);
                }
                int x = DataGridServCom.RowCount;
                //Preencher o modelo e gravar no banco
                for (int i = 0; i < x; i++)
                {
                    ClassProduto_DTO classProduto1 = new ClassProduto_DTO();
                    classProduto1.classServico_DTO = new ClassServico_DTO();
                    classProduto1.classServico_DTO.ID_Servico = Convert.ToInt32(DataGridServCom.Rows[i].Cells[0].Value);
                    classProduto1.ID_Produto = Convert.ToInt32(ID_Produto);
                    classProduto_BLL.InserirServicosProduto(classProduto1);
                }
                try
                {
                    IDProduto = Convert.ToInt32(ID_Produto);
                    MessageBox.Show("Atualização concluida com êxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Atualizar. Detalhes: " + ID_Produto + "\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
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
        private void DataGridServCom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((DataGridServCom.Rows[e.RowIndex].DataBoundItem != null) &&
                    (DataGridServCom.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(DataGridServCom.Rows[e.RowIndex].DataBoundItem, DataGridServCom.Columns[e.ColumnIndex].DataPropertyName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarCadProd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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


        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

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

        private void txtBoxPrecProd_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtBoxPrecProd);
        }

        public bool Validar()
        {
            bool valida = true;

            if (txtBoxPrecProd.Text.Equals(String.Empty))
            {
                valida = false;
                txtBoxPrecProd.Focus();
                lblMsgPrecoProd.ForeColor = Color.Red;
            }
            if (!txtBoxPrecProd.Text.Equals(String.Empty))
            {
                lblMsgPrecoProd.ForeColor = Color.Black;
            }
            if (txtBoxMarcProd.Text.Equals(String.Empty))
            {
                valida = false;
                txtBoxMarcProd.Focus();
                lblMsgMarcaProd.ForeColor = Color.Red;
            }
            if (!txtBoxMarcProd.Text.Equals(String.Empty))
            {
                lblMsgMarcaProd.ForeColor = Color.Black;
            }

            if (txtBoxNomeProd.Text.Equals(String.Empty))
            {
                valida = false;
                txtBoxNomeProd.Focus();
                lblMsgNomeProd.ForeColor = Color.Red;
            }
            if (!txtBoxNomeProd.Text.Equals(String.Empty))
            {
                lblMsgNomeProd.ForeColor = Color.Black;
            }

            return valida;

        }

        private void btnAddServProd_Click(object sender, EventArgs e)
        {
            if (cmbServProv.Text.Equals("--Selecione--") || cmbServProv.Text == String.Empty)
            {
                MessageBox.Show("Selecione um serviço!", "Serviço não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridServCom.Rows.Add();
            DataGridServCom.Rows[i].Cells[0].Value = ((ClassServico_DTO)cmbServProv.SelectedItem).ID_Servico;
            DataGridServCom.Rows[i].Cells[1].Value = ((ClassServico_DTO)cmbServProv.SelectedItem).Nome_Serv;
            i++;
            cmbServProv.Items.RemoveAt(cmbServProv.SelectedIndex);
            cmbServProv.Text = "--Selecione--";

        }




        private void FrmCadProdutos_Load(object sender, EventArgs e)
        {
            cmbServProv.Text = "--Selecione--";
        }


        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                //Verificar se tem alguma linha selecionada
                if (DataGridServCom.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("Nenhum registro foi selecionado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataGridServCom.Rows.Remove(DataGridServCom.SelectedRows[0]);
                int x = DataGridServCom.RowCount;
                bool ValorNoGrid = false;
                cmbServProv.Items.Clear();

                foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
                {
                    for (int l = 0; l < x; l++)
                    {
                        if (DataGridServCom.RowCount > 0)
                        {
                            if (DataGridServCom.Rows[l].Cells[0].Value.Equals(classServico_DTO.ID_Servico))
                            {
                                ValorNoGrid = true;
                            }
                        }
                    }

                    if (ValorNoGrid == false)
                    {
                        cmbServProv.Items.Add(classServico_DTO);
                    }
                    ValorNoGrid = false;

                }
                int LinhasGrid = DataGridServCom.RowCount;
                i = LinhasGrid;
                cmbServProv.Text = "--Selecione--";

            }
        }
    }

