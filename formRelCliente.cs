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
    public partial class formRelCliente : Form
    {
        public formRelCliente()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void formRelCliente_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Sexo");
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

            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.SelectedIndex = 0;

            //COMBO CIDADE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.CarregarComboCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = 0;
            this.rvCliente.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 3)//Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
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
            classCliente cCliente = new classCliente();
            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {
                case "Idade":
                    if (string.IsNullOrWhiteSpace(txtIdadeInicial.Text) && string.IsNullOrWhiteSpace(txtIdadeFinal.Text))
                    {
                        MessageBox.Show("Favor informar idade inicial e idade final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdadeInicial.Focus();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliIdade(Convert.ToInt32(txtIdadeInicial.Text), Convert.ToInt32(txtIdadeFinal.Text));
                        this.rvCliente.RefreshReport();
                    }
                    break;

                case "Status":
                    if (rbAtivo.Checked)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliStatus(1);
                        this.rvCliente.RefreshReport();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliStatus(0);
                        this.rvCliente.RefreshReport();
                    }
                    break;

                case "Sexo":
                    if (string.IsNullOrWhiteSpace(cbSexo.Text))
                    {
                        MessageBox.Show("Favor informar um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(cbSexo.SelectedIndex == 0)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliSexo("F");
                        this.rvCliente.RefreshReport();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliSexo("M");
                        this.rvCliente.RefreshReport();
                    }
                    break;

                case "Cidade":
                    if (string.IsNullOrWhiteSpace(cbCidade.Text))
                    {
                        MessageBox.Show("Favor informar uma cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliCidade(Convert.ToString(cbCidade.SelectedValue));
                        this.rvCliente.RefreshReport();
                    }
                    break;

                //ANIVERSARIANTES DO MÊS
                default:
                    if (cbMes.SelectedIndex == 0)
                    {
                        MessageBox.Show("Favor escolher um mês.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.RelCliMesNiver(Convert.ToInt32(cbMes.SelectedIndex));
                        this.rvCliente.RefreshReport();
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
