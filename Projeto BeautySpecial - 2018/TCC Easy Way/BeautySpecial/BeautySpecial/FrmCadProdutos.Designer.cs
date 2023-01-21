namespace Apresentacao
{
    partial class FrmCadProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProdutos));
            this.lblMsgProdutos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCadProd = new System.Windows.Forms.Button();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.DataGridServCom = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbServProv = new System.Windows.Forms.ComboBox();
            this.btnAddServCadCom = new System.Windows.Forms.Button();
            this.lblServCadCom = new System.Windows.Forms.Label();
            this.lblMsgPrecoProd = new System.Windows.Forms.Label();
            this.lblMsgMarcaProd = new System.Windows.Forms.Label();
            this.lblMsgNomeProd = new System.Windows.Forms.Label();
            this.txtBoxQuantProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDescProd = new System.Windows.Forms.TextBox();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.txtBoxMarcProd = new System.Windows.Forms.TextBox();
            this.lblMarcProd = new System.Windows.Forms.Label();
            this.txtBoxPrecProd = new System.Windows.Forms.TextBox();
            this.lblPrecProd = new System.Windows.Forms.Label();
            this.txtBoxNomeProd = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.lblEmpresaProd = new System.Windows.Forms.Label();
            this.btnFecharProd = new System.Windows.Forms.Button();
            this.btnMinimizarProd = new System.Windows.Forms.Button();
            this.picBoxLogoProd = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsgProdutos
            // 
            this.lblMsgProdutos.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgProdutos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgProdutos.Location = new System.Drawing.Point(2, 83);
            this.lblMsgProdutos.Name = "lblMsgProdutos";
            this.lblMsgProdutos.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgProdutos.TabIndex = 40;
            this.lblMsgProdutos.Text = "Cadastro de Produtos";
            this.lblMsgProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnCancelarCadProd);
            this.groupBox1.Controls.Add(this.btnSalvarProd);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 487);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelarCadProd
            // 
            this.btnCancelarCadProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadProd.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCadProd.Location = new System.Drawing.Point(935, 429);
            this.btnCancelarCadProd.Name = "btnCancelarCadProd";
            this.btnCancelarCadProd.Size = new System.Drawing.Size(108, 37);
            this.btnCancelarCadProd.TabIndex = 14;
            this.btnCancelarCadProd.Text = "Cancelar";
            this.btnCancelarCadProd.UseVisualStyleBackColor = false;
            this.btnCancelarCadProd.Click += new System.EventHandler(this.btnCancelarCadProd_Click);
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProd.ForeColor = System.Drawing.Color.White;
            this.btnSalvarProd.Location = new System.Drawing.Point(812, 429);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(108, 37);
            this.btnSalvarProd.TabIndex = 8;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 387);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.DataGridServCom);
            this.groupBox2.Controls.Add(this.cmbServProv);
            this.groupBox2.Controls.Add(this.btnAddServCadCom);
            this.groupBox2.Controls.Add(this.lblServCadCom);
            this.groupBox2.Controls.Add(this.lblMsgPrecoProd);
            this.groupBox2.Controls.Add(this.lblMsgMarcaProd);
            this.groupBox2.Controls.Add(this.lblMsgNomeProd);
            this.groupBox2.Controls.Add(this.txtBoxQuantProd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBoxDescProd);
            this.groupBox2.Controls.Add(this.lblDescProd);
            this.groupBox2.Controls.Add(this.txtBoxMarcProd);
            this.groupBox2.Controls.Add(this.lblMarcProd);
            this.groupBox2.Controls.Add(this.txtBoxPrecProd);
            this.groupBox2.Controls.Add(this.lblPrecProd);
            this.groupBox2.Controls.Add(this.txtBoxNomeProd);
            this.groupBox2.Controls.Add(this.lblNomeProd);
            this.groupBox2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 339);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::BeautySpecial.Properties.Resources.Excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(914, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(30, 26);
            this.btnExcluir.TabIndex = 109;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // DataGridServCom
            // 
            this.DataGridServCom.AllowUserToAddRows = false;
            this.DataGridServCom.AllowUserToDeleteRows = false;
            this.DataGridServCom.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridServCom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridServCom.ColumnHeadersHeight = 26;
            this.DataGridServCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridServCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.servico,
            this.precoserv,
            this.duracao,
            this.descricao});
            this.DataGridServCom.Location = new System.Drawing.Point(540, 83);
            this.DataGridServCom.Name = "DataGridServCom";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridServCom.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridServCom.RowHeadersVisible = false;
            this.DataGridServCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridServCom.Size = new System.Drawing.Size(441, 241);
            this.DataGridServCom.TabIndex = 108;
            this.DataGridServCom.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridServCom_CellFormatting);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "classServico_DTO.ID_Servico";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.DefaultCellStyle = dataGridViewCellStyle8;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // servico
            // 
            this.servico.DataPropertyName = "classServico_DTO.Nome_Serv";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servico.DefaultCellStyle = dataGridViewCellStyle9;
            this.servico.HeaderText = "Serviço";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            this.servico.Width = 438;
            // 
            // precoserv
            // 
            this.precoserv.DataPropertyName = "Preco_Serv";
            this.precoserv.HeaderText = "Preço";
            this.precoserv.Name = "precoserv";
            this.precoserv.ReadOnly = true;
            this.precoserv.Visible = false;
            // 
            // duracao
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracao.DefaultCellStyle = dataGridViewCellStyle10;
            this.duracao.HeaderText = "Duração";
            this.duracao.Name = "duracao";
            this.duracao.ReadOnly = true;
            this.duracao.Visible = false;
            // 
            // descricao
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.DefaultCellStyle = dataGridViewCellStyle11;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Visible = false;
            this.descricao.Width = 350;
            // 
            // cmbServProv
            // 
            this.cmbServProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbServProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbServProv.DisplayMember = "Nome_Serv";
            this.cmbServProv.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServProv.FormattingEnabled = true;
            this.cmbServProv.Location = new System.Drawing.Point(604, 24);
            this.cmbServProv.Name = "cmbServProv";
            this.cmbServProv.Size = new System.Drawing.Size(300, 26);
            this.cmbServProv.TabIndex = 106;
            // 
            // btnAddServCadCom
            // 
            this.btnAddServCadCom.BackgroundImage = global::BeautySpecial.Properties.Resources.Adicionar;
            this.btnAddServCadCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddServCadCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServCadCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServCadCom.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddServCadCom.Location = new System.Drawing.Point(950, 24);
            this.btnAddServCadCom.Name = "btnAddServCadCom";
            this.btnAddServCadCom.Size = new System.Drawing.Size(31, 25);
            this.btnAddServCadCom.TabIndex = 105;
            this.btnAddServCadCom.UseVisualStyleBackColor = true;
            this.btnAddServCadCom.Click += new System.EventHandler(this.btnAddServProd_Click);
            // 
            // lblServCadCom
            // 
            this.lblServCadCom.AutoSize = true;
            this.lblServCadCom.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServCadCom.Location = new System.Drawing.Point(537, 31);
            this.lblServCadCom.Name = "lblServCadCom";
            this.lblServCadCom.Size = new System.Drawing.Size(60, 18);
            this.lblServCadCom.TabIndex = 103;
            this.lblServCadCom.Text = "Serviço";
            // 
            // lblMsgPrecoProd
            // 
            this.lblMsgPrecoProd.AutoSize = true;
            this.lblMsgPrecoProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPrecoProd.ForeColor = System.Drawing.Color.Black;
            this.lblMsgPrecoProd.Location = new System.Drawing.Point(96, 126);
            this.lblMsgPrecoProd.Name = "lblMsgPrecoProd";
            this.lblMsgPrecoProd.Size = new System.Drawing.Size(16, 18);
            this.lblMsgPrecoProd.TabIndex = 43;
            this.lblMsgPrecoProd.Text = "*";
            // 
            // lblMsgMarcaProd
            // 
            this.lblMsgMarcaProd.AutoSize = true;
            this.lblMsgMarcaProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgMarcaProd.ForeColor = System.Drawing.Color.Black;
            this.lblMsgMarcaProd.Location = new System.Drawing.Point(96, 77);
            this.lblMsgMarcaProd.Name = "lblMsgMarcaProd";
            this.lblMsgMarcaProd.Size = new System.Drawing.Size(16, 18);
            this.lblMsgMarcaProd.TabIndex = 42;
            this.lblMsgMarcaProd.Text = "*";
            // 
            // lblMsgNomeProd
            // 
            this.lblMsgNomeProd.AutoSize = true;
            this.lblMsgNomeProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgNomeProd.ForeColor = System.Drawing.Color.Black;
            this.lblMsgNomeProd.Location = new System.Drawing.Point(96, 27);
            this.lblMsgNomeProd.Name = "lblMsgNomeProd";
            this.lblMsgNomeProd.Size = new System.Drawing.Size(16, 18);
            this.lblMsgNomeProd.TabIndex = 41;
            this.lblMsgNomeProd.Text = "*";
            // 
            // txtBoxQuantProd
            // 
            this.txtBoxQuantProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuantProd.Location = new System.Drawing.Point(118, 174);
            this.txtBoxQuantProd.Name = "txtBoxQuantProd";
            this.txtBoxQuantProd.Size = new System.Drawing.Size(107, 26);
            this.txtBoxQuantProd.TabIndex = 4;
            this.txtBoxQuantProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantidade";
            // 
            // txtBoxDescProd
            // 
            this.txtBoxDescProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescProd.Location = new System.Drawing.Point(118, 220);
            this.txtBoxDescProd.Multiline = true;
            this.txtBoxDescProd.Name = "txtBoxDescProd";
            this.txtBoxDescProd.Size = new System.Drawing.Size(390, 104);
            this.txtBoxDescProd.TabIndex = 5;
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescProd.Location = new System.Drawing.Point(20, 221);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(77, 18);
            this.lblDescProd.TabIndex = 38;
            this.lblDescProd.Text = "Descrição";
            // 
            // txtBoxMarcProd
            // 
            this.txtBoxMarcProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMarcProd.Location = new System.Drawing.Point(118, 74);
            this.txtBoxMarcProd.Name = "txtBoxMarcProd";
            this.txtBoxMarcProd.Size = new System.Drawing.Size(156, 26);
            this.txtBoxMarcProd.TabIndex = 2;
            // 
            // lblMarcProd
            // 
            this.lblMarcProd.AutoSize = true;
            this.lblMarcProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcProd.Location = new System.Drawing.Point(45, 77);
            this.lblMarcProd.Name = "lblMarcProd";
            this.lblMarcProd.Size = new System.Drawing.Size(52, 18);
            this.lblMarcProd.TabIndex = 36;
            this.lblMarcProd.Text = "Marca";
            // 
            // txtBoxPrecProd
            // 
            this.txtBoxPrecProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecProd.Location = new System.Drawing.Point(118, 123);
            this.txtBoxPrecProd.Name = "txtBoxPrecProd";
            this.txtBoxPrecProd.Size = new System.Drawing.Size(107, 26);
            this.txtBoxPrecProd.TabIndex = 3;
            this.txtBoxPrecProd.TextChanged += new System.EventHandler(this.txtBoxPrecProd_TextChanged);
            this.txtBoxPrecProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lblPrecProd
            // 
            this.lblPrecProd.AutoSize = true;
            this.lblPrecProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecProd.Location = new System.Drawing.Point(49, 126);
            this.lblPrecProd.Name = "lblPrecProd";
            this.lblPrecProd.Size = new System.Drawing.Size(48, 18);
            this.lblPrecProd.TabIndex = 34;
            this.lblPrecProd.Text = "Preço";
            // 
            // txtBoxNomeProd
            // 
            this.txtBoxNomeProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeProd.Location = new System.Drawing.Point(118, 24);
            this.txtBoxNomeProd.Name = "txtBoxNomeProd";
            this.txtBoxNomeProd.Size = new System.Drawing.Size(267, 26);
            this.txtBoxNomeProd.TabIndex = 1;
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.Location = new System.Drawing.Point(45, 27);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(49, 18);
            this.lblNomeProd.TabIndex = 32;
            this.lblNomeProd.Text = "Nome";
            // 
            // lblEmpresaProd
            // 
            this.lblEmpresaProd.AutoSize = true;
            this.lblEmpresaProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblEmpresaProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresaProd.Location = new System.Drawing.Point(86, 19);
            this.lblEmpresaProd.Name = "lblEmpresaProd";
            this.lblEmpresaProd.Size = new System.Drawing.Size(204, 18);
            this.lblEmpresaProd.TabIndex = 66;
            this.lblEmpresaProd.Text = "Easy Way BeautySpecial";
            this.lblEmpresaProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblEmpresaProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblEmpresaProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // btnFecharProd
            // 
            this.btnFecharProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharProd.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharProd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharProd.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharProd.Location = new System.Drawing.Point(1035, 9);
            this.btnFecharProd.Name = "btnFecharProd";
            this.btnFecharProd.Size = new System.Drawing.Size(33, 29);
            this.btnFecharProd.TabIndex = 2;
            this.btnFecharProd.UseVisualStyleBackColor = false;
            this.btnFecharProd.Click += new System.EventHandler(this.btnFecharProd_Click);
            // 
            // btnMinimizarProd
            // 
            this.btnMinimizarProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarProd.BackgroundImage = global::BeautySpecial.Properties.Resources.Minimizar;
            this.btnMinimizarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarProd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarProd.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarProd.Location = new System.Drawing.Point(987, 9);
            this.btnMinimizarProd.Name = "btnMinimizarProd";
            this.btnMinimizarProd.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizarProd.TabIndex = 1;
            this.btnMinimizarProd.UseVisualStyleBackColor = false;
            this.btnMinimizarProd.Click += new System.EventHandler(this.btnMinimizarProd_Click);
            // 
            // picBoxLogoProd
            // 
            this.picBoxLogoProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoProd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoProd.Image")));
            this.picBoxLogoProd.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoProd.Name = "picBoxLogoProd";
            this.picBoxLogoProd.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoProd.TabIndex = 65;
            this.picBoxLogoProd.TabStop = false;
            this.picBoxLogoProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkOrchid;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1083, 65);
            this.label23.TabIndex = 62;
            this.label23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.lblEmpresaProd);
            this.Controls.Add(this.btnFecharProd);
            this.Controls.Add(this.btnMinimizarProd);
            this.Controls.Add(this.picBoxLogoProd);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblMsgProdutos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadProduto";
            this.Load += new System.EventHandler(this.FrmCadProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxDescProd;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.TextBox txtBoxMarcProd;
        private System.Windows.Forms.Label lblMarcProd;
        private System.Windows.Forms.TextBox txtBoxPrecProd;
        private System.Windows.Forms.Label lblPrecProd;
        private System.Windows.Forms.TextBox txtBoxNomeProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Label lblEmpresaProd;
        private System.Windows.Forms.Button btnFecharProd;
        private System.Windows.Forms.Button btnMinimizarProd;
        private System.Windows.Forms.PictureBox picBoxLogoProd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBoxQuantProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCadProd;
        private System.Windows.Forms.Label lblMsgPrecoProd;
        private System.Windows.Forms.Label lblMsgMarcaProd;
        private System.Windows.Forms.Label lblMsgNomeProd;
        private System.Windows.Forms.ComboBox cmbServProv;
        private System.Windows.Forms.Button btnAddServCadCom;
        private System.Windows.Forms.Label lblServCadCom;
        private System.Windows.Forms.DataGridView DataGridServCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Button btnExcluir;
    }
}