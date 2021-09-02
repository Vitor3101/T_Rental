﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_RentalWEB.API.Domains
{
    public class VeiculoDomain
    {
        public int idVeiculo { get; set; }
        public int idModelo { get; set; }
        public int idEmpresa { get; set; }
        public int idPlaca { get; set; }
        public EmpresaDomain NomeEmpresa { get; set; }
        public PlacaDomain NumeroPlaca { get; set; }
    }
}
