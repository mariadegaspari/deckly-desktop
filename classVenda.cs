using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeckly
{
    class classVenda
    {
        public int codigo_venda { get; set; }
        public DateTime data_pedido { get; set; }
        public string forma_pagamento { get; set; }
        public decimal desconto { get; set; }
        public decimal valor_total { get; set; }
        public int codigo_cliente { get; set; }
        public int codigo_funcionario { get; set; }
        public bool CadastrarVenda()
        {
            string sql = $"INSERT INTO venda VALUES (0, NOW(), '{forma_pagamento}', '{desconto.ToString().Replace(",", ".")}', '{valor_total.ToString().Replace(",", ".")}', {codigo_cliente}, {codigo_funcionario}); SELECT LAST_INSERT_ID()";

            classConexao cConexao = new classConexao();

            codigo_venda = 0;
            codigo_venda = cConexao.ExecutaQueryID(sql);

            if(codigo_venda !=0)
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
