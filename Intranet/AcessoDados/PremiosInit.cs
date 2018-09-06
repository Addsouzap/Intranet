using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Intranet.AcessoDados
{
    public class PremiosInit : CreateDatabaseIfNotExists<PremioContexto>

    {
        protected override void Seed(PremioContexto context)
        {

            List<Premio> premios = new List<Premio>()
                    {
                new Premio() {
                            Nome = "Prêmio Bunge 2016",
                            Data = DateTime.Now,
                            Indicados= "Ennio Marques Palmeira",
                            Laureados="José Vicente Caixeta Filho",
                            Instituicao="ESALQ/Universidade de São Paulo",
                            PR=null

                } };
        }
    }
}