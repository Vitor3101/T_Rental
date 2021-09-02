using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_RentalWEB.API.Domains;
using T_RentalWEB.API.Interfaces;

namespace T_RentalWEB.API.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        public void AtualizarPeloId(AluguelDomain aluguelAtualizado)
        {
            throw new NotImplementedException();
        }

        public AluguelDomain BuscarPorId(int idAluguel)
        {
            throw new NotImplementedException();
        }

        public void CadastrarAluguel(AluguelDomain novoAluguel)
        {
            throw new NotImplementedException();
        }

        public void DeletarPeloId(int idAluguel)
        {
            throw new NotImplementedException();
        }

        public List<AluguelDomain> ListarAlugueis()
        {
            throw new NotImplementedException();
        }
    }
}
