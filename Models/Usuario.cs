using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RifugoApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

       
        public string Nome { get; set; }

       
        public string Telefone { get; set; }

       
        public string Email { get; set; }
    }
}
