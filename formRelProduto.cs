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
    public partial class formRelProduto : Form
    {
        public formRelProduto()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void formRelProduto_Load(object sender, EventArgs e)
        {
            cbTipoRel.Items.Add("Categoria");
            cbTipoRel.Items.Add("Marca");
            cbTipoRel.Items.Add("Estoque");
            cbTipoRel.Items.Add("Preço");
            cbTipoRel.Items.Add("Status");

            cbTipoRel.SelectedIndex = 0;


            //COMBO CATEGORIA
            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.CarregarComboCategoria();
            cbCategoria.DisplayMember = "nome_categoria";
            cbCategoria.ValueMember = "codigo_categoria";
            cbCategoria.SelectedIndex = -1;


            //COMBO MARCA
            classMarca cMarca = new classMarca();
            cbMarca.DataSource = cMarca.CarregarComboMarca();
            cbMarca.DisplayMember = "nome_marca";
            cbMarca.ValueMember = "codigo_marca";
            cbMarca.SelectedIndex = -1;

            this.rvProduto.RefreshReport();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Categoria
            {
                gbCategoria.Enabled = true;
                gbMarca.Enabled = false;
                gbPreco.Enabled = false;
                gbEstoque.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1)//Marca
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = true;
                gbPreco.Enabled = false;
                gbEstoque.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2)//Estoque
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = false;
                gbPreco.Enabled = false;
                gbEstoque.Enabled = true;
                gbStatus.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3)//Preco
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = false;
                gbPreco.Enabled = true;
                gbEstoque.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4)//Status
            {
                gbCategoria.Enabled = false;
                gbMarca.Enabled = false;
                gbPreco.Enabled = false;
                gbEstoque.Enabled = false;
                gbStatus.Enabled = true;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();
            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {
                case "Categoria":
                    if (string.IsNullOrWhiteSpace(cbCategoria.Text))
                    {
                        MessageBox.Show("Favor informar um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProCat(Convert.ToString(cbCategoria.SelectedValue));
                        this.rvProduto.RefreshReport();
                    }
                    break;

                case "Marca":
                    if (string.IsNullOrWhiteSpace(cbMarca.Text))
                    {
                        MessageBox.Show("Favor informar um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProMar(Convert.ToString(cbMarca.SelectedValue));
                        this.rvProduto.RefreshReport();
                    }
                    break;

                case "Preço":
                    if (string.IsNullOrWhiteSpace(txtPrecoi.Text) && string.IsNullOrWhiteSpace(txtPrecof.Text))
                    {
                        MessageBox.Show("Favor informar preço inicial e preço final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrecoi.Focus();
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProPreco(Convert.ToInt32(txtPrecoi.Text), Convert.ToInt32(txtPrecof.Text));
                        this.rvProduto.RefreshReport();
                    }
                    break;


                case "Status":
                    if (rbAtivo.Checked)
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProStatus(1);
                        this.rvProduto.RefreshReport();
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProStatus(0);
                        this.rvProduto.RefreshReport();
                    }
                    break;

               
                default:
                    if (string.IsNullOrWhiteSpace(txtEstoquei.Text) && string.IsNullOrWhiteSpace(txtEstoquef.Text))
                    {
                        MessageBox.Show("Favor informar estoque inicial e estoque final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEstoquei.Focus();
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.RelProEstoque(Convert.ToInt32(txtEstoquei.Text), Convert.ToInt32(txtEstoquef.Text));
                        this.rvProduto.RefreshReport();
                    }
                    break;

            }
        }

        private void txtEstoquei_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtEstoquef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPrecof_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
    }
}
