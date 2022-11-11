using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.DTO
{
    public class CadastrarProdutoDTO
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public CadastrarProdutoDTO(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
        public CadastrarProdutoDTO()
        {

        }
    }
}
