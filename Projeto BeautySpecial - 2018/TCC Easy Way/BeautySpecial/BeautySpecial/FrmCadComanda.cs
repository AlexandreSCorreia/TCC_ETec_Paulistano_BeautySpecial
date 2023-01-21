using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//chamando pastas referenciadas
using CamadaLogicaDeNegocios_BLL;
using CamadaAcessoADados_DTO;


namespace Apresentacao
{
    public partial class FrmCadComanda : Form
    {
        ClassAcaoNaTela acaoNaTelaSelecionada;
        ClassCliente_BLL classCliente_BLL = new ClassCliente_BLL();
        ClassServico_BLL classServico_BLL = new ClassServico_BLL();
        ClassComanda_BLL classComanda_BLL = new ClassComanda_BLL();
        ClassProduto_BLL classProduto_BLL = new ClassProduto_BLL();
        ClassFuncionario_BLL classFuncionario_BLL = new ClassFuncionario_BLL();
        Int32 ID_Comanda = 0; Int32 ID_Cliente = 0; Int32 ID_Funcionario = 0; Int32 ID_Servico = 0; Int32 ID_Produto = 0;
        bool mover = false;
        Point posicao_Inicial;
        Int32 i = 0;
        Int32 p = 0;
        Decimal Total = 0;

        public FrmCadComanda(ClassAcaoNaTela acaoNaTela, ClassComanda_DTO classComanda_DTO)
        {
            InitializeComponent();
            DataGridServCom.AutoGenerateColumns = false;
            acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == ClassAcaoNaTela.Inserir)
            {
                this.Text = "Inserir nova comanda";
                PreencherCombos();
            }
            else if (acaoNaTela == ClassAcaoNaTela.Atualizar)
            {
                this.Text = "Atualizar comanda";
                //Passando os valores para os TextBox
                if (!(classComanda_DTO.ID_Comanda == 0)) { ID_Comanda = classComanda_DTO.ID_Comanda; }
                if (!(classComanda_DTO.classCliente_DTO.ID_Cliente == 0)) { ID_Cliente = classComanda_DTO.classCliente_DTO.ID_Cliente; }
                if (Convert.ToString(classComanda_DTO.classCliente_DTO.Nome_Clie) != null) { cmbClienteCom.Text = classComanda_DTO.classCliente_DTO.Nome_Clie.ToString(); }
                if (!(classComanda_DTO.classFuncionario_DTO.ID_Funcionario == 0)) { ID_Funcionario = classComanda_DTO.classFuncionario_DTO.ID_Funcionario; }
                if (Convert.ToString(classComanda_DTO.classFuncionario_DTO.Nome_Func) != null) { cmbProfissional.Text = classComanda_DTO.classFuncionario_DTO.Nome_Func.ToString(); }
                if (!(classComanda_DTO.classServico_DTO.ID_Servico == 0)) { ID_Servico = classComanda_DTO.classServico_DTO.ID_Servico; }
                if (Convert.ToString(classComanda_DTO.classServico_DTO.Nome_Serv) != null) { cmbServCadCom.Items.Add("--Selecione--"); cmbServCadCom.Text = "--Selecione--"; }
                if (!(classComanda_DTO.classProduto_DTO.ID_Produto == 0)) { ID_Produto = classComanda_DTO.classProduto_DTO.ID_Produto; }
                if (Convert.ToString(classComanda_DTO.classServico_DTO.Nome_Serv) != null) { cmbProdCom.Items.Add("--Selecione--"); cmbProdCom.Text = "--Selecione--"; }
                if (Convert.ToString(classComanda_DTO.ValorTotal_Com) != null) { txtBoxTotCadCom.Text = classComanda_DTO.ValorTotal_Com.ToString(); Total = classComanda_DTO.ValorTotal_Com; }
                CarregaCMProd();
                CarregarCmServ();
                cmbClienteCom.Enabled = false;
                cmbProfissional.Enabled = false;
            }
            else if (acaoNaTela == ClassAcaoNaTela.Consultar)
            {
                this.Text = "Consultar cliente";
                //Passando os valores para os TextBox
                if (!(classComanda_DTO.ID_Comanda == 0)) { ID_Comanda = classComanda_DTO.ID_Comanda; }
                if (!(classComanda_DTO.classCliente_DTO.ID_Cliente == 0)) { ID_Cliente = classComanda_DTO.classCliente_DTO.ID_Cliente; }
                if (Convert.ToString(classComanda_DTO.classCliente_DTO.Nome_Clie) != null) { cmbClienteCom.Text = classComanda_DTO.classCliente_DTO.Nome_Clie.ToString(); }
                if (!(classComanda_DTO.classFuncionario_DTO.ID_Funcionario == 0)) { ID_Funcionario = classComanda_DTO.classFuncionario_DTO.ID_Funcionario; }
                if (Convert.ToString(classComanda_DTO.classFuncionario_DTO.Nome_Func) != null) { cmbProfissional.Text = classComanda_DTO.classFuncionario_DTO.Nome_Func.ToString(); }
                if (!(classComanda_DTO.classServico_DTO.ID_Servico == 0)) { ID_Servico = classComanda_DTO.classServico_DTO.ID_Servico; }
                if (Convert.ToString(classComanda_DTO.classServico_DTO.Nome_Serv) != null) { cmbServCadCom.Items.Add("--Selecione--"); cmbServCadCom.Text = "--Selecione--"; }
                if (!(classComanda_DTO.classProduto_DTO.ID_Produto == 0)) { ID_Produto = classComanda_DTO.classProduto_DTO.ID_Produto; }
                if (Convert.ToString(classComanda_DTO.classServico_DTO.Nome_Serv) != null) { cmbProdCom.Items.Add("--Selecione--"); cmbProdCom.Text = "--Selecione--"; }
                if (Convert.ToString(classComanda_DTO.ValorTotal_Com) != null) { txtBoxTotCadCom.Text = classComanda_DTO.ValorTotal_Com.ToString(); Total = classComanda_DTO.ValorTotal_Com; }
                CarregaCMProd();
                CarregarCmServ();
                //Desabilitar 
                DataGridCadProd.Enabled = false;
                DataGridServCom.Enabled = false;
                cmbClienteCom.Enabled = false;
                cmbProfissional.Enabled = false;
                cmbProdCom.Enabled = false;
                cmbServCadCom.Enabled = false;
                txtBoxPrecCadCom.Enabled = false;
                txtBoxTotCadCom.Enabled = false;
                btnAddProduto.Visible = false;
                btnAddServCadCom.Visible = false;
                btnExcluProd.Enabled = false;
                btnExcluProd.Visible = false;
                btnExcluServ.Enabled = false;
                btnExcluServ.Visible = false;
                btnSalvarCadCom.Visible = false;

            }
        }

        public void PreencherCombos()
        {
            cmbClienteCom.Items.Clear();
            cmbClienteCom.Items.Add("--Selecione--");
            var classCliente_BLL = new ClassCliente_BLL();
            foreach (ClassCliente_DTO classCliente_DTO in classCliente_BLL.ConsultaPorNome(""))
            {
                cmbClienteCom.Items.Add(classCliente_DTO);
            }
            cmbClienteCom.Text = "--Selecione--";


            cmbProdCom.Items.Clear();
            cmbProdCom.Items.Add("--Selecione--");
            var classProduto_BLL = new ClassProduto_BLL();
            foreach (ClassProduto_DTO classProduto_DTO in classProduto_BLL.ConsultaPorNome(""))
            {
                cmbProdCom.Items.Add(classProduto_DTO);
            }
            cmbProdCom.Text = "--Selecione--";


            cmbProfissional.Items.Clear();
            cmbProfissional.Items.Add("--Selecione--");
            foreach (ClassFuncionario_DTO classFuncionario_DTO in classFuncionario_BLL.ConsultaPorNome(""))
            {
                cmbProfissional.Items.Add(classFuncionario_DTO);
            }
            cmbProfissional.Text = "--Selecione--";


            cmbServCadCom.Items.Clear();
            cmbServCadCom.Items.Add("--Selecione--");
            foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
            {
                cmbServCadCom.Items.Add(classServico_DTO);
            }
            cmbServCadCom.Text = "--Selecione--";

        }
        public void CarregarCmServ()
        {
            DataTable dataTableServ = new DataTable();
            dataTableServ = classComanda_BLL.ConsultaServicoComanda(ID_Comanda);
            int tServ = 0;
            tServ = dataTableServ.Rows.Count;
            if (tServ > 0)
            {
                for (int Linha = 0; Linha < tServ;)
                {
                    DataGridServCom.Rows.Add();
                    DataGridServCom.Rows[Linha].Cells[0].Value = dataTableServ.Rows[Linha][0];
                    DataGridServCom.Rows[Linha].Cells[1].Value = dataTableServ.Rows[Linha][1];
                    DataGridServCom.Rows[Linha].Cells[2].Value = dataTableServ.Rows[Linha][2];
                    Linha++;
                }
                dataTableServ.Dispose();
            }
            int linhaServ = DataGridServCom.RowCount;
            bool ItemGridServ = false;
            foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
            {
                for (int l = 0; l < linhaServ; l++)
                {
                    if (DataGridServCom.Rows[l].Cells[0].FormattedValue.Equals(classServico_DTO.ID_Servico.ToString()))
                    {
                        ItemGridServ = true;
                    }

                }
                if (ItemGridServ == false)
                {
                    cmbServCadCom.Items.Add(classServico_DTO);
                }
                ItemGridServ = false;
            }
            int LinhasGrid = DataGridServCom.RowCount;
            i = LinhasGrid;
        }
        public void CarregaCMProd()
        {
            DataTable dataTableProd = new DataTable();
            dataTableProd = classComanda_BLL.ConsultaProdutoComanda(ID_Comanda);
            int tProd = 0;
            tProd = dataTableProd.Rows.Count;
            if (tProd > 0)
            {
                for (int Linha = 0; Linha < tProd;)
                {
                    DataGridCadProd.Rows.Add();
                    DataGridCadProd.Rows[Linha].Cells[0].Value = dataTableProd.Rows[Linha][0];
                    DataGridCadProd.Rows[Linha].Cells[1].Value = dataTableProd.Rows[Linha][1];
                    Linha++;
                }
                dataTableProd.Dispose();
            }
            int x = DataGridCadProd.RowCount;
            bool ItemGrid = false;
            foreach (ClassProduto_DTO classProduto_DTO in classProduto_BLL.ConsultaPorNome(""))
            {
                for (int l = 0; l < x; l++)
                {
                    if (DataGridCadProd.Rows[l].Cells[0].FormattedValue.Equals(classProduto_DTO.ID_Produto.ToString()))
                    {
                        ItemGrid = true;
                    }

                }
                if (ItemGrid == false)
                {
                    cmbProdCom.Items.Add(classProduto_DTO);
                }
                ItemGrid = false;
            }
            int LinhasGrid = DataGridServCom.RowCount;
            p = LinhasGrid;
        } 
        private void btnFecharProd_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnMinimizarProd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnAddServCadCom_Click(object sender, EventArgs e)
        {
             if (cmbServCadCom.Text.Equals("--Selecione--") || cmbServCadCom.Text == String.Empty)
              {
                  MessageBox.Show("Selecione um serviço!", "Serviço não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
              }
              DataGridServCom.Rows.Add();
              DataGridServCom.Rows[i].Cells[0].Value = ((ClassServico_DTO)cmbServCadCom.SelectedItem).ID_Servico;
              DataGridServCom.Rows[i].Cells[1].Value = ((ClassServico_DTO)cmbServCadCom.SelectedItem).Nome_Serv;
              DataGridServCom.Rows[i].Cells[2].Value = txtBoxPrecCadCom.Text;
              DataGridServCom.Rows[i].Cells[3].Value = ((ClassServico_DTO)cmbServCadCom.SelectedItem).Duracao_Serv;
              DataGridServCom.Rows[i].Cells[4].Value = ((ClassServico_DTO)cmbServCadCom.SelectedItem).Descricao_Serv;
              Total = Total + ((ClassServico_DTO)cmbServCadCom.SelectedItem).Preco_Serv;
              i++;
              txtBoxTotCadCom.Text = Total.ToString();
              cmbServCadCom.Items.RemoveAt(cmbServCadCom.SelectedIndex);
              cmbServCadCom.Text = "--Selecione--";
        }
        private void cmbServCadCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServCadCom.SelectedItem != null)
            {
                if (cmbServCadCom.Text != "--Selecione--")
                {
                    txtBoxPrecCadCom.Text = ((ClassServico_DTO)cmbServCadCom.SelectedItem).Preco_Serv.ToString();
                }
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
        private void btnCancelarCadCom_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Inserir)
            {
                LimparCampos();
                cmbServCadCom.Items.Clear();
                cmbServCadCom.Items.Add("--Selecione--");
                foreach (ClassServico_DTO classServico_DTO in classServico_BLL.ConsultaPorNome(""))
                {
                    cmbServCadCom.Items.Add(classServico_DTO);
                }
                cmbServCadCom.Text = "--Selecione--";

                cmbProdCom.Items.Clear();
                cmbProdCom.Items.Add("--Selecione--");
                var classProduto_BLL = new ClassProduto_BLL();
                foreach (ClassProduto_DTO classProduto_DTO in classProduto_BLL.ConsultaPorNome(""))
                {
                    cmbProdCom.Items.Add(classProduto_DTO);
                }
                cmbProdCom.Text = "--Selecione--";
            }
            else
            {
                this.Close();
                this.Dispose();
            }
        }
        private void LimparCampos()
        {
            cmbClienteCom.Text = "--Selecione--";
            cmbProfissional.Text = "--Selecione--";
            cmbServCadCom.Text = "--Selecione--";
            cmbProdCom.Text = "--Selecione--";
            txtBoxPrecCadCom.Text = "0,00";
            txtBoxTotCadCom.Text = "";
            DataGridServCom.Rows.Clear();
            DataGridCadProd.Rows.Clear();
        }
     
        private void btnSalvarCadCom_Click(object sender, EventArgs e)
        {
            ClassComanda_DTO classComanda_DTO = new ClassComanda_DTO();
            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Inserir)
            {
                try
                {
                    Int32 ID = 0;
                    try
                    {
                        classComanda_DTO.classCliente_DTO = new ClassCliente_DTO();
                        classComanda_DTO.classCliente_DTO.ID_Cliente = ((ClassCliente_DTO)cmbClienteCom.SelectedItem).ID_Cliente;
                        classComanda_DTO.classFuncionario_DTO = new ClassFuncionario_DTO();
                        classComanda_DTO.classFuncionario_DTO.ID_Funcionario = ((ClassFuncionario_DTO)cmbProfissional.SelectedItem).ID_Funcionario;
                        classComanda_DTO.ValorTotal_Com = Convert.ToDecimal(txtBoxTotCadCom.Text);
                        String IDComanda = classComanda_BLL.InserirComanda(classComanda_DTO);
                        ID = Convert.ToInt32(IDComanda);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao inserir a comanda. \n\n Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    int x = DataGridServCom.RowCount;
                    //Preencher o modelo e gravar no banco
                    for (int i = 0; i < x; i++)
                    {
                        classComanda_DTO.classServico_DTO = new ClassServico_DTO();
                        classComanda_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(DataGridServCom.Rows[i].Cells[0].Value);
                        classComanda_DTO.ID_Comanda = ID;
                        classComanda_BLL.InserirServicosComanda(classComanda_DTO);
                    }
                    int rowConunt = DataGridCadProd.RowCount;
                    //Preencher o modelo e gravar no banco
                    for (int i = 0; i < rowConunt; i++)
                    {
                        classComanda_DTO.classProduto_DTO = new ClassProduto_DTO();
                        classComanda_DTO.classProduto_DTO.ID_Produto = Convert.ToInt32(DataGridCadProd.Rows[i].Cells[0].Value);
                        classComanda_DTO.ID_Comanda = ID;
                        classComanda_BLL.InserirProdutoComanda(classComanda_DTO);
                    }
                    LimparCampos();
                    MessageBox.Show("Comanda salva com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro \n\n Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.No;
                }
            }
            if (acaoNaTelaSelecionada == ClassAcaoNaTela.Atualizar)
            {
                try
                {
                    Int32 ID = 0;
                    try
                    {
                        String IDComanda = classComanda_BLL.AtualizarComanda(ID_Comanda, Convert.ToDecimal(txtBoxTotCadCom.Text));
                        ID = Convert.ToInt32(IDComanda);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao inserir a comanda. \n\n Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int x = DataGridServCom.RowCount;
                    classComanda_BLL.ExcluirServicoComanda(ID_Comanda);
                    //Preencher o modelo e gravar no banco
                    for (int i = 0; i < x; i++)
                    {
                        classComanda_DTO.classServico_DTO = new ClassServico_DTO();
                        classComanda_DTO.classServico_DTO.ID_Servico = Convert.ToInt32(DataGridServCom.Rows[i].Cells[0].Value);
                        classComanda_DTO.ID_Comanda = ID;
                        classComanda_BLL.InserirServicosComanda(classComanda_DTO);
                    }
                    int rowConunt = DataGridCadProd.RowCount;
                    classComanda_BLL.ExcluirProdutoComanda(ID_Comanda);
                    //Preencher o modelo e gravar no banco
                    for (int i = 0; i < rowConunt; i++)
                    {
                        classComanda_DTO.classProduto_DTO = new ClassProduto_DTO();
                        classComanda_DTO.classProduto_DTO.ID_Produto = Convert.ToInt32(DataGridCadProd.Rows[i].Cells[0].Value);
                        classComanda_DTO.ID_Comanda = ID;
                        classComanda_BLL.InserirProdutoComanda(classComanda_DTO);
                    }
                    LimparCampos();
                    MessageBox.Show("Comanda salva com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro \n\n Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.No;

                }
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
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (cmbProdCom.Text.Equals("--Selecione--") || cmbProdCom.Text == String.Empty)
            {
                MessageBox.Show("Selecione um produto!", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridCadProd.Rows.Add();
            DataGridCadProd.Rows[p].Cells[0].Value = ((ClassProduto_DTO)cmbProdCom.SelectedItem).ID_Produto;
            DataGridCadProd.Rows[p].Cells[1].Value = ((ClassProduto_DTO)cmbProdCom.SelectedItem).Nome_Prod;
            DataGridCadProd.Rows[p].Cells[3].Value = ((ClassProduto_DTO)cmbProdCom.SelectedItem).Marca_Prod;
            DataGridCadProd.Rows[p].Cells[4].Value = ((ClassProduto_DTO)cmbProdCom.SelectedItem).Preco_Prod;
            p++;
            cmbProdCom.Items.RemoveAt(cmbProdCom.SelectedIndex);
            cmbProdCom.Text = "--Selecione--";
        }

        private void btnExcluServ_Click(object sender, EventArgs e)
        {
            Decimal ValorG = Convert.ToDecimal(DataGridServCom.SelectedRows[0].Cells[2].FormattedValue);
            Total = Total - ValorG;
            txtBoxTotCadCom.Text = Convert.ToString(Total);
            DataGridServCom.Rows.Remove(DataGridServCom.SelectedRows[0]);
            int x = DataGridServCom.RowCount;
            bool ValorNoGrid = false;
            cmbServCadCom.Items.Clear();
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
                    cmbServCadCom.Items.Add(classServico_DTO);
                }
                ValorNoGrid = false;
            }
            int LinhasGrid = DataGridServCom.RowCount;
            i = LinhasGrid;
            cmbServCadCom.Text = "--Selecione--";
            txtBoxPrecCadCom.Text = "0,00";
        }

        private void btnExcluProd_Click(object sender, EventArgs e)
        {
            DataGridCadProd.Rows.Remove(DataGridCadProd.SelectedRows[0]);
            int x = DataGridCadProd.RowCount;
            bool ValorNoGrid = false;
            cmbProdCom.Items.Clear();

            foreach (ClassProduto_DTO classProduto_DTO in classProduto_BLL.ConsultaPorNome(""))
            {
                for (int l = 0; l < x; l++)
                {
                    if (DataGridCadProd.RowCount > 0)
                    {
                        if (DataGridCadProd.Rows[l].Cells[0].Value.Equals(classProduto_DTO.ID_Produto))
                        {
                            ValorNoGrid = true;
                        }
                    }
                }

                if (ValorNoGrid == false)
                {
                    cmbProdCom.Items.Add(classProduto_DTO);
                }
                ValorNoGrid = false;

            }
            int LinhasGrid = DataGridCadProd.RowCount;
            p = LinhasGrid;
            cmbProdCom.Text = "--Selecione--";
        }

        private void txtBoxPrecCadCom_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtBoxPrecCadCom);
        }
    }
}
