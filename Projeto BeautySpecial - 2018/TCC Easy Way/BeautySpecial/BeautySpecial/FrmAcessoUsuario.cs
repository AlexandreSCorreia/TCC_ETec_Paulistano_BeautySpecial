using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaAcessoADados_DTO;
using CamadaLogicaDeNegocios_BLL;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmAcessoUsuario : Form
    {
        int GrupoID = 0;
        String UsuNomePesquisado = "";
        string operacao = "";
        bool mover = false;
        Point posicao_Inicial;


        Permissao_DTO modelousuariopermissao = new Permissao_DTO();
        Permissao_BLL permissaousuarioBLL = new Permissao_BLL();
        public FrmAcessoUsuario()
        {
            InitializeComponent();
        }
        
        public void alterarBotoes(int op)
        {
            // op = operacões que seram feitas com os botões
            // 1 = prepara os botões para inserir e localizar
            // 2 =  prepara para inserir/alterar um registro
            // 3 =  prepara a tela para inserir ou alterar

            dataGridPerm.Enabled = false;
            btnAtualizar.Enabled = false;
            btnAtualizar.BackColor = Color.Gainsboro;
            btnExcluir.Enabled = false;
            btnExcluir.BackColor = Color.Gainsboro;
            btnPesquisar.Enabled = false;
            btnPesquisar.BackColor = Color.Gainsboro;
            btnPesquisaPerm.Enabled = false;
            btnPesquisaPerm.BackColor = Color.Gainsboro;
            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.Gainsboro;
            btnSalvar.Enabled = false;
            btnSalvar.BackColor = Color.Gainsboro;
            GBMaDeTodos.Enabled = false;


            if (op == 1)
            {
                btnPesquisaPerm.Enabled = true;
                if (btnPesquisaPerm.Enabled == false) { btnPesquisaPerm.BackColor = Color.Gainsboro; } else { btnPesquisaPerm.BackColor = Color.MediumSlateBlue; }
                btnPesquisar.Enabled = true;
                if (btnPesquisar.Enabled == false) { btnPesquisar.BackColor = Color.Gainsboro; } else { btnPesquisar.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = false;
            }
            if (op == 2)
            {
                dataGridPerm.Enabled = true;

                GBMaDeTodos.Enabled = true;

                btnSalvar.Enabled = true;
                if (btnSalvar.Enabled == false) { btnSalvar.BackColor = Color.Gainsboro; } else { btnSalvar.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = true;
                if (btnCancelar.Enabled == false) { btnCancelar.BackColor = Color.Gainsboro; } else { btnCancelar.BackColor = Color.MediumSlateBlue; }
            }
            if (op == 3)
            {
                btnAtualizar.Enabled = true;
                if (btnAtualizar.Enabled == false) { btnAtualizar.BackColor = Color.Gainsboro; } else { btnAtualizar.BackColor = Color.MediumSlateBlue; }
                btnExcluir.Enabled = true;
                if (btnExcluir.Enabled == false) { btnExcluir.BackColor = Color.Gainsboro; } else { btnExcluir.BackColor = Color.MediumSlateBlue; }
                btnCancelar.Enabled = true;
                if (btnCancelar.Enabled == false) { btnCancelar.BackColor = Color.Gainsboro; } else { btnCancelar.BackColor = Color.MediumSlateBlue; }
            }
        }

        private void btnPesquisaPerm_Click(object sender, EventArgs e)
        {
            try
            {
                ClassGrupo_BLL grupoBLL = new ClassGrupo_BLL();
                 DataTable tabela = new DataTable();
                //Verificar se tem usuario com o id digitado
                if (grupoBLL.LocalizarGruPorID(Convert.ToInt32(txtPesquisa.Text)).Rows.Count <= 0)
                {
                    MessageBox.Show("Atenção!! O código digitado não corresponde a nenhum grupo! ", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesquisa.Focus();
                    txtPesquisa.Text = "";
                    return;
                }
                    tabela = permissaousuarioBLL.ConsultaPermGru(Convert.ToInt32(txtPesquisa.Text));
                    int tPerm = 0;
                    tPerm = tabela.Rows.Count;
                    if (tPerm > 0)
                    {
                        //Carrega as permissões que o usuario ja possui no banco de dados
                        for (int x = 0; x < tPerm;)
                        {
                            dataGridPerm.Rows.Add();
                            dataGridPerm.Rows[x].Cells[0].Value = tabela.Rows[x][0];
                            dataGridPerm.Rows[x].Cells[1].Value = tabela.Rows[x][1];
                            dataGridPerm.Rows[x].Cells[2].Value = tabela.Rows[x][2];
                            dataGridPerm.Rows[x].Cells[3].Value = tabela.Rows[x][3];
                            dataGridPerm.Rows[x].Cells[4].Value = tabela.Rows[x][4];
                            dataGridPerm.Rows[x].Cells[5].Value = tabela.Rows[x][5];
                            dataGridPerm.Rows[x].Cells[6].Value = tabela.Rows[x][6];
                            dataGridPerm.Rows[x].Cells[7].Value = tabela.Rows[x][7];

                            x++;
                        }
                        GrupoID = Convert.ToInt32(tabela.Rows[0][8]);
                        UsuNomePesquisado = Convert.ToString(tabela.Rows[0][9]);
                        alterarBotoes(3);
                        tabela.Dispose();
                    }
                    else
                    {

                        DataTable tabelaUsu = new DataTable();
                        tabelaUsu = grupoBLL.LocalizarGruPorID(Convert.ToInt32(txtPesquisa.Text));
                        GrupoID = Convert.ToInt32(tabelaUsu.Rows[0][0]);
                        UsuNomePesquisado = Convert.ToString(tabelaUsu.Rows[0][1]);

                        //Carregar permissões Default
                        IDictionary<String, string> stgPerm = new Dictionary<String, string>()
                    {
                        //Cadastro dos formularios
                        {"FrmProdutos" ,"Produtos"},
                        {"FrmServicos" ,"Serviços"},
                        {"FrmFinancas" ,"Finanças"},
                        {"FrmCliente" ,"Clientes"},
                         {"FrmControleComanda" ,"Comanda"},
                        {"FrmFuncionario" ,"Funcionarios"},
                        {"FrmPermissaoUsuario" ,"Cadastrar permissão de acesso ao funcionario"}

                    };
                        int i = 0;
                        foreach (String Perm in stgPerm.Keys)
                        {
                            dataGridPerm.Rows.Add();
                            dataGridPerm.Rows[i].Cells[1].Value = Perm;
                            dataGridPerm.Rows[i].Cells[2].Value = stgPerm[Perm];
                            if (Perm == "FrmFuncionario" || Perm == "FrmPermissaoUsuario"
                            || Perm == "FrmFinancas" || Perm == "FrmServicos")
                            {
                                dataGridPerm.Rows[i].Cells[3].Value = "true";
                            }
                            else
                            {
                                dataGridPerm.Rows[i].Cells[3].Value = "false";
                                dataGridPerm.Rows[i].Cells[4].Value = "false";
                                dataGridPerm.Rows[i].Cells[5].Value = "false";
                                dataGridPerm.Rows[i].Cells[6].Value = "false";
                                dataGridPerm.Rows[i].Cells[7].Value = "false";
                            }
                            i++;
                        }
                        MessageBox.Show("Atenção!! \n As configurações padrão(Default) foram carregadas para o grupo! \n\n" +
                            "Realize as devidas alterações e click em salvar, para o grupo ter acesso ao sistema", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        operacao = "Inserir";
                        alterarBotoes(2);
                    }
                    txtUsuarioPesquisado.Text = UsuNomePesquisado;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void FrmPermissaoUsuario_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            operacao = "Atualizar";
            alterarBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alterarBotoes(1);
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (operacao == "Atualizar")
            {
                //Excluir a permissao do usuario
                permissaousuarioBLL.ExcluirPermUsuario(GrupoID);

            }

            int x = dataGridPerm.RowCount;
            //Preencher o modelo e gravar no banco
            for (int i = 0; i < x; i++)
            {
                modelousuariopermissao.ClassGrupo_DTO = new ClassGrupo_DTO();
                modelousuariopermissao.ClassGrupo_DTO.ID_Grupo = Convert.ToInt32(GrupoID);
                modelousuariopermissao.per_nomeform = Convert.ToString(dataGridPerm.Rows[i].Cells[1].Value);
                modelousuariopermissao.per_Descricao = Convert.ToString(dataGridPerm.Rows[i].Cells[2].Value);
                modelousuariopermissao.per_bloquear = Convert.ToBoolean(dataGridPerm.Rows[i].Cells[3].Value).ToString();
                modelousuariopermissao.per_inserir = Convert.ToBoolean(dataGridPerm.Rows[i].Cells[4].Value).ToString();
                modelousuariopermissao.per_atualizar = Convert.ToBoolean(dataGridPerm.Rows[i].Cells[5].Value).ToString();
                modelousuariopermissao.per_excluir = Convert.ToBoolean(dataGridPerm.Rows[i].Cells[6].Value).ToString();
                modelousuariopermissao.per_consultar = Convert.ToBoolean(dataGridPerm.Rows[i].Cells[7].Value).ToString();
                permissaousuarioBLL.InserirPermUsuario(modelousuariopermissao);
               
            }
            MessageBox.Show("As permissões foram cadastradas com sucesso!!!","Aviso!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            alterarBotoes(1);
            operacao = "";
            LimparCampos();
        }

       

        private void cbBloquear_CheckedChanged(object sender, EventArgs e)
        {
            int x = dataGridPerm.RowCount;
            for (int i = 0; i < x; i++)
            {
                dataGridPerm.Rows[i].Cells[3].Value = cbBloquear.Checked;
            }
        }

        private void cbinserir_CheckedChanged(object sender, EventArgs e)
        {
            int x = dataGridPerm.RowCount;
            for (int i = 0; i < x; i++)
            {
                dataGridPerm.Rows[i].Cells[4].Value = cbinserir.Checked;
            }
        }

        private void cbatualizar_CheckedChanged(object sender, EventArgs e)
        {
            int x = dataGridPerm.RowCount;
            for (int i = 0; i < x; i++)
            {
                dataGridPerm.Rows[i].Cells[5].Value = cbatualizar.Checked;
            }
        }

        private void cbexcluir_CheckedChanged(object sender, EventArgs e)
        {
            int x = dataGridPerm.RowCount;
            for (int i = 0; i < x; i++)
            {
                dataGridPerm.Rows[i].Cells[6].Value = cbexcluir.Checked;
            }
        }

        private void cbconsultar_CheckedChanged(object sender, EventArgs e)
        {
            int x = dataGridPerm.RowCount;
            for (int i = 0; i < x; i++)
            {
                dataGridPerm.Rows[i].Cells[7].Value = cbconsultar.Checked;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarGruposUsuarios consultarGruposUsuarios = new ConsultarGruposUsuarios();

            consultarGruposUsuarios.ShowDialog();

            if (consultarGruposUsuarios.ClassGrupo_DTO.ID_Grupo != 0)
            {
                txtPesquisa.Text = consultarGruposUsuarios.ClassGrupo_DTO.ID_Grupo.ToString();
                btnPesquisaPerm_Click(sender, e);
                alterarBotoes(3);
            }
            else
            {
                alterarBotoes(1);
            }
            consultarGruposUsuarios.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dataGridPerm.Rows[0].Cells[0].Value) <= 0)
                {
                    dataGridPerm.Rows.Clear();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Deseja excluir Todas as permissões do grupo pesquisado?"+
                    "\n\n Atenção!! sem as permissões, o usuário não consseguirá acessar o sistema","Aviso!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (dialogResult.ToString() == "Yes")
                {
                    permissaousuarioBLL.ExcluirPermUsuario(GrupoID);
                    LimparCampos();
                    alterarBotoes(1);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Impossivel excluir o registro. \n O registro está sendo ultilizado em outro local.");
                this.alterarBotoes(3);
            }
        }


        public void LimparCampos()
        {
            cbBloquear.Checked =false;
            cbinserir.Checked = false;
            cbatualizar.Checked = false;
            cbexcluir.Checked = false;
            cbconsultar.Checked = false;
            GrupoID = 0;
            dataGridPerm.Rows.Clear();
            UsuNomePesquisado = "";
            txtPesquisa.Text = "";
            txtUsuarioPesquisado.Text = "";
        }

        private void btnFecharAcess_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnMinimizarAcess_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
