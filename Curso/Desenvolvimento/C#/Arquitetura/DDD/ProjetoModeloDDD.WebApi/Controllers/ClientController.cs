using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.WebApi.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    [Route("client")]
    public class ClientController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClientAppService _clientAppService;

        public ClientController(
            IMapper mapper,
            IClientAppService clientAppService)
        {
            _mapper = mapper;
            _clientAppService = clientAppService;
        }

        [HttpPost("")]
        public IActionResult Inserir([FromBody] ClientViewModel clientViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var client = _mapper.Map<ClientViewModel, Client>(clientViewModel);

            _clientAppService.InsertAsync(client);

            return Ok();
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEspecialClients([FromHeader] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var client = await _clientAppService.GetByIdAsync(id);

            var clientViewModel =
                    _mapper.Map<Client, ClientViewModel>(client);

            return Ok(clientViewModel);
        }

        [HttpGet("especial")]
        public async Task<IActionResult> GetEspecialClients()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var listClient = await _clientAppService.GetAllAsync();

            var listClientEspecial = _clientAppService.GetEspecialClient(listClient);

            var listClientViewModel = _mapper.Map<IEnumerable<Client>, List<ClientViewModel>>(listClientEspecial);

            return Ok(listClientViewModel);
        }

        [HttpPut("")]
        public async Task<IActionResult> Update([FromBody] ClientViewModel clientViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var client = _mapper.Map<ClientViewModel, Client>(clientViewModel);

            await _clientAppService.UpdateAsync(client);

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _clientAppService.RemoveAsync(
                await _clientAppService.GetByIdAsync(id));

            return Ok();
        }
    }
}