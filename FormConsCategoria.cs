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
    public partial class FormConsCategoria : Form
    {

        public FormConsCategoria()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormConsCategoria_Load(object sender, EventArgs e)
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
            classCategoria cCategoria = new classCategoria();
            //CRIAR VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            int filtro = cbFiltro.SelectedIndex;

            switch (filtro)
            {
                case 0:
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                    {
                        MessageBox.Show("Favor informar uma categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }

                    else
                    {
                        dgvCategoria.DataSource = cCategoria.ConsCatNomeContem(txtNome.Text);
                    }
                    break;

                case 1:
                    if (rbAtivo.Checked)
                    {
                        dgvCategoria.DataSource = cCategoria.ConsCatStatus(1);
                    }

                    else
                    {
                        dgvCategoria.DataSource = cCategoria.ConsCatStatus(0);

                    }
                    break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID DE FUNCIONÁRIO E EDITAR OU EXCLUIR UM FUNCIONÁRIO 
            //USAR O EVENTO CellClick  (PODE CLICAR NO CONTEÚDO, NÃO SOMENTE NO TEXTO)
            //USANDO O EVENTO CellContentClick (TEM QUE CLICAR NO CONTEÚDO (TEXTO))

            //PERGUNTAR PARA O USUÁRIO SE REALMENTE DESEJA ALTERAR O FUNCIONÁRIO SELECIONADO
            if (MessageBox.Show("Deseja alterar ou excluir o cargo selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                classCategoria cCategoria = new classCategoria();
                FormCategoria fCategoria = new FormCategoria();

                cCategoria.DadosCategoria(Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value));

                fCategoria.txtCodigo_cat.Text = cCategoria.codigo_categoria.ToString();
                fCategoria.txtNome_cat.Text = cCategoria.nome_categoria.ToString();
                fCategoria.txtObservacao_cat.Text = cCategoria.observacao.ToString();

                if (cCategoria.status == 1)
                {
                    fCategoria.ckbStatus_cat.Checked = true;
                }
                else
                {
                    fCategoria.ckbStatus_cat.Checked = false;
                }


                fCategoria.data_cadastro = cCategoria.data_cadastro;

                fCategoria.tipo = "Atualização";
                fCategoria.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
        }

        private void label10_Click(object sender, EventArgs e)
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
