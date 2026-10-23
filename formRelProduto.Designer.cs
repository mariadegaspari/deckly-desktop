
namespace SistemaDeckly
{
    partial class formRelProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelProduto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbTipoRel = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTipoRel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCategoria = new Guna.UI2.WinForms.Guna2Panel();
            this.cbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMarca = new Guna.UI2.WinForms.Guna2Panel();
            this.cbMarca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPreco = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPrecof = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPrecoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rvProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbEstoque = new Guna.UI2.WinForms.Guna2Panel();
            this.txtEstoquef = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEstoquei = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).BeginInit();
            this.gbTipoRel.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbPreco.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGerarRelatorio
            // 
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
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
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
            this.gbTipoRel.Location = new System.Drawing.Point(11, 71);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(235, 81);
            this.gbTipoRel.TabIndex = 147;
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
            // gbCategoria
            // 
            this.gbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbCategoria.BorderRadius = 8;
            this.gbCategoria.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbCategoria.BorderThickness = 1;
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Controls.Add(this.label2);
            this.gbCategoria.ForeColor = System.Drawing.Color.Black;
            this.gbCategoria.Location = new System.Drawing.Point(11, 169);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(235, 82);
            this.gbCategoria.TabIndex = 149;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbCategoria.BorderRadius = 5;
            this.cbCategoria.BorderThickness = 0;
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategoria.ForeColor = System.Drawing.Color.White;
            this.cbCategoria.ItemHeight = 30;
            this.cbCategoria.Location = new System.Drawing.Point(15, 32);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(205, 36);
            this.cbCategoria.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 148;
            this.label2.Text = "Categoria";
            // 
            // gbMarca
            // 
            this.gbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbMarca.BorderRadius = 8;
            this.gbMarca.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbMarca.BorderThickness = 1;
            this.gbMarca.Controls.Add(this.cbMarca);
            this.gbMarca.Controls.Add(this.label3);
            this.gbMarca.ForeColor = System.Drawing.Color.Black;
            this.gbMarca.Location = new System.Drawing.Point(11, 268);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(235, 79);
            this.gbMarca.TabIndex = 150;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.Transparent;
            this.cbMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbMarca.BorderRadius = 5;
            this.cbMarca.BorderThickness = 0;
            this.cbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbMarca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMarca.ForeColor = System.Drawing.Color.White;
            this.cbMarca.ItemHeight = 30;
            this.cbMarca.Location = new System.Drawing.Point(15, 31);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(205, 36);
            this.cbMarca.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Marca";
            // 
            // gbPreco
            // 
            this.gbPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbPreco.BorderRadius = 8;
            this.gbPreco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbPreco.BorderThickness = 1;
            this.gbPreco.Controls.Add(this.txtPrecof);
            this.gbPreco.Controls.Add(this.guna2HtmlLabel2);
            this.gbPreco.Controls.Add(this.guna2HtmlLabel1);
            this.gbPreco.Controls.Add(this.txtPrecoi);
            this.gbPreco.Controls.Add(this.label4);
            this.gbPreco.ForeColor = System.Drawing.Color.Black;
            this.gbPreco.Location = new System.Drawing.Point(11, 465);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(235, 79);
            this.gbPreco.TabIndex = 151;
            // 
            // txtPrecof
            // 
            this.txtPrecof.BorderRadius = 5;
            this.txtPrecof.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPrecof.BorderThickness = 0;
            this.txtPrecof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecof.DefaultText = "";
            this.txtPrecof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecof.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtPrecof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecof.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecof.ForeColor = System.Drawing.Color.White;
            this.txtPrecof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecof.Location = new System.Drawing.Point(166, 33);
            this.txtPrecof.Name = "txtPrecof";
            this.txtPrecof.PlaceholderText = "";
            this.txtPrecof.SelectedText = "";
            this.txtPrecof.Size = new System.Drawing.Size(54, 38);
            this.txtPrecof.TabIndex = 154;
            this.txtPrecof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecof_KeyPress);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(127, 45);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(33, 22);
            this.guna2HtmlLabel2.TabIndex = 153;
            this.guna2HtmlLabel2.Text = "Até:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(27, 22);
            this.guna2HtmlLabel1.TabIndex = 152;
            this.guna2HtmlLabel1.Text = "De:";
            // 
            // txtPrecoi
            // 
            this.txtPrecoi.BorderRadius = 5;
            this.txtPrecoi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPrecoi.BorderThickness = 0;
            this.txtPrecoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoi.DefaultText = "";
            this.txtPrecoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtPrecoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoi.Font = new System.Drawing.Font("Century", 9F);
            this.txtPrecoi.ForeColor = System.Drawing.Color.White;
            this.txtPrecoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoi.Location = new System.Drawing.Point(48, 31);
            this.txtPrecoi.Name = "txtPrecoi";
            this.txtPrecoi.PlaceholderText = "";
            this.txtPrecoi.SelectedText = "";
            this.txtPrecoi.Size = new System.Drawing.Size(54, 38);
            this.txtPrecoi.TabIndex = 149;
            this.txtPrecoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "Preço";
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
            this.gbStatus.TabIndex = 155;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btGerarRelatorio);
            this.guna2Panel1.Location = new System.Drawing.Point(11, 663);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(235, 79);
            this.guna2Panel1.TabIndex = 156;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(418, 21);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(266, 30);
            this.guna2HtmlLabel3.TabIndex = 235;
            this.guna2HtmlLabel3.Text = "Relatório de Produtos";
            // 
            // rvProduto
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.classProdutoBindingSource;
            this.rvProduto.LocalReport.DataSources.Add(reportDataSource2);
            this.rvProduto.LocalReport.ReportEmbeddedResource = "SistemaDeckly.rbtProduto.rdlc";
            this.rvProduto.Location = new System.Drawing.Point(17, 18);
            this.rvProduto.Name = "rvProduto";
            this.rvProduto.ServerReport.BearerToken = null;
            this.rvProduto.Size = new System.Drawing.Size(757, 631);
            this.rvProduto.TabIndex = 236;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.rvProduto);
            this.guna2Panel2.Location = new System.Drawing.Point(270, 71);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(791, 671);
            this.guna2Panel2.TabIndex = 237;
            // 
            // gbEstoque
            // 
            this.gbEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbEstoque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbEstoque.BorderRadius = 8;
            this.gbEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbEstoque.BorderThickness = 1;
            this.gbEstoque.Controls.Add(this.txtEstoquef);
            this.gbEstoque.Controls.Add(this.guna2HtmlLabel4);
            this.gbEstoque.Controls.Add(this.guna2HtmlLabel5);
            this.gbEstoque.Controls.Add(this.txtEstoquei);
            this.gbEstoque.Controls.Add(this.label6);
            this.gbEstoque.ForeColor = System.Drawing.Color.Black;
            this.gbEstoque.Location = new System.Drawing.Point(11, 366);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(235, 79);
            this.gbEstoque.TabIndex = 155;
            // 
            // txtEstoquef
            // 
            this.txtEstoquef.BorderRadius = 5;
            this.txtEstoquef.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtEstoquef.BorderThickness = 0;
            this.txtEstoquef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoquef.DefaultText = "";
            this.txtEstoquef.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstoquef.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstoquef.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstoquef.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstoquef.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEstoquef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstoquef.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoquef.ForeColor = System.Drawing.Color.White;
            this.txtEstoquef.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstoquef.Location = new System.Drawing.Point(166, 33);
            this.txtEstoquef.Name = "txtEstoquef";
            this.txtEstoquef.PlaceholderText = "";
            this.txtEstoquef.SelectedText = "";
            this.txtEstoquef.Size = new System.Drawing.Size(54, 38);
            this.txtEstoquef.TabIndex = 154;
            this.txtEstoquef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoquef_KeyPress);
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
            // txtEstoquei
            // 
            this.txtEstoquei.BorderRadius = 5;
            this.txtEstoquei.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtEstoquei.BorderThickness = 0;
            this.txtEstoquei.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoquei.DefaultText = "";
            this.txtEstoquei.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstoquei.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstoquei.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstoquei.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstoquei.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEstoquei.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstoquei.Font = new System.Drawing.Font("Century", 9F);
            this.txtEstoquei.ForeColor = System.Drawing.Color.White;
            this.txtEstoquei.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstoquei.Location = new System.Drawing.Point(48, 33);
            this.txtEstoquei.Name = "txtEstoquei";
            this.txtEstoquei.PlaceholderText = "";
            this.txtEstoquei.SelectedText = "";
            this.txtEstoquei.Size = new System.Drawing.Size(54, 38);
            this.txtEstoquei.TabIndex = 149;
            this.txtEstoquei.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoquei_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 148;
            this.label6.Text = "Estoque";
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
            this.btnClose.Location = new System.Drawing.Point(1026, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 238;
            this.btnClose.Click += new System.EventHandler(this.btSair_Click);
            // 
            // formRelProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1073, 752);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbPreco);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbTipoRel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelProduto";
            this.Text = "formRelProduto";
            this.Load += new System.EventHandler(this.formRelProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).EndInit();
            this.gbTipoRel.ResumeLayout(false);
            this.gbTipoRel.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbMarca.ResumeLayout(false);
            this.gbMarca.PerformLayout();
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGerarRelatorio;
        private Guna.UI2.WinForms.Guna2Panel gbTipoRel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoRel;
        private Guna.UI2.WinForms.Guna2Panel gbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel gbMarca;
        private Guna.UI2.WinForms.Guna2ComboBox cbMarca;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel gbPreco;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecoi;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecof;
        private System.Windows.Forms.BindingSource classProdutoBindingSource;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2RadioButton rbAtivo;
        private Guna.UI2.WinForms.Guna2RadioButton rbInativo;
        private Guna.UI2.WinForms.Guna2Panel gbStatus;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Microsoft.Reporting.WinForms.ReportViewer rvProduto;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel gbEstoque;
        private Guna.UI2.WinForms.Guna2TextBox txtEstoquef;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtEstoquei;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}