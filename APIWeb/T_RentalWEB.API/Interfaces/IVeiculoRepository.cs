using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_RentalWEB.API.Domains;

namespace T_RentalWEB.API.Interfaces
{
    interface IVeiculoRepository
    {
        List<VeiculoDomain> ListarVeiculos();
        VeiculoDomain BuscarPeloId(int idVeiculo);
        void Cadastrar(VeiculoDomain novoVeiculo);
        void AtualizarPeloIdUrl(VeiculoDomain veiculoAtualizado);
        void DeletarVeiculoPorId(int idVeiculo);
    }
}
