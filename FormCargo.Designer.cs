
namespace SistemaDeckly
{
    partial class FormCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbStatus_car = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskDatacadastro_car = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacao_car = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNome_car = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtCodigo_car = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCadastrar_car = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(332, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // ckbStatus_car
            // 
            this.ckbStatus_car.AutoSize = true;
            this.ckbStatus_car.Checked = true;
            this.ckbStatus_car.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus_car.Enabled = false;
            this.ckbStatus_car.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatus_car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(185)))), ((int)(((byte)(186)))));
            this.ckbStatus_car.Location = new System.Drawing.Point(327, 50);
            this.ckbStatus_car.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ckbStatus_car.Name = "ckbStatus_car";
            this.ckbStatus_car.Size = new System.Drawing.Size(68, 24);
            this.ckbStatus_car.TabIndex = 7;
            this.ckbStatus_car.Text = "Ativo";
            this.ckbStatus_car.UseVisualStyleBackColor = true;
            this.ckbStatus_car.CheckedChanged += new System.EventHandler(this.ckbStatus_car_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observações";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskDatacadastro_car
            // 
            this.maskDatacadastro_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.maskDatacadastro_car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskDatacadastro_car.Enabled = false;
            this.maskDatacadastro_car.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDatacadastro_car.ForeColor = System.Drawing.SystemColors.Window;
            this.maskDatacadastro_car.Location = new System.Drawing.Point(171, 48);
            this.maskDatacadastro_car.Mask = "00/00/0000";
            this.maskDatacadastro_car.Name = "maskDatacadastro_car";
            this.maskDatacadastro_car.Size = new System.Drawing.Size(93, 27);
            this.maskDatacadastro_car.TabIndex = 9;
            this.maskDatacadastro_car.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskDatacadastro_car.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data de cadastro";
            // 
            // txtObservacao_car
            // 
            this.txtObservacao_car.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.txtObservacao_car.BorderRadius = 8;
            this.txtObservacao_car.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtObservacao_car.BorderThickness = 0;
            this.txtObservacao_car.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacao_car.DefaultText = "";
            this.txtObservacao_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtObservacao_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtObservacao_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacao_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacao_car.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtObservacao_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacao_car.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservacao_car.ForeColor = System.Drawing.Color.White;
            this.txtObservacao_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacao_car.Location = new System.Drawing.Point(41, 39);
            this.txtObservacao_car.MaxLength = 100;
            this.txtObservacao_car.Multiline = true;
            this.txtObservacao_car.Name = "txtObservacao_car";
            this.txtObservacao_car.PlaceholderText = "";
            this.txtObservacao_car.SelectedText = "";
            this.txtObservacao_car.Size = new System.Drawing.Size(317, 122);
            this.txtObservacao_car.TabIndex = 14;
            this.txtObservacao_car.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacoes_car_KeyPress);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtNome_car);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(22, 200);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(409, 78);
            this.guna2Panel1.TabIndex = 18;
            // 
            // txtNome_car
            // 
            this.txtNome_car.BorderRadius = 5;
            this.txtNome_car.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNome_car.BorderThickness = 0;
            this.txtNome_car.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome_car.DefaultText = "";
            this.txtNome_car.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome_car.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome_car.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtNome_car.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome_car.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome_car.ForeColor = System.Drawing.Color.White;
            this.txtNome_car.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome_car.Location = new System.Drawing.Point(28, 30);
            this.txtNome_car.MaxLength = 40;
            this.txtNome_car.Name = "txtNome_car";
            this.txtNome_car.PlaceholderText = "";
            this.txtNome_car.SelectedText = "";
            this.txtNome_car.Size = new System.Drawing.Size(330, 36);
            this.txtNome_car.TabIndex = 15;
            this.txtNome_car.TextChanged += new System.EventHandler(this.txtNome_car_TextChanged);
            this.txtNome_car.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_car_KeyPress);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtCodigo_car);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.maskDatacadastro_car);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.ckbStatus_car);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(22, 57);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(409, 115);
            this.guna2Panel2.TabIndex = 19;
            // 
            // txtCodigo_car
            // 
            this.txtCodigo_car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtCodigo_car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo_car.Enabled = false;
            this.txtCodigo_car.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCodigo_car.Location = new System.Drawing.Point(19, 48);
            this.txtCodigo_car.Name = "txtCodigo_car";
            this.txtCodigo_car.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo_car.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código cargo";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.txtObservacao_car);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Location = new System.Drawing.Point(22, 299);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(409, 177);
            this.guna2Panel3.TabIndex = 20;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(96, 14);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(241, 28);
            this.lbTitulo.TabIndex = 22;
            this.lbTitulo.Text = "Cadastro de cargos";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btnExcluir.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btnExcluir.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcluir.Location = new System.Drawing.Point(319, 497);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 27);
            this.btnExcluir.TabIndex = 52;
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btnEditar.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btnEditar.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditar.Location = new System.Drawing.Point(201, 497);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 27);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Atualizar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar_car
            // 
            this.btnCadastrar_car.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btnCadastrar_car.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnCadastrar_car.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar_car.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar_car.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar_car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar_car.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btnCadastrar_car.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar_car.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar_car.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar_car.Image")));
            this.btnCadastrar_car.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadastrar_car.Location = new System.Drawing.Point(83, 497);
            this.btnCadastrar_car.Name = "btnCadastrar_car";
            this.btnCadastrar_car.Size = new System.Drawing.Size(112, 27);
            this.btnCadastrar_car.TabIndex = 50;
            this.btnCadastrar_car.Text = "Cadastrar";
            this.btnCadastrar_car.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCadastrar_car.Click += new System.EventHandler(this.btnCadastrar_car_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(395, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 54;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(454, 542);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar_car);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCargo";
            this.Text = "FormCargo";
            this.Load += new System.EventHandler(this.FormCargo_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbTitulo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox ckbStatus_car;
        public System.Windows.Forms.MaskedTextBox maskDatacadastro_car;
        public Guna.UI2.WinForms.Guna2TextBox txtObservacao_car;
        public System.Windows.Forms.TextBox txtCodigo_car;
        public Guna.UI2.WinForms.Guna2TextBox txtNome_car;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar_car;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}