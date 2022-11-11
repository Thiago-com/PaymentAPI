using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.DTO
{
    public class ProdutoDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public ProdutoDTO(int id, string nome, int quantidade)
        {
            ID = id;
            Nome = nome;
            Quantidade = quantidade;
        }

        public ProdutoDTO()
        {

        }
    }
}
