
namespace SistemaDeckly
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.statuslbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsFun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsCar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsCat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsMar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelPro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealizarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.statusPrincipal.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbHora,
            this.statuslbData,
            this.statuslbMensagem});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 491);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusPrincipal.Size = new System.Drawing.Size(933, 28);
            this.statusPrincipal.TabIndex = 1;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // statuslbHora
            // 
            this.statuslbHora.ForeColor = System.Drawing.Color.White;
            this.statuslbHora.Name = "statuslbHora";
            this.statuslbHora.Size = new System.Drawing.Size(55, 23);
            this.statuslbHora.Text = "Hora";
            // 
            // statuslbData
            // 
            this.statuslbData.ForeColor = System.Drawing.Color.White;
            this.statuslbData.Name = "statuslbData";
            this.statuslbData.Size = new System.Drawing.Size(54, 23);
            this.statuslbData.Text = "Data";
            // 
            // statuslbMensagem
            // 
            this.statuslbMensagem.ForeColor = System.Drawing.Color.White;
            this.statuslbMensagem.Name = "statuslbMensagem";
            this.statuslbMensagem.Size = new System.Drawing.Size(212, 23);
            this.statuslbMensagem.Text = "!Bem-vindo ao sistema";
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuConsulta,
            this.menuRelatorios,
            this.menuVenda,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCargo,
            this.menuCadFuncionario,
            this.menuCadMarca,
            this.menuCadCategoria,
            this.menuCadCliente,
            this.menuCadProduto});
            this.menuCadastrar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.menuCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastrar.Image")));
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(152, 29);
            this.menuCadastrar.Text = "Cadastrar";
            this.menuCadastrar.BackColorChanged += new System.EventHandler(this.menuCadastrar_BackColorChanged);
            this.menuCadastrar.Click += new System.EventHandler(this.menuCadastrar_Click);
            // 
            // menuCargo
            // 
            this.menuCargo.Name = "menuCargo";
            this.menuCargo.Size = new System.Drawing.Size(225, 30);
            this.menuCargo.Text = "Cargo";
            this.menuCargo.Click += new System.EventHandler(this.menuCargo_Click);
            // 
            // menuCadFuncionario
            // 
            this.menuCadFuncionario.Name = "menuCadFuncionario";
            this.menuCadFuncionario.Size = new System.Drawing.Size(225, 30);
            this.menuCadFuncionario.Text = "Funcionários";
            this.menuCadFuncionario.Click += new System.EventHandler(this.menuCadFuncionario_Click);
            // 
            // menuCadMarca
            // 
            this.menuCadMarca.Name = "menuCadMarca";
            this.menuCadMarca.Size = new System.Drawing.Size(225, 30);
            this.menuCadMarca.Text = "Marca";
            this.menuCadMarca.Click += new System.EventHandler(this.menuCadMarca_Click);
            // 
            // menuCadCategoria
            // 
            this.menuCadCategoria.Name = "menuCadCategoria";
            this.menuCadCategoria.Size = new System.Drawing.Size(225, 30);
            this.menuCadCategoria.Text = "Categoria";
            this.menuCadCategoria.Click += new System.EventHandler(this.menuCadCategoria_Click);
            // 
            // menuCadCliente
            // 
            this.menuCadCliente.Name = "menuCadCliente";
            this.menuCadCliente.Size = new System.Drawing.Size(225, 30);
            this.menuCadCliente.Text = "Cliente";
            this.menuCadCliente.Click += new System.EventHandler(this.menuCadCliente_Click);
            // 
            // menuCadProduto
            // 
            this.menuCadProduto.Name = "menuCadProduto";
            this.menuCadProduto.Size = new System.Drawing.Size(225, 30);
            this.menuCadProduto.Text = "Produto";
            this.menuCadProduto.Click += new System.EventHandler(this.menuCadProduto_Click);
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsFun,
            this.menuConsCar,
            this.menuConsCat,
            this.menuConsMar,
            this.menuConsCliente,
            this.menuConsProduto});
            this.menuConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.menuConsulta.Image = ((System.Drawing.Image)(resources.GetObject("menuConsulta.Image")));
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(141, 29);
            this.menuConsulta.Text = "Consulta";
            // 
            // menuConsFun
            // 
            this.menuConsFun.Name = "menuConsFun";
            this.menuConsFun.Size = new System.Drawing.Size(214, 30);
            this.menuConsFun.Text = "Funcionário";
            this.menuConsFun.Click += new System.EventHandler(this.menuConsFun_Click);
            // 
            // menuConsCar
            // 
            this.menuConsCar.Name = "menuConsCar";
            this.menuConsCar.Size = new System.Drawing.Size(214, 30);
            this.menuConsCar.Text = "Cargo";
            this.menuConsCar.Click += new System.EventHandler(this.menuConsCar_Click);
            // 
            // menuConsCat
            // 
            this.menuConsCat.Name = "menuConsCat";
            this.menuConsCat.Size = new System.Drawing.Size(214, 30);
            this.menuConsCat.Text = "Categoria";
            this.menuConsCat.Click += new System.EventHandler(this.menuConsCat_Click);
            // 
            // menuConsMar
            // 
            this.menuConsMar.Name = "menuConsMar";
            this.menuConsMar.Size = new System.Drawing.Size(214, 30);
            this.menuConsMar.Text = "Marca";
            this.menuConsMar.Click += new System.EventHandler(this.menuConsMar_Click);
            // 
            // menuConsCliente
            // 
            this.menuConsCliente.Name = "menuConsCliente";
            this.menuConsCliente.Size = new System.Drawing.Size(214, 30);
            this.menuConsCliente.Text = "Cliente";
            this.menuConsCliente.Click += new System.EventHandler(this.menuConsCliente_Click);
            // 
            // menuConsProduto
            // 
            this.menuConsProduto.Name = "menuConsProduto";
            this.menuConsProduto.Size = new System.Drawing.Size(214, 30);
            this.menuConsProduto.Text = "Produto";
            this.menuConsProduto.Click += new System.EventHandler(this.menuConsProduto_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelFunc,
            this.menuRelCli,
            this.menuRelPro});
            this.menuRelatorios.ForeColor = System.Drawing.SystemColors.Control;
            this.menuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("menuRelatorios.Image")));
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(155, 29);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuRelFunc
            // 
            this.menuRelFunc.Name = "menuRelFunc";
            this.menuRelFunc.Size = new System.Drawing.Size(225, 30);
            this.menuRelFunc.Text = "Funcionários";
            this.menuRelFunc.Click += new System.EventHandler(this.menuRelFunc_Click);
            // 
            // menuRelCli
            // 
            this.menuRelCli.Name = "menuRelCli";
            this.menuRelCli.Size = new System.Drawing.Size(225, 30);
            this.menuRelCli.Text = "Clientes";
            this.menuRelCli.Click += new System.EventHandler(this.menuRelCli_Click);
            // 
            // menuRelPro
            // 
            this.menuRelPro.Name = "menuRelPro";
            this.menuRelPro.Size = new System.Drawing.Size(225, 30);
            this.menuRelPro.Text = "Produtos";
            this.menuRelPro.Click += new System.EventHandler(this.menuRelPro_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRealizarVenda});
            this.menuVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.menuVenda.Image = ((System.Drawing.Image)(resources.GetObject("menuVenda.Image")));
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(123, 29);
            this.menuVenda.Text = "Vendas";
            // 
            // menuRealizarVenda
            // 
            this.menuRealizarVenda.Name = "menuRealizarVenda";
            this.menuRealizarVenda.Size = new System.Drawing.Size(250, 30);
            this.menuRealizarVenda.Text = "Realizar Venda";
            this.menuRealizarVenda.Click += new System.EventHandler(this.menuRealizarVenda_Click);
            // 
            // menuSair
            // 
            this.menuSair.ForeColor = System.Drawing.SystemColors.Control;
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(89, 29);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deckly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel statuslbHora;
        private System.Windows.Forms.ToolStripStatusLabel statuslbData;
        private System.Windows.Forms.ToolStripStatusLabel statuslbMensagem;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuCargo;
        private System.Windows.Forms.ToolStripMenuItem menuCadFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuCadMarca;
        private System.Windows.Forms.ToolStripMenuItem menuCadCategoria;
        private System.Windows.Forms.ToolStripMenuItem menuCadCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadProduto;
        private System.Windows.Forms.ToolStripMenuItem menuConsFun;
        private System.Windows.Forms.ToolStripMenuItem menuConsCar;
        private System.Windows.Forms.ToolStripMenuItem menuConsCat;
        private System.Windows.Forms.ToolStripMenuItem menuConsMar;
        private System.Windows.Forms.ToolStripMenuItem menuConsCliente;
        private System.Windows.Forms.ToolStripMenuItem menuConsProduto;
        private System.Windows.Forms.ToolStripMenuItem menuRelFunc;
        private System.Windows.Forms.ToolStripMenuItem menuRelCli;
        private System.Windows.Forms.ToolStripMenuItem menuRelPro;
        private System.Windows.Forms.ToolStripMenuItem menuRealizarVenda;
    }
}

