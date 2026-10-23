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
    public partial class FormConsMarca : Form
    {
        public FormConsMarca()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormConsMarca_Load(object sender, EventArgs e)
        {
            //COMBO DE FILTROS
            cbFiltro.Items.Add("Nome");
            cbFiltro.Items.Add("Status");

            cbFiltro.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void OcultarFiltros()
        {
            gbNome.Visible = false;
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
                    gbStatus.Visible = true;
                    break;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();
            //CRIAR VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            int filtro = cbFiltro.SelectedIndex;

            switch (filtro)
            {
                case 0:
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                    {
                        MessageBox.Show("Favor informar uma marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }

                    else
                    {
                        dgvMarca.DataSource = cMarca.ConsMarNomeContem(txtNome.Text);
                    }
                    break;

                case 1:
                    if (rbAtivo.Checked)
                    {
                        dgvMarca.DataSource = cMarca.ConsMarStatus(1);
                    }

                    else
                    {
                        dgvMarca.DataSource = cMarca.ConsMarStatus(0);

                    }
                    break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //PERGUNTAR PARA O USUÁRIO SE REALMENTE DESEJA ALTERAR A MARCA SELECIONADA
            if (MessageBox.Show("Deseja alterar ou excluir a marca selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                classMarca cMarca = new classMarca();
                FormMarca fMarca = new FormMarca();

                cMarca.DadosMarca(Convert.ToInt32(dgvMarca.SelectedRows[0].Cells[0].Value));

                fMarca.txtCodigo_mar.Text = cMarca.codigo_marca.ToString();
                fMarca.txtNome_mar.Text = cMarca.nome_marca.ToString();
                fMarca.txtObservacao_mar.Text = cMarca.observacao.ToString();

                if (cMarca.status == 1)
                {
                    fMarca.ckbStatus_mar.Checked = true;
                }
                else
                {
                    fMarca.ckbStatus_mar.Checked = false;
                }


                fMarca.data_cadastro = cMarca.data_cadastro;

                fMarca.tipo = "Atualização";
                fMarca.ShowDialog();

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
