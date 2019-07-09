using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) :
            base(clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetEspecialClient(IEnumerable<Client> clients)
        {
            return clients.Where(c => c.IsClientEspecial(c));
        }
    }
}
