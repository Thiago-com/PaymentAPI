using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PaymentAPI.Exceptions;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.Entity
{
    [Table("TB_Venda")]
    public class Venda
    {
        [Key]
        public int ID { get; private set; }
        public List<Produto> Produtos { get; private set; }
        public StatusVenda StatusVenda { get; private set; }
        public DateTime DataVenda { get; private set; }
        public Vendedor Vendedor { get; private set; }

        public void AtualizarStatusVenda(StatusVenda novoStatus)
        {
            if (ValidaAtualizacaoStatus(novoStatus))
            {
                StatusVenda = novoStatus;
            }
        }

        private bool ValidaAtualizacaoStatus(StatusVenda novoStatus)
        {
           
            if( StatusVenda==0 && (novoStatus==(StatusVenda)1 || novoStatus==(StatusVenda)2))
            {
                return true;
            }
            else if(StatusVenda==(StatusVenda)1 && (novoStatus==(StatusVenda)2 ||novoStatus==(StatusVenda)3))
            {
                return true;
            }else if (StatusVenda ==(StatusVenda)3 && novoStatus==(StatusVenda)4)
            {
                return true;
            }
            throw new InvalidStatusUpdateException();
        }
    }
}
