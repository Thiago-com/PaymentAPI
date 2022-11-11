using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Exceptions
{
    public class EmptyProductListException:Exception
    {
        public override string Message => "A venda não pode ser efetuada sem produtos!";
    }
}
