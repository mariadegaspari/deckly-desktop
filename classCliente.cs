using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDeckly
{
    class classCliente
    {
        //CONSTRUTOR
        public classCliente()
        {
            codigo_cliente = 0;
            nome = null;
            nome_social = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            cpf = null;
            rg = null;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            telefone_celular = null;
            email = null;
            data_cadastro = DateTime.Now;
            status = 0;

        }

        //PROPRIEDADES
        public int codigo_cliente { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string telefone_celular { get; set; }
        public string email { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        //CADASTRAR CLIENTE
        public int CadastrarCliente()
        {
            string sql = $"INSERT INTO cliente VALUES(0, '{nome}', '{nome_social}', '{data_nascimento.ToString("yyyy/MM/dd")}', '{sexo}', '{cpf}', '{rg}', '{endereco}', {numero}, '{complemento}', '{bairro}', '{cidade}', '{estado}', '{cep}', '{telefone_celular}', '{email}',  Now(), 1)";


            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);

        }

        //MÉTODO PARA CARREGAR AS CIDADES CADASTRADAS NA TABELA CLIENTE NO FORM DE CONSULTA
        public DataTable CarregarComboCidade()
        {
            string sql = "SELECT DISTINCT cidade FROM cliente WHERE status = 1 ORDER BY cidade ;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliNomeInicio(string nomei)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND IF(cliente.nome_social != '', cliente.nome_social LIKE '{nomei}%', cliente.nome LIKE '{nomei}%') ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliNomeContem(string nomec)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND IF(cliente.nome_social != '', cliente.nome_social LIKE '%{nomec}%', cliente.nome LIKE '%{nomec}%') ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliSexo(string sexo)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND cliente.sexo = '{sexo}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliCidade(string cidade)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '{cidade}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliCidade2(string cidade, string sexo)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '{cidade}' AND cliente.sexo = '{sexo}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliCpf(string cpf)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND cliente.cpf = '{cpf}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliDataAdmissao(DateTime datai, DateTime dataf)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = 1 AND CAST(cliente.data_cadastro AS DATE) BETWEEN '{datai.ToString("yyyy-MM-dd")}' AND '{dataf.ToString("yyyy-MM-dd")}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable ConsCliStatus(int status)
        {
            string sql = $"SELECT cliente.codigo_cliente, IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'Nome', cliente.cpf 'CPF', cliente.data_nascimento 'Nascimento', cliente.sexo 'Sexo', cliente.cidade 'Cidade', cliente.telefone_celular 'Celular' FROM cliente WHERE cliente.status = '{status}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome);";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //MÉTODO PARA BUSCAR TODOS OS DADOS DO FUNCIONÁRIO SELECIONADO PELO USUÁRIO NO FORM DE CONSULTA
        public bool DadosCliente(int codigo)
        {
            string sql = $"SELECT * FROM cliente WHERE codigo_cliente = {codigo};";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            //SE A CONSULTA RETORNOU DADOS
            if (dt.Rows.Count > 0)
            {
                //EXIBIR TODOS OS CAMPOS DA TABELA FUNCIONÁRIO
                codigo_cliente = Convert.ToInt32(dt.Rows[0]["codigo_cliente"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                telefone_celular = Convert.ToString(dt.Rows[0]["telefone_celular"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);

                return true;
            }

            else
            {
                return false;
            }

        }

        //MÉTODO PARA ATUALIZAR FUNCIONARIO
        public int AtualizarCliente()
        {
            string sql = $"UPDATE cliente SET nome = '{nome}', nome_social = '{nome_social}', data_nascimento = '{data_nascimento.ToString("yyyy/MM/dd")}', sexo ='{sexo}',  cpf = '{cpf}', rg = '{rg}', endereco = '{endereco}', numero = {numero}, complemento = '{complemento}', bairro = '{bairro}', cidade = '{cidade}', estado = '{estado}', cep = '{cep}', telefone_celular = '{telefone_celular}', email = '{email}', status = {status} WHERE codigo_cliente = {codigo_cliente};";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }


        //MÉTODO PARA EXCLUIR FUNCIONARIO
        public int ExcluirCliente()
        {
            string sql = $"DELETE FROM cliente WHERE codigo_cliente = {codigo_cliente}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        public DataTable RelCliIdade(int idade1, int idade2)
        {
            string sql = $"SELECT IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'nome', cliente.cpf, cliente.data_nascimento, cliente.sexo, cliente.cidade, cliente.telefone_celular, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND TIMESTAMPDIFF(YEAR, cliente.data_nascimento, NOW()) BETWEEN {idade1} AND {idade2} ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome)";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelCliStatus(int status)
        {
            string sql = $"SELECT IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'nome', cliente.cpf, cliente.data_nascimento, cliente.sexo, cliente.cidade, cliente.telefone_celular, cliente.data_cadastro FROM cliente WHERE cliente.status = {status} ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome)";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelCliSexo(string sexo)
        {
            string sql = $"SELECT IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'nome', cliente.cpf, cliente.data_nascimento, cliente.sexo, cliente.cidade, cliente.telefone_celular, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND cliente.sexo = '{sexo}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome)";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelCliCidade(string cidade)
        {
            string sql = $"SELECT IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'nome', cliente.cpf, cliente.data_nascimento, cliente.sexo, cliente.cidade, cliente.telefone_celular, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '{cidade}' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome)";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable RelCliMesNiver(int mes)
        {
            string sql = $"SELECT IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'nome', cliente.cpf, cliente.data_nascimento, cliente.sexo, cliente.cidade, cliente.telefone_celular, cliente.data_cadastro FROM cliente WHERE cliente.status = 1 AND MONTH(cliente.data_nascimento) = {mes} ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome)";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //MÉTODO VENDA
        public DataTable CarregarGridCliente(string nomec)
        {
            string query = $"SELECT codigo_cliente'Cod', IF(cliente.nome_social != '', cliente.nome_social, cliente.nome) 'nome', cpf 'CPF' FROM cliente WHERE status = 1 AND cliente.nome LIKE '%{nomec}%' ORDER BY IF(cliente.nome_social != '', cliente.nome_social, cliente.nome)";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
    }


}
