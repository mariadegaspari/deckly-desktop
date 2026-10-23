
namespace SistemaDeckly
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtCodigo_cat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskDatacadastro_cat = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbStatus_cat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNome_cat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtObservacao_cat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCadastrar_cat = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da categoria";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(100, 19);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(234, 23);
            this.lbTitulo.TabIndex = 35;
            this.lbTitulo.Text = "Cadastro de categorias";
            // 
            // txtCodigo_cat
            // 
            this.txtCodigo_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtCodigo_cat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo_cat.Enabled = false;
            this.txtCodigo_cat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo_cat.Location = new System.Drawing.Point(19, 41);
            this.txtCodigo_cat.Name = "txtCodigo_cat";
            this.txtCodigo_cat.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo_cat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código categoria";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // maskDatacadastro_cat
            // 
            this.maskDatacadastro_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.maskDatacadastro_cat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskDatacadastro_cat.Enabled = false;
            this.maskDatacadastro_cat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDatacadastro_cat.ForeColor = System.Drawing.Color.White;
            this.maskDatacadastro_cat.Location = new System.Drawing.Point(191, 39);
            this.maskDatacadastro_cat.Mask = "00/00/0000";
            this.maskDatacadastro_cat.Name = "maskDatacadastro_cat";
            this.maskDatacadastro_cat.Size = new System.Drawing.Size(88, 20);
            this.maskDatacadastro_cat.TabIndex = 9;
            this.maskDatacadastro_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskDatacadastro_cat.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data de cadastro";
            // 
            // ckbStatus_cat
            // 
            this.ckbStatus_cat.AutoSize = true;
            this.ckbStatus_cat.Checked = true;
            this.ckbStatus_cat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus_cat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatus_cat.ForeColor = System.Drawing.Color.White;
            this.ckbStatus_cat.Location = new System.Drawing.Point(329, 44);
            this.ckbStatus_cat.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ckbStatus_cat.Name = "ckbStatus_cat";
            this.ckbStatus_cat.Size = new System.Drawing.Size(68, 24);
            this.ckbStatus_cat.TabIndex = 7;
            this.ckbStatus_cat.Text = "Ativo";
            this.ckbStatus_cat.UseVisualStyleBackColor = true;
            this.ckbStatus_cat.CheckedChanged += new System.EventHandler(this.ckbStatus_car_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(325, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel4.BorderRadius = 8;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Controls.Add(this.txtCodigo_cat);
            this.guna2Panel4.Controls.Add(this.ckbStatus_cat);
            this.guna2Panel4.Controls.Add(this.maskDatacadastro_cat);
            this.guna2Panel4.Location = new System.Drawing.Point(22, 57);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(405, 79);
            this.guna2Panel4.TabIndex = 45;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txtNome_cat);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(22, 157);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(405, 79);
            this.guna2Panel1.TabIndex = 46;
            // 
            // txtNome_cat
            // 
            this.txtNome_cat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtNome_cat.BorderRadius = 5;
            this.txtNome_cat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome_cat.DefaultText = "";
            this.txtNome_cat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome_cat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome_cat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome_cat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome_cat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtNome_cat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome_cat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome_cat.ForeColor = System.Drawing.Color.White;
            this.txtNome_cat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome_cat.Location = new System.Drawing.Point(18, 32);
            this.txtNome_cat.MaxLength = 60;
            this.txtNome_cat.Name = "txtNome_cat";
            this.txtNome_cat.PlaceholderText = "";
            this.txtNome_cat.SelectedText = "";
            this.txtNome_cat.Size = new System.Drawing.Size(370, 36);
            this.txtNome_cat.TabIndex = 2;
            this.txtNome_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_cat_KeyPress);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.txtObservacao_cat);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Location = new System.Drawing.Point(22, 258);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(405, 172);
            this.guna2Panel2.TabIndex = 15;
            // 
            // txtObservacao_cat
            // 
            this.txtObservacao_cat.BorderRadius = 5;
            this.txtObservacao_cat.BorderThickness = 0;
            this.txtObservacao_cat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacao_cat.DefaultText = "";
            this.txtObservacao_cat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtObservacao_cat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtObservacao_cat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacao_cat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacao_cat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtObservacao_cat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacao_cat.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao_cat.ForeColor = System.Drawing.Color.Black;
            this.txtObservacao_cat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacao_cat.Location = new System.Drawing.Point(23, 38);
            this.txtObservacao_cat.MaxLength = 100;
            this.txtObservacao_cat.Multiline = true;
            this.txtObservacao_cat.Name = "txtObservacao_cat";
            this.txtObservacao_cat.PlaceholderText = "";
            this.txtObservacao_cat.SelectedText = "";
            this.txtObservacao_cat.Size = new System.Drawing.Size(360, 122);
            this.txtObservacao_cat.TabIndex = 14;
            this.txtObservacao_cat.TextChanged += new System.EventHandler(this.txtObservacao_cat_TextChanged);
            this.txtObservacao_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacao_cat_KeyPress);
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
            this.btnExcluir.Location = new System.Drawing.Point(315, 449);
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
            this.btnEditar.Location = new System.Drawing.Point(197, 449);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 27);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Atualizar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar_cat
            // 
            this.btnCadastrar_cat.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.btnCadastrar_cat.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnCadastrar_cat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar_cat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar_cat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar_cat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar_cat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.btnCadastrar_cat.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar_cat.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar_cat.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar_cat.Image")));
            this.btnCadastrar_cat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadastrar_cat.Location = new System.Drawing.Point(79, 449);
            this.btnCadastrar_cat.Name = "btnCadastrar_cat";
            this.btnCadastrar_cat.Size = new System.Drawing.Size(112, 27);
            this.btnCadastrar_cat.TabIndex = 50;
            this.btnCadastrar_cat.Text = "Cadastrar";
            this.btnCadastrar_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCadastrar_cat.Click += new System.EventHandler(this.btnCadastrar_cat_Click);
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
            this.btnClose.Location = new System.Drawing.Point(392, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 54;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(452, 488);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar_cat);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public System.Windows.Forms.TextBox txtCodigo_cat;
        public System.Windows.Forms.MaskedTextBox maskDatacadastro_cat;
        public System.Windows.Forms.CheckBox ckbStatus_cat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2TextBox txtObservacao_cat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2TextBox txtNome_cat;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar_cat;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}