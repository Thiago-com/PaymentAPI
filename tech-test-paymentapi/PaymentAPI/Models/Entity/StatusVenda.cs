using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PaymentAPI.Models.Entity
{
    public enum StatusVenda
    {
        [Description("Aguardando Pagamento")]
        AguardandoPagamento,
        [Description("Pagamento Aprovado")]
        PagamentoAprovado,
        [Description("Cancelada")]
        Cancelada,
        [Description("Enviado para transportadora")]
        EnviadoParaTransportadora,
        [Description("Entregue")]
        Entregue
    }
}
