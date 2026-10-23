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
    public partial class FormFuncionario : Form
    {
        //CRIAR VARIÁVEIS QUE SERÃO UTILIZADAS NO FORM DE CONSULTA
        //TIPO - MANEIRA QUE FORM SERÁ ABERTO
        //OUTRAS VARIÁVEIS - EXIBIR OS DADOS QUE ESTÃO ARMAZENADO NO BD E NÃO OS DECLARADOS NO LOAD DO FORM, TUDO QUE FOR COMBOBOX PRECISA TER UMA VARIÁVEL E A VARIÁVEL PARA CARREGAR A DATA CADASTRO ARMAZENADA NO BD

        public string tipo, estado_civil, estado;
        public int cargo, tipo_acesso;
            public DateTime data_cadastro;
        public FormFuncionario()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void lblCodigoFunc_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_func_Click(object sender, EventArgs e)
        {

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            //EXIBIR A DATA ATUAL DO SISTEMA
            maskDatacadastro_fun.Text = DateTime.Now.ToShortDateString();

            //CARREGAR COMBOS 
            //COMBO ESTADO CIVIL
            cbEstadocivil_fun.Items.Add("Solteiro(a)");
            cbEstadocivil_fun.Items.Add("Casado(a)");
            cbEstadocivil_fun.Items.Add("Divorciado(a)");
            cbEstadocivil_fun.Items.Add("Viúvo(a)");
            cbEstadocivil_fun.Items.Add("Separado(a) Judicialmente");
            cbEstadocivil_fun.Items.Add("União Estável");

            cbEstadocivil_fun.SelectedIndex = 0;

            //COMBO TIPO ACESSO
            cbTipoacesso_fun.Items.Add("Comum");
            cbTipoacesso_fun.Items.Add("Administrador");

            cbTipoacesso_fun.SelectedIndex = 0;

            //COMBO ESTADO
            cbEstado_fun.Items.Add("AC");
            cbEstado_fun.Items.Add("AL");
            cbEstado_fun.Items.Add("AP");
            cbEstado_fun.Items.Add("AM");
            cbEstado_fun.Items.Add("BA");
            cbEstado_fun.Items.Add("CE");
            cbEstado_fun.Items.Add("DF");
            cbEstado_fun.Items.Add("ES");
            cbEstado_fun.Items.Add("GO");
            cbEstado_fun.Items.Add("MA");
            cbEstado_fun.Items.Add("MT");
            cbEstado_fun.Items.Add("MS");
            cbEstado_fun.Items.Add("MG");
            cbEstado_fun.Items.Add("PA");
            cbEstado_fun.Items.Add("PB");
            cbEstado_fun.Items.Add("PR");
            cbEstado_fun.Items.Add("PE");
            cbEstado_fun.Items.Add("PI");
            cbEstado_fun.Items.Add("RJ");
            cbEstado_fun.Items.Add("RN");
            cbEstado_fun.Items.Add("RS");
            cbEstado_fun.Items.Add("RO");
            cbEstado_fun.Items.Add("RR");
            cbEstado_fun.Items.Add("SC");
            cbEstado_fun.Items.Add("SP");
            cbEstado_fun.Items.Add("SE");
            cbEstado_fun.Items.Add("TO");

            cbEstado_fun.SelectedItem = "SP";

            //COMBO CARGO - TRAZER DADOS DA TABELA CARGO DO BANCO DE DADOS
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR O MÉTODO QUE VAI CARREGAR A COMBO
            classCargo cCargo = new classCargo();
            //CHAMAR O MÉTODO NA COMBO DE CARGO
            cbCargo_fun.DataSource = cCargo.CarregarComboCargo();
            //DISPLAY MEMBER - O QUE SERÁ EXIBIDO NA COMBO - NOME DA COLUNA DO BD
            cbCargo_fun.DisplayMember = "nome";
            //VALUE MEMBER - O QUE SERÁ ARMAZENADO NO BANCO DE DADOS
            cbCargo_fun.ValueMember = "codigo_cargo";
            //NÃO DEIXAR NENHUM CARGO SELECIONADO
            cbCargo_fun.SelectedIndex = -1;

            //VERIFICAR O MODO DE ABERTURA DO FORM - SE FOR ATUALIZAÇÃO
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Funcionário";
                ckbStatus_fun.Enabled = true;
                btnCadastrar_fun.Visible = false;
                //COMBO BOX (VARIÁVEIS CRIADAS PARA ATUALIZAÇÃO)
                //RECEBER O QUE ESTÁ ARMAZENADA NO BD E NÃO O PADRÃO QUE FOI DEFINIFO NA HORA DE CADASTRAR
                maskDatacadastro_fun.Text = data_cadastro.ToString();
                cbEstado_fun.SelectedItem = estado;
                cbEstadocivil_fun.SelectedItem = estado_civil;
                cbCargo_fun.SelectedValue = cargo;

                //TIPO ACESSO 0 COMUM - 1 ADM
                if(tipo_acesso == 0)
                {
                    cbTipoacesso_fun.SelectedItem = "Comum";
                }

                else
                {
                    cbTipoacesso_fun.SelectedItem = "Administrador";
                }
            }
            else
            {
                btnCadastrar_fun.Location = btnExcluir.Location;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;

            }

        }

        private void ckbStatus_func_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome_fun.Text) || maskDatanascimento_fun.Text != "  /  /" || maskCpf_fun.Text != "   .   .   -" || !string.IsNullOrWhiteSpace(txtRua_fun.Text) || !string.IsNullOrWhiteSpace(txtNumero_fun.Text) || !string.IsNullOrWhiteSpace(txtBairro_fun.Text) || !string.IsNullOrWhiteSpace(txtCidade_fun.Text) || maskCep_fun.Text != "     -" || !string.IsNullOrWhiteSpace(txtEmail_fun.Text) || !string.IsNullOrWhiteSpace(txtUsuario_fun.Text) || !string.IsNullOrWhiteSpace(txtSenha_fun.Text) || cbCargo_fun.SelectedIndex != -1)
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

        private void btnCadastrar_fun_Click(object sender, EventArgs e)
        {
            
            //CRIAR OBJETO DA CLASSE FUNCIONÁRIO
            classFuncionario cFuncionario = new classFuncionario();

            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS PELO USUÁRIO
            if(string.IsNullOrWhiteSpace(txtNome_fun.Text) || maskDatanascimento_fun.Text == "  /  /" || maskCpf_fun.Text == "   .   .   -" || string.IsNullOrWhiteSpace(txtRua_fun.Text) || string.IsNullOrWhiteSpace(txtNumero_fun.Text) || string.IsNullOrWhiteSpace(txtBairro_fun.Text) || string.IsNullOrWhiteSpace(txtCidade_fun.Text) || maskCep_fun.Text == "     -" || string.IsNullOrWhiteSpace(txtEmail_fun.Text) || string.IsNullOrWhiteSpace(txtUsuario_fun.Text) || string.IsNullOrWhiteSpace(txtSenha_fun.Text) || cbCargo_fun.SelectedIndex == -1)
            {
                MessageBox.Show("Favor preencher todos os campos obriatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else //REALIZAR O CADASTRO, USUÁRIO PREENCHEU OS CAMPOS - MANDAR PARA AS PROPRIEDADES DA CLASSE TODOS OS CAMPOS QUE O USUÁRIO PODE PREENCHER DO FORMULÁRIO
            {
                cFuncionario.nome = txtNome_fun.Text;
                cFuncionario.nome_social = txtNomesocial_fun.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(maskDatanascimento_fun.Text);

                //SEXO RADIOBUTTON - VERIFICAR QUAL OPÇÃO USUÁRIO ESCOLHEU 
                if (rdbSexoFeminino_fun.Checked)
                {
                    cFuncionario.sexo = "F";
                }

                else if (rdbSexoMasculino_fun.Checked)
                {
                    cFuncionario.sexo = "M";
                }

                else 
                {
                    cFuncionario.sexo = "N";
                }

                //ESTADO CIVIL
                if(cbEstadocivil_fun.SelectedIndex == 0)
                {
                    cFuncionario.estado_civil = "";
                }

                else
                {
                    cFuncionario.estado_civil = cbEstadocivil_fun.SelectedItem.ToString();
                }

                cFuncionario.cpf = maskCpf_fun.Text;

                //RG - MÁSCARA CAMPO NÃO OBRIGATÓRIO, FAZER IF CASO O USUÁRIO NÃO PREENCHA PARA MANDAR VAZIO NO BD E NÃO A MÁSCARA
                if (maskRg_fun.Text == "  .   .   -")
                {
                    cFuncionario.rg = "";
                }

                else
                {
                    cFuncionario.rg = maskRg_fun.Text;
                }

                //SALÁRIO - CAMPO DECIMAL NÃO OBRIGATÓRIO NO BANCO DE DADOS, IF PARA MANDAR 0 CASO O USUÁRIO NÃO PREENCHA O CAMPO
                if(string.IsNullOrWhiteSpace(txtSalario_fun.Text))
                {
                    cFuncionario.salario = 0;
                }

                else
                {
                    cFuncionario.salario = Convert.ToDecimal(txtSalario_fun.Text);
                }

                cFuncionario.endereco = txtRua_fun.Text;
                cFuncionario.numero = Convert.ToInt32(txtNumero_fun.Text);
                cFuncionario.complemento = txtComplemento_fun.Text;
                cFuncionario.bairro = txtBairro_fun.Text;
                cFuncionario.cidade = txtCidade_fun.Text;

                //ESTADO, MANDAR PARA O BD O ITEM SELECIONADO PELO USUÁRIO
                cFuncionario.estado = cbEstado_fun.SelectedItem.ToString();

                cFuncionario.cep = maskCep_fun.Text;

                if (maskTelcelular_fun.Text != "(  )     -" || maskTelresidencial_fun.Text != "(  )     -")
                {

                    //CAMPOS TELEFONES - MASCARA CAMPO OBRIGATÓRIO  NO BD, CASO USUÁRIO  NÃO PREENCHA 
                    if (maskTelresidencial_fun.Text == "(  )     -")
                    {
                        cFuncionario.telefone_residencial = "";
                    }

                    else
                    {
                        cFuncionario.telefone_residencial = maskTelresidencial_fun.Text;
                    }

                    if (maskTelcelular_fun.Text == "(  )     -")
                    {
                        cFuncionario.telefone_celular = "";
                    }

                    else
                    {
                        cFuncionario.telefone_celular = maskTelcelular_fun.Text;
                    }

                    cFuncionario.email = txtEmail_fun.Text;
                    cFuncionario.usuario = txtUsuario_fun.Text;
                    cFuncionario.senha = txtSenha_fun.Text;


                    //TIPO ACESSO - COMBO -- INDEX 0 COMUM - INDEX 1 ADM
                    cFuncionario.tipo_acesso = cbTipoacesso_fun.SelectedIndex;

                    //CÓDIGO CARGO - FK - USAR A PROPRIEDADE SELECTEDVALUE DA COMBO, PARA PEGAR O CÓDIGO DO CARGO SELECIONADO PELO USUÁRIO
                    cFuncionario.codigo_cargo = Convert.ToInt32(cbCargo_fun.SelectedValue);


                    //CHAMAR O MÉTODO DE CADASTRO DA CLASSE FUNCIONÁRIO
                    int resp = cFuncionario.CadastrarFuncionario();


                    if (resp == 1)
                    {
                        if (txtNomesocial_fun.Text != null)
                        {
                            MessageBox.Show($"Funcionário: {cFuncionario.nome_social} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpar();
                        }

                        else
                        {
                            MessageBox.Show($"Funcionário: {cFuncionario.nome} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpar();

                        }
                    }

                    else
                    {
                        MessageBox.Show("Erro ao cadastrar funcionário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Preencha ao menos um telefone!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //MÉTODO PARA LIMPAR TODOS OS CAMPOS DO FORMULÁRIO QUANDO O CADASTRO FOR FINALIZADO
        private void Limpar()
        {
            txtNome_fun.Clear();
            txtNomesocial_fun.Clear();
            maskDatanascimento_fun.Clear();
            rdbSexoFeminino_fun.Checked = true;
            cbEstadocivil_fun.SelectedIndex = 0;
            maskCpf_fun.Clear();
            maskRg_fun.Clear();
            txtSalario_fun.Clear();
            txtRua_fun.Clear();
            txtNumero_fun.Clear();
            txtComplemento_fun.Clear();
            txtBairro_fun.Clear();
            txtCidade_fun.Clear();
            cbEstado_fun.SelectedItem = "SP";
            maskCep_fun.Clear();
            maskTelresidencial_fun.Clear();
            maskTelcelular_fun.Clear();
            txtEmail_fun.Clear();
            txtUsuario_fun.Clear();
            txtSenha_fun.Clear();
            cbTipoacesso_fun.SelectedIndex = 0;
            cbCargo_fun.SelectedIndex = -1; //NENHUM CARGO PRÉ SELECIONADO

        }

        private void btnEditar_fun_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE FUNCIONÁRIO
            classFuncionario cFuncionario = new classFuncionario();

            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS PELO USUÁRIO
            if (string.IsNullOrWhiteSpace(txtNome_fun.Text) || maskDatanascimento_fun.Text == "  /  /" || maskCpf_fun.Text == "   .   .   -" || string.IsNullOrWhiteSpace(txtRua_fun.Text) || string.IsNullOrWhiteSpace(txtNumero_fun.Text) || string.IsNullOrWhiteSpace(txtBairro_fun.Text) || string.IsNullOrWhiteSpace(txtCidade_fun.Text) || maskCep_fun.Text == "     -" || string.IsNullOrWhiteSpace(txtEmail_fun.Text) || string.IsNullOrWhiteSpace(txtUsuario_fun.Text) || string.IsNullOrWhiteSpace(txtSenha_fun.Text) || cbCargo_fun.SelectedIndex == -1)
            {
                MessageBox.Show("Favor preencher todos os campos obriatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else //REALIZAR O CADASTRO, USUÁRIO PREENCHEU OS CAMPOS - MANDAR PARA AS PROPRIEDADES DA CLASSE TODOS OS CAMPOS QUE O USUÁRIO PODE PREENCHER DO FORMULÁRIO
            {
                cFuncionario.nome = txtNome_fun.Text;
                cFuncionario.nome_social = txtNomesocial_fun.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(maskDatanascimento_fun.Text);

                //SEXO RADIOBUTTON - VERIFICAR QUAL OPÇÃO USUÁRIO ESCOLHEU 
                if (rdbSexoFeminino_fun.Checked)
                {
                    cFuncionario.sexo = "F";
                }

                else if (rdbSexoMasculino_fun.Checked)
                {
                    cFuncionario.sexo = "M";
                }

                else
                {
                    cFuncionario.sexo = "N";
                }

                //ESTADO CIVIL
                if (cbEstadocivil_fun.SelectedIndex == 0)
                {
                    cFuncionario.estado_civil = "";
                }

                else
                {
                    cFuncionario.estado_civil = cbEstadocivil_fun.SelectedItem.ToString();
                }

                cFuncionario.cpf = maskCpf_fun.Text;

                //RG - MÁSCARA CAMPO NÃO OBRIGATÓRIO, FAZER IF CASO O USUÁRIO NÃO PREENCHA PARA MANDAR VAZIO NO BD E NÃO A MÁSCARA
                if (maskRg_fun.Text == "  .   .   -")
                {
                    cFuncionario.rg = "";
                }

                else
                {
                    cFuncionario.rg = maskRg_fun.Text;
                }

                //SALÁRIO - CAMPO DECIMAL NÃO OBRIGATÓRIO NO BANCO DE DADOS, IF PARA MANDAR 0 CASO O USUÁRIO NÃO PREENCHA O CAMPO
                if (string.IsNullOrWhiteSpace(txtSalario_fun.Text))
                {
                    cFuncionario.salario = 0;
                }

                else
                {
                    cFuncionario.salario = Convert.ToDecimal(txtSalario_fun.Text);
                }

                cFuncionario.endereco = txtRua_fun.Text;
                cFuncionario.numero = Convert.ToInt32(txtNumero_fun.Text);
                cFuncionario.complemento = txtComplemento_fun.Text;
                cFuncionario.bairro = txtBairro_fun.Text;
                cFuncionario.cidade = txtCidade_fun.Text;

                //ESTADO, MANDAR PARA O BD O ITEM SELECIONADO PELO USUÁRIO
                cFuncionario.estado = cbEstado_fun.SelectedItem.ToString();

                cFuncionario.cep = maskCep_fun.Text;

                if (maskTelcelular_fun.Text != "(  )     -" || maskTelresidencial_fun.Text != "(  )     -")
                {

                    //CAMPOS TELEFONES - MASCARA CAMPO OBRIGATÓRIO  NO BD, CASO USUÁRIO  NÃO PREENCHA 
                    if (maskTelresidencial_fun.Text == "(  )     -")
                    {
                        cFuncionario.telefone_residencial = "";
                    }

                    else
                    {
                        cFuncionario.telefone_residencial = maskTelresidencial_fun.Text;
                    }

                    if (maskTelcelular_fun.Text == "(  )     -")
                    {
                        cFuncionario.telefone_celular = "";
                    }

                    else
                    {
                        cFuncionario.telefone_celular = maskTelcelular_fun.Text;
                    }

                    cFuncionario.email = txtEmail_fun.Text;
                    cFuncionario.usuario = txtUsuario_fun.Text;
                    cFuncionario.senha = txtSenha_fun.Text;


                    //TIPO ACESSO - COMBO -- INDEX 0 COMUM - INDEX 1 ADM
                    cFuncionario.tipo_acesso = cbTipoacesso_fun.SelectedIndex;

                    //CÓDIGO CARGO - FK - USAR A PROPRIEDADE SELECTEDVALUE DA COMBO, PARA PEGAR O CÓDIGO DO CARGO SELECIONADO PELO USUÁRIO
                    cFuncionario.codigo_cargo = Convert.ToInt32(cbCargo_fun.SelectedValue);

                    cFuncionario.codigo_funcionario = Convert.ToInt32(txtCodigo_fun.Text);
                    //IF DE STATUS
                    if(ckbStatus_fun.Checked)
                    {
                        cFuncionario.status = 1;
                    }
                    else
                    {
                        cFuncionario.status = 0;
                    }

                    //CHAMAR O MÉTODO DE CADASTRO DA CLASSE FUNCIONÁRIO
                    int resp = cFuncionario.AtualizarFuncionario();


                    if (resp == 1)
                    {
                        if (!string.IsNullOrWhiteSpace(cFuncionario.nome_social))
                        {
                            MessageBox.Show($"Funcionario: {cFuncionario.nome_social} atualizado com sucesso!", "DAFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"Funcionario: {cFuncionario.nome} atualizado com sucesso!", "DAFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar o cadastro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MessageBox.Show("Preencha ao menos um telefone!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        
    }

        private void btnExcluir_fun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir o funcionário: {txtNome_fun.Text}", "Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFuncionario cFuncionario = new classFuncionario();
                cFuncionario.codigo_funcionario = Convert.ToInt32(txtCodigo_fun.Text);

                int resp = cFuncionario.ExcluirFuncionario();

                if(resp == 1)
                {
                    MessageBox.Show("Funcionario excluído com sucesso", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

          
        }

        private void txtSalario_fun_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void maskCpf_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void maskTelresidencial_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void maskTelcelular_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void maskCep_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNome_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_fun_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void cbEstadocivil_fun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_fun_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNumero_fun_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtNomesocial_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRua_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCidade_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNomesocial_fun_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtNumero_fun_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A TECLA DIGITADA NÃO FOR NÚMERO, BACKSPACE(08), ENTER(13)
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_fun_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskDatanascimento_fun_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(!e.IsValidInput)
            {
                MessageBox.Show("Data inválida!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskDatanascimento_fun.Focus();
            }
        }
    }
}
