using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDeckly
{
    class classCategoria
    {
        //CONSTRURTOR DA CLASSE: INICIALIZAR TODAS AS PROPRIEDADES DA CLASSE
        //O MÉTODO CONSTRUTOR PRECISA TER O MESMO NOME DA CLASSE
        public classCategoria()
        {
            codigo_categoria = 0;
            nome_categoria = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        public int codigo_categoria { get; set; }
        public string nome_categoria{ get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public int CadastrarCategoria()
        {
            string sql = $"INSERT INTO categoria VALUES(0, '{nome_categoria}', '{observacao}', NOW(), 1); ";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarComboCategoria()
        {
            string sql = "SELECT codigo_categoria, nome_categoria FROM categoria WHERE status_categoria = 1 ORDER BY nome_categoria;";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE CATEGORIA POR STATUS
        public DataTable ConsCatStatus(int status)
        {
            string sql = $"SELECT categoria.codigo_categoria 'Código categoria', categoria.nome_categoria 'Categoria', categoria.observacao 'Observação', categoria.data_cadastro 'Data de cadastro', categoria.status_categoria FROM categoria WHERE categoria.status_categoria = '{status}' ORDER BY categoria.nome_categoria;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE CATEGORIA POR NOME(CONTÉM)
        public DataTable ConsCatNomeContem(string nomec)
        {
            string sql = $"SELECT categoria.codigo_categoria 'Código categoria', categoria.nome_categoria 'Categoria', categoria.observacao 'Observação', categoria.data_cadastro 'Data de cadastro', categoria.status_categoria 'Status' FROM categoria WHERE categoria.status_categoria = 1 AND categoria.nome_categoria LIKE '%{nomec}%' ORDER BY categoria.nome_categoria;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }


        public bool DadosCategoria(int codigo)
        {
            string sql = $"SELECT * FROM categoria WHERE codigo_categoria = {codigo};";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            //SE A CONSULTA RETORNOU DADOS
            if (dt.Rows.Count > 0)
            {
                codigo_categoria = Convert.ToInt32(dt.Rows[0]["codigo_categoria"]);
                nome_categoria = Convert.ToString(dt.Rows[0]["nome_categoria"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["status_categoria"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        public int AtualizarCategoria()
        {
            string sql = $"UPDATE categoria SET nome_categoria = '{nome_categoria}', observacao = '{observacao}', status_categoria = {status} WHERE codigo_categoria = {codigo_categoria};";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        public int ExcluirCategoria()
        {
            string sql = $"DELETE FROM categoria WHERE codigo_categoria = {codigo_categoria}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

    }

}
