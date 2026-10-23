using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDeckly
{
    class classMarca
    {
        //CONSTRURTOR DA CLASSE: INICIALIZAR TODAS AS PROPRIEDADES DA CLASSE
        //O MÉTODO CONSTRUTOR PRECISA TER O MESMO NOME DA CLASSE
        public classMarca()
        {
            codigo_marca = 0;
            nome_marca = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //PROPRIEDADES: LER, ARMAZENAR E CALCULAR OS DADOS QUE SERÃO ENVIADOS OU RETORNADOS DO BD
        //MESMO NOME E TIPO DE DADO DOS CAMPOS DO BD
        //ATALHO PARA CRIAR PROPRIEDADE NO C#: PROP TAB TAB

        public int codigo_marca { get; set; }
        public string nome_marca { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
        

        public int CadastrarMarca()
        {
            string sql = $"INSERT INTO marca VALUES(0, '{nome_marca}', '{observacao}', NOW(), 1); ";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarComboMarca()
        {
            string sql = "SELECT codigo_marca, nome_marca FROM marca WHERE status_marca = 1 ORDER BY nome_marca;";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE MARCA POR NOME(CONTÉM)
        public DataTable ConsMarNomeContem(string nomec)
        {
            string sql = $"SELECT marca.codigo_marca 'Código da marca', marca.nome_marca 'Marca', marca.observacao 'Observação', marca.data_cadastro 'Data de cadastro', marca.status_marca 'Status' FROM marca WHERE marca.status_marca = 1 AND marca.nome_marca LIKE '%{nomec}%' ORDER BY marca.nome_marca;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE MARCA POR STATUS
        public DataTable ConsMarStatus(int status)
        {
            string sql = $"SELECT marca.codigo_marca 'Código da marca', marca.nome_marca 'Marca', marca.observacao 'Observação', marca.data_cadastro 'Data de cadastro', marca.status_marca 'Status' FROM marca WHERE marca.status_marca = '{status}' ORDER BY marca.nome_marca";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }

        public bool DadosMarca(int codigo)
        {
            string sql = $"SELECT * FROM marca WHERE codigo_marca = {codigo};";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            //SE A CONSULTA RETORNOU DADOS
            if (dt.Rows.Count > 0)
            {
                codigo_marca = Convert.ToInt32(dt.Rows[0]["codigo_marca"]);
                nome_marca = Convert.ToString(dt.Rows[0]["nome_marca"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["status_marca"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        public int AtualizarMarca()
        {
            string sql = $"UPDATE marca SET nome_marca = '{nome_marca}', observacao = '{observacao}', status_marca = {status} WHERE codigo_marca = {codigo_marca};";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        public int ExcluirMarca()
        {
            string sql = $"DELETE FROM marca WHERE codigo_marca = {codigo_marca}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }
    }
}
