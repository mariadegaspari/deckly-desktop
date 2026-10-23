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
    public partial class FormCargo : Form
    {
        //CRIAR VARIÁVEIS QUE SERÃO UTILIZADAS NO FORM DE CONSULTA
        //TIPO - MANEIRA QUE FORM SERÁ ABERTO
        //OUTRAS VARIÁVEIS - EXIBIR OS DADOS QUE ESTÃO ARMAZENADO NO BD E NÃO OS DECLARADOS NO LOAD DO FORM, TUDO QUE FOR COMBOBOX PRECISA TER UMA VARIÁVEL E A VARIÁVEL PARA CARREGAR A DATA CADASTRO ARMAZENADA NO BD

        public string tipo;
        public DateTime data_cadastro;
        public FormCargo()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            //EXIBIR A DATA ATUAL DO SISTEMA
            maskDatacadastro_car.Text = DateTime.Now.ToShortDateString();

            //VERIFICAR O MODO DE ABERTURA DO FORM - SE FOR ATUALIZAÇÃO
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Cargo";
                ckbStatus_car.Enabled = true;
                btnCadastrar_car.Visible = false;
                //COMBO BOX (VARIÁVEIS CRIADAS PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIFO NA HORA DE CADASTRAR
                maskDatacadastro_car.Text = data_cadastro.ToString();
            }
            else
            {
                btnCadastrar_car.Location = btnExcluir.Location;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;

            }
        }
        private void ckbStatus_car_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNome_car.Text) || !string.IsNullOrWhiteSpace(txtObservacao_car.Text))
            {
                if(MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnCadastrar_car_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR PROPRIEDADES E MÉTODOS DA CLASSE 
            classCargo cCargo = new classCargo();

            //VERIFICAR SE TODOS PS CAMPOS QUE DEVEM SER PREENCHIDOS PELO USUÁRIO ESTÃO PREENCHIDOS
            if (string.IsNullOrWhiteSpace(txtNome_car.Text))
            {
                MessageBox.Show("Favor preencher os campos obrigatórios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome_car.Focus();
            }

            else
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE O CONTEÚDO DE TODOS OS ELEMENTOS QUE PODEM SER PREENCHIDO PELO USUÁRIO
                cCargo.nome = txtNome_car.Text;
                cCargo.observacao = txtObservacao_car.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO 
                //MÉTODO RETORNA UM NÚMERO 0 ERRADO E 1 CERTO
                int resp = cCargo.CadastrarCargo();

                if (resp == 1)
                {
                    MessageBox.Show($"Cargo: {cCargo.nome} cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome_car.Clear();
                    txtObservacao_car.Clear();
                    txtNome_car.Focus();
                }

                else
                {
                    MessageBox.Show($"Erro ao cadastrar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR PROPRIEDADES E MÉTODOS DA CLASSE 
            classCargo cCargo = new classCargo();

            if (string.IsNullOrWhiteSpace(txtNome_car.Text))
            {
                MessageBox.Show("Favor preencher o nome do cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE O CONTEÚDO DE TODOS OS ELEMENTOS QUE PODEM SER PREENCHIDO PELO USUÁRIO
                cCargo.nome = txtNome_car.Text;
                cCargo.observacao = txtObservacao_car.Text;

                cCargo.codigo_cargo = Convert.ToInt32(txtCodigo_car.Text);

                if (ckbStatus_car.Checked)
                {
                    cCargo.status = 1;
                }

                else
                {
                    cCargo.status = 0;
                }

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO 
                //MÉTODO RETORNA UM NÚMERO 0 ERRADO E 1 CERTO
                int resp = cCargo.AtualizarCargo();

                if (resp == 1)
                {
                    MessageBox.Show($"Cargo: {cCargo.nome} atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show($"Deseja excluir o cargo: {txtNome_car.Text}", "Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCargo cCargo = new classCargo();
                cCargo.codigo_cargo = Convert.ToInt32(txtCodigo_car.Text);

                int resp = cCargo.ExcluirCargo();

                if (resp == 1)
                {
                    MessageBox.Show("Cargo excluído com sucesso", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNome_car_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtObservacoes_car_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNome_car_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
