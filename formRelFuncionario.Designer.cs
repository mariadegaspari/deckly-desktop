namespace SistemaDeckly
{
    partial class formRelFuncionario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelFuncionario));
            this.classFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rvFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbTipoRel = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTipoRel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAniversariantes = new Guna.UI2.WinForms.Guna2Panel();
            this.cbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCargo = new Guna.UI2.WinForms.Guna2Panel();
            this.cbCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCidade = new Guna.UI2.WinForms.Guna2Panel();
            this.cbCidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbIdade = new Guna.UI2.WinForms.Guna2Panel();
            this.txtIdadeFinal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdadeInicial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.rbInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btGerarRelatorio = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).BeginInit();
            this.gbTipoRel.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.gbCargo.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classFuncionarioBindingSource
            // 
            this.classFuncionarioBindingSource.DataSource = typeof(SistemaDeckly.classFuncionario);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "De:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(123, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Até:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(491, 19);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(270, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Funcionários";
            // 
            // rvFuncionario
            // 
            reportDataSource2.Name = "dsFuncionario";
            reportDataSource2.Value = this.classFuncionarioBindingSource;
            this.rvFuncionario.LocalReport.DataSources.Add(reportDataSource2);
            this.rvFuncionario.LocalReport.ReportEmbeddedResource = "SistemaDeckly.rbtFuncionario.rdlc";
            this.rvFuncionario.Location = new System.Drawing.Point(19, 19);
            this.rvFuncionario.Name = "rvFuncionario";
            this.rvFuncionario.ServerReport.BearerToken = null;
            this.rvFuncionario.Size = new System.Drawing.Size(872, 610);
            this.rvFuncionario.TabIndex = 134;
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbTipoRel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbTipoRel.BorderRadius = 8;
            this.gbTipoRel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbTipoRel.BorderThickness = 1;
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Controls.Add(this.label1);
            this.gbTipoRel.ForeColor = System.Drawing.Color.Black;
            this.gbTipoRel.Location = new System.Drawing.Point(12, 66);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(235, 81);
            this.gbTipoRel.TabIndex = 148;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoRel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbTipoRel.BorderRadius = 5;
            this.cbTipoRel.BorderThickness = 0;
            this.cbTipoRel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbTipoRel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoRel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoRel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoRel.ForeColor = System.Drawing.Color.White;
            this.cbTipoRel.ItemHeight = 30;
            this.cbTipoRel.Location = new System.Drawing.Point(15, 30);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(205, 36);
            this.cbTipoRel.TabIndex = 148;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 148;
            this.label1.Text = "Tipo de relatório";
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbAniversariantes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbAniversariantes.BorderRadius = 8;
            this.gbAniversariantes.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbAniversariantes.BorderThickness = 1;
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.Controls.Add(this.label2);
            this.gbAniversariantes.ForeColor = System.Drawing.Color.Black;
            this.gbAniversariantes.Location = new System.Drawing.Point(12, 163);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(235, 81);
            this.gbAniversariantes.TabIndex = 149;
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.Transparent;
            this.cbMes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbMes.BorderRadius = 5;
            this.cbMes.BorderThickness = 0;
            this.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbMes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMes.ForeColor = System.Drawing.Color.White;
            this.cbMes.ItemHeight = 30;
            this.cbMes.Location = new System.Drawing.Point(15, 30);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(205, 36);
            this.cbMes.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 148;
            this.label2.Text = "Aniversariantes Mês";
            // 
            // gbCargo
            // 
            this.gbCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbCargo.BorderRadius = 8;
            this.gbCargo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbCargo.BorderThickness = 1;
            this.gbCargo.Controls.Add(this.cbCargo);
            this.gbCargo.Controls.Add(this.label3);
            this.gbCargo.ForeColor = System.Drawing.Color.Black;
            this.gbCargo.Location = new System.Drawing.Point(12, 260);
            this.gbCargo.Name = "gbCargo";
            this.gbCargo.Size = new System.Drawing.Size(235, 81);
            this.gbCargo.TabIndex = 150;
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.Transparent;
            this.cbCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbCargo.BorderRadius = 5;
            this.cbCargo.BorderThickness = 0;
            this.cbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbCargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCargo.ForeColor = System.Drawing.Color.White;
            this.cbCargo.ItemHeight = 30;
            this.cbCargo.Location = new System.Drawing.Point(15, 30);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(205, 36);
            this.cbCargo.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Cargo";
            // 
            // gbCidade
            // 
            this.gbCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbCidade.BorderRadius = 8;
            this.gbCidade.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbCidade.BorderThickness = 1;
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Controls.Add(this.label4);
            this.gbCidade.ForeColor = System.Drawing.Color.Black;
            this.gbCidade.Location = new System.Drawing.Point(12, 357);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(235, 81);
            this.gbCidade.TabIndex = 151;
            // 
            // cbCidade
            // 
            this.cbCidade.BackColor = System.Drawing.Color.Transparent;
            this.cbCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbCidade.BorderRadius = 5;
            this.cbCidade.BorderThickness = 0;
            this.cbCidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbCidade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCidade.ForeColor = System.Drawing.Color.White;
            this.cbCidade.ItemHeight = 30;
            this.cbCidade.Location = new System.Drawing.Point(15, 30);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(205, 36);
            this.cbCidade.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "Cidade";
            // 
            // gbIdade
            // 
            this.gbIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbIdade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbIdade.BorderRadius = 8;
            this.gbIdade.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbIdade.BorderThickness = 1;
            this.gbIdade.Controls.Add(this.txtIdadeFinal);
            this.gbIdade.Controls.Add(this.txtIdadeInicial);
            this.gbIdade.Controls.Add(this.label5);
            this.gbIdade.Controls.Add(this.label13);
            this.gbIdade.Controls.Add(this.label14);
            this.gbIdade.ForeColor = System.Drawing.Color.Black;
            this.gbIdade.Location = new System.Drawing.Point(12, 454);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(235, 81);
            this.gbIdade.TabIndex = 151;
            // 
            // txtIdadeFinal
            // 
            this.txtIdadeFinal.BorderRadius = 5;
            this.txtIdadeFinal.BorderThickness = 0;
            this.txtIdadeFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdadeFinal.DefaultText = "";
            this.txtIdadeFinal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdadeFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdadeFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeFinal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeFinal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtIdadeFinal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdadeFinal.ForeColor = System.Drawing.Color.White;
            this.txtIdadeFinal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeFinal.Location = new System.Drawing.Point(162, 35);
            this.txtIdadeFinal.Name = "txtIdadeFinal";
            this.txtIdadeFinal.PlaceholderText = "";
            this.txtIdadeFinal.SelectedText = "";
            this.txtIdadeFinal.Size = new System.Drawing.Size(62, 36);
            this.txtIdadeFinal.TabIndex = 150;
            this.txtIdadeFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeFinal_KeyPress);
            // 
            // txtIdadeInicial
            // 
            this.txtIdadeInicial.BorderRadius = 5;
            this.txtIdadeInicial.BorderThickness = 0;
            this.txtIdadeInicial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdadeInicial.DefaultText = "";
            this.txtIdadeInicial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdadeInicial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdadeInicial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeInicial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeInicial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtIdadeInicial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeInicial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdadeInicial.ForeColor = System.Drawing.Color.White;
            this.txtIdadeInicial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeInicial.Location = new System.Drawing.Point(43, 35);
            this.txtIdadeInicial.Name = "txtIdadeInicial";
            this.txtIdadeInicial.PlaceholderText = "";
            this.txtIdadeInicial.SelectedText = "";
            this.txtIdadeInicial.Size = new System.Drawing.Size(62, 36);
            this.txtIdadeInicial.TabIndex = 149;
            this.txtIdadeInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeInicial_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 148;
            this.label5.Text = "Idade";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbStatus.BorderRadius = 8;
            this.gbStatus.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbStatus.BorderThickness = 1;
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Controls.Add(this.label6);
            this.gbStatus.ForeColor = System.Drawing.Color.Black;
            this.gbStatus.Location = new System.Drawing.Point(12, 554);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(235, 79);
            this.gbStatus.TabIndex = 156;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInativo.CheckedState.BorderThickness = 0;
            this.rbInativo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInativo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInativo.CheckedState.InnerOffset = -4;
            this.rbInativo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.ForeColor = System.Drawing.Color.White;
            this.rbInativo.Location = new System.Drawing.Point(139, 40);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(81, 24);
            this.rbInativo.TabIndex = 150;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInativo.UncheckedState.BorderThickness = 2;
            this.rbInativo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInativo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAtivo.CheckedState.BorderThickness = 0;
            this.rbAtivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAtivo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAtivo.CheckedState.InnerOffset = -4;
            this.rbAtivo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.ForeColor = System.Drawing.Color.White;
            this.rbAtivo.Location = new System.Drawing.Point(17, 40);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(67, 24);
            this.rbAtivo.TabIndex = 149;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAtivo.UncheckedState.BorderThickness = 2;
            this.rbAtivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAtivo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 148;
            this.label6.Text = "Status";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.btGerarRelatorio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btGerarRelatorio.BorderRadius = 5;
            this.btGerarRelatorio.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btGerarRelatorio.BorderThickness = 1;
            this.btGerarRelatorio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btGerarRelatorio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btGerarRelatorio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btGerarRelatorio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btGerarRelatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btGerarRelatorio.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.Location = new System.Drawing.Point(12, 649);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(235, 66);
            this.btGerarRelatorio.TabIndex = 157;
            this.btGerarRelatorio.Text = "  Gerar Relatório";
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.rvFuncionario);
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(262, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(910, 649);
            this.guna2Panel1.TabIndex = 149;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(1137, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 158;
            this.btnClose.Click += new System.EventHandler(this.btSair_Click);
            // 
            // formRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1188, 735);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbIdade);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbCargo);
            this.Controls.Add(this.gbAniversariantes);
            this.Controls.Add(this.gbTipoRel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRelFuncionario";
            this.Load += new System.EventHandler(this.formRelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).EndInit();
            this.gbTipoRel.ResumeLayout(false);
            this.gbTipoRel.PerformLayout();
            this.gbAniversariantes.ResumeLayout(false);
            this.gbAniversariantes.PerformLayout();
            this.gbCargo.ResumeLayout(false);
            this.gbCargo.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbCidade.PerformLayout();
            this.gbIdade.ResumeLayout(false);
            this.gbIdade.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer rvFuncionario;
        private System.Windows.Forms.BindingSource classFuncionarioBindingSource;
        private Guna.UI2.WinForms.Guna2Panel gbTipoRel;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoRel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel gbAniversariantes;
        private Guna.UI2.WinForms.Guna2ComboBox cbMes;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel gbCargo;
        private Guna.UI2.WinForms.Guna2ComboBox cbCargo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel gbCidade;
        private Guna.UI2.WinForms.Guna2ComboBox cbCidade;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel gbIdade;
        private Guna.UI2.WinForms.Guna2TextBox txtIdadeFinal;
        private Guna.UI2.WinForms.Guna2TextBox txtIdadeInicial;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel gbStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbInativo;
        private Guna.UI2.WinForms.Guna2RadioButton rbAtivo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btGerarRelatorio;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}