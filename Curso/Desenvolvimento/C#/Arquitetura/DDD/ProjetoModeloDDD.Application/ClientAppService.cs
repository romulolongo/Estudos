using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _clientService;

        public ClientAppService(IClientService clientService)
            : base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> GetEspecialClient(IEnumerable<Client> clients)
        {
            return _clientService.GetEspecialClient(clients);
        }
    }
}
