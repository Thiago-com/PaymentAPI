using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.Entity
{
    [Table("TB_Vendedor")]
    public class Vendedor
    {
        [Key]
        public int ID { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public string CPF { get; private set; }
        [Required]
        public string Email { get; private set; }
        [Required]
        public string Telefone { get; private set; }
    }
}
