using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Models.DTO;

namespace PaymentAPI.Services.Interfaces
{
    interface IValidaQuantidadeProduto
    {
       void ValidaQuantidadeProduto(CadastrarVendaDTO vendaDTO);
    }
}
