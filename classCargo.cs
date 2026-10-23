using System;
using System.Data;

namespace SistemaDeckly
{
    class classCargo
    {
        //CONSTRURTOR DA CLASSE: INICIALIZAR TODAS AS PROPRIEDADES DA CLASSE
        //O MÉTODO CONSTRUTOR PRECISA TER O MESMO NOME DA CLASSE
        public classCargo()
        {
            codigo_cargo = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //PROPRIEDADES: LER, ARMAZENAR E CALCULAR OS DADOS QUE SERÃO ENVIADOS OU RETORNADOS DO BD
        //MESMO NOME E TIPO DE DADO DOS CAMPOS DO BD
        //ATALHO PARA CRIAR PROPRIEDADE NO C#: PROP TAB TAB

        public int codigo_cargo { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }

        //MÉTODOS: FUNCIONALIDADES DO SISTEMA
        //CRIAR MÉTODO: ENCAPSULAMENTO (PUBLIC/PRIVATE), TIPO DE RETORNO DO MÉTODO (INT/ STRING/ DATATABLE), NOME DO MÉTODO, PARÂMETROS () - CONDIÇÕES

        //MÉTODO PARA CADASTRAR CARGO
        public int CadastrarCargo ()
        {
            //VARIÁVEL STRING PARA ESCREVER O COMANDO QUE O MÉTODO IRÁ EXECUTAR
            //USANDO INTERPOLAÇÃO DE STRING $ {} - CONCATENAÇÃO
            string sql = $"INSERT INTO cargo VALUES(0, '{nome}', '{observacao}', NOW(), 1 ); ";


            //CRIAR O OBJETO DA CLASSE CONEXÃO PARA USAR O MÉTODO QUE VAI EXECUTAR O COMANDO QUE ESCREVEMOS - MÉTODO EXECUTAQUERY()
            classConexao cConexao = new classConexao();

            //CHAMAR O MÉTODO DA CLASSE CONEXAO QUE VAI EXECUTAR O COMANDO
            //RETURN 0 SE DEU ERRO E 1 SE DER CERTO
            return cConexao.ExecutaQuery(sql);
        }

        //MÉTODO PARA CARREGAR OS CARGOS NO FOMULÁRIO DE FUNCIONÁRIO
        public DataTable CarregarComboCargo()
        {
            string sql = "SELECT codigo_cargo, nome FROM cargo WHERE status = 1 ORDER BY nome;";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE CARGO POR NOME(CONTÉM)
        public DataTable ConsCarNomeContem(string nomec)
        {
            string sql = $"SELECT cargo.codigo_cargo 'Código do cargo', cargo.nome 'Cargo', cargo.observacao 'Observação', cargo.data_cadastro 'Data de cadastro', cargo.status 'Status' FROM cargo WHERE cargo.status = 1 AND cargo.nome LIKE '%{nomec}%' ORDER BY cargo.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //CONSULTA DE CARGO POR STATUS
        public DataTable ConsCarStatus(int status)
        {
            string sql = $"SELECT cargo.codigo_cargo 'Código do cargo', cargo.nome 'Cargo', cargo.observacao 'Observação', cargo.data_cadastro 'Data de cadastro', cargo.status FROM cargo WHERE cargo.status = '{status}' ORDER BY cargo.nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public bool DadosCargo (int codigo)
        {
            string sql = $"SELECT * FROM cargo WHERE codigo_cargo = {codigo};";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            //SE A CONSULTA RETORNOU DADOS
            if (dt.Rows.Count > 0)
            {
                codigo_cargo = Convert.ToInt32(dt.Rows[0]["codigo_cargo"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        public int AtualizarCargo()
        {
            string sql = $"UPDATE cargo SET nome = '{nome}', observacao = '{observacao}', status = {status} WHERE codigo_cargo = {codigo_cargo};";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        //MÉTODO PARA EXCLUIR CARGO
        public int ExcluirCargo()
        {
            string sql = $"DELETE FROM cargo WHERE codigo_cargo = {codigo_cargo}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }
    }
}
