using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_RentalWEB.API.Domains
{
    public class ClienteDomain
    {
        public int idCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int CPF { get; set; }
    }
}
