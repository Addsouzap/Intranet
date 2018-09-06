using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } 
        public string Email { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }
       
    }
}