using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarrosMonitoria.Models
{
    public class CadastrarCarro
    {
        [Key]
        [Required]
        public int Id_Carro { get; set; }
        [Required]
        public string Nome_Carro { get; set; }
        [Required]
        public string Preco { get; set; }
        [Required]
        public int Ano { get; set; }
        public virtual List<Comprar> Comprar { get; set; }
    }
}
