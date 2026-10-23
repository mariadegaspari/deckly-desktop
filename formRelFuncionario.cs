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
    public partial class formRelFuncionario : Form
    {
        public formRelFuncionario()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void formRelFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes do Mês");     
            cbTipoRel.Items.Add("Cargo");
            cbTipoRel.Items.Add("Cidade");      
            cbTipoRel.Items.Add("Idade");         
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;
            this.rvFuncionario.RefreshReport();

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

            //COMBO CIDADE
            classFuncionario cFuncionario = new classFuncionario();
            cbCidade.DataSource = cFuncionario.CarregarComboCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;  
                gbStatus.Enabled = false;           
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
           
            if (cbTipoRel.SelectedIndex == 1)//Cargo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbCargo.Enabled = true;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = true;
            }
            
            if (cbTipoRel.SelectedIndex == 3)//Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbStatus.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            
            if (cbTipoRel.SelectedIndex == 4)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = true;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();
            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {
                case "Idade":
                    if(string.IsNullOrWhiteSpace(txtIdadeInicial.Text) && string.IsNullOrWhiteSpace(txtIdadeFinal.Text))
                    {
                        MessageBox.Show("Favor informar idade inicial e idade final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdadeInicial.Focus();
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncIdade(Convert.ToInt32(txtIdadeInicial.Text), Convert.ToInt32(txtIdadeFinal.Text));
                        this.rvFuncionario.RefreshReport();
                    }
                break;

                case "Status":
                    if(rbAtivo.Checked)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncStatus(1);
                        this.rvFuncionario.RefreshReport();
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncStatus(0);
                        this.rvFuncionario.RefreshReport();
                    }
                    break;

                case "Cargo":
                    if (string.IsNullOrWhiteSpace(cbCargo.Text))
                    {
                        MessageBox.Show("Favor informar um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncCargo(Convert.ToInt32(cbCargo.SelectedValue));
                        this.rvFuncionario.RefreshReport();
                    }
                    break;

                case "Cidade":
                    if (string.IsNullOrWhiteSpace(cbCidade.Text))
                    {
                        MessageBox.Show("Favor informar uma cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncCidade(Convert.ToString(cbCidade.SelectedValue));
                        this.rvFuncionario.RefreshReport();
                    }
                    break;

                //ANIVERSARIANTES DO MÊS
                default:
                    if(cbMes.SelectedIndex == 0)
                    {
                        MessageBox.Show("Favor escolher um mês.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncMesNiver(Convert.ToInt32(cbMes.SelectedIndex));
                        this.rvFuncionario.RefreshReport();
                    }
                    break;

            }

        }

        private void txtIdadeInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtIdadeFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
    }
}
