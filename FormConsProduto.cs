using System;
using System.Windows.Forms;

namespace SistemaDeckly
{
    public partial class FormConsProduto : Form
    {
        public FormConsProduto()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormConsProduto_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO DE OPÇOES DE CONSULTA
            cbFiltro.Items.Add("Nome do produto");
            cbFiltro.Items.Add("Categoria");
            cbFiltro.Items.Add("Marca");
            cbFiltro.Items.Add("Raridade");
            cbFiltro.Items.Add("Status");

            cbFiltro.SelectedIndex = 0;

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

            //COMBO RARIDADE
            classProduto cProduto = new classProduto();
            cbRaridade.DataSource = cProduto.CarregarComboRaridade();
            cbRaridade.DisplayMember = "raridade_produto";
            cbRaridade.ValueMember = "raridade_produto";
            cbRaridade.SelectedIndex = 0;
        }

        private void OcultarFiltros()
        {
            gbNome.Visible = false;
            gbCategoria.Visible = false;
            gbMarca.Visible = false;
            gbRaridade.Visible = false;
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
                    gbCategoria.Visible = true;
                    break;

                case 2:
                    gbMarca.Visible = true;
                    break;

                case 3:
                    gbRaridade.Visible = true;
                    break;

                case 4:
                    gbStatus.Visible = true;
                    break;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            //CRIAR VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            int filtro = cbFiltro.SelectedIndex;

            switch (filtro) //USUÁRIO ESCOLHE OPÇÃO E SISTEMA LÊ A POSIÇÃO DO ITEM NA LISTA (SELECTED.INDEX)
            {
                case 1:
                    dgvProduto.DataSource = cProduto.ConsProCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                    break;

                case 2:
                    dgvProduto.DataSource = cProduto.ConsProMarca(Convert.ToInt32(cbMarca.SelectedValue));
                    break;

                case 3:
                    dgvProduto.DataSource = cProduto.ConsProRaridade(Convert.ToString(cbRaridade.SelectedValue));
                    break;

                case 4:
                    if (rbAtivo.Checked)
                    {
                        dgvProduto.DataSource = cProduto.ConsProStatus(Convert.ToInt32(1));
                    }

                    else
                    {
                        dgvProduto.DataSource = cProduto.ConsProStatus(Convert.ToInt32(0));
                    }
                    break;

                default:
                    if (string.IsNullOrWhiteSpace(txtNome.Text))
                    {
                        MessageBox.Show("Favor informar um produto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Focus();
                    }

                    else
                    {
                        if (rbContem.Checked)
                        {
                            dgvProduto.DataSource = cProduto.ConsProNomeContem(txtNome.Text);
                        }

                        else
                        {
                            dgvProduto.DataSource = cProduto.ConsProNomeInicio(txtNome.Text);
                        }
                    }
                    break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir o produto selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONÁRIO
                classProduto cProduto = new classProduto();

                //INSTANCIAR O FORMULÁRIO DE CADASTRO DE FUNCIONÁRIO - PARA MANDAR AS INFORMAÇÕES DO BD PARA O FORM
                FormProduto fProduto = new FormProduto();

                //PEGAR O FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO ATRAVÉS DA SELEÇÃO NA GRID
                cProduto.DadosProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BANCO PARA OS ELEMENTOS DO FORM DE CADASTRO
                fProduto.txtCodigo_pro.Text = cProduto.codigo_produto.ToString();
                fProduto.txtNome_pro.Text = cProduto.nome_produto.ToString();
                fProduto.raridade = cProduto.raridade_produto;
                fProduto.txtEstoque_pro.Text = cProduto.quantidade_estoque.ToString();
                fProduto.txtCusto_pro.Text = cProduto.preco_custo.ToString();
                fProduto.txtLucro_pro.Text = cProduto.lucro.ToString();
                fProduto.txtVenda_pro.Text = cProduto.preco_venda.ToString();

                if(cProduto.status_promocao == 1)
                {
                    fProduto.rdbPromAtiva_pro.Checked = true;
                }

                else
                {
                    fProduto.rdbPromInativa_pro.Checked = true;
                }

                fProduto.txtDesconto_pro.Text = cProduto.desconto_promocao.ToString();
                fProduto.txtValorfinal_pro.Text = cProduto.preco_promocao.ToString();


                //foto_produto1 
                fProduto.ImagemNome = cProduto.foto_produto1;


                if (cProduto.status_produto == 1)
                {
                    fProduto.ckbStatus_pro.Checked = true;
                }

                else
                {
                    fProduto.ckbStatus_pro.Checked = false;
                }

                //DATA CADASTRO - MANDAR PARA A VARIÁVEL O VALOR ARMAZENADO NO BANCO
                fProduto.data_cadastro = cProduto.data_cadastro;


                //CÓDIGO CARGO - COMBO - MANDAR PARA A VARIÁVEL O VALOR ARMAZENADO NO BD
                fProduto.categoria = cProduto.codigo_categoria;
                fProduto.marca = cProduto.codigo_marca;


                fProduto.tipo = "Atualização";

                fProduto.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
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
