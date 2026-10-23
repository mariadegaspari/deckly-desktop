
namespace SistemaDeckly
{
    partial class formRelCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelCliente));
            this.classClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTitulo = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.gbTipoRel = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTipoRel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAniversariantes = new Guna.UI2.WinForms.Guna2Panel();
            this.cbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSexo = new Guna.UI2.WinForms.Guna2Panel();
            this.cbSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCidade = new Guna.UI2.WinForms.Guna2Panel();
            this.cbCidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbIdade = new Guna.UI2.WinForms.Guna2Panel();
            this.txtIdadeFinal = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIdadeInicial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.rbInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.rvCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).BeginInit();
            this.gbTipoRel.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classClienteBindingSource
            // 
            this.classClienteBindingSource.DataSource = typeof(SistemaDeckly.classCliente);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(454, 22);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(221, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Clientes";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.gbTipoRel.Location = new System.Drawing.Point(11, 75);
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
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 148;
            this.label1.Text = "Selecione o Relatório";
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
            this.gbAniversariantes.Location = new System.Drawing.Point(11, 172);
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
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbSexo.BorderRadius = 8;
            this.gbSexo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbSexo.BorderThickness = 1;
            this.gbSexo.Controls.Add(this.cbSexo);
            this.gbSexo.Controls.Add(this.label3);
            this.gbSexo.ForeColor = System.Drawing.Color.Black;
            this.gbSexo.Location = new System.Drawing.Point(11, 270);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(235, 81);
            this.gbSexo.TabIndex = 150;
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbSexo.BorderRadius = 5;
            this.cbSexo.BorderThickness = 0;
            this.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSexo.ForeColor = System.Drawing.Color.White;
            this.cbSexo.ItemHeight = 30;
            this.cbSexo.Location = new System.Drawing.Point(15, 30);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(205, 36);
            this.cbSexo.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Sexo";
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
            this.gbCidade.Location = new System.Drawing.Point(12, 367);
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
            this.gbIdade.Controls.Add(this.guna2HtmlLabel4);
            this.gbIdade.Controls.Add(this.guna2HtmlLabel5);
            this.gbIdade.Controls.Add(this.txtIdadeInicial);
            this.gbIdade.Controls.Add(this.label6);
            this.gbIdade.ForeColor = System.Drawing.Color.Black;
            this.gbIdade.Location = new System.Drawing.Point(12, 466);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(235, 79);
            this.gbIdade.TabIndex = 156;
            // 
            // txtIdadeFinal
            // 
            this.txtIdadeFinal.BorderRadius = 5;
            this.txtIdadeFinal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtIdadeFinal.BorderThickness = 0;
            this.txtIdadeFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdadeFinal.DefaultText = "";
            this.txtIdadeFinal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdadeFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdadeFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeFinal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeFinal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtIdadeFinal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeFinal.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadeFinal.ForeColor = System.Drawing.Color.White;
            this.txtIdadeFinal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeFinal.Location = new System.Drawing.Point(166, 33);
            this.txtIdadeFinal.Name = "txtIdadeFinal";
            this.txtIdadeFinal.PlaceholderText = "";
            this.txtIdadeFinal.SelectedText = "";
            this.txtIdadeFinal.Size = new System.Drawing.Size(54, 38);
            this.txtIdadeFinal.TabIndex = 154;
            this.txtIdadeFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeFinal_KeyPress);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(127, 45);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(33, 22);
            this.guna2HtmlLabel4.TabIndex = 153;
            this.guna2HtmlLabel4.Text = "Até:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(14, 45);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(27, 22);
            this.guna2HtmlLabel5.TabIndex = 152;
            this.guna2HtmlLabel5.Text = "De:";
            // 
            // txtIdadeInicial
            // 
            this.txtIdadeInicial.BorderRadius = 5;
            this.txtIdadeInicial.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtIdadeInicial.BorderThickness = 0;
            this.txtIdadeInicial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdadeInicial.DefaultText = "";
            this.txtIdadeInicial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdadeInicial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdadeInicial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeInicial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdadeInicial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtIdadeInicial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeInicial.Font = new System.Drawing.Font("Century", 9F);
            this.txtIdadeInicial.ForeColor = System.Drawing.Color.White;
            this.txtIdadeInicial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdadeInicial.Location = new System.Drawing.Point(48, 33);
            this.txtIdadeInicial.Name = "txtIdadeInicial";
            this.txtIdadeInicial.PlaceholderText = "";
            this.txtIdadeInicial.SelectedText = "";
            this.txtIdadeInicial.Size = new System.Drawing.Size(54, 38);
            this.txtIdadeInicial.TabIndex = 149;
            this.txtIdadeInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeInicial_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 148;
            this.label6.Text = "Idade";
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
            this.gbStatus.Controls.Add(this.label5);
            this.gbStatus.ForeColor = System.Drawing.Color.Black;
            this.gbStatus.Location = new System.Drawing.Point(11, 565);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(235, 79);
            this.gbStatus.TabIndex = 157;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 148;
            this.label5.Text = "Status";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btGerarRelatorio);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 661);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(235, 79);
            this.guna2Panel1.TabIndex = 157;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(11, 11);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(209, 57);
            this.btGerarRelatorio.TabIndex = 143;
            this.btGerarRelatorio.Text = "   Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // rvCliente
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classClienteBindingSource;
            this.rvCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCliente.LocalReport.ReportEmbeddedResource = "SistemaDeckly.rbtCliente.rdlc";
            this.rvCliente.Location = new System.Drawing.Point(274, 75);
            this.rvCliente.Name = "rvCliente";
            this.rvCliente.ServerReport.BearerToken = null;
            this.rvCliente.Size = new System.Drawing.Size(812, 665);
            this.rvCliente.TabIndex = 235;
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
            this.btnClose.Location = new System.Drawing.Point(1051, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 236;
            this.btnClose.Click += new System.EventHandler(this.btSair_Click);
            // 
            // formRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1099, 755);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rvCliente);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbIdade);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbAniversariantes);
            this.Controls.Add(this.gbTipoRel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelCliente";
            this.Text = "formRelCliente";
            this.Load += new System.EventHandler(this.formRelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).EndInit();
            this.gbTipoRel.ResumeLayout(false);
            this.gbTipoRel.PerformLayout();
            this.gbAniversariantes.ResumeLayout(false);
            this.gbAniversariantes.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
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
        private System.Windows.Forms.Label lbTitulo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel gbCidade;
        private Guna.UI2.WinForms.Guna2ComboBox cbCidade;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel gbSexo;
        private Guna.UI2.WinForms.Guna2ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel gbAniversariantes;
        private Guna.UI2.WinForms.Guna2ComboBox cbMes;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel gbTipoRel;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoRel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel gbIdade;
        private Guna.UI2.WinForms.Guna2TextBox txtIdadeFinal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtIdadeInicial;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel gbStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbInativo;
        private Guna.UI2.WinForms.Guna2RadioButton rbAtivo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.BindingSource classClienteBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvCliente;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}