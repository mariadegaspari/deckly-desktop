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
    public partial class FormMarca : Form
    {
        public string tipo;
        public DateTime data_cadastro;
        public FormMarca()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome_mar.Text))
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

        private void btnCadastrar_mar_Click(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();

            if (string.IsNullOrWhiteSpace(txtNome_mar.Text))
            {
                MessageBox.Show("Favor preencher os campos obrigatórios.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                cMarca.nome_marca = txtNome_mar.Text;
                cMarca.observacao = txtObservacao_mar.Text;

                int resp = cMarca.CadastrarMarca();

                if (resp == 1)
                {

                    MessageBox.Show($"Marca: {cMarca.nome_marca} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtNome_mar.Clear();
            txtObservacao_mar.Clear();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            maskDatacadastro_mar.Text = DateTime.Now.ToShortDateString();
            //VERIFICAR O MODO DE ABERTURA DO FORM - SE FOR ATUALIZAÇÃO
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Marca";
                ckbStatus_mar.Enabled = true;
                btnCadastrar_mar.Visible = false;
                //COMBO BOX (VARIÁVEIS CRIADAS PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIFO NA HORA DE CADASTRAR
                maskDatacadastro_mar.Text = data_cadastro.ToString();
            }
            else
            {
                btnCadastrar_mar.Location = btnExcluir.Location;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR PROPRIEDADES E MÉTODOS DA CLASSE 
            classMarca cMarca = new classMarca();

            if (string.IsNullOrWhiteSpace(txtNome_mar.Text))
            {
                MessageBox.Show("Favor preencher o nome do cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE O CONTEÚDO DE TODOS OS ELEMENTOS QUE PODEM SER PREENCHIDO PELO USUÁRIO
                cMarca.nome_marca = txtNome_mar.Text;
                cMarca.observacao = txtObservacao_mar.Text;

                cMarca.codigo_marca = Convert.ToInt32(txtCodigo_mar.Text);

                if (ckbStatus_mar.Checked)
                {
                    cMarca.status = 1;
                }

                else
                {
                    cMarca.status = 0;
                }

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO 
                //MÉTODO RETORNA UM NÚMERO 0 ERRADO E 1 CERTO
                int resp = cMarca.AtualizarMarca();

                if (resp == 1)
                {
                    MessageBox.Show($"Marca: {cMarca.nome_marca} atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show($"Deseja excluir a marca: {txtNome_mar.Text}", "Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classMarca cMarca = new classMarca();
                cMarca.codigo_marca = Convert.ToInt32(txtCodigo_mar.Text);

                int resp = cMarca.ExcluirMarca();

                if (resp == 1)
                {
                    MessageBox.Show("Marca excluída com sucesso", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNome_mar_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txtNome_mar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
