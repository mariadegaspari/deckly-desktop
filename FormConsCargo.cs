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
    public partial class FormConsCargo : Form
    {
        public FormConsCargo()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormConsCargo_Load(object sender, EventArgs e)
        {
            //COMBO DE FILTROS
            cbFiltro.Items.Add("Cargo");
            cbFiltro.Items.Add("Status");

            cbFiltro.SelectedIndex = 0;
            txtNome.Focus();



        }

        private void OcultarFiltros()
        {
            gbNome.Visible = false;
            gbStatus.Visible = false;
        }

        private void gbConsCargo_Enter(object sender, EventArgs e)
        {

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

        private void gbOpcao_Enter(object sender, EventArgs e)
        {

        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }

        private void gbDataAdmissao_Enter(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();

            //CRIAR VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            int filtro = cbFiltro.SelectedIndex;

            switch(filtro)
            {
                case 0:
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                    {
                        MessageBox.Show("Favor informar um cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }

                    else
                    {
                        dgvCargo.DataSource = cCargo.ConsCarNomeContem(txtNome.Text);
                    }
                    break;

                case 1:
                    if (rbAtivo.Checked)
                    {
                        dgvCargo.DataSource = cCargo.ConsCarStatus(1);
                    }

                    else
                    {
                        dgvCargo.DataSource = cCargo.ConsCarStatus(0);

                    }
                    break;
            }
        }


            private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pnTituloCargo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID DE FUNCIONÁRIO E EDITAR OU EXCLUIR UM FUNCIONÁRIO 
            //USAR O EVENTO CellClick  (PODE CLICAR NO CONTEÚDO, NÃO SOMENTE NO TEXTO)
            //USANDO O EVENTO CellContentClick (TEM QUE CLICAR NO CONTEÚDO (TEXTO))

            //PERGUNTAR PARA O USUÁRIO SE REALMENTE DESEJA ALTERAR O FUNCIONÁRIO SELECIONADO
            if (MessageBox.Show("Deseja alterar ou excluir o cargo selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                classCargo cCargo = new classCargo();
                FormCargo fCargo = new FormCargo();

                cCargo.DadosCargo(Convert.ToInt32(dgvCargo.SelectedRows[0].Cells[0].Value));

                fCargo.txtCodigo_car.Text = cCargo.codigo_cargo.ToString();
                fCargo.txtNome_car.Text = cCargo.nome.ToString();
                fCargo.txtObservacao_car.Text = cCargo.observacao.ToString();

                if (cCargo.status == 1)
                {
                    fCargo.ckbStatus_car.Checked = true;
                }
                else
                {
                    fCargo.ckbStatus_car.Checked = false;
                }


                fCargo.data_cadastro = cCargo.data_cadastro;

                fCargo.tipo = "Atualização";
                fCargo.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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
