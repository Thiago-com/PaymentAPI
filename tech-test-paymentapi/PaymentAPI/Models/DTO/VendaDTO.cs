using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.Entity;
namespace PaymentAPI.Models.DTO
{
    public class VendaDTO
    {
        public int ID { get; private set; }
        public List<ProdutoDTO> Produtos { get; private set; }
        public StatusVenda StatusVenda { get; private set; }
        public DateTime DataVenda { get; private set; }
        public VendedorDTO Vendedor { get; private set; }

        public VendaDTO(int id, List<ProdutoDTO>produtos, StatusVenda statusVenda, DateTime dataVenda, VendedorDTO vendedor)
        {
            ID = id;
            Produtos = produtos;
            StatusVenda = statusVenda;
            DataVenda = dataVenda;
            Vendedor = vendedor;
        }

        public VendaDTO()
        {

        }
    }
}
