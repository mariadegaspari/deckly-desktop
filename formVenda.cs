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
    
    public partial class formVenda : Form
    {

        //CRIAR LISTA QUE SERÁ USADA NA GRID DE PRODUTOS VENDIDOS QUE TERÁ COMO BASE A CLASSE ITENSVENDA
        private List<classItensVenda> ListaItensVenda = new List<classItensVenda>();

        //VARIÁVEL PARA CALCULAR VALOR TOTAL DA VENDA
        private decimal VendaTotal = 0;



        public formVenda()
        {
            InitializeComponent();
            this.TopMost = true;
        }          
        private void formVenda_Load(object sender, EventArgs e)
        {
            //CARREGAR DATA DA VENDA
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

            //COMBO FORMA DE PAGAMENTO
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Pix");
            cbFormaPagamento.SelectedIndex = -1;


            //COMBO FUNCIONARIO
            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarFuncionario();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "Cod";
            cbFuncionario.SelectedIndex = 0;

        }
        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            if(string.IsNullOrWhiteSpace(txtPesqCliente.Text))
            {
                MessageBox.Show("Favor informar um cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesqCliente.Focus();
            }
            
            else
            {
                dgvCliente.DataSource = cCliente.CarregarGridCliente(txtPesqCliente.Text);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            if (string.IsNullOrWhiteSpace(txtPesqProduto.Text))
            {
                MessageBox.Show("Favor informar um produto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesqProduto.Focus();
            }

            else
            {
                dgvProduto.DataSource = cProduto.CarregarGridProduto(txtPesqProduto.Text);
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classProduto cProduto = new classProduto();

            bool resp = cProduto.DadosProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

            if(resp == true)
            {
                txtProduto.Text = cProduto.nome_produto;
                txtQtdeEstoque.Text = cProduto.quantidade_estoque.ToString();
                txtValor.Text = cProduto.preco_venda.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();
            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtQtde.Text))
            {
                MessageBox.Show("Favor informar uma quantidade", "Sistema Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if(Convert.ToInt32(txtQtde.Text) < 1)
            {
                MessageBox.Show("Favor informar uma quantidade", "Sistema Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (Convert.ToInt32(txtQtde.Text) > Convert.ToInt32(txtQtdeEstoque.Text))
            {
                MessageBox.Show("Favor colocar uma quantidade compatível com o estoque disponível", "Sistema Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int qtde = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);

                decimal total = qtde * valor;

                txtTotal.Text = total.ToString();
            }

            
        }

        private void AtualizarGrid()
        {

            classProduto cProduto = new classProduto();

            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor unitário"));
            dt.Columns.Add(new DataColumn("Valor total"));

            foreach(classItensVenda item in ListaItensVenda)
            {
                dt.Rows.Add(item.codigo_produto, cProduto.BuscarNomeProd(item.codigo_produto), item.quantidade_itens, item.preco_unitario, item.valor_total);
                dt.AcceptChanges();
            }

            dgvItens.DataSource = dt;
        }


        private void CalcularDescontoTotalVenda()
        {
            decimal valorVenda = 0;
            decimal percentualDesconto = 0;
            decimal.TryParse(txtValorTotal.Text, out valorVenda);
            decimal.TryParse(txtPercentualDesconto.Text, out percentualDesconto);

            if(percentualDesconto < 0)
            {
                percentualDesconto = 0;
            }

            
            decimal valorDesconto = valorVenda * percentualDesconto / 100;
            decimal totalVenda = valorVenda - valorDesconto;

            txtTotalDesconto.Text = valorDesconto.ToString("N2");
            txtTotalVenda.Text = totalVenda.ToString("N2");
        }

        private void txtPercentualDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularDescontoTotalVenda();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Não há produto para ser inserido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                classItensVenda cItensVenda = new classItensVenda();

                cItensVenda.codigo_produto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);
                cItensVenda.quantidade_itens = Convert.ToInt32(txtQtde.Text);
                cItensVenda.preco_unitario = Convert.ToDecimal(txtValor.Text);
                cItensVenda.valor_total = Convert.ToDecimal(txtTotal.Text);

                ListaItensVenda.Add(cItensVenda);

                decimal ValorItem = 0;
                ValorItem = Convert.ToDecimal(txtTotal.Text);
                VendaTotal = VendaTotal + ValorItem;
                txtValorTotal.Text = VendaTotal.ToString("n2");


                txtQtdeItens.Text = ListaItensVenda.Count.ToString();

                AtualizarGrid();

                txtProduto.Clear();
                txtQtde.Text = "1";
                txtValor.Clear();
                txtTotal.Clear();
                txtQtdeEstoque.Clear();

                CalcularDescontoTotalVenda();
                txtPercentualDesconto.Focus();
            }

        }

        private void Limpar()
        {
            cbFuncionario.SelectedIndex = -1;
            txtPesqCliente.Clear();
            dgvCliente.DataSource = null;

            txtPesqProduto.Clear();
            dgvProduto.DataSource = null;

            ListaItensVenda.Clear();
            AtualizarGrid();

            VendaTotal = 0;
            txtValorTotal.Text = "0.00";
            txtValor.Clear();
            txtQtdeEstoque.Clear();
            txtTotalVenda.Text = "0.00";
            txtTotalDesconto.Text = "0.00";
            txtPercentualDesconto.Text = "0";
            txtQtdeItens.Text = "0";

            cbFormaPagamento.SelectedIndex = -1;
        }

        private void CalculaEstoque(int qtde, int cod)
        {
            classProduto cProduto = new classProduto();
            cProduto.DadosProduto(cod);
            int estoque = cProduto.quantidade_estoque;
            cProduto.AtualizarEstoque(estoque - qtde, cod);
        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.SelectedIndex != -1 && dgvCliente.DataSource != null && dgvItens.DataSource != null && cbFormaPagamento.SelectedIndex != -1)
            {
                classVenda cVenda = new classVenda();

                cVenda.valor_total = Convert.ToDecimal(txtTotalVenda.Text);
                cVenda.desconto = Convert.ToDecimal(txtTotalDesconto.Text);
                cVenda.forma_pagamento = cbFormaPagamento.SelectedItem.ToString();
                cVenda.codigo_cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                cVenda.codigo_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);


                bool resp = cVenda.CadastrarVenda();

                if(resp == true)
                {
                    foreach(classItensVenda item in ListaItensVenda)
                    {
                        item.codigo_venda = cVenda.codigo_venda;
                        resp = item.CadastrarItemVenda();

                        CalculaEstoque(item.quantidade_itens, item.codigo_produto);
                    }

                    if(resp == true)
                    {
                        MessageBox.Show("Venda realizada com sucesso!", "Sistema Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();//por favor
                    }

                    else
                    {
                        MessageBox.Show("Erro ao realizar venda!", "Sistema Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Favor preencher todos os campos", "Sistema Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    Camposobrigatorios();
                }

                    
            }

        }

        private void Camposobrigatorios()
        {
            gbFuncionario.BackColor = Color.FromArgb(33, 211, 255);

            gbClientes.BackColor = Color.FromArgb(33, 211, 255);

            gbProdutos.BackColor = Color.FromArgb(33, 211, 255);

            gbItensVenda.BackColor = Color.FromArgb(33, 211, 255); gbPagamneto.BackColor = Color.FromArgb(33, 211, 255);

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item da lista para remover.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja remover o item selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
                return;

            int indice = dgvItens.SelectedRows[0].Index;

            // Garante que o índice existe na lista
            if (indice < 0 || indice >= ListaItensVenda.Count)
                return;

            // Subtrai o valor do item removido do total da venda
            decimal ValorItem = ListaItensVenda[indice].valor_total;
            VendaTotal = VendaTotal - ValorItem;

            if (VendaTotal < 0)
                VendaTotal = 0;

            // Remove o item da lista
            ListaItensVenda.RemoveAt(indice);

            // Atualiza os campos da tela
            txtValorTotal.Text = VendaTotal.ToString("n2");
            txtQtdeItens.Text = ListaItensVenda.Count.ToString();

            AtualizarGrid();
            CalcularDescontoTotalVenda();
            txtProduto.Focus();
        }

        private void txtPesqCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPesqProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPercentualDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTotalDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTotalVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQtdeItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
    }
}
