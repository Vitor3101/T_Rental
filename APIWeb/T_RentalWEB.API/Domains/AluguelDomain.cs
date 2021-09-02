using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_RentalWEB.API.Domains
{
    public class AluguelDomain
    {
        public int idAluguel { get; set; }
        public int idCliente { get; set; }
        public int idVeiculo { get; set; }
        public ClienteDomain Nome { get; set; }
        public ClienteDomain Sobrenome { get; set; }
        public string DataRetirada { get; set; }
        public string DataEntrega { get; set; }
    }
}
