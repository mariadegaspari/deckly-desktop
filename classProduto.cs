using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDeckly
{
    class classProduto
    {


        public classProduto()
        {
            codigo_produto = 0;
            nome_produto = null;
            descricao_produto = null;
            raridade_produto = null;
            quantidade_estoque = 0;
            preco_custo = 0;
            lucro = 0;
            preco_venda = 0;
            status_promocao = 0;
            desconto_promocao = 0;
            preco_promocao = 0;
            foto_produto1 = null;
            foto_produto2 = null;
            data_cadastro = DateTime.Now;
            status_produto = 0;
            codigo_categoria = 0;
            codigo_marca = 0;
        }

        public int codigo_produto { get; set; }
        public string nome_produto { get; set; }
        public string descricao_produto { get; set; }
        public string raridade_produto { get; set; }
        public int quantidade_estoque { get; set; }
        public decimal preco_custo { get; set; }
        public int lucro { get; set; }
        public decimal preco_venda { get; set; }
        public int status_promocao { get; set; }
        public int desconto_promocao { get; set; }
        public decimal preco_promocao { get; set; }
        public string foto_produto1 { get; set; }
        public string foto_produto2 { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status_produto { get; set; }
        public int codigo_categoria { get; set; }
        public int codigo_marca { get; set; }

        public int CadastrarProduto()
        {
            string sql = $"INSERT INTO produto VALUES(0, '{nome_produto}', '{descricao_produto}', '{raridade_produto}', '{quantidade_estoque}', '{preco_custo.ToString().Replace(",", ".")}', '{lucro}', '{preco_venda.ToString().Replace(",", ".")}', {status_promocao}, '{desconto_promocao}', '{preco_promocao.ToString().Replace(",", ".")}', '{foto_produto1}', '{foto_produto2}', Now(), 1, '{codigo_categoria}', '{codigo_marca}')";


            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);

        }

        //MÉTODO PARA CARREGAR AS RARIDADES CADASTRADAS NA TABELA FUNCIONÁRIO NO FORM DE CONSULTA
        public DataTable CarregarComboRaridade()
        {
            string sql = "SELECT DISTINCT raridade_produto FROM produto WHERE status_produto = 1 ORDER BY raridade_produto";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE PRODUTO POR NOME(CONTÉM)
        public DataTable ConsProNomeContem(string nomec)
        {
            string sql = $"SELECT produto.codigo_produto 'Código produto', produto.nome_produto 'Produto', produto.raridade_produto 'Raridade', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', produto.data_cadastro 'Data de cadastro', produto.status_produto 'Status' FROM produto JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.nome_produto LIKE '%{nomec}%' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE PRODUTO POR NOME(INÍCIO)
        public DataTable ConsProNomeInicio(string nomei)
        {
            string sql = $"SELECT produto.codigo_produto 'Código produto', produto.nome_produto 'Produto', produto.raridade_produto 'Raridade', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', produto.data_cadastro 'Data de cadastro', produto.status_produto 'Status' FROM produto JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.nome_produto LIKE '{nomei}%' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //CATEGORIA
        public DataTable ConsProCategoria(int cat)
        {
            string sql = $"SELECT produto.codigo_produto 'Código produto', produto.nome_produto 'Produto', produto.raridade_produto 'Raridade', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', produto.data_cadastro 'Data de cadastro', produto.status_produto 'Status' FROM produto JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.codigo_categoria = '{cat}' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //MARCA
        public DataTable ConsProMarca(int mar)
        {
            string sql = $"SELECT produto.codigo_produto 'Código produto', produto.nome_produto 'Produto', produto.raridade_produto 'Raridade', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', produto.data_cadastro 'Data de cadastro', produto.status_produto 'Status' FROM produto JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.codigo_marca = '{mar}' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //RARIDADE
        public DataTable ConsProRaridade(string rar)
        {
            string sql = $"SELECT produto.codigo_produto 'Código produto', produto.nome_produto 'Produto', produto.raridade_produto 'Raridade', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', produto.data_cadastro 'Data de cadastro', produto.status_produto 'Status' FROM produto JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.raridade_produto = '{rar}' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //STATUS
        public DataTable ConsProStatus(int status)
        {
            string sql = $"SELECT produto.codigo_produto 'Código produto', produto.nome_produto 'Produto', produto.raridade_produto 'Raridade', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', produto.data_cadastro 'Data de cadastro', produto.status_produto 'Status' FROM produto JOIN marca ON marca.codigo_marca = produto.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = '{status}' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public int AtualizarProduto()
        {
            string sql = $"UPDATE produto SET produto.nome_produto = '{nome_produto}', produto.raridade_produto = '{raridade_produto}', produto.codigo_marca = {codigo_marca}, produto.codigo_categoria = {codigo_categoria}, produto.quantidade_estoque = {quantidade_estoque}, produto.preco_custo = '{preco_custo.ToString().Replace(",", ".")}', produto.lucro = '{lucro}', produto.preco_venda = '{preco_venda.ToString().Replace(",", ".")}', produto.status_promocao = {status_promocao}, produto.desconto_promocao = {desconto_promocao}, produto.preco_promocao = {preco_promocao.ToString().Replace(",", ".")}, produto.foto_produto1 = '{foto_produto1}' ,produto.status_produto = {status_produto} WHERE produto.codigo_produto = {codigo_produto}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        //MÉTODO PARA BUSCAR TODOS OS DADOS DO FUNCIONÁRIO SELECIONADO PELO USUÁRIO NO FORM DE CONSULTA
        public bool DadosProduto(int codigo)
        {
            string sql = $"SELECT * FROM produto WHERE codigo_produto = {codigo};";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            //SE A CONSULTA RETORNOU DADOS
            if (dt.Rows.Count > 0)
            {
                //EXIBIR TODOS OS CAMPOS DA TABELA FUNCIONÁRIO
                codigo_produto = Convert.ToInt32(dt.Rows[0]["codigo_produto"]);
                nome_produto = Convert.ToString(dt.Rows[0]["nome_produto"]);
                descricao_produto = Convert.ToString(dt.Rows[0]["descricao_produto"]);
                raridade_produto = Convert.ToString(dt.Rows[0]["raridade_produto"]);
                quantidade_estoque = Convert.ToInt32(dt.Rows[0]["quantidade_estoque"]);
                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);
                lucro = Convert.ToInt32(dt.Rows[0]["lucro"]);
                preco_venda = Convert.ToDecimal(dt.Rows[0]["preco_venda"]);
                status_promocao = Convert.ToInt32(dt.Rows[0]["status_promocao"]);
                desconto_promocao = Convert.ToInt32(dt.Rows[0]["desconto_promocao"]);
                preco_promocao = Convert.ToDecimal(dt.Rows[0]["preco_promocao"]);
                foto_produto1 = Convert.ToString(dt.Rows[0]["foto_produto1"]);
                foto_produto2 = Convert.ToString(dt.Rows[0]["foto_produto2"]);
                status_produto = Convert.ToInt32(dt.Rows[0]["status_produto"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                codigo_categoria = Convert.ToInt32(dt.Rows[0]["codigo_categoria"]);
                codigo_marca = Convert.ToInt32(dt.Rows[0]["codigo_marca"]);

                return true;
            }

            else
            {
                return false;
            }

        }

        //MÉTODO PARA EXCLUIR PRODUTO
        public int ExcluirProduto()
        {
            string sql = $"DELETE FROM produto WHERE codigo_produto = {codigo_produto}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        //MÉTODOS DE RELATÓRIO
        public DataTable RelProCat(string cat)
        {
            string sql = $"SELECT produto.nome_produto, produto.raridade_produto, produto.quantidade_estoque, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria', IF( produto.status_promocao = 0, produto.preco_promocao, produto.preco_venda ) 'Valor', produto.data_cadastro FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.codigo_categoria = '{cat}' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelProMar(string mar)
        {
            string sql = $"SELECT produto.nome_produto, produto.raridade_produto, produto.quantidade_estoque, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria', IF( produto.status_promocao = 0, produto.preco_promocao, produto.preco_venda ) 'Valor', produto.data_cadastro FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.codigo_marca = '{mar}' ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelProPreco(int preco1, int preco2)
        {
            string sql = $"SELECT produto.nome_produto, produto.raridade_produto, produto.quantidade_estoque, marca.nome_marca AS codigo_marca, categoria.nome_categoria AS codigo_categoria, IF( produto.status_promocao = 0, produto.preco_promocao, produto.preco_venda ) 'Valor', produto.data_cadastro FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND IF( produto.preco_promocao IS NOT NULL AND produto.preco_promocao != 0, produto.preco_promocao, produto.preco_venda ) BETWEEN {preco1} AND {preco2} ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelProStatus(int status)
        {
            string sql = $"SELECT produto.nome_produto, produto.raridade_produto, produto.quantidade_estoque, marca.nome_marca AS codigo_marca, categoria.nome_categoria AS codigo_categoria, IF( produto.status_promocao = 0, produto.preco_promocao, produto.preco_venda ) 'Valor', produto.data_cadastro FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = {status} ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelProEstoque(int estoque1, int estoque2)
        {
            string sql = $"SELECT produto.nome_produto, produto.raridade_produto, produto.quantidade_estoque, marca.nome_marca AS codigo_marca, categoria.nome_categoria AS codigo_categoria, IF( produto.status_promocao = 0, produto.preco_promocao, produto.preco_venda ) 'Valor', produto.data_cadastro FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.quantidade_estoque BETWEEN {estoque1} AND {estoque2} ORDER BY produto.nome_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable CarregarGridProduto(string produto)
        {
            string query = $"SELECT produto.codigo_produto 'Cod', produto.nome_produto 'produto', categoria.nome_categoria 'Categoria', produto.quantidade_estoque 'Estoque', IF( produto.status_promocao = 0, produto.preco_venda, produto.preco_promocao) 'Valor' FROM produto JOIN categoria ON categoria.codigo_categoria = produto.codigo_categoria WHERE produto.status_produto = 1 AND produto.nome_produto LIKE '%{produto}%' AND produto.quantidade_estoque > 0 ORDER BY produto.nome_produto";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public string BuscarNomeProd(int cod)
        {
            string query = $"SELECT nome_produto FROM produto WHERE codigo_produto = {cod}";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(query);
            if (dt.Rows.Count > 0)
            {
                nome_produto = dt.Rows[0]["nome_produto"].ToString();
            }
            return nome_produto;
        }

        public bool AtualizarEstoque(int qtde, int cod)
        {
            string query = $"UPDATE produto SET quantidade_estoque = {qtde} WHERE codigo_produto = {cod}";

            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(query);

            if(resp == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

