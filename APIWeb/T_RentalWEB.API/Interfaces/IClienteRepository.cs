using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_RentalWEB.API.Domains;

namespace T_RentalWEB.API.Interfaces
{
    interface IClienteRepository
    {
        List<ClienteDomain> ListarClientes();
        ClienteDomain BuscarPeloId(int idCliente);
        void Cadastrar(ClienteDomain novoCliente);
        void AtualizarPeloIdUrl(ClienteDomain clienteAtualizado);
        void DeletarPeloId(int idCliente);

    }
}
