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
    public partial class FormConsCliente : Form
    {
        public FormConsCliente()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormConsCliente_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO DE OPÇOES DE CONSULTA
            cbFiltro.Items.Add("Nome");
            cbFiltro.Items.Add("Cidade");
            cbFiltro.Items.Add("CPF");
            cbFiltro.Items.Add("Sexo");
            cbFiltro.Items.Add("Status");

            cbFiltro.SelectedIndex = 0;

            //COMBO SEXO
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não informado");

            cbSexo.SelectedIndex = 0;

            //COMBO CIDADE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.CarregarComboCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;

        }
        private void OcultarFiltros()
        {
            gbNome.Visible = false;
            gbCidade.Visible = false;
            gbCPF.Visible = false;
            gbSexo.Visible = false;
            gbStatus.Visible = false;

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
                    gbCidade.Visible = true;
                    break;

                case 2:
                    gbCPF.Visible = true;
                    break;

                case 3:
                    gbSexo.Visible = true;
                    break;


                case 4:
                    gbStatus.Visible = true;
                    break;


            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();
            //CRIAR VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            int filtro = cbFiltro.SelectedIndex;

            switch (filtro) //USUÁRIO ESCOLHE OPÇÃO E SISTEMA LÊ A POSIÇÃO DO ITEM NA LISTA (SELECTED.INDEX)
            {
                case 0:
                //NOME 
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                    {
                        MessageBox.Show("Favor informar um nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }

                    else
                    {
                        if (rbContem.Checked)
                        {
                            dgvCliente.DataSource = cCliente.ConsCliNomeContem(txtNome.Text);
                        }

                        else
                        {
                            dgvCliente.DataSource = cCliente.ConsCliNomeInicio(txtNome.Text);
                        }
                    }

                    break;
                //CIDADE
                case 1:
                    dgvCliente.DataSource = cCliente.ConsCliCidade(cbCidade.SelectedValue.ToString());
                    break;

                //CPF
                case 2:
                    //VALIDAR SE O USUÁRIO INFORMOU UM CPF
                    if (mskCpf.Text != "   .   .   -")
                    {
                        dgvCliente.DataSource = cCliente.ConsCliCpf(mskCpf.Text);
                    }

                    else
                    {
                        MessageBox.Show("Favor inserir um CPF completo", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskCpf.Focus();
                    }
                    break;

                //SEXO
                case 3:
                    //FEMININO
                    if (cbSexo.SelectedIndex == 0)
                    {
                        dgvCliente.DataSource = cCliente.ConsCliSexo("F");
                    }

                    else if (cbSexo.SelectedIndex == 1)
                    {
                        dgvCliente.DataSource = cCliente.ConsCliSexo("M");

                    }

                    else
                    {
                        dgvCliente.DataSource = cCliente.ConsCliSexo("N");
                    }

                    break;

                //STATUS
                case 4:
                    if (rbAtivo.Checked)
                    {
                        dgvCliente.DataSource = cCliente.ConsCliStatus(1);
                    }

                    else
                    {
                        dgvCliente.DataSource = cCliente.ConsCliStatus(0);

                    }
                    break;

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir o funcionario selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONÁRIO
                classCliente cCliente = new classCliente();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO DE FUNCIONÁRIO - PARA MANDAR AS INFORMAÇÕES DO BD PARA O FORM
                FormCliente fCliente = new FormCliente();

                //PEGAR O FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO ATRAVÉS DA SELEÇÃO NA GRID
                cCliente.DadosCliente(Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BANCO PARA OS ELEMENTOS DO FORM DE CADASTRO
                fCliente.txtCodigo_cli.Text = cCliente.codigo_cliente.ToString();
                fCliente.txtNome_cli.Text = cCliente.nome.ToString();
                fCliente.txtNomesocial_cli.Text = cCliente.nome_social.ToString();
                fCliente.maskDatanascimento_cli.Text = cCliente.data_nascimento.ToString();

                //SEXO
                if (cCliente.sexo == "F")
                {
                    fCliente.rdbSexoFeminino_cli.Checked = true;
                }

                else if (cCliente.sexo == "M")
                {
                    fCliente.rdbSexoMasculino_cli.Checked = true;
                }

                else
                {
                    fCliente.rdbSexoNinformado_cli.Checked = true;
                }


                fCliente.maskCpf_cli.Text = cCliente.cpf.ToString();
                fCliente.maskRg_cli.Text = cCliente.rg.ToString();
                fCliente.txtRua_cli.Text = cCliente.endereco.ToString();
                fCliente.txtNumero_cli.Text = cCliente.numero.ToString();
                fCliente.txtComplemento_cli.Text = cCliente.complemento.ToString();
                fCliente.txtBairro_cli.Text = cCliente.bairro.ToString();
                fCliente.txtCidade_cli.Text = cCliente.cidade.ToString();

                //ESTADO - COMBOBOX
                fCliente.estado = cCliente.estado;
                fCliente.maskCep_cli.Text = cCliente.cep.ToString();
                fCliente.maskTelcelular_cli.Text = cCliente.telefone_celular.ToString();
                fCliente.txtEmail_cli.Text = cCliente.email.ToString();

                //STATUS
                if (cCliente.status == 1)
                {
                    fCliente.ckbStatus_cli.Checked = true;
                }

                else
                {
                    fCliente.ckbStatus_cli.Checked = false;
                }

                //DATA CADASTRO - MANDAR PARA A VARIÁVEL O VALOR ARMAZENADO NO BANCO
                fCliente.data_cadastro = cCliente.data_cadastro;


                fCliente.tipo = "Atualização";

                fCliente.ShowDialog();

                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
