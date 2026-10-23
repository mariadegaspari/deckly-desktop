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
    public partial class formConsFuncionario : Form
    {
        public formConsFuncionario()                                                                              
        {
            InitializeComponent();
            this.AcceptButton = btPesquisar;
            this.TopMost = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formConsFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO DE OPÇOES DE CONSULTA
            cbFiltro.Items.Add("Nome");
            cbFiltro.Items.Add("Cargo");
            cbFiltro.Items.Add("Cidade");
            cbFiltro.Items.Add("CPF");
            cbFiltro.Items.Add("Sexo");
            cbFiltro.Items.Add("Data de Admissão");
            cbFiltro.Items.Add("Status");
            cbFiltro.Items.Add("Cidade e sexo");

            cbFiltro.SelectedIndex = 0;

            //COMBO CARGO - TRAZER DADOS DA TABELA CARGO DO BANCO DE DADOS
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR O MÉTODO QUE VAI CARREGAR A COMBO
            classCargo cCargo = new classCargo();
            //CHAMAR O MÉTODO NA COMBO DE CARGO
            cbCargo.DataSource = cCargo.CarregarComboCargo();
            //DISPLAY MEMBER - O QUE SERÁ EXIBIDO NA COMBO - NOME DA COLUNA DO BD
            cbCargo.DisplayMember = "nome";
            //VALUE MEMBER - O QUE SERÁ ARMAZENADO NO BANCO DE DADOS
            cbCargo.ValueMember = "codigo_cargo";
            //NÃO DEIXAR NENHUM CARGO SELECIONADO
            cbCargo.SelectedIndex = -1;

            //COMBO SEXO
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não informado");

            cbSexo.SelectedIndex = 0;

            //COMBO CIDADE
            classFuncionario cFuncionario = new classFuncionario();
            cbCidade.DataSource = cFuncionario.CarregarComboCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;


            //COMBO CIDADE2
            cbCidade2.DataSource = cFuncionario.CarregarComboCidade();
            cbCidade2.DisplayMember = "cidade";
            cbCidade2.ValueMember = "cidade";
            cbCidade2.SelectedIndex = 0;

            //COMBO SEXO2
            cbSexo2.Items.Add("Feminino");
            cbSexo2.Items.Add("Masculino");
            cbSexo2.Items.Add("Não informado");

            cbSexo2.SelectedIndex = 0;
        }

        private void OcultarFiltros()
        {
            gbNome.Visible = false;
            gbCargo.Visible = false;
            gbCidade.Visible = false;
            gbCPF.Visible = false;
            gbSexo.Visible = false;
            gbDataAdmissao.Visible = false;
            gbStatus.Visible = false;
            gbCidadeSexo.Visible = false;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarFiltros();

            int filtro = cbFiltro.SelectedIndex;

            switch (filtro)
            {
                case 0:
                    gbNome.Visible = true;
                    txtNome.Focus();
                    break;

                case 1:
                    gbCargo.Visible = true;
                    break;

                case 2:
                    gbCidade.Visible = true;                 
                    break;

                case 3:
                    gbCPF.Visible = true;
                    break;              

                case 4:
                    gbSexo.Visible = true;                    
                    break;

                case 5:
                    gbDataAdmissao.Visible = true;                   
                    break;

                case 6:
                    gbStatus.Visible = true;                   
                    break;

                case 7:
                    gbCidadeSexo.Visible = true;
                    break;
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //CRIANDO UM OBJETO DA CLASSE FUNCIONÁRIO PARA USAR OS MÉTODOS DE CONSULTA E PROPRIEDADES

            classFuncionario cFuncionario = new classFuncionario();

            //CRIAR VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            int filtro = cbFiltro.SelectedIndex;

            switch(filtro) //USUÁRIO ESCOLHE OPÇÃO E SISTEMA LÊ A POSIÇÃO DO ITEM NA LISTA (SELECTED.INDEX)
            {
                
                //CARGO
                case 1:
                    dgvFuncionario.DataSource = cFuncionario.ConsFuncCargo(Convert.ToInt32(cbCargo.SelectedValue));
                    break;

                //CIDADE
                case 2:
                    dgvFuncionario.DataSource = cFuncionario.ConsFuncCidade(cbCidade.SelectedValue.ToString());
                    break;

                //CPF
                case 3:
                    //VALIDAR SE O USUÁRIO INFORMOU UM CPF
                    if(mskCpf.Text != "   .   .   -")
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncCpf(mskCpf.Text);
                    }

                    else
                    {
                        MessageBox.Show("Favor inserir um CPF completo", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskCpf.Focus();
                    }
                    break;

                  //SEXO
                  case 4:
                    //FEMININO
                    if(cbSexo.SelectedIndex == 0)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncSexo("F");
                    }
                    
                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncSexo("M");

                    }

                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncSexo("N");
                    }

                    break;

                //DATA ADMISSÃO
                //VOLTAR PARA VALIDAR DATA INICIAL MENOR OU IGUAL DATA FINAL
                case 5:
                    dgvFuncionario.DataSource = cFuncionario.ConsFuncDataAdmissao(dtpDataInicial.Value , dtpDataFinal.Value);

                    break;

                //STATUS
                case 6:
                    if (rbAtivo.Checked)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncStatus(1);
                    }

                    else 
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncStatus(0);

                    }
                    break;

                //CIDADE2
                case 7:

                    //FEMININO
                    if (cbSexo2.SelectedIndex == 0)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncCidade2(cbCidade2.SelectedValue.ToString(), "F");
                    }

                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncCidade2(cbCidade2.SelectedValue.ToString(), "M");
                    }

                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncCidade2(cbCidade2.SelectedValue.ToString(), "N");
                    }

                    break;

                //NOME 
                default:
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                    {
                        MessageBox.Show("Favor informar um nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }

                    else
                    {
                        if(rbContem.Checked)
                        {
                            dgvFuncionario.DataSource = cFuncionario.ConsFuncNomeContem(txtNome.Text);
                        }

                        else
                        {
                            dgvFuncionario.DataSource = cFuncionario.ConsFuncNomeInicio(txtNome.Text);
                        }
                    }

                break;
            }


        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID DE FUNCIONÁRIO E EDITAR OU EXCLUIR UM FUNCIONÁRIO 
            //USAR O EVENTO CellClick  (PODE CLICAR NO CONTEÚDO, NÃO SOMENTE NO TEXTO)
            //USANDO O EVENTO CellContentClick (TEM QUE CLICAR NO CONTEÚDO (TEXTO))

            //PERGUNTAR PARA O USUÁRIO SE REALMENTE DESEJA ALTERAR O FUNCIONÁRIO SELECIONADO
            if(MessageBox.Show("Deseja alterar ou excluir o funcionario selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONÁRIO
                classFuncionario cFuncionario = new classFuncionario();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO DE FUNCIONÁRIO - PARA MANDAR AS INFORMAÇÕES DO BD PARA O FORM
                FormFuncionario fFuncionario = new FormFuncionario();

                //PEGAR O FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO ATRAVÉS DA SELEÇÃO NA GRID
                cFuncionario.DadosFuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BANCO PARA OS ELEMENTOS DO FORM DE CADASTRO
                fFuncionario.txtCodigo_fun.Text = cFuncionario.codigo_funcionario.ToString();
                fFuncionario.txtNome_fun.Text = cFuncionario.nome.ToString();
                fFuncionario.txtNomesocial_fun.Text = cFuncionario.nome_social.ToString();
                fFuncionario.maskDatanascimento_fun.Text = cFuncionario.data_nascimento.ToString();
                
                //SEXO
                if(cFuncionario.sexo == "F")
                {
                    fFuncionario.rdbSexoFeminino_fun.Checked = true;
                }

                else if(cFuncionario.sexo == "M")
                {
                    fFuncionario.rdbSexoMasculino_fun.Checked = true;
                }

                else
                {
                    fFuncionario.rdbSexoNinformado_fun.Checked = true;
                }

                //ESTADO CIVIL - COMBOBOX - PASSAR VARIÁVEL DECLARANDO NO FORM 
                fFuncionario.estado_civil = cFuncionario.estado_civil;

                fFuncionario.maskCpf_fun.Text = cFuncionario.cpf.ToString();
                fFuncionario.maskRg_fun.Text = cFuncionario.rg.ToString();
                fFuncionario.txtSalario_fun.Text = cFuncionario.salario.ToString();
                fFuncionario.txtRua_fun.Text = cFuncionario.endereco.ToString();
                fFuncionario.txtNumero_fun.Text = cFuncionario.numero.ToString();
                fFuncionario.txtComplemento_fun.Text = cFuncionario.complemento.ToString();
                fFuncionario.txtBairro_fun.Text = cFuncionario.bairro.ToString();
                fFuncionario.txtCidade_fun.Text = cFuncionario.cidade.ToString();

                //ESTADO - COMBOBOX
                fFuncionario.estado = cFuncionario.estado;

                fFuncionario.maskCep_fun.Text = cFuncionario.cep.ToString();
                fFuncionario.maskTelresidencial_fun.Text = cFuncionario.telefone_residencial.ToString();
                fFuncionario.maskTelcelular_fun.Text = cFuncionario.telefone_celular.ToString();
                fFuncionario.txtEmail_fun.Text = cFuncionario.email.ToString();
                fFuncionario.txtUsuario_fun.Text = cFuncionario.usuario.ToString();
                fFuncionario.txtSenha_fun.Text = cFuncionario.senha.ToString();
                fFuncionario.tipo_acesso = cFuncionario.tipo_acesso;

                //STATUS
                if(cFuncionario.status == 1)
                {
                    fFuncionario.ckbStatus_fun.Checked = true;
                }

                else
                {
                    fFuncionario.ckbStatus_fun.Checked = false;
                }

                //DATA CADASTRO - MANDAR PARA A VARIÁVEL O VALOR ARMAZENADO NO BANCO
                fFuncionario.data_cadastro = cFuncionario.data_cadastro;

                //CÓDIGO CARGO - COMBO - MANDAR PARA A VARIÁVEL O VALOR ARMAZENADO NO BD
                fFuncionario.cargo = cFuncionario.codigo_cargo;


                fFuncionario.tipo = "Atualização";

                fFuncionario.ShowDialog();

                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void gbConsFuncionario_Enter(object sender, EventArgs e)
        {

        }

        private void gbCidadeSexo_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
