using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.DTO
{
    public class VendedorDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public VendedorDTO(int id, string nome, string cpf,string email, string telefone)
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
        }

        public VendedorDTO()
        {

        }
    }
}
