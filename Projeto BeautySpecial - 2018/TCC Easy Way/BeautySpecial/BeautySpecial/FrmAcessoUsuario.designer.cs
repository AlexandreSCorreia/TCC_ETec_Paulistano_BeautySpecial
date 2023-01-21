namespace Apresentacao
{
    partial class FrmAcessoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcessoUsuario));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dataGridPerm = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloquear = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inserir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.atualizar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consultar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPesquisaPerm = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioPesquisado = new System.Windows.Forms.TextBox();
            this.GBMaDeTodos = new System.Windows.Forms.GroupBox();
            this.cbconsultar = new System.Windows.Forms.CheckBox();
            this.cbexcluir = new System.Windows.Forms.CheckBox();
            this.cbatualizar = new System.Windows.Forms.CheckBox();
            this.cbinserir = new System.Windows.Forms.CheckBox();
            this.cbBloquear = new System.Windows.Forms.CheckBox();
            this.GBPermUsu = new System.Windows.Forms.GroupBox();
            this.lblEmpresaAcess = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblMsgPermUsua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFecharAcess = new System.Windows.Forms.Button();
            this.btnMinimizarAcess = new System.Windows.Forms.Button();
            this.picBoxLogoAcess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerm)).BeginInit();
            this.GBMaDeTodos.SuspendLayout();
            this.GBPermUsu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoAcess)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(586, 619);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 37);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(956, 619);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(832, 619);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 37);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(709, 619);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 37);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(463, 619);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 37);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dataGridPerm
            // 
            this.dataGridPerm.AllowUserToAddRows = false;
            this.dataGridPerm.AllowUserToDeleteRows = false;
            this.dataGridPerm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomeform,
            this.formulario,
            this.bloquear,
            this.inserir,
            this.atualizar,
            this.excluir,
            this.consultar});
            this.dataGridPerm.Location = new System.Drawing.Point(36, 87);
            this.dataGridPerm.Name = "dataGridPerm";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPerm.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridPerm.RowHeadersVisible = false;
            this.dataGridPerm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPerm.Size = new System.Drawing.Size(997, 247);
            this.dataGridPerm.TabIndex = 14;
            // 
            // codigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // nomeform
            // 
            this.nomeform.HeaderText = "nomeform";
            this.nomeform.Name = "nomeform";
            this.nomeform.Visible = false;
            // 
            // formulario
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formulario.DefaultCellStyle = dataGridViewCellStyle3;
            this.formulario.HeaderText = "Formulário";
            this.formulario.Name = "formulario";
            this.formulario.ReadOnly = true;
            this.formulario.Width = 300;
            // 
            // bloquear
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.NullValue = false;
            this.bloquear.DefaultCellStyle = dataGridViewCellStyle4;
            this.bloquear.HeaderText = "Bloquear";
            this.bloquear.Name = "bloquear";
            this.bloquear.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bloquear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bloquear.Width = 90;
            // 
            // inserir
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.NullValue = false;
            this.inserir.DefaultCellStyle = dataGridViewCellStyle5;
            this.inserir.HeaderText = "Inserir";
            this.inserir.Name = "inserir";
            this.inserir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inserir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inserir.Width = 90;
            // 
            // atualizar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.NullValue = false;
            this.atualizar.DefaultCellStyle = dataGridViewCellStyle6;
            this.atualizar.HeaderText = "Atualizar";
            this.atualizar.Name = "atualizar";
            this.atualizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.atualizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.atualizar.Width = 90;
            // 
            // excluir
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.NullValue = false;
            this.excluir.DefaultCellStyle = dataGridViewCellStyle7;
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.Width = 90;
            // 
            // consultar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.NullValue = false;
            this.consultar.DefaultCellStyle = dataGridViewCellStyle8;
            this.consultar.HeaderText = "Consultar";
            this.consultar.Name = "consultar";
            this.consultar.Width = 90;
            // 
            // btnPesquisaPerm
            // 
            this.btnPesquisaPerm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPesquisaPerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaPerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaPerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaPerm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaPerm.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaPerm.Location = new System.Drawing.Point(906, 38);
            this.btnPesquisaPerm.Name = "btnPesquisaPerm";
            this.btnPesquisaPerm.Size = new System.Drawing.Size(124, 37);
            this.btnPesquisaPerm.TabIndex = 17;
            this.btnPesquisaPerm.Text = "Pesquisar";
            this.btnPesquisaPerm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisaPerm.UseVisualStyleBackColor = false;
            this.btnPesquisaPerm.Click += new System.EventHandler(this.btnPesquisaPerm_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(33, 49);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(298, 26);
            this.txtPesquisa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código do grupo:";
            // 
            // txtUsuarioPesquisado
            // 
            this.txtUsuarioPesquisado.Enabled = false;
            this.txtUsuarioPesquisado.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioPesquisado.Location = new System.Drawing.Point(13, 29);
            this.txtUsuarioPesquisado.Name = "txtUsuarioPesquisado";
            this.txtUsuarioPesquisado.Size = new System.Drawing.Size(279, 26);
            this.txtUsuarioPesquisado.TabIndex = 18;
            // 
            // GBMaDeTodos
            // 
            this.GBMaDeTodos.BackColor = System.Drawing.Color.Transparent;
            this.GBMaDeTodos.Controls.Add(this.cbconsultar);
            this.GBMaDeTodos.Controls.Add(this.cbexcluir);
            this.GBMaDeTodos.Controls.Add(this.cbatualizar);
            this.GBMaDeTodos.Controls.Add(this.cbinserir);
            this.GBMaDeTodos.Controls.Add(this.cbBloquear);
            this.GBMaDeTodos.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMaDeTodos.ForeColor = System.Drawing.Color.Black;
            this.GBMaDeTodos.Location = new System.Drawing.Point(338, 16);
            this.GBMaDeTodos.Name = "GBMaDeTodos";
            this.GBMaDeTodos.Size = new System.Drawing.Size(695, 65);
            this.GBMaDeTodos.TabIndex = 19;
            this.GBMaDeTodos.TabStop = false;
            this.GBMaDeTodos.Text = "Marcar / Desmarcar Todos";
            // 
            // cbconsultar
            // 
            this.cbconsultar.AutoSize = true;
            this.cbconsultar.Location = new System.Drawing.Point(399, 32);
            this.cbconsultar.Name = "cbconsultar";
            this.cbconsultar.Size = new System.Drawing.Size(15, 14);
            this.cbconsultar.TabIndex = 4;
            this.cbconsultar.UseVisualStyleBackColor = true;
            this.cbconsultar.CheckedChanged += new System.EventHandler(this.cbconsultar_CheckedChanged);
            // 
            // cbexcluir
            // 
            this.cbexcluir.AutoSize = true;
            this.cbexcluir.Location = new System.Drawing.Point(312, 32);
            this.cbexcluir.Name = "cbexcluir";
            this.cbexcluir.Size = new System.Drawing.Size(15, 14);
            this.cbexcluir.TabIndex = 3;
            this.cbexcluir.UseVisualStyleBackColor = true;
            this.cbexcluir.CheckedChanged += new System.EventHandler(this.cbexcluir_CheckedChanged);
            // 
            // cbatualizar
            // 
            this.cbatualizar.AutoSize = true;
            this.cbatualizar.Location = new System.Drawing.Point(216, 32);
            this.cbatualizar.Name = "cbatualizar";
            this.cbatualizar.Size = new System.Drawing.Size(15, 14);
            this.cbatualizar.TabIndex = 2;
            this.cbatualizar.UseVisualStyleBackColor = true;
            this.cbatualizar.CheckedChanged += new System.EventHandler(this.cbatualizar_CheckedChanged);
            // 
            // cbinserir
            // 
            this.cbinserir.AutoSize = true;
            this.cbinserir.Location = new System.Drawing.Point(125, 32);
            this.cbinserir.Name = "cbinserir";
            this.cbinserir.Size = new System.Drawing.Size(15, 14);
            this.cbinserir.TabIndex = 1;
            this.cbinserir.UseVisualStyleBackColor = true;
            this.cbinserir.CheckedChanged += new System.EventHandler(this.cbinserir_CheckedChanged);
            // 
            // cbBloquear
            // 
            this.cbBloquear.AutoSize = true;
            this.cbBloquear.Location = new System.Drawing.Point(38, 32);
            this.cbBloquear.Name = "cbBloquear";
            this.cbBloquear.Size = new System.Drawing.Size(15, 14);
            this.cbBloquear.TabIndex = 0;
            this.cbBloquear.UseVisualStyleBackColor = true;
            this.cbBloquear.CheckedChanged += new System.EventHandler(this.cbBloquear_CheckedChanged);
            // 
            // GBPermUsu
            // 
            this.GBPermUsu.BackColor = System.Drawing.Color.Transparent;
            this.GBPermUsu.Controls.Add(this.txtUsuarioPesquisado);
            this.GBPermUsu.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPermUsu.ForeColor = System.Drawing.Color.Black;
            this.GBPermUsu.Location = new System.Drawing.Point(360, 20);
            this.GBPermUsu.Name = "GBPermUsu";
            this.GBPermUsu.Size = new System.Drawing.Size(298, 69);
            this.GBPermUsu.TabIndex = 20;
            this.GBPermUsu.TabStop = false;
            this.GBPermUsu.Text = "Nome do grupo";
            // 
            // lblEmpresaAcess
            // 
            this.lblEmpresaAcess.AutoSize = true;
            this.lblEmpresaAcess.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblEmpresaAcess.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaAcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresaAcess.Location = new System.Drawing.Point(86, 19);
            this.lblEmpresaAcess.Name = "lblEmpresaAcess";
            this.lblEmpresaAcess.Size = new System.Drawing.Size(204, 18);
            this.lblEmpresaAcess.TabIndex = 105;
            this.lblEmpresaAcess.Text = "Easy Way BeautySpecial";
            this.lblEmpresaAcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblEmpresaAcess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblEmpresaAcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkOrchid;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1083, 65);
            this.label23.TabIndex = 101;
            this.label23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // lblMsgPermUsua
            // 
            this.lblMsgPermUsua.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPermUsua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgPermUsua.Location = new System.Drawing.Point(2, 83);
            this.lblMsgPermUsua.Name = "lblMsgPermUsua";
            this.lblMsgPermUsua.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgPermUsua.TabIndex = 100;
            this.lblMsgPermUsua.Text = "Acesso de Usúario";
            this.lblMsgPermUsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisaPerm);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.GBPermUsu);
            this.groupBox1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 101);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dataGridPerm);
            this.groupBox2.Controls.Add(this.GBMaDeTodos);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 351);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // btnFecharAcess
            // 
            this.btnFecharAcess.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharAcess.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharAcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharAcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharAcess.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharAcess.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharAcess.Location = new System.Drawing.Point(1035, 9);
            this.btnFecharAcess.Name = "btnFecharAcess";
            this.btnFecharAcess.Size = new System.Drawing.Size(33, 29);
            this.btnFecharAcess.TabIndex = 103;
            this.btnFecharAcess.UseVisualStyleBackColor = false;
            this.btnFecharAcess.Click += new System.EventHandler(this.btnFecharAcess_Click);
            // 
            // btnMinimizarAcess
            // 
            this.btnMinimizarAcess.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarAcess.BackgroundImage = global::BeautySpecial.Properties.Resources.Minimizar;
            this.btnMinimizarAcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarAcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarAcess.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarAcess.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarAcess.Location = new System.Drawing.Point(987, 9);
            this.btnMinimizarAcess.Name = "btnMinimizarAcess";
            this.btnMinimizarAcess.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizarAcess.TabIndex = 102;
            this.btnMinimizarAcess.UseVisualStyleBackColor = false;
            this.btnMinimizarAcess.Click += new System.EventHandler(this.btnMinimizarAcess_Click);
            // 
            // picBoxLogoAcess
            // 
            this.picBoxLogoAcess.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoAcess.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoAcess.Image")));
            this.picBoxLogoAcess.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoAcess.Name = "picBoxLogoAcess";
            this.picBoxLogoAcess.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoAcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoAcess.TabIndex = 104;
            this.picBoxLogoAcess.TabStop = false;
            this.picBoxLogoAcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoAcess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoAcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // FrmAcessoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEmpresaAcess);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFecharAcess);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnMinimizarAcess);
            this.Controls.Add(this.picBoxLogoAcess);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblMsgPermUsua);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmAcessoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissao de Usuário";
            this.Load += new System.EventHandler(this.FrmPermissaoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerm)).EndInit();
            this.GBMaDeTodos.ResumeLayout(false);
            this.GBMaDeTodos.PerformLayout();
            this.GBPermUsu.ResumeLayout(false);
            this.GBPermUsu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoAcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnPesquisar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dataGridPerm;
        protected System.Windows.Forms.Button btnPesquisaPerm;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioPesquisado;
        private System.Windows.Forms.GroupBox GBMaDeTodos;
        private System.Windows.Forms.CheckBox cbexcluir;
        private System.Windows.Forms.CheckBox cbatualizar;
        private System.Windows.Forms.CheckBox cbinserir;
        private System.Windows.Forms.CheckBox cbBloquear;
        private System.Windows.Forms.CheckBox cbconsultar;
        private System.Windows.Forms.GroupBox GBPermUsu;
        private System.Windows.Forms.Label lblEmpresaAcess;
        private System.Windows.Forms.Button btnFecharAcess;
        private System.Windows.Forms.Button btnMinimizarAcess;
        private System.Windows.Forms.PictureBox picBoxLogoAcess;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMsgPermUsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeform;
        private System.Windows.Forms.DataGridViewTextBoxColumn formulario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloquear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inserir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn atualizar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn consultar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}