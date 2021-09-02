using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_RentalWEB.API.Domains;
using T_RentalWEB.API.Interfaces;
using T_RentalWEB.API.Repositories;

namespace T_RentalWEB.API.Controllers
{
    [Produces("Application/Json")]

    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IClienteRepository _clienteRepository { get; set; }

        public ClientesController()
        {
            _clienteRepository = new ClienteRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<ClienteDomain> listaClientes = _clienteRepository.ListarClientes();
            return Ok(listaClientes);
        }
        [HttpPost]
        public IActionResult Post(ClienteDomain novoCliente)
        {
            _clienteRepository.Cadastrar(novoCliente);
            return StatusCode(201);
        }
    }
}
