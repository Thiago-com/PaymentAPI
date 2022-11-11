using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.Entity;

namespace PaymentAPI.Models.DTO
{
    public class CadastrarVendaDTO
    {
        public List<CadastrarProdutoDTO> Produtos { get; set; }
        public DateTime? DataVenda { get; set; }
        public CadastrarVendedorDTO Vendedor { get; set; }

        public CadastrarVendaDTO(List<CadastrarProdutoDTO> produtos, CadastrarVendedorDTO vendedor, DateTime? dataVenda)
        {
            Produtos = produtos;
            DataVenda = dataVenda;
            Vendedor = vendedor;
        }
        public CadastrarVendaDTO()
        {

        }
    }
}
