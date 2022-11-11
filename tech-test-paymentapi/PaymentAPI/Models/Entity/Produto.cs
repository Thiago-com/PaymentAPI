using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.Entity
{
    [Table("TB_Produto")]
    public class Produto
    {
        
        [Key]
        public int ID { get; private set; }
        [Required]
        public string Nome { get; private set; }

        public int Quantidade { get; private set; }

    }
}
