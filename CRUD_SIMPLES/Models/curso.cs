using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_SIMPLES.Models
{
    public class curso
    {   [Key]
        public int idCurso { get; set; }
        [Required(ErrorMessage = "Entre com o nome do curso")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Entre com a descrição do curso")]
        [DataType(DataType.MultilineText)] //
        public int Descrição {get; set;}
    }
}