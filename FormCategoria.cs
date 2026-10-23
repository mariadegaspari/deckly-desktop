using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeckly
{
    public partial class FormCategoria : Form
    {

        public string tipo;
        public DateTime data_cadastro;
        public FormCategoria()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNome_cat.Text))
            {
                this.Close();
            }

            else
            {
                if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void btnCadastrar_cat_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();

            if (string.IsNullOrWhiteSpace(txtNome_cat.Text))
            {
                MessageBox.Show("Favor preencher os campos obrigatórios.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                cCategoria.nome_categoria = txtNome_cat.Text;
                cCategoria.observacao = txtObservacao_cat.Text;

                int resp = cCategoria.CadastrarCategoria();

                if (resp == 1)
                {

                    MessageBox.Show($"Categoria: {cCategoria.nome_categoria} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpar();
                }

                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpar();

                }
            }
        }

        private void Limpar()
        {
            txtNome_cat.Clear();
            txtObservacao_cat.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ckbStatus_car_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            //VERIFICAR O MODO DE ABERTURA DO FORM - SE FOR ATUALIZAÇÃO
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Categoria";
                ckbStatus_cat.Enabled = true;
                btnCadastrar_cat.Visible = false;
                //COMBO BOX (VARIÁVEIS CRIADAS PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIFO NA HORA DE CADASTRAR
                maskDatacadastro_cat.Text = data_cadastro.ToString();
            }
            else
            {
                btnCadastrar_cat.Location = btnExcluir.Location;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;

            }

            maskDatacadastro_cat.Text = DateTime.Now.ToShortDateString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR PROPRIEDADES E MÉTODOS DA CLASSE 
            classCategoria cCategoria = new classCategoria();

            if (string.IsNullOrWhiteSpace(txtNome_cat.Text))
            {
                MessageBox.Show("Favor preencher o nome do cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE O CONTEÚDO DE TODOS OS ELEMENTOS QUE PODEM SER PREENCHIDO PELO USUÁRIO
                cCategoria.nome_categoria = txtNome_cat.Text;
                cCategoria.observacao = txtObservacao_cat.Text;

                cCategoria.codigo_categoria = Convert.ToInt32(txtCodigo_cat.Text);

                if (ckbStatus_cat.Checked)
                {
                    cCategoria.status = 1;
                }

                else
                {
                    cCategoria.status = 0;
                }

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO 
                //MÉTODO RETORNA UM NÚMERO 0 ERRADO E 1 CERTO
                int resp = cCategoria.AtualizarCategoria();

                if (resp == 1)
                {
                    MessageBox.Show($"Categoria: {cCategoria.nome_categoria} atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show($"Erro ao atualizar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir a categoria: {txtNome_cat.Text}", "Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCategoria cCategoria = new classCategoria();
                cCategoria.codigo_categoria = Convert.ToInt32(txtCodigo_cat.Text);

                int resp = cCategoria.ExcluirCategoria();

                if (resp == 1)
                {
                    MessageBox.Show("Categoria excluída com sucesso", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNome_cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtObservacao_cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtObservacao_cat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
