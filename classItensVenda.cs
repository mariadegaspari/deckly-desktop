using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeckly
{
    class classItensVenda
    {
        public int codigo_itensvenda { get; set; }
        public int quantidade_itens { get; set; }
        public decimal preco_unitario { get; set; }
        public decimal valor_total { get; set; }
        public int codigo_produto { get; set; }
        public int codigo_venda { get; set; } 

        public bool CadastrarItemVenda()
        {
            string sql = $"INSERT INTO itens_venda VALUES (0, {quantidade_itens}, '{preco_unitario.ToString().Replace(",", ".")}', '{valor_total.ToString().Replace(",", ".")}', {codigo_produto}, {codigo_venda})";

            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(sql);

            if(resp !=0 )
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
