using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Exceptions
{
    public class InvalidStatusUpdateException: Exception
    {
        public override string Message => "Atualização de status inválida!";
    }
}
