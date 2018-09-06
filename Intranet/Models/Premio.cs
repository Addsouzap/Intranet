using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class Premio
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Indicados { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        public string Laureados { get; set; }
        public string Instituicao { get; set; }
        public string PR { get; set; }


       
    }
}