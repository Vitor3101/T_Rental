using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_RentalWEB.API.Domains
{
    public class ModeloDomain
    {
        public int idModelo { get; set; }
        public int idMarca { get; set; }
        public string NomeModelo { get; set; }
        public MarcaDomain NomeMarca { get; set; }
    }
}
