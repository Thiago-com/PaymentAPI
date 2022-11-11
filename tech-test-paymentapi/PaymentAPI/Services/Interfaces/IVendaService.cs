using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.DTO;

namespace PaymentAPI.Services.Interfaces
{
    public interface IVendaService
    {
        public VendaDTO GetByID(int id);
        public VendaDTO CreateVenda(CadastrarVendaDTO vendaDTO);
        
        public VendaDTO UpdateVenda(int id,AtualizaVendaDTO vendaDTO);
    }
}
