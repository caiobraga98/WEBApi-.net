using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCursos.Models
{
    public class Curso
    { 
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O titulo precisa ser preenchido.")]
        [MaxLength(50)]
        public String Titulo { get; set; }

        public String Url { get; set; }
        [Required(ErrorMessage = "a data de publicação deve ser preenchida")]
        public DateTime datapublicacao { get; set; }
        [Required(ErrorMessage = "campo requirido")]
        [Range(1,1000)]
        public int CargaHoraria { get; set; }
    }
}