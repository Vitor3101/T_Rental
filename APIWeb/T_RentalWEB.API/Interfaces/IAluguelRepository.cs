using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_RentalWEB.API.Domains;

namespace T_RentalWEB.API.Interfaces
{
    interface IAluguelRepository
    {
        List<AluguelDomain> ListarAlugueis();
        AluguelDomain BuscarPorId(int idAluguel);
        void CadastrarAluguel(AluguelDomain novoAluguel);
        void AtualizarPeloId(AluguelDomain aluguelAtualizado);
        void DeletarPeloId(int idAluguel);
    }
}
