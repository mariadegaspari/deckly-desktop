using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;

namespace SistemaDeckly
{
    public partial class FormProduto : Form
    {
        //CRIAR VARIÁVEIS QUE SERÃO UTILIZADAS NO FORM DE CONSULTA
        //TIPO - MANEIRA QUE FORM SERÁ ABERTO
        //OUTRAS VARIÁVEIS - EXIBIR OS DADOS QUE ESTÃO ARMAZENADO NO BD E NÃO OS DECLARADOS NO LOAD DO FORM, TUDO QUE FOR COMBOBOX PRECISA TER UMA VARIÁVEL E A VARIÁVEL PARA CARREGAR A DATA CADASTRO ARMAZENADA NO BD

        public string tipo, raridade;
        public int marca, categoria;
        public DateTime data_cadastro;

        // O diretório de imagens é o mesmo que é utilizado pelo sistema web.
        /* Como a pasta de imagems é dependente do sistema do usuário, o ideal seria criar um arquivo de configuração que guarde o diretório do xampp para que algum tecnico sem conhecimento de programação possa facilmente altera-lo. Se der tempo, adicionar um arquivo editavel .ini ou .json no projeto. */
        string phpDirImagem = @"C:\xampp\htdocs\INFO_53\Deckly\images\";
        string imgDestino;
        public string imgOriginal;
        public string ImagemNome;


        // IMAGES
        Image oImageUsuario;

        public FormProduto()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void txtObservacao_cat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcFoto_pro_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome_pro.Text) || cbRaridade_pro.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(txtEstoque_pro.Text) || !string.IsNullOrWhiteSpace(txtCusto_pro.Text) || !string.IsNullOrWhiteSpace(txtLucro_pro.Text) || !string.IsNullOrWhiteSpace(txtVenda_pro.Text) || cbMarca_pro.SelectedIndex != -1 || cbCategoria_pro.SelectedIndex != -1)
            {
                if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void btnCadastrar_pro_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            try
            {
                if (!Directory.Exists(phpDirImagem))
                {
                    throw new Exception("O diretório de imagens não existente ou não encontrado. Comunique o administrador do seu sitema caso o erro persista.");
                }
                else if (!File.Exists(imgOriginal))
                {
                    throw new Exception("Arquivo de imagem especificado não encontrado ou não existente. Caso o erro persista, comunique o seu administrador.");
                }
                else
                {
                    File.Copy(imgOriginal, imgDestino);
                    //MessageBox.Show("Falha ao mover arquivo de imagem. Verifique se o caminho especificado existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtNome_pro.Text) || cbRaridade_pro.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtEstoque_pro.Text) || string.IsNullOrWhiteSpace(txtCusto_pro.Text) || string.IsNullOrWhiteSpace(txtLucro_pro.Text) || string.IsNullOrWhiteSpace(txtVenda_pro.Text) || cbMarca_pro.SelectedIndex == -1 || cbCategoria_pro.SelectedIndex == -1)
            {
                MessageBox.Show("Favor preencher todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                cProduto.nome_produto = txtNome_pro.Text;
                cProduto.descricao_produto = txtDescricao_pro.Text;
                cProduto.raridade_produto = cbRaridade_pro.SelectedItem.ToString();
                cProduto.quantidade_estoque = Convert.ToInt32(txtEstoque_pro.Text);
                cProduto.preco_custo = Convert.ToDecimal(txtCusto_pro.Text);
                cProduto.lucro = Convert.ToInt32(txtLucro_pro.Text);
                cProduto.preco_venda = Convert.ToDecimal(txtVenda_pro.Text);


                if (rdbPromAtiva_pro.Checked)
                {
                    cProduto.status_promocao = 1;
                    cProduto.desconto_promocao = Convert.ToInt32(txtDesconto_pro.Text);
                }

                else
                {
                    cProduto.status_promocao = 0;
                    cProduto.desconto_promocao = 0;
                }

                
                cProduto.preco_promocao = Convert.ToDecimal(txtValorfinal_pro.Text);

                cProduto.foto_produto1 = ImagemNome;

                
                cProduto.codigo_marca = Convert.ToInt32(cbMarca_pro.SelectedValue);
                cProduto.codigo_categoria = Convert.ToInt32(cbCategoria_pro.SelectedValue);

                //CHAMAR O MÉTODO DE CADASTRO DA CLASSE FUNCIONÁRIO
                int resp = cProduto.CadastrarProduto();


                if (resp == 1)
                {
                    MessageBox.Show($"Produto: {cProduto.nome_produto} cadastrado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void FormProduto_Load(object sender, EventArgs e)
        {
            txtDesconto_pro.Enabled = false;
            maskDatacadastro_pro.Text = DateTime.Now.ToShortDateString();

            //COMBO CARGO - TRAZER DADOS DA TABELA CARGO DO BANCO DE DADOS
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR O MÉTODO QUE VAI CARREGAR A COMBO
            classCategoria cCategoria = new classCategoria();
            //CHAMAR O MÉTODO NA COMBO DE CARGO
            cbCategoria_pro.DataSource = cCategoria.CarregarComboCategoria();
            //DISPLAY MEMBER - O QUE SERÁ EXIBIDO NA COMBO - NOME DA COLUNA DO BD
            cbCategoria_pro.DisplayMember = "nome_categoria";
            //VALUE MEMBER - O QUE SERÁ ARMAZENADO NO BANCO DE DADOS
            cbCategoria_pro.ValueMember = "codigo_categoria";
            //NÃO DEIXAR NENHUM CARGO SELECIONADO
            cbCategoria_pro.SelectedIndex = -1;


            //COMBO MARCA - TRAZER DADOS DA TABELA CARGO DO BANCO DE DADOS
            //CRIAR OBJETO DA CLASSE MARCA PARA USAR O MÉTODO QUE VAI CARREGAR A COMBO
            classMarca cMarca = new classMarca();
            //CHAMAR O MÉTODO NA COMBO DE MARCA
            cbMarca_pro.DataSource = cMarca.CarregarComboMarca();
            //DISPLAY MEMBER - O QUE SERÁ EXIBIDO NA COMBO - NOME DA COLUNA DO BD
            cbMarca_pro.DisplayMember = "nome_marca";
            //VALUE MEMBER - O QUE SERÁ ARMAZENADO NO BANCO DE DADOS
            cbMarca_pro.ValueMember = "codigo_marca";
            //NÃO DEIXAR NENHUM CARGO SELECIONADO
            cbMarca_pro.SelectedIndex = -1;


            cbRaridade_pro.Items.Add("Comum");
            cbRaridade_pro.Items.Add("Incomum");
            cbRaridade_pro.Items.Add("Rara");
            cbRaridade_pro.Items.Add("Super rara");
            cbRaridade_pro.Items.Add("Mangá");

            txtDesconto_pro.BackColor = Color.FromArgb(212, 210, 207);

            //VERIFICAR O MODO DE ABERTURA DO FORM - SE FOR ATUALIZAÇÃO
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Produto";
                ckbStatus_pro.Enabled = true;
                btnCadastrar_pro.Visible = false;

                maskDatacadastro_pro.Text = data_cadastro.ToString();
                cbRaridade_pro.SelectedItem = raridade;
                cbCategoria_pro.SelectedValue = categoria;
                cbMarca_pro.SelectedValue = marca;

                // CARREGAR A FOTO JÁ CADASTRADA
                if (!string.IsNullOrWhiteSpace(ImagemNome))
                {
                    string caminhoFoto = Path.Combine(phpDirImagem, ImagemNome);

                    if (File.Exists(caminhoFoto))
                    {
                        try
                        {
                            pcFoto_pro.Image = CarregarImagem(caminhoFoto);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Não foi possível carregar a foto deste produto.", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            else
            {
                btnCadastrar_pro.Location = btnExcluir.Location;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;

            }
        }

        private void rdbPromAtiva_pro_CheckedChanged(object sender, EventArgs e)
        {
            

            if (rdbPromAtiva_pro.Checked)
            {
                    txtDesconto_pro.Enabled = true;
                txtDesconto_pro.BackColor = Color.FromArgb(255, 236, 211);
            }

            else
            {
                txtDesconto_pro.Enabled = false;
                txtDesconto_pro.BackColor = Color.FromArgb(212, 210, 207);
            }
        }

        private void txtCusto_pro_TextChanged(object sender, EventArgs e)
        {
            CalcularPreco();

        }

        private void CalcularPreco()
        {
            if (string.IsNullOrWhiteSpace(txtCusto_pro.Text) ||
                string.IsNullOrWhiteSpace(txtLucro_pro.Text))
            {
                txtVenda_pro.Text = "";
                txtValorfinal_pro.Text = "";
                return;
            }

            double preco = Convert.ToDouble(txtCusto_pro.Text);
            double lucro = Convert.ToDouble(txtLucro_pro.Text);

            double precoVenda = preco + (preco * lucro / 100);

            txtVenda_pro.Text = precoVenda.ToString("F2");

            if (rdbPromAtiva_pro.Checked && !string.IsNullOrWhiteSpace(txtDesconto_pro.Text))
            {
                double desconto = Convert.ToDouble(txtDesconto_pro.Text);
                if (desconto > lucro)
                {
                    MessageBox.Show("Desconto maior que o lucro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesconto_pro.Text = "0";
                    
                }

                else
                {
                    double precoPromocional = precoVenda - (precoVenda * desconto / 100);

                    txtValorfinal_pro.Text = precoPromocional.ToString("F2");
                }
            }
            else
            {
                txtValorfinal_pro.Text = "0";
            }
        }

        private void txtLucro_pro_TextChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private void txtVenda_pro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesconto_pro_TextChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private void ckbStatus_pro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            if (string.IsNullOrWhiteSpace(txtNome_pro.Text) || cbRaridade_pro.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtEstoque_pro.Text) || string.IsNullOrWhiteSpace(txtCusto_pro.Text) || string.IsNullOrWhiteSpace(txtLucro_pro.Text) || string.IsNullOrWhiteSpace(txtVenda_pro.Text) || cbMarca_pro.SelectedIndex == -1 || cbCategoria_pro.SelectedIndex == -1)
            {
                MessageBox.Show("Favor preencher todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (!string.IsNullOrWhiteSpace(imgOriginal) && File.Exists(imgOriginal))
                {
                    if (!File.Exists(imgDestino))
                    {
                        File.Copy(imgOriginal, imgDestino);
                    }
                }
                cProduto.codigo_produto = Convert.ToInt32(txtCodigo_pro.Text);
                cProduto.nome_produto = txtNome_pro.Text;
                cProduto.descricao_produto = txtDescricao_pro.Text;
                cProduto.raridade_produto = cbRaridade_pro.SelectedItem.ToString();
                cProduto.quantidade_estoque = Convert.ToInt32(txtEstoque_pro.Text);
                cProduto.preco_custo = Convert.ToDecimal(txtCusto_pro.Text);
                cProduto.lucro = Convert.ToInt32(txtLucro_pro.Text);
                cProduto.preco_venda = Convert.ToDecimal(txtVenda_pro.Text);


                if (rdbPromAtiva_pro.Checked)
                {
                    cProduto.status_promocao = 1;
                }

                else
                {
                    cProduto.status_promocao = 0;
                }

                
                if(string.IsNullOrWhiteSpace(txtDesconto_pro.Text))
                {
                    cProduto.desconto_promocao = 0;
                }

                else
                {
                    cProduto.desconto_promocao = Convert.ToInt32(txtDesconto_pro.Text);
                }

                cProduto.preco_promocao = Convert.ToDecimal(txtValorfinal_pro.Text);


                cProduto.foto_produto1 = ImagemNome;
                cProduto.codigo_marca = Convert.ToInt32(cbMarca_pro.SelectedValue);
                cProduto.codigo_categoria = Convert.ToInt32(cbCategoria_pro.SelectedValue);

                if(ckbStatus_pro.Checked)
                {
                    cProduto.status_produto = 1;
                }

                else
                {
                    cProduto.status_produto = 0;
                }

                //CHAMAR O MÉTODO DE CADASTRO DA CLASSE FUNCIONÁRIO
                int resp = cProduto.AtualizarProduto();


                if (resp == 1)
                {
                    MessageBox.Show($"Produto: {cProduto.nome_produto} atualizado com sucesso!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Erro ao atualizar!", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCusto_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtVenda_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtValorfinal_pro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorfinal_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtEstoque_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLucro_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void cbCategoria_pro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            // Nome do arquivo
            string nomeArquivo;

            // Objeto do diálogo de arquivo para selecionar imagems
            OpenFileDialog abrirArquivo = new OpenFileDialog();

            // Abre a janela para selecionar imagems
            abrirArquivo.ShowDialog();

            // Armazena apenas o nome da imagem (sem o caminho inteiro do diretório)
            nomeArquivo = abrirArquivo.SafeFileName;

            // Armazena o caminho do diretório inteiro do arquivo
            ImagemNome = nomeArquivo;

            // Variável para definir o destiono final do arquivo
            imgDestino = "";

            // "phpDirImagem" se refere ao caminho da pasta de imagem padrão que as imagems deve ser armazenada (.../img)
            imgDestino = phpDirImagem + nomeArquivo;

            // Caminho inteiro da imagem selecionada
            imgOriginal = abrirArquivo.FileName;

            // Validação (verifica se a imagem selecionada de fato existe)
            if (!string.IsNullOrWhiteSpace(imgOriginal) && (Path.GetExtension(imgOriginal).ToLower() == ".jpg" || Path.GetExtension(imgOriginal).ToLower() == ".png"))
            {
                // Armazena imagem do funcionário no objeto Image
                oImageUsuario = Image.FromFile(abrirArquivo.FileName);
                pcFoto_pro.Image = oImageUsuario; // Muda o preview
            }
            
        }

        private void rdbPromInativa_pro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbRaridade_pro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir o Produto: {txtNome_pro.Text}", "Deckly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classProduto cProduto = new classProduto();
                cProduto.codigo_produto = Convert.ToInt32(txtCodigo_pro.Text);

                int resp = cProduto.ExcluirProduto();

                if (resp == 1)
                {
                    MessageBox.Show("Produto excluído com sucesso", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir", "Deckly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private Image CarregarImagem(string caminho)
        {
            try
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read))
                using (Image img = Image.FromStream(fs))
                {
                    return new Bitmap(img);
                }
            }
            catch (ArgumentException)
            {
                using (MagickImage magick = new MagickImage(caminho))
                using (MemoryStream ms = new MemoryStream(magick.ToByteArray(MagickFormat.Png)))
                using (Image img = Image.FromStream(ms))
                {
                    return new Bitmap(img);
                }
            }
        }

    }
}
