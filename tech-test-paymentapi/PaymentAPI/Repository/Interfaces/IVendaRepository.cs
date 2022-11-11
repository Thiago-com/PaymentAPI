using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.Entity;

namespace PaymentAPI.Repository.Interfaces
{
    public interface IVendaRepository
    {
        public Venda GetByID(int id);
        public Venda CreateVenda(Venda venda);
        public Venda UpdateVenda(Venda venda);
    }
}
