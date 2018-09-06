using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Ramal { get; set; }
        public string Celular { get; set; }
        
        public DateTime DataNasc { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }


    }
}