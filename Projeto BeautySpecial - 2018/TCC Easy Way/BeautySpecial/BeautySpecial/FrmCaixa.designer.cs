namespace Apresentacao
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.txtBoxTotCaix = new System.Windows.Forms.TextBox();
            this.lblTotCaix = new System.Windows.Forms.Label();
            this.lblDatCaix = new System.Windows.Forms.Label();
            this.dateTimePickerCaix = new System.Windows.Forms.DateTimePicker();
            this.txtBoxValorRecCaix = new System.Windows.Forms.TextBox();
            this.lblDescCaix = new System.Windows.Forms.Label();
            this.lblComCaix = new System.Windows.Forms.Label();
            this.lblTipPagCaix = new System.Windows.Forms.Label();
            this.lblNomeCliCaix = new System.Windows.Forms.Label();
            this.lblEmpresaProd = new System.Windows.Forms.Label();
            this.btnFecharProd = new System.Windows.Forms.Button();
            this.btnMinimizarProd = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxOperCaix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMsgPrecoServ = new System.Windows.Forms.Label();
            this.txtBoxDescCaix = new System.Windows.Forms.TextBox();
            this.lblMsgDuracaoServ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTrocCaix = new System.Windows.Forms.TextBox();
            this.lblTrocCaix = new System.Windows.Forms.Label();
            this.cmbBoxTipPagCaix = new System.Windows.Forms.ComboBox();
            this.cmbBoxComCaix = new System.Windows.Forms.ComboBox();
            this.cmbBoxNomCliCaix = new System.Windows.Forms.ComboBox();
            this.lblMsgCaix = new System.Windows.Forms.Label();
            this.picBoxLogoProd = new System.Windows.Forms.PictureBox();
            this.btnCancelarCaix = new System.Windows.Forms.Button();
            this.btnFinalizarCaix = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTotCaix
            // 
            this.txtBoxTotCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotCaix.Location = new System.Drawing.Point(660, 320);
            this.txtBoxTotCaix.Name = "txtBoxTotCaix";
            this.txtBoxTotCaix.ReadOnly = true;
            this.txtBoxTotCaix.Size = new System.Drawing.Size(107, 26);
            this.txtBoxTotCaix.TabIndex = 92;
            this.txtBoxTotCaix.Text = "0,00";
            this.txtBoxTotCaix.TextChanged += new System.EventHandler(this.txtBoxTotCaix_TextChanged);
            // 
            // lblTotCaix
            // 
            this.lblTotCaix.AutoSize = true;
            this.lblTotCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCaix.Location = new System.Drawing.Point(597, 328);
            this.lblTotCaix.Name = "lblTotCaix";
            this.lblTotCaix.Size = new System.Drawing.Size(49, 18);
            this.lblTotCaix.TabIndex = 93;
            this.lblTotCaix.Text = "Total:";
            // 
            // lblDatCaix
            // 
            this.lblDatCaix.AutoSize = true;
            this.lblDatCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatCaix.Location = new System.Drawing.Point(781, 38);
            this.lblDatCaix.Name = "lblDatCaix";
            this.lblDatCaix.Size = new System.Drawing.Size(46, 18);
            this.lblDatCaix.TabIndex = 91;
            this.lblDatCaix.Text = "Data:";
            // 
            // dateTimePickerCaix
            // 
            this.dateTimePickerCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCaix.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCaix.Location = new System.Drawing.Point(833, 34);
            this.dateTimePickerCaix.Name = "dateTimePickerCaix";
            this.dateTimePickerCaix.Size = new System.Drawing.Size(122, 26);
            this.dateTimePickerCaix.TabIndex = 90;
            this.dateTimePickerCaix.Value = new System.DateTime(2018, 11, 13, 19, 52, 48, 0);
            // 
            // txtBoxValorRecCaix
            // 
            this.txtBoxValorRecCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxValorRecCaix.Location = new System.Drawing.Point(203, 320);
            this.txtBoxValorRecCaix.Name = "txtBoxValorRecCaix";
            this.txtBoxValorRecCaix.Size = new System.Drawing.Size(107, 26);
            this.txtBoxValorRecCaix.TabIndex = 4;
            this.txtBoxValorRecCaix.Text = "0,00";
            this.txtBoxValorRecCaix.TextChanged += new System.EventHandler(this.txtBoxValorRecCaix_TextChanged);
            this.txtBoxValorRecCaix.Leave += new System.EventHandler(this.txtBoxValorRecCaix_Leave);
            // 
            // lblDescCaix
            // 
            this.lblDescCaix.AutoSize = true;
            this.lblDescCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCaix.Location = new System.Drawing.Point(73, 328);
            this.lblDescCaix.Name = "lblDescCaix";
            this.lblDescCaix.Size = new System.Drawing.Size(115, 18);
            this.lblDescCaix.TabIndex = 86;
            this.lblDescCaix.Text = "Valor recebido:";
            // 
            // lblComCaix
            // 
            this.lblComCaix.AutoSize = true;
            this.lblComCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComCaix.Location = new System.Drawing.Point(84, 145);
            this.lblComCaix.Name = "lblComCaix";
            this.lblComCaix.Size = new System.Drawing.Size(78, 18);
            this.lblComCaix.TabIndex = 85;
            this.lblComCaix.Text = "Comanda:";
            // 
            // lblTipPagCaix
            // 
            this.lblTipPagCaix.AutoSize = true;
            this.lblTipPagCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipPagCaix.Location = new System.Drawing.Point(18, 200);
            this.lblTipPagCaix.Name = "lblTipPagCaix";
            this.lblTipPagCaix.Size = new System.Drawing.Size(147, 18);
            this.lblTipPagCaix.TabIndex = 84;
            this.lblTipPagCaix.Text = "Tipo de Pagamento:";
            // 
            // lblNomeCliCaix
            // 
            this.lblNomeCliCaix.AutoSize = true;
            this.lblNomeCliCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliCaix.Location = new System.Drawing.Point(35, 88);
            this.lblNomeCliCaix.Name = "lblNomeCliCaix";
            this.lblNomeCliCaix.Size = new System.Drawing.Size(130, 18);
            this.lblNomeCliCaix.TabIndex = 83;
            this.lblNomeCliCaix.Text = "Nome do Cliente:";
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
            this.lblEmpresaProd.TabIndex = 80;
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
            this.btnFecharProd.TabIndex = 75;
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
            this.btnMinimizarProd.TabIndex = 74;
            this.btnMinimizarProd.UseVisualStyleBackColor = false;
            this.btnMinimizarProd.Click += new System.EventHandler(this.btnMinimizarProd_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkOrchid;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1083, 65);
            this.label23.TabIndex = 78;
            this.label23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.label23.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.label23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmbBoxOperCaix);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMsgPrecoServ);
            this.groupBox1.Controls.Add(this.txtBoxDescCaix);
            this.groupBox1.Controls.Add(this.lblMsgDuracaoServ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxTrocCaix);
            this.groupBox1.Controls.Add(this.lblTrocCaix);
            this.groupBox1.Controls.Add(this.cmbBoxTipPagCaix);
            this.groupBox1.Controls.Add(this.cmbBoxComCaix);
            this.groupBox1.Controls.Add(this.cmbBoxNomCliCaix);
            this.groupBox1.Controls.Add(this.txtBoxTotCaix);
            this.groupBox1.Controls.Add(this.lblTotCaix);
            this.groupBox1.Controls.Add(this.lblDatCaix);
            this.groupBox1.Controls.Add(this.dateTimePickerCaix);
            this.groupBox1.Controls.Add(this.txtBoxValorRecCaix);
            this.groupBox1.Controls.Add(this.lblDescCaix);
            this.groupBox1.Controls.Add(this.lblComCaix);
            this.groupBox1.Controls.Add(this.lblTipPagCaix);
            this.groupBox1.Controls.Add(this.lblNomeCliCaix);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 431);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // cmbBoxOperCaix
            // 
            this.cmbBoxOperCaix.Enabled = false;
            this.cmbBoxOperCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxOperCaix.Location = new System.Drawing.Point(203, 34);
            this.cmbBoxOperCaix.Name = "cmbBoxOperCaix";
            this.cmbBoxOperCaix.Size = new System.Drawing.Size(275, 26);
            this.cmbBoxOperCaix.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(183, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 112;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(164, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 111;
            this.label4.Text = "*";
            // 
            // lblMsgPrecoServ
            // 
            this.lblMsgPrecoServ.AutoSize = true;
            this.lblMsgPrecoServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPrecoServ.ForeColor = System.Drawing.Color.Black;
            this.lblMsgPrecoServ.Location = new System.Drawing.Point(162, 88);
            this.lblMsgPrecoServ.Name = "lblMsgPrecoServ";
            this.lblMsgPrecoServ.Size = new System.Drawing.Size(16, 18);
            this.lblMsgPrecoServ.TabIndex = 109;
            this.lblMsgPrecoServ.Text = "*";
            // 
            // txtBoxDescCaix
            // 
            this.txtBoxDescCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescCaix.Location = new System.Drawing.Point(443, 320);
            this.txtBoxDescCaix.Name = "txtBoxDescCaix";
            this.txtBoxDescCaix.Size = new System.Drawing.Size(107, 26);
            this.txtBoxDescCaix.TabIndex = 5;
            // 
            // lblMsgDuracaoServ
            // 
            this.lblMsgDuracaoServ.AutoSize = true;
            this.lblMsgDuracaoServ.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDuracaoServ.ForeColor = System.Drawing.Color.Black;
            this.lblMsgDuracaoServ.Location = new System.Drawing.Point(163, 138);
            this.lblMsgDuracaoServ.Name = "lblMsgDuracaoServ";
            this.lblMsgDuracaoServ.Size = new System.Drawing.Size(16, 18);
            this.lblMsgDuracaoServ.TabIndex = 108;
            this.lblMsgDuracaoServ.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 104;
            this.label2.Text = "Desconto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Operador:";
            // 
            // txtBoxTrocCaix
            // 
            this.txtBoxTrocCaix.Enabled = false;
            this.txtBoxTrocCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTrocCaix.Location = new System.Drawing.Point(884, 320);
            this.txtBoxTrocCaix.MaxLength = 15;
            this.txtBoxTrocCaix.Name = "txtBoxTrocCaix";
            this.txtBoxTrocCaix.Size = new System.Drawing.Size(107, 26);
            this.txtBoxTrocCaix.TabIndex = 99;
            this.txtBoxTrocCaix.Text = "0,00";
            // 
            // lblTrocCaix
            // 
            this.lblTrocCaix.AutoSize = true;
            this.lblTrocCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocCaix.Location = new System.Drawing.Point(818, 328);
            this.lblTrocCaix.Name = "lblTrocCaix";
            this.lblTrocCaix.Size = new System.Drawing.Size(52, 18);
            this.lblTrocCaix.TabIndex = 100;
            this.lblTrocCaix.Text = "Troco:";
            // 
            // cmbBoxTipPagCaix
            // 
            this.cmbBoxTipPagCaix.DisplayMember = "Descricao_TP";
            this.cmbBoxTipPagCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxTipPagCaix.FormattingEnabled = true;
            this.cmbBoxTipPagCaix.Location = new System.Drawing.Point(203, 197);
            this.cmbBoxTipPagCaix.Name = "cmbBoxTipPagCaix";
            this.cmbBoxTipPagCaix.Size = new System.Drawing.Size(181, 26);
            this.cmbBoxTipPagCaix.TabIndex = 3;
            // 
            // cmbBoxComCaix
            // 
            this.cmbBoxComCaix.DisplayMember = "Data_Com";
            this.cmbBoxComCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxComCaix.FormattingEnabled = true;
            this.cmbBoxComCaix.Location = new System.Drawing.Point(203, 142);
            this.cmbBoxComCaix.Name = "cmbBoxComCaix";
            this.cmbBoxComCaix.Size = new System.Drawing.Size(216, 26);
            this.cmbBoxComCaix.TabIndex = 2;
            this.cmbBoxComCaix.SelectedIndexChanged += new System.EventHandler(this.cmbBoxComCaix_SelectedIndexChanged);
            // 
            // cmbBoxNomCliCaix
            // 
            this.cmbBoxNomCliCaix.DisplayMember = "Nome_Clie";
            this.cmbBoxNomCliCaix.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxNomCliCaix.FormattingEnabled = true;
            this.cmbBoxNomCliCaix.Items.AddRange(new object[] {
            "Joaquim"});
            this.cmbBoxNomCliCaix.Location = new System.Drawing.Point(203, 88);
            this.cmbBoxNomCliCaix.Name = "cmbBoxNomCliCaix";
            this.cmbBoxNomCliCaix.Size = new System.Drawing.Size(275, 26);
            this.cmbBoxNomCliCaix.TabIndex = 1;
            this.cmbBoxNomCliCaix.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNomCliCaix_SelectedIndexChanged);
            // 
            // lblMsgCaix
            // 
            this.lblMsgCaix.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgCaix.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgCaix.Location = new System.Drawing.Point(2, 83);
            this.lblMsgCaix.Name = "lblMsgCaix";
            this.lblMsgCaix.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgCaix.TabIndex = 77;
            this.lblMsgCaix.Text = "Caixa";
            this.lblMsgCaix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxLogoProd
            // 
            this.picBoxLogoProd.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoProd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoProd.Image")));
            this.picBoxLogoProd.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoProd.Name = "picBoxLogoProd";
            this.picBoxLogoProd.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoProd.TabIndex = 79;
            this.picBoxLogoProd.TabStop = false;
            this.picBoxLogoProd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoProd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // btnCancelarCaix
            // 
            this.btnCancelarCaix.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarCaix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCaix.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCaix.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCaix.Location = new System.Drawing.Point(948, 617);
            this.btnCancelarCaix.Name = "btnCancelarCaix";
            this.btnCancelarCaix.Size = new System.Drawing.Size(108, 37);
            this.btnCancelarCaix.TabIndex = 106;
            this.btnCancelarCaix.Text = "Cancelar";
            this.btnCancelarCaix.UseVisualStyleBackColor = false;
            this.btnCancelarCaix.Click += new System.EventHandler(this.btnCancelarCaix_Click);
            // 
            // btnFinalizarCaix
            // 
            this.btnFinalizarCaix.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFinalizarCaix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCaix.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCaix.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCaix.Location = new System.Drawing.Point(825, 617);
            this.btnFinalizarCaix.Name = "btnFinalizarCaix";
            this.btnFinalizarCaix.Size = new System.Drawing.Size(108, 37);
            this.btnFinalizarCaix.TabIndex = 105;
            this.btnFinalizarCaix.Text = "Finalizar";
            this.btnFinalizarCaix.UseVisualStyleBackColor = false;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.btnCancelarCaix);
            this.Controls.Add(this.btnFinalizarCaix);
            this.Controls.Add(this.picBoxLogoProd);
            this.Controls.Add(this.lblEmpresaProd);
            this.Controls.Add(this.btnFecharProd);
            this.Controls.Add(this.btnMinimizarProd);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMsgCaix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxTotCaix;
        private System.Windows.Forms.Label lblTotCaix;
        private System.Windows.Forms.Label lblDatCaix;
        private System.Windows.Forms.DateTimePicker dateTimePickerCaix;
        private System.Windows.Forms.TextBox txtBoxValorRecCaix;
        private System.Windows.Forms.Label lblDescCaix;
        private System.Windows.Forms.Label lblComCaix;
        private System.Windows.Forms.Label lblTipPagCaix;
        private System.Windows.Forms.Label lblNomeCliCaix;
        private System.Windows.Forms.PictureBox picBoxLogoProd;
        private System.Windows.Forms.Label lblEmpresaProd;
        private System.Windows.Forms.Button btnFecharProd;
        private System.Windows.Forms.Button btnMinimizarProd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMsgCaix;
        private System.Windows.Forms.ComboBox cmbBoxComCaix;
        private System.Windows.Forms.ComboBox cmbBoxNomCliCaix;
        private System.Windows.Forms.TextBox txtBoxTrocCaix;
        private System.Windows.Forms.Label lblTrocCaix;
        private System.Windows.Forms.ComboBox cmbBoxTipPagCaix;
        private System.Windows.Forms.Button btnCancelarCaix;
        private System.Windows.Forms.Button btnFinalizarCaix;
        private System.Windows.Forms.TextBox txtBoxDescCaix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMsgPrecoServ;
        private System.Windows.Forms.Label lblMsgDuracaoServ;
        private System.Windows.Forms.TextBox cmbBoxOperCaix;
    }
}