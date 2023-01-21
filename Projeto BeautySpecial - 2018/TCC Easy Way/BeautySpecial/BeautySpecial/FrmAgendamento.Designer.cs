namespace Apresentacao
{
    partial class FrmAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendamento));
            this.lblServAgend = new System.Windows.Forms.Label();
            this.lblClientesAgend = new System.Windows.Forms.Label();
            this.lblDadosAgend = new System.Windows.Forms.Label();
            this.btnSalvarAgend = new System.Windows.Forms.Button();
            this.lblProfAgend = new System.Windows.Forms.Label();
            this.lblObsAgend = new System.Windows.Forms.Label();
            this.cmbBoxProfAgend = new System.Windows.Forms.ComboBox();
            this.lblDurAgend = new System.Windows.Forms.Label();
            this.DataGridAgend = new System.Windows.Forms.DataGridView();
            this.Cliente_Clie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servico_Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracao_Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Agend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação_Agend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAgend = new System.Windows.Forms.DateTimePicker();
            this.txtBoxObsAgend = new System.Windows.Forms.TextBox();
            this.lblMsgAgendamento = new System.Windows.Forms.Label();
            this.btnAddServAgend = new System.Windows.Forms.Button();
            this.picBoxLogoAgend = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.cmbBoxHorAgend = new System.Windows.Forms.ComboBox();
            this.lblHorAgend = new System.Windows.Forms.Label();
            this.btnFecharAgend = new System.Windows.Forms.Button();
            this.btnMinimizarAgend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.mkdTxtBoxDuracAgend = new System.Windows.Forms.MaskedTextBox();
            this.lblMsgDuracao = new System.Windows.Forms.Label();
            this.lblMsgHorarioAgend = new System.Windows.Forms.Label();
            this.lblMsgProfissionalAgend = new System.Windows.Forms.Label();
            this.lblMsgServicoAgend = new System.Windows.Forms.Label();
            this.lblMsgClienteAgend = new System.Windows.Forms.Label();
            this.cmbtServAgend = new System.Windows.Forms.ComboBox();
            this.cmbClienteAgend = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresaFunc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAgend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoAgend)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServAgend
            // 
            this.lblServAgend.AutoSize = true;
            this.lblServAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServAgend.Location = new System.Drawing.Point(12, 75);
            this.lblServAgend.Name = "lblServAgend";
            this.lblServAgend.Size = new System.Drawing.Size(67, 18);
            this.lblServAgend.TabIndex = 36;
            this.lblServAgend.Text = "Serviços";
            // 
            // lblClientesAgend
            // 
            this.lblClientesAgend.AutoSize = true;
            this.lblClientesAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesAgend.Location = new System.Drawing.Point(12, 19);
            this.lblClientesAgend.Name = "lblClientesAgend";
            this.lblClientesAgend.Size = new System.Drawing.Size(60, 18);
            this.lblClientesAgend.TabIndex = 33;
            this.lblClientesAgend.Text = "Cliente";
            // 
            // lblDadosAgend
            // 
            this.lblDadosAgend.AutoSize = true;
            this.lblDadosAgend.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosAgend.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDadosAgend.Location = new System.Drawing.Point(11, 15);
            this.lblDadosAgend.Name = "lblDadosAgend";
            this.lblDadosAgend.Size = new System.Drawing.Size(71, 23);
            this.lblDadosAgend.TabIndex = 31;
            this.lblDadosAgend.Text = "Dados";
            // 
            // btnSalvarAgend
            // 
            this.btnSalvarAgend.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvarAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAgend.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAgend.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAgend.Location = new System.Drawing.Point(929, 440);
            this.btnSalvarAgend.Name = "btnSalvarAgend";
            this.btnSalvarAgend.Size = new System.Drawing.Size(111, 36);
            this.btnSalvarAgend.TabIndex = 9;
            this.btnSalvarAgend.Text = "Salvar";
            this.btnSalvarAgend.UseVisualStyleBackColor = false;
            this.btnSalvarAgend.Click += new System.EventHandler(this.btnSalvarAgend_Click);
            // 
            // lblProfAgend
            // 
            this.lblProfAgend.AutoSize = true;
            this.lblProfAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfAgend.Location = new System.Drawing.Point(11, 184);
            this.lblProfAgend.Name = "lblProfAgend";
            this.lblProfAgend.Size = new System.Drawing.Size(92, 18);
            this.lblProfAgend.TabIndex = 44;
            this.lblProfAgend.Text = "Profissional";
            // 
            // lblObsAgend
            // 
            this.lblObsAgend.AutoSize = true;
            this.lblObsAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsAgend.Location = new System.Drawing.Point(15, 294);
            this.lblObsAgend.Name = "lblObsAgend";
            this.lblObsAgend.Size = new System.Drawing.Size(89, 18);
            this.lblObsAgend.TabIndex = 46;
            this.lblObsAgend.Text = "Observação";
            // 
            // cmbBoxProfAgend
            // 
            this.cmbBoxProfAgend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBoxProfAgend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBoxProfAgend.DisplayMember = "Nome_Func";
            this.cmbBoxProfAgend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProfAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxProfAgend.FormattingEnabled = true;
            this.cmbBoxProfAgend.Location = new System.Drawing.Point(14, 210);
            this.cmbBoxProfAgend.Name = "cmbBoxProfAgend";
            this.cmbBoxProfAgend.Size = new System.Drawing.Size(217, 26);
            this.cmbBoxProfAgend.TabIndex = 4;
            // 
            // lblDurAgend
            // 
            this.lblDurAgend.AutoSize = true;
            this.lblDurAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurAgend.Location = new System.Drawing.Point(12, 129);
            this.lblDurAgend.Name = "lblDurAgend";
            this.lblDurAgend.Size = new System.Drawing.Size(67, 18);
            this.lblDurAgend.TabIndex = 42;
            this.lblDurAgend.Text = "Duração";
            // 
            // DataGridAgend
            // 
            this.DataGridAgend.AllowUserToAddRows = false;
            this.DataGridAgend.AllowUserToDeleteRows = false;
            this.DataGridAgend.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAgend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridAgend.ColumnHeadersHeight = 26;
            this.DataGridAgend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridAgend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_Clie,
            this.Servico_Serv,
            this.Duracao_Serv,
            this.Nome_Func,
            this.IdHora,
            this.Hora_Agend,
            this.Observação_Agend,
            this.idAgend});
            this.DataGridAgend.Location = new System.Drawing.Point(304, 66);
            this.DataGridAgend.Name = "DataGridAgend";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAgend.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridAgend.RowHeadersVisible = false;
            this.DataGridAgend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAgend.Size = new System.Drawing.Size(736, 358);
            this.DataGridAgend.TabIndex = 17;
            this.DataGridAgend.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridAgend_CellFormatting);
            this.DataGridAgend.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridAgend_CellMouseDoubleClick);
            // 
            // Cliente_Clie
            // 
            this.Cliente_Clie.DataPropertyName = "classCliente_DTO.Nome_Clie";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_Clie.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cliente_Clie.HeaderText = "Cliente";
            this.Cliente_Clie.MaxInputLength = 50;
            this.Cliente_Clie.Name = "Cliente_Clie";
            this.Cliente_Clie.ReadOnly = true;
            this.Cliente_Clie.Width = 210;
            // 
            // Servico_Serv
            // 
            this.Servico_Serv.DataPropertyName = "classServico_DTO.Nome_Serv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servico_Serv.DefaultCellStyle = dataGridViewCellStyle3;
            this.Servico_Serv.HeaderText = "Serviço";
            this.Servico_Serv.Name = "Servico_Serv";
            this.Servico_Serv.ReadOnly = true;
            this.Servico_Serv.Width = 150;
            // 
            // Duracao_Serv
            // 
            this.Duracao_Serv.DataPropertyName = "classServico_DTO.Duracao_Serv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duracao_Serv.DefaultCellStyle = dataGridViewCellStyle4;
            this.Duracao_Serv.HeaderText = "Duração";
            this.Duracao_Serv.Name = "Duracao_Serv";
            this.Duracao_Serv.ReadOnly = true;
            this.Duracao_Serv.Width = 110;
            // 
            // Nome_Func
            // 
            this.Nome_Func.DataPropertyName = "classFuncionario_DTO.Nome_Func";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Func.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nome_Func.HeaderText = "Profissional";
            this.Nome_Func.Name = "Nome_Func";
            this.Nome_Func.ReadOnly = true;
            this.Nome_Func.Width = 210;
            // 
            // IdHora
            // 
            this.IdHora.DataPropertyName = "classHoraSalao.ID_HoraSalao";
            this.IdHora.HeaderText = "CodigoHora";
            this.IdHora.Name = "IdHora";
            this.IdHora.Visible = false;
            // 
            // Hora_Agend
            // 
            this.Hora_Agend.DataPropertyName = "classHoraSalao.Horario_Sal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Agend.DefaultCellStyle = dataGridViewCellStyle6;
            this.Hora_Agend.HeaderText = "Horário";
            this.Hora_Agend.Name = "Hora_Agend";
            this.Hora_Agend.ReadOnly = true;
            this.Hora_Agend.Width = 110;
            // 
            // Observação_Agend
            // 
            this.Observação_Agend.DataPropertyName = "Observacao_Agend";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observação_Agend.DefaultCellStyle = dataGridViewCellStyle7;
            this.Observação_Agend.HeaderText = "Observação";
            this.Observação_Agend.Name = "Observação_Agend";
            this.Observação_Agend.ReadOnly = true;
            this.Observação_Agend.Width = 250;
            // 
            // idAgend
            // 
            this.idAgend.DataPropertyName = "ID_Agendamento";
            this.idAgend.HeaderText = "Codigo";
            this.idAgend.Name = "idAgend";
            this.idAgend.Visible = false;
            // 
            // DataAgend
            // 
            this.DataAgend.CalendarFont = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAgend.CustomFormat = "yyyy-MM-dd";
            this.DataAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAgend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataAgend.Location = new System.Drawing.Point(10, 66);
            this.DataAgend.Name = "DataAgend";
            this.DataAgend.Size = new System.Drawing.Size(241, 26);
            this.DataAgend.TabIndex = 16;
            this.DataAgend.Value = new System.DateTime(2018, 11, 5, 0, 0, 0, 0);
            this.DataAgend.ValueChanged += new System.EventHandler(this.dateTimePickerAgend_ValueChanged);
            // 
            // txtBoxObsAgend
            // 
            this.txtBoxObsAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObsAgend.Location = new System.Drawing.Point(15, 319);
            this.txtBoxObsAgend.MaxLength = 256;
            this.txtBoxObsAgend.Multiline = true;
            this.txtBoxObsAgend.Name = "txtBoxObsAgend";
            this.txtBoxObsAgend.Size = new System.Drawing.Size(221, 62);
            this.txtBoxObsAgend.TabIndex = 6;
            // 
            // lblMsgAgendamento
            // 
            this.lblMsgAgendamento.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgAgendamento.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMsgAgendamento.Location = new System.Drawing.Point(2, 83);
            this.lblMsgAgendamento.Name = "lblMsgAgendamento";
            this.lblMsgAgendamento.Size = new System.Drawing.Size(1062, 60);
            this.lblMsgAgendamento.TabIndex = 63;
            this.lblMsgAgendamento.Text = "Agendamento";
            this.lblMsgAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddServAgend
            // 
            this.btnAddServAgend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddServAgend.BackgroundImage")));
            this.btnAddServAgend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddServAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServAgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServAgend.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddServAgend.Location = new System.Drawing.Point(201, 97);
            this.btnAddServAgend.Name = "btnAddServAgend";
            this.btnAddServAgend.Size = new System.Drawing.Size(30, 26);
            this.btnAddServAgend.TabIndex = 6;
            this.btnAddServAgend.UseVisualStyleBackColor = true;
            this.btnAddServAgend.Click += new System.EventHandler(this.btnAddServAgend_Click);
            // 
            // picBoxLogoAgend
            // 
            this.picBoxLogoAgend.BackColor = System.Drawing.Color.DarkOrchid;
            this.picBoxLogoAgend.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoAgend.Image")));
            this.picBoxLogoAgend.Location = new System.Drawing.Point(6, 7);
            this.picBoxLogoAgend.Name = "picBoxLogoAgend";
            this.picBoxLogoAgend.Size = new System.Drawing.Size(74, 48);
            this.picBoxLogoAgend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogoAgend.TabIndex = 68;
            this.picBoxLogoAgend.TabStop = false;
            this.picBoxLogoAgend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.picBoxLogoAgend.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.picBoxLogoAgend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1083, 65);
            this.lblTop.TabIndex = 65;
            this.lblTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // cmbBoxHorAgend
            // 
            this.cmbBoxHorAgend.DisplayMember = "Horario_Sal";
            this.cmbBoxHorAgend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxHorAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxHorAgend.FormattingEnabled = true;
            this.cmbBoxHorAgend.Location = new System.Drawing.Point(13, 263);
            this.cmbBoxHorAgend.Name = "cmbBoxHorAgend";
            this.cmbBoxHorAgend.Size = new System.Drawing.Size(155, 26);
            this.cmbBoxHorAgend.TabIndex = 5;
            // 
            // lblHorAgend
            // 
            this.lblHorAgend.AutoSize = true;
            this.lblHorAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorAgend.Location = new System.Drawing.Point(11, 240);
            this.lblHorAgend.Name = "lblHorAgend";
            this.lblHorAgend.Size = new System.Drawing.Size(64, 18);
            this.lblHorAgend.TabIndex = 72;
            this.lblHorAgend.Text = "Horário";
            // 
            // btnFecharAgend
            // 
            this.btnFecharAgend.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharAgend.BackgroundImage = global::BeautySpecial.Properties.Resources.Fechar;
            this.btnFecharAgend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharAgend.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharAgend.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFecharAgend.Location = new System.Drawing.Point(1035, 9);
            this.btnFecharAgend.Name = "btnFecharAgend";
            this.btnFecharAgend.Size = new System.Drawing.Size(33, 29);
            this.btnFecharAgend.TabIndex = 2;
            this.btnFecharAgend.UseVisualStyleBackColor = false;
            this.btnFecharAgend.Click += new System.EventHandler(this.btnFecharAgend_Click);
            // 
            // btnMinimizarAgend
            // 
            this.btnMinimizarAgend.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarAgend.BackgroundImage = global::BeautySpecial.Properties.Resources.Minimizar;
            this.btnMinimizarAgend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizarAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarAgend.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarAgend.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnMinimizarAgend.Location = new System.Drawing.Point(987, 9);
            this.btnMinimizarAgend.Name = "btnMinimizarAgend";
            this.btnMinimizarAgend.Size = new System.Drawing.Size(33, 29);
            this.btnMinimizarAgend.TabIndex = 1;
            this.btnMinimizarAgend.UseVisualStyleBackColor = false;
            this.btnMinimizarAgend.Click += new System.EventHandler(this.btnMinimizarAgend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lblInformacao);
            this.groupBox1.Controls.Add(this.btnSalvarAgend);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DataGridAgend);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DataAgend);
            this.groupBox1.Controls.Add(this.lblDadosAgend);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 497);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(301, 463);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(362, 16);
            this.lblInformacao.TabIndex = 86;
            this.lblInformacao.Text = "Clique 2 vezes na linha do agendamento para poder excluir.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAddCliente);
            this.groupBox2.Controls.Add(this.mkdTxtBoxDuracAgend);
            this.groupBox2.Controls.Add(this.lblMsgDuracao);
            this.groupBox2.Controls.Add(this.lblClientesAgend);
            this.groupBox2.Controls.Add(this.lblServAgend);
            this.groupBox2.Controls.Add(this.lblProfAgend);
            this.groupBox2.Controls.Add(this.lblObsAgend);
            this.groupBox2.Controls.Add(this.lblMsgHorarioAgend);
            this.groupBox2.Controls.Add(this.cmbBoxProfAgend);
            this.groupBox2.Controls.Add(this.btnAddServAgend);
            this.groupBox2.Controls.Add(this.lblDurAgend);
            this.groupBox2.Controls.Add(this.lblMsgProfissionalAgend);
            this.groupBox2.Controls.Add(this.lblHorAgend);
            this.groupBox2.Controls.Add(this.lblMsgServicoAgend);
            this.groupBox2.Controls.Add(this.cmbBoxHorAgend);
            this.groupBox2.Controls.Add(this.lblMsgClienteAgend);
            this.groupBox2.Controls.Add(this.txtBoxObsAgend);
            this.groupBox2.Controls.Add(this.cmbtServAgend);
            this.groupBox2.Controls.Add(this.cmbClienteAgend);
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 399);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCliente.BackgroundImage")));
            this.btnAddCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCliente.Location = new System.Drawing.Point(238, 42);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(30, 26);
            this.btnAddCliente.TabIndex = 87;
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddClienteAgend_Click);
            // 
            // mkdTxtBoxDuracAgend
            // 
            this.mkdTxtBoxDuracAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdTxtBoxDuracAgend.Location = new System.Drawing.Point(15, 152);
            this.mkdTxtBoxDuracAgend.Mask = "00:00";
            this.mkdTxtBoxDuracAgend.Name = "mkdTxtBoxDuracAgend";
            this.mkdTxtBoxDuracAgend.PromptChar = ' ';
            this.mkdTxtBoxDuracAgend.Size = new System.Drawing.Size(158, 26);
            this.mkdTxtBoxDuracAgend.TabIndex = 86;
            this.mkdTxtBoxDuracAgend.ValidatingType = typeof(System.DateTime);
            // 
            // lblMsgDuracao
            // 
            this.lblMsgDuracao.AutoSize = true;
            this.lblMsgDuracao.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDuracao.ForeColor = System.Drawing.Color.Black;
            this.lblMsgDuracao.Location = new System.Drawing.Point(76, 127);
            this.lblMsgDuracao.Name = "lblMsgDuracao";
            this.lblMsgDuracao.Size = new System.Drawing.Size(16, 18);
            this.lblMsgDuracao.TabIndex = 83;
            this.lblMsgDuracao.Text = "*";
            // 
            // lblMsgHorarioAgend
            // 
            this.lblMsgHorarioAgend.AutoSize = true;
            this.lblMsgHorarioAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgHorarioAgend.ForeColor = System.Drawing.Color.Black;
            this.lblMsgHorarioAgend.Location = new System.Drawing.Point(73, 238);
            this.lblMsgHorarioAgend.Name = "lblMsgHorarioAgend";
            this.lblMsgHorarioAgend.Size = new System.Drawing.Size(16, 18);
            this.lblMsgHorarioAgend.TabIndex = 82;
            this.lblMsgHorarioAgend.Text = "*";
            // 
            // lblMsgProfissionalAgend
            // 
            this.lblMsgProfissionalAgend.AutoSize = true;
            this.lblMsgProfissionalAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgProfissionalAgend.ForeColor = System.Drawing.Color.Black;
            this.lblMsgProfissionalAgend.Location = new System.Drawing.Point(101, 182);
            this.lblMsgProfissionalAgend.Name = "lblMsgProfissionalAgend";
            this.lblMsgProfissionalAgend.Size = new System.Drawing.Size(16, 18);
            this.lblMsgProfissionalAgend.TabIndex = 81;
            this.lblMsgProfissionalAgend.Text = "*";
            // 
            // lblMsgServicoAgend
            // 
            this.lblMsgServicoAgend.AutoSize = true;
            this.lblMsgServicoAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgServicoAgend.ForeColor = System.Drawing.Color.Black;
            this.lblMsgServicoAgend.Location = new System.Drawing.Point(76, 72);
            this.lblMsgServicoAgend.Name = "lblMsgServicoAgend";
            this.lblMsgServicoAgend.Size = new System.Drawing.Size(16, 18);
            this.lblMsgServicoAgend.TabIndex = 79;
            this.lblMsgServicoAgend.Text = "*";
            // 
            // lblMsgClienteAgend
            // 
            this.lblMsgClienteAgend.AutoSize = true;
            this.lblMsgClienteAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgClienteAgend.ForeColor = System.Drawing.Color.Black;
            this.lblMsgClienteAgend.Location = new System.Drawing.Point(68, 16);
            this.lblMsgClienteAgend.Name = "lblMsgClienteAgend";
            this.lblMsgClienteAgend.Size = new System.Drawing.Size(16, 18);
            this.lblMsgClienteAgend.TabIndex = 78;
            this.lblMsgClienteAgend.Text = "*";
            // 
            // cmbtServAgend
            // 
            this.cmbtServAgend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbtServAgend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbtServAgend.DisplayMember = "Nome_Serv";
            this.cmbtServAgend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtServAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtServAgend.FormattingEnabled = true;
            this.cmbtServAgend.Location = new System.Drawing.Point(15, 98);
            this.cmbtServAgend.Name = "cmbtServAgend";
            this.cmbtServAgend.Size = new System.Drawing.Size(180, 26);
            this.cmbtServAgend.TabIndex = 75;
            this.cmbtServAgend.SelectedIndexChanged += new System.EventHandler(this.cmbtServAgend_SelectedIndexChanged);
            // 
            // cmbClienteAgend
            // 
            this.cmbClienteAgend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClienteAgend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClienteAgend.DisplayMember = "Nome_Clie";
            this.cmbClienteAgend.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClienteAgend.FormattingEnabled = true;
            this.cmbClienteAgend.Location = new System.Drawing.Point(14, 43);
            this.cmbClienteAgend.Name = "cmbClienteAgend";
            this.cmbClienteAgend.Size = new System.Drawing.Size(217, 26);
            this.cmbClienteAgend.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 83;
            this.label2.Text = "Data";
            // 
            // lblEmpresaFunc
            // 
            this.lblEmpresaFunc.AutoSize = true;
            this.lblEmpresaFunc.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblEmpresaFunc.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpresaFunc.Location = new System.Drawing.Point(86, 19);
            this.lblEmpresaFunc.Name = "lblEmpresaFunc";
            this.lblEmpresaFunc.Size = new System.Drawing.Size(204, 18);
            this.lblEmpresaFunc.TabIndex = 85;
            this.lblEmpresaFunc.Text = "Easy Way BeautySpecial";
            this.lblEmpresaFunc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseDown);
            this.lblEmpresaFunc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseMove);
            this.lblEmpresaFunc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoverForm_MouseUp);
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.lblEmpresaFunc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFecharAgend);
            this.Controls.Add(this.btnMinimizarAgend);
            this.Controls.Add(this.picBoxLogoAgend);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblMsgAgendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FrmAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAgend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoAgend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddServAgend;
        private System.Windows.Forms.Label lblServAgend;
        private System.Windows.Forms.Label lblClientesAgend;
        private System.Windows.Forms.Label lblDadosAgend;
        private System.Windows.Forms.Button btnSalvarAgend;
        private System.Windows.Forms.Label lblProfAgend;
        private System.Windows.Forms.Label lblObsAgend;
        private System.Windows.Forms.ComboBox cmbBoxProfAgend;
        private System.Windows.Forms.Label lblDurAgend;
        private System.Windows.Forms.TextBox txtBoxObsAgend;
        private System.Windows.Forms.Label lblMsgAgendamento;
        private System.Windows.Forms.DateTimePicker DataAgend;
        private System.Windows.Forms.PictureBox picBoxLogoAgend;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.ComboBox cmbBoxHorAgend;
        private System.Windows.Forms.Label lblHorAgend;
        private System.Windows.Forms.Button btnFecharAgend;
        private System.Windows.Forms.Button btnMinimizarAgend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridAgend;
        private System.Windows.Forms.ComboBox cmbtServAgend;
        private System.Windows.Forms.ComboBox cmbClienteAgend;
        private System.Windows.Forms.TextBox txtBoxDurAgend;
        private System.Windows.Forms.Label lblMsgHorarioAgend;
        private System.Windows.Forms.Label lblMsgProfissionalAgend;
        private System.Windows.Forms.Label lblMsgServicoAgend;
        private System.Windows.Forms.Label lblMsgClienteAgend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresaFunc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMsgDuracao;
        private System.Windows.Forms.MaskedTextBox mkdTxtBoxDuracAgend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Clie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servico_Serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao_Serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Agend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação_Agend;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgend;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label lblInformacao;
    }
}