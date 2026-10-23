
namespace SistemaDeckly
{
    partial class formVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenda));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.gbEstoque = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDataVenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFuncionario = new Guna.UI2.WinForms.Guna2Panel();
            this.cbFuncionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbClientes = new Guna.UI2.WinForms.Guna2Panel();
            this.btBuscaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesqCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbProdutos = new Guna.UI2.WinForms.Guna2Panel();
            this.btBuscaProduto = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesqProduto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbItensVenda = new Guna.UI2.WinForms.Guna2Panel();
            this.btRemover = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQtde = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQtdeEstoque = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.txtProduto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPagamneto = new Guna.UI2.WinForms.Guna2Panel();
            this.btFechaVenda = new Guna.UI2.WinForms.Guna2Button();
            this.txtQtdeItens = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTotalVenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPercentualDesconto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbEstoque.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.gbClientes.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            this.gbItensVenda.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.gbPagamneto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.Location = new System.Drawing.Point(9, 80);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(500, 100);
            this.dgvCliente.TabIndex = 4;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.Location = new System.Drawing.Point(10, 86);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(499, 212);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.Location = new System.Drawing.Point(10, 41);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(558, 354);
            this.dgvItens.TabIndex = 19;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(496, 12);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(92, 36);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Venda";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // gbEstoque
            // 
            this.gbEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbEstoque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbEstoque.BorderRadius = 8;
            this.gbEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbEstoque.BorderThickness = 1;
            this.gbEstoque.Controls.Add(this.txtDataVenda);
            this.gbEstoque.Controls.Add(this.label1);
            this.gbEstoque.ForeColor = System.Drawing.Color.Black;
            this.gbEstoque.Location = new System.Drawing.Point(12, 59);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(154, 70);
            this.gbEstoque.TabIndex = 233;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.BorderRadius = 5;
            this.txtDataVenda.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtDataVenda.BorderThickness = 0;
            this.txtDataVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataVenda.DefaultText = "";
            this.txtDataVenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDataVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDataVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataVenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataVenda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtDataVenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataVenda.Font = new System.Drawing.Font("Century", 9F);
            this.txtDataVenda.ForeColor = System.Drawing.Color.White;
            this.txtDataVenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataVenda.Location = new System.Drawing.Point(28, 23);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.PlaceholderText = "";
            this.txtDataVenda.SelectedText = "";
            this.txtDataVenda.Size = new System.Drawing.Size(84, 38);
            this.txtDataVenda.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 148;
            this.label1.Text = "Data venda:";
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbFuncionario.BorderRadius = 8;
            this.gbFuncionario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbFuncionario.BorderThickness = 1;
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Controls.Add(this.label8);
            this.gbFuncionario.ForeColor = System.Drawing.Color.Black;
            this.gbFuncionario.Location = new System.Drawing.Point(174, 59);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(357, 70);
            this.gbFuncionario.TabIndex = 234;
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.cbFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbFuncionario.BorderRadius = 5;
            this.cbFuncionario.BorderThickness = 0;
            this.cbFuncionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbFuncionario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFuncionario.ForeColor = System.Drawing.Color.White;
            this.cbFuncionario.ItemHeight = 30;
            this.cbFuncionario.Location = new System.Drawing.Point(12, 25);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(333, 36);
            this.cbFuncionario.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 148;
            this.label8.Text = "Escolha o Funcionário";
            // 
            // gbClientes
            // 
            this.gbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbClientes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbClientes.BorderRadius = 8;
            this.gbClientes.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbClientes.BorderThickness = 1;
            this.gbClientes.Controls.Add(this.dgvCliente);
            this.gbClientes.Controls.Add(this.btBuscaCliente);
            this.gbClientes.Controls.Add(this.txtPesqCliente);
            this.gbClientes.Controls.Add(this.label12);
            this.gbClientes.ForeColor = System.Drawing.Color.Black;
            this.gbClientes.Location = new System.Drawing.Point(12, 145);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(519, 195);
            this.gbClientes.TabIndex = 235;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btBuscaCliente.BorderRadius = 5;
            this.btBuscaCliente.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btBuscaCliente.BorderThickness = 1;
            this.btBuscaCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBuscaCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBuscaCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBuscaCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBuscaCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btBuscaCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBuscaCliente.ForeColor = System.Drawing.Color.White;
            this.btBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.Image")));
            this.btBuscaCliente.ImageSize = new System.Drawing.Size(30, 30);
            this.btBuscaCliente.Location = new System.Drawing.Point(458, 27);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(40, 38);
            this.btBuscaCliente.TabIndex = 20;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.BorderRadius = 5;
            this.txtPesqCliente.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPesqCliente.BorderThickness = 0;
            this.txtPesqCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesqCliente.DefaultText = "";
            this.txtPesqCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesqCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesqCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesqCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesqCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtPesqCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesqCliente.Font = new System.Drawing.Font("Century", 9F);
            this.txtPesqCliente.ForeColor = System.Drawing.Color.White;
            this.txtPesqCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesqCliente.Location = new System.Drawing.Point(9, 27);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.PlaceholderText = "";
            this.txtPesqCliente.SelectedText = "";
            this.txtPesqCliente.Size = new System.Drawing.Size(433, 38);
            this.txtPesqCliente.TabIndex = 150;
            this.txtPesqCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesqCliente_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 20);
            this.label12.TabIndex = 148;
            this.label12.Text = "Pesquisa de Clientes:";
            // 
            // gbProdutos
            // 
            this.gbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbProdutos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbProdutos.BorderRadius = 8;
            this.gbProdutos.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbProdutos.BorderThickness = 1;
            this.gbProdutos.Controls.Add(this.dgvProduto);
            this.gbProdutos.Controls.Add(this.btBuscaProduto);
            this.gbProdutos.Controls.Add(this.txtPesqProduto);
            this.gbProdutos.Controls.Add(this.label14);
            this.gbProdutos.ForeColor = System.Drawing.Color.Black;
            this.gbProdutos.Location = new System.Drawing.Point(12, 357);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(519, 320);
            this.gbProdutos.TabIndex = 236;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btBuscaProduto.BorderRadius = 5;
            this.btBuscaProduto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btBuscaProduto.BorderThickness = 1;
            this.btBuscaProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBuscaProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBuscaProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBuscaProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBuscaProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btBuscaProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBuscaProduto.ForeColor = System.Drawing.Color.White;
            this.btBuscaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.Image")));
            this.btBuscaProduto.ImageSize = new System.Drawing.Size(30, 30);
            this.btBuscaProduto.Location = new System.Drawing.Point(458, 27);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Size = new System.Drawing.Size(40, 38);
            this.btBuscaProduto.TabIndex = 20;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.BorderRadius = 5;
            this.txtPesqProduto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPesqProduto.BorderThickness = 0;
            this.txtPesqProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesqProduto.DefaultText = "";
            this.txtPesqProduto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesqProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesqProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesqProduto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesqProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtPesqProduto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesqProduto.Font = new System.Drawing.Font("Century", 9F);
            this.txtPesqProduto.ForeColor = System.Drawing.Color.White;
            this.txtPesqProduto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesqProduto.Location = new System.Drawing.Point(9, 27);
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.PlaceholderText = "";
            this.txtPesqProduto.SelectedText = "";
            this.txtPesqProduto.Size = new System.Drawing.Size(433, 38);
            this.txtPesqProduto.TabIndex = 150;
            this.txtPesqProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesqProduto_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 20);
            this.label14.TabIndex = 148;
            this.label14.Text = "Pesquisa de Produtos:";
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbItensVenda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbItensVenda.BorderRadius = 8;
            this.gbItensVenda.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbItensVenda.BorderThickness = 1;
            this.gbItensVenda.Controls.Add(this.btRemover);
            this.gbItensVenda.Controls.Add(this.txtTotal);
            this.gbItensVenda.Controls.Add(this.label19);
            this.gbItensVenda.Controls.Add(this.txtValor);
            this.gbItensVenda.Controls.Add(this.label18);
            this.gbItensVenda.Controls.Add(this.txtQtde);
            this.gbItensVenda.Controls.Add(this.label17);
            this.gbItensVenda.Controls.Add(this.txtQtdeEstoque);
            this.gbItensVenda.Controls.Add(this.label16);
            this.gbItensVenda.Controls.Add(this.btAdicionar);
            this.gbItensVenda.Controls.Add(this.txtProduto);
            this.gbItensVenda.Controls.Add(this.label15);
            this.gbItensVenda.ForeColor = System.Drawing.Color.Black;
            this.gbItensVenda.Location = new System.Drawing.Point(548, 59);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(576, 186);
            this.gbItensVenda.TabIndex = 236;
            // 
            // btRemover
            // 
            this.btRemover.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btRemover.BorderRadius = 5;
            this.btRemover.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btRemover.BorderThickness = 1;
            this.btRemover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btRemover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btRemover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRemover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btRemover.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btRemover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btRemover.ForeColor = System.Drawing.Color.White;
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.ImageSize = new System.Drawing.Size(30, 30);
            this.btRemover.Location = new System.Drawing.Point(505, 117);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(46, 48);
            this.btRemover.TabIndex = 159;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderRadius = 5;
            this.txtTotal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTotal.BorderThickness = 0;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Century", 9F);
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(280, 127);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(111, 38);
            this.txtTotal.TabIndex = 158;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(280, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 157;
            this.label19.Text = "Total";
            // 
            // txtValor
            // 
            this.txtValor.BorderRadius = 5;
            this.txtValor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtValor.BorderThickness = 0;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Font = new System.Drawing.Font("Century", 9F);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.Location = new System.Drawing.Point(140, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.PlaceholderText = "";
            this.txtValor.ReadOnly = true;
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(109, 38);
            this.txtValor.TabIndex = 156;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(140, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 20);
            this.label18.TabIndex = 155;
            this.label18.Text = "Valor";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderRadius = 5;
            this.txtQtde.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtQtde.BorderThickness = 0;
            this.txtQtde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtde.DefaultText = "";
            this.txtQtde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQtde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQtde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtQtde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQtde.Font = new System.Drawing.Font("Century", 9F);
            this.txtQtde.ForeColor = System.Drawing.Color.White;
            this.txtQtde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQtde.Location = new System.Drawing.Point(25, 127);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.PlaceholderText = "";
            this.txtQtde.SelectedText = "";
            this.txtQtde.Size = new System.Drawing.Size(79, 38);
            this.txtQtde.TabIndex = 154;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(25, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 153;
            this.label17.Text = "Qtde";
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.BorderRadius = 5;
            this.txtQtdeEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtQtdeEstoque.BorderThickness = 0;
            this.txtQtdeEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtdeEstoque.DefaultText = "";
            this.txtQtdeEstoque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQtdeEstoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQtdeEstoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtdeEstoque.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtdeEstoque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtQtdeEstoque.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQtdeEstoque.Font = new System.Drawing.Font("Century", 9F);
            this.txtQtdeEstoque.ForeColor = System.Drawing.Color.White;
            this.txtQtdeEstoque.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQtdeEstoque.Location = new System.Drawing.Point(471, 45);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.PlaceholderText = "";
            this.txtQtdeEstoque.ReadOnly = true;
            this.txtQtdeEstoque.SelectedText = "";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(79, 38);
            this.txtQtdeEstoque.TabIndex = 152;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(472, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 151;
            this.label16.Text = "Estoque";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btAdicionar.BorderRadius = 5;
            this.btAdicionar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btAdicionar.BorderThickness = 1;
            this.btAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdicionar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.ImageSize = new System.Drawing.Size(30, 30);
            this.btAdicionar.Location = new System.Drawing.Point(438, 117);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(46, 48);
            this.btAdicionar.TabIndex = 20;
            this.btAdicionar.TextChanged += new System.EventHandler(this.btAdicionar_Click);
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BorderRadius = 5;
            this.txtProduto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtProduto.BorderThickness = 0;
            this.txtProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProduto.DefaultText = "";
            this.txtProduto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProduto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProduto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtProduto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProduto.Font = new System.Drawing.Font("Century", 9F);
            this.txtProduto.ForeColor = System.Drawing.Color.White;
            this.txtProduto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProduto.Location = new System.Drawing.Point(22, 45);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PlaceholderText = "";
            this.txtProduto.SelectedText = "";
            this.txtProduto.Size = new System.Drawing.Size(416, 38);
            this.txtProduto.TabIndex = 150;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(22, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 20);
            this.label15.TabIndex = 148;
            this.label15.Text = "Produto Selecionado:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.dgvItens);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(548, 260);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(576, 417);
            this.guna2Panel2.TabIndex = 237;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Itens da Venda:";
            // 
            // gbPagamneto
            // 
            this.gbPagamneto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.gbPagamneto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.gbPagamneto.BorderRadius = 8;
            this.gbPagamneto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbPagamneto.BorderThickness = 1;
            this.gbPagamneto.Controls.Add(this.btFechaVenda);
            this.gbPagamneto.Controls.Add(this.txtQtdeItens);
            this.gbPagamneto.Controls.Add(this.label21);
            this.gbPagamneto.Controls.Add(this.txtTotalVenda);
            this.gbPagamneto.Controls.Add(this.label20);
            this.gbPagamneto.Controls.Add(this.txtTotalDesconto);
            this.gbPagamneto.Controls.Add(this.label7);
            this.gbPagamneto.Controls.Add(this.txtPercentualDesconto);
            this.gbPagamneto.Controls.Add(this.label6);
            this.gbPagamneto.Controls.Add(this.txtValorTotal);
            this.gbPagamneto.Controls.Add(this.label5);
            this.gbPagamneto.Controls.Add(this.cbFormaPagamento);
            this.gbPagamneto.Controls.Add(this.label4);
            this.gbPagamneto.ForeColor = System.Drawing.Color.Black;
            this.gbPagamneto.Location = new System.Drawing.Point(12, 694);
            this.gbPagamneto.Name = "gbPagamneto";
            this.gbPagamneto.Size = new System.Drawing.Size(1112, 88);
            this.gbPagamneto.TabIndex = 238;
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.BorderRadius = 2;
            this.btFechaVenda.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btFechaVenda.BorderThickness = 1;
            this.btFechaVenda.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btFechaVenda.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btFechaVenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFechaVenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFechaVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFechaVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFechaVenda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btFechaVenda.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaVenda.ForeColor = System.Drawing.Color.White;
            this.btFechaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btFechaVenda.Image")));
            this.btFechaVenda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btFechaVenda.ImageSize = new System.Drawing.Size(30, 30);
            this.btFechaVenda.Location = new System.Drawing.Point(918, 15);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Size = new System.Drawing.Size(180, 58);
            this.btFechaVenda.TabIndex = 237;
            this.btFechaVenda.Text = "Fechar venda";
            this.btFechaVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btFechaVenda.TextChanged += new System.EventHandler(this.btFechaVenda_Click);
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // txtQtdeItens
            // 
            this.txtQtdeItens.BorderRadius = 5;
            this.txtQtdeItens.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtQtdeItens.BorderThickness = 0;
            this.txtQtdeItens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQtdeItens.DefaultText = "";
            this.txtQtdeItens.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQtdeItens.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQtdeItens.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtdeItens.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQtdeItens.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtQtdeItens.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQtdeItens.Font = new System.Drawing.Font("Century", 9F);
            this.txtQtdeItens.ForeColor = System.Drawing.Color.White;
            this.txtQtdeItens.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQtdeItens.Location = new System.Drawing.Point(796, 35);
            this.txtQtdeItens.Name = "txtQtdeItens";
            this.txtQtdeItens.PlaceholderText = "";
            this.txtQtdeItens.SelectedText = "";
            this.txtQtdeItens.Size = new System.Drawing.Size(94, 38);
            this.txtQtdeItens.TabIndex = 230;
            this.txtQtdeItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeItens_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(796, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 20);
            this.label21.TabIndex = 229;
            this.label21.Text = "Qtde Itens:";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.BorderRadius = 5;
            this.txtTotalVenda.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTotalVenda.BorderThickness = 0;
            this.txtTotalVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalVenda.DefaultText = "";
            this.txtTotalVenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalVenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalVenda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtTotalVenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalVenda.Font = new System.Drawing.Font("Century", 9F);
            this.txtTotalVenda.ForeColor = System.Drawing.Color.White;
            this.txtTotalVenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalVenda.Location = new System.Drawing.Point(604, 35);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.PlaceholderText = "";
            this.txtTotalVenda.SelectedText = "";
            this.txtTotalVenda.Size = new System.Drawing.Size(165, 38);
            this.txtTotalVenda.TabIndex = 228;
            this.txtTotalVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalVenda_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(604, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 20);
            this.label20.TabIndex = 227;
            this.label20.Text = "Total da Venda (R$)";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.BorderRadius = 5;
            this.txtTotalDesconto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTotalDesconto.BorderThickness = 0;
            this.txtTotalDesconto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDesconto.DefaultText = "";
            this.txtTotalDesconto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalDesconto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalDesconto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDesconto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDesconto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtTotalDesconto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDesconto.Font = new System.Drawing.Font("Century", 9F);
            this.txtTotalDesconto.ForeColor = System.Drawing.Color.White;
            this.txtTotalDesconto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDesconto.Location = new System.Drawing.Point(496, 35);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.PlaceholderText = "";
            this.txtTotalDesconto.SelectedText = "";
            this.txtTotalDesconto.Size = new System.Drawing.Size(80, 38);
            this.txtTotalDesconto.TabIndex = 226;
            this.txtTotalDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDesconto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(475, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 23);
            this.label7.TabIndex = 225;
            this.label7.Text = "=";
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.BorderRadius = 5;
            this.txtPercentualDesconto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPercentualDesconto.BorderThickness = 0;
            this.txtPercentualDesconto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercentualDesconto.DefaultText = "";
            this.txtPercentualDesconto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPercentualDesconto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPercentualDesconto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercentualDesconto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPercentualDesconto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtPercentualDesconto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercentualDesconto.Font = new System.Drawing.Font("Century", 9F);
            this.txtPercentualDesconto.ForeColor = System.Drawing.Color.White;
            this.txtPercentualDesconto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPercentualDesconto.Location = new System.Drawing.Point(431, 35);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.PlaceholderText = "";
            this.txtPercentualDesconto.SelectedText = "";
            this.txtPercentualDesconto.Size = new System.Drawing.Size(42, 38);
            this.txtPercentualDesconto.TabIndex = 153;
            this.txtPercentualDesconto.TextChanged += new System.EventHandler(this.txtPercentualDesconto_TextChanged);
            this.txtPercentualDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentualDesconto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 152;
            this.label6.Text = "Deconto (%)";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BorderRadius = 5;
            this.txtValorTotal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtValorTotal.BorderThickness = 0;
            this.txtValorTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorTotal.DefaultText = "";
            this.txtValorTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValorTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValorTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtValorTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorTotal.Font = new System.Drawing.Font("Century", 9F);
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorTotal.Location = new System.Drawing.Point(262, 35);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.PlaceholderText = "";
            this.txtValorTotal.SelectedText = "";
            this.txtValorTotal.Size = new System.Drawing.Size(151, 38);
            this.txtValorTotal.TabIndex = 151;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(258, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 149;
            this.label5.Text = "Valor total";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.cbFormaPagamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cbFormaPagamento.BorderRadius = 5;
            this.cbFormaPagamento.BorderThickness = 0;
            this.cbFormaPagamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.cbFormaPagamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFormaPagamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.cbFormaPagamento.ItemHeight = 30;
            this.cbFormaPagamento.Location = new System.Drawing.Point(6, 35);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(230, 36);
            this.cbFormaPagamento.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "Forma de pagamento:";
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
            this.btnClose.Location = new System.Drawing.Point(1089, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 239;
            this.btnClose.Click += new System.EventHandler(this.btSair_Click);
            // 
            // formVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1140, 805);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbPagamneto);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.lbTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.formVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            this.gbItensVenda.ResumeLayout(false);
            this.gbItensVenda.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.gbPagamneto.ResumeLayout(false);
            this.gbPagamneto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label lbTitulo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel gbEstoque;
        private Guna.UI2.WinForms.Guna2TextBox txtDataVenda;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel gbClientes;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel gbFuncionario;
        private Guna.UI2.WinForms.Guna2ComboBox cbFuncionario;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btBuscaCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtPesqCliente;
        private Guna.UI2.WinForms.Guna2Panel gbItensVenda;
        private Guna.UI2.WinForms.Guna2Button btRemover;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtQtde;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtQtdeEstoque;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btAdicionar;
        private Guna.UI2.WinForms.Guna2TextBox txtProduto;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Panel gbProdutos;
        private Guna.UI2.WinForms.Guna2Button btBuscaProduto;
        private Guna.UI2.WinForms.Guna2TextBox txtPesqProduto;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel gbPagamneto;
        private Guna.UI2.WinForms.Guna2ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtQtdeItens;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalVenda;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDesconto;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPercentualDesconto;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtValorTotal;
        private Guna.UI2.WinForms.Guna2Button btFechaVenda;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}