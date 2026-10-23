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
    public partial class FormCliente : Form
    {
        //CRIAR VARIÁVEIS QUE SERÃO UTILIZADAS NO FORM DE CONSULTA
        //TIPO - MANEIRA QUE FORM SERÁ ABERTO
        //OUTRAS VARIÁVEIS - EXIBIR OS DADOS QUE ESTÃO ARMAZENADO NO BD E NÃO OS DECLARADOS NO LOAD DO FORM, TUDO QUE FOR COMBOBOX PRECISA TER UMA VARIÁVEL E A VARIÁVEL PARA CARREGAR A DATA CADASTRO ARMAZENADA NO BD

        public string tipo, estado;
        public DateTime data_cadastro;
        public FormCliente()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            maskDatacadastro_cli.Text = DateTime.Now.ToShortDateString();
            //VERIFICAR O MODO DE ABERTURA DO FORM - SE FOR ATUALIZAÇÃO
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Cliente";
                ckbStatus_cli.Enabled = true;
                btnCadastrar_cli.Visible = false;
                //COMBO BOX (VARIÁVEIS CRIADAS PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIFO NA HORA DE CADASTRAR
                maskDatacadastro_cli.Text = data_cadastro.ToString();
                cbEstado_cli.SelectedItem = estado;
            }

            else
            {
                btnCadastrar_cli.Location = btnExcluir.Location;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;

            }

            //COMBO ESTADO
            cbEstado_cli.BackColor = Color.FromArgb(255, 236, 211);

            cbEstado_cli.Items.Add("AC");
            cbEstado_cli.Items.Add("AL");
            cbEstado_cli.Items.Add("AP");
            cbEstado_cli.Items.Add("AM");
            cbEstado_cli.Items.Add("BA");
            cbEstado_cli.Items.Add("CE");
            cbEstado_cli.Items.Add("DF");
            cbEstado_cli.Items.Add("ES");
            cbEstado_cli.Items.Add("GO");
            cbEstado_cli.Items.Add("MA");
            cbEstado_cli.Items.Add("MT");
            cbEstado_cli.Items.Add("MS");
            cbEstado_cli.Items.Add("MG");
            cbEstado_cli.Items.Add("PA");
            cbEstado_cli.Items.Add("PB");
            cbEstado_cli.Items.Add("PR");
            cbEstado_cli.Items.Add("PE");
            cbEstado_cli.Items.Add("PI");
            cbEstado_cli.Items.Add("RJ");
            cbEstado_cli.Items.Add("RN");
            cbEstado_cli.Items.Add("RS");
            cbEstado_cli.Items.Add("RO");
            cbEstado_cli.Items.Add("RR");
            cbEstado_cli.Items.Add("SC");
            cbEstado_cli.Items.Add("SP");
            cbEstado_cli.Items.Add("SE");
            cbEstado_cli.Items.Add("TO");

            cbEstado_cli.SelectedItem = "SP";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome_cli.Text) || maskDatanascimento_cli.Text != "  /  /" || maskTelcelular_cli.Text != "(  )     -" || maskCpf_cli.Text != "   .   .   -" || !string.IsNullOrWhiteSpace(txtRua_cli.Text) || !string.IsNullOrWhiteSpace(txtNumero_cli.Text) || !string.IsNullOrWhiteSpace(txtBairro_cli.Text) || !string.IsNullOrWhiteSpace(txtCidade_cli.Text) || maskCep_cli.Text != "     -" || !string.IsNullOrWhiteSpace(txtEmail_cli.Text))
            {
                if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                
            }

            else
            {
                this.Close();
            }

        }

        private void btnCadastrar_cli_Click(object sender, EventArgs e)
        {

            //CRIAR OBJETO DA CLASSE FUNCIONÁRIO
            classCliente cCliente = new classCliente();

            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS PELO USUÁRIO
               if (string.IsNullOrWhiteSpace(txtNome_cli.Text) || maskDatanascimento_cli.Text == "  /  /" || maskTelcelular_cli.Text == "(  )     -" || maskCpf_cli.Text == "   .   .   -" || string.IsNullOrWhiteSpace(txtRua_cli.Text) || string.IsNullOrWhiteSpace(txtNumero_cli.Text) || string.IsNullOrWhiteSpace(txtBairro_cli.Text) || string.IsNullOrWhiteSpace(txtCidade_cli.Text) || maskCep_cli.Text == "     -" || string.IsNullOrWhiteSpace(txtEmail_cli.Text))
            {
                MessageBox.Show("Favor preencher todos os campos obriatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CamposObrigatórios();
            }

            else //REALIZAR O CADASTRO, USUÁRIO PREENCHEU OS CAMPOS - MANDAR PARA AS PROPRIEDADES DA CLASSE TODOS OS CAMPOS QUE O USUÁRIO PODE PREENCHER DO FORMULÁRIO
            {
                cCliente.nome = txtNome_cli.Text;
                cCliente.nome_social = txtNomesocial_cli.Text;
                cCliente.data_nascimento = Convert.ToDateTime(maskDatanascimento_cli.Text);

                //CAMPOS TELEFONES - MASCARA CAMPO OBRIGATÓRIO  NO BD, CASO USUÁRIO  NÃO PREENCHA
                if (maskTelcelular_cli.Text == "(  )     -")
                {
                    cCliente.telefone_celular = "";
                }

                else
                {
                    cCliente.telefone_celular = maskTelcelular_cli.Text;
                }

                //SEXO RADIOBUTTON - VERIFICAR QUAL OPÇÃO USUÁRIO ESCOLHEU 
                if (rdbSexoFeminino_cli.Checked)
                {
                    cCliente.sexo = "F";
                }

                else if (rdbSexoMasculino_cli.Checked)
                {
                    cCliente.sexo = "M";
                }

                else
                {
                    cCliente.sexo = "N";
                }


                cCliente.cpf = maskCpf_cli.Text;

                //RG - MÁSCARA CAMPO NÃO OBRIGATÓRIO, FAZER IF CASO O USUÁRIO NÃO PREENCHA PARA MANDAR VAZIO NO BD E NÃO A MÁSCARA
                if (maskRg_cli.Text == "  .   .   -")
                {
                    cCliente.rg = "";
                }

                else
                {
                    cCliente.rg = maskRg_cli.Text;
                }

             
                cCliente.endereco = txtRua_cli.Text;
                cCliente.numero = Convert.ToInt32(txtNumero_cli.Text);
                cCliente.complemento = txtComplemento_cli.Text;
                cCliente.bairro = txtBairro_cli.Text;
                cCliente.cidade = txtCidade_cli.Text;

                //ESTADO, MANDAR PARA O BD O ITEM SELECIONADO PELO USUÁRIO
                cCliente.estado = cbEstado_cli.SelectedItem.ToString();

                cCliente.cep = maskCep_cli.Text;

                
                    cCliente.email = txtEmail_cli.Text;


                    //CHAMAR O MÉTODO DE CADASTRO DA CLASSE CLIENTE
                    int resp = cCliente.CadastrarCliente();


                    if (resp == 1)
                    {
                        if (txtNomesocial_cli.Text != null)
                        {
                            MessageBox.Show($"Cliente: {cCliente.nome_social} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpar();
                        }

                        else
                        {
                            MessageBox.Show($"Cliente: {cCliente.nome} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpar();

                        }
                    }

                    else
                    {
                        MessageBox.Show("Erro ao cadastrar cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                

            }
        }

        private void CamposObrigatórios()
        {
            pnNome.BackColor = Color.MistyRose;
            pnDatanascimento.BackColor = Color.MistyRose;
            pnDatanascimento.BackColor = Color.MistyRose;
            pnEndereco.BackColor = Color.MistyRose;
            pnCpf.BackColor = Color.MistyRose;
            pnSexo.BackColor = Color.MistyRose;
        }

        //MÉTODO PARA LIMPAR TODOS OS CAMPOS DO FORMULÁRIO QUANDO O CADASTRO FOR FINALIZADO
        private void Limpar()
        {
            txtNome_cli.Clear();
            txtNomesocial_cli.Clear();
            maskDatanascimento_cli.Clear();
            rdbSexoFeminino_cli.Checked = true;
            maskCpf_cli.Clear();
            maskRg_cli.Clear();
            txtRua_cli.Clear();
            txtNumero_cli.Clear();
            txtComplemento_cli.Clear();
            txtBairro_cli.Clear();
            txtCidade_cli.Clear();
            cbEstado_cli.SelectedItem = "SP";
            maskCep_cli.Clear();
            maskTelcelular_cli.Clear();
            txtEmail_cli.Clear();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtComplemento_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir o cliente: {txtNome_cli.Text}", "Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCliente cCliente = new classCliente();
                cCliente.codigo_cliente = Convert.ToInt32(txtCodigo_cli.Text);

                int resp = cCliente.ExcluirCliente();

                if (resp == 1)
                {
                    MessageBox.Show("Cliente excluído com sucesso", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void maskDatanascimento_cli_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskDatanascimento_cli.Focus();
            }
        }

        private void maskRg_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void maskCpf_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void maskTelcelular_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void maskCep_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNumero_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNome_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNomesocial_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_cli_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNomesocial_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRua_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCidade_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBairro_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumero_cli_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE FUNCIONÁRIO
            classCliente cCliente = new classCliente();

            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS PELO USUÁRIO
            if (string.IsNullOrWhiteSpace(txtNome_cli.Text) || maskDatanascimento_cli.Text == "  /  /" || maskTelcelular_cli.Text == "(  )     -" || maskCpf_cli.Text == "   .   .   -" || string.IsNullOrWhiteSpace(txtRua_cli.Text) || string.IsNullOrWhiteSpace(txtNumero_cli.Text) || string.IsNullOrWhiteSpace(txtBairro_cli.Text) || string.IsNullOrWhiteSpace(txtCidade_cli.Text) || maskCep_cli.Text == "     -" || string.IsNullOrWhiteSpace(txtEmail_cli.Text))
            {
                MessageBox.Show("Favor preencher todos os campos obriatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CamposObrigatórios();
            }

            else //REALIZAR O CADASTRO, USUÁRIO PREENCHEU OS CAMPOS - MANDAR PARA AS PROPRIEDADES DA CLASSE TODOS OS CAMPOS QUE O USUÁRIO PODE PREENCHER DO FORMULÁRIO
            {
                cCliente.nome = txtNome_cli.Text;
                cCliente.nome_social = txtNomesocial_cli.Text;
                cCliente.data_nascimento = Convert.ToDateTime(maskDatanascimento_cli.Text);

                //CAMPOS TELEFONES - MASCARA CAMPO OBRIGATÓRIO  NO BD, CASO USUÁRIO  NÃO PREENCHA
                if (maskTelcelular_cli.Text == "(  )     -")
                {
                    cCliente.telefone_celular = "";
                }

                else
                {
                    cCliente.telefone_celular = maskTelcelular_cli.Text;
                }

                //SEXO RADIOBUTTON - VERIFICAR QUAL OPÇÃO USUÁRIO ESCOLHEU 
                if (rdbSexoFeminino_cli.Checked)
                {
                    cCliente.sexo = "F";
                }

                else if (rdbSexoMasculino_cli.Checked)
                {
                    cCliente.sexo = "M";
                }

                else
                {
                    cCliente.sexo = "N";
                }


                cCliente.cpf = maskCpf_cli.Text;

                //RG - MÁSCARA CAMPO NÃO OBRIGATÓRIO, FAZER IF CASO O USUÁRIO NÃO PREENCHA PARA MANDAR VAZIO NO BD E NÃO A MÁSCARA
                if (maskRg_cli.Text == "  .   .   -")
                {
                    cCliente.rg = "";
                }

                else
                {
                    cCliente.rg = maskRg_cli.Text;
                }


                cCliente.endereco = txtRua_cli.Text;
                cCliente.numero = Convert.ToInt32(txtNumero_cli.Text);
                cCliente.complemento = txtComplemento_cli.Text;
                cCliente.bairro = txtBairro_cli.Text;
                cCliente.cidade = txtCidade_cli.Text;

                //ESTADO, MANDAR PARA O BD O ITEM SELECIONADO PELO USUÁRIO
                cCliente.estado = cbEstado_cli.SelectedItem.ToString();

                cCliente.cep = maskCep_cli.Text;


                cCliente.email = txtEmail_cli.Text;

                cCliente.codigo_cliente = Convert.ToInt32(txtCodigo_cli.Text);

                if(ckbStatus_cli.Checked)
                {
                    cCliente.status = 1;
                }

                else
                {
                    cCliente.status = 0;
                }

                //CHAMAR O MÉTODO DE CADASTRO DA CLASSE CLIENTE
                int resp = cCliente.AtualizarCliente();


                if (resp == 1)
                {
                    if (txtNomesocial_cli.Text != null)
                    {
                        MessageBox.Show($"Cliente: {cCliente.nome_social} atualizado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show($"Cliente: {cCliente.nome} atualizado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        

                    }
                }

                else
                {
                    MessageBox.Show("Erro ao atualizar cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
