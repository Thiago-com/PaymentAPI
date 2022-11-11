using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Exceptions
{
    public class VendaNotFoundException: Exception
    {
        public override string Message => "Venda não encontrada!";
    }
}
