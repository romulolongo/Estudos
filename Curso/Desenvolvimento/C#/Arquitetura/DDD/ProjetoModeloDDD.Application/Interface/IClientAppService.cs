using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IClientAppService: IAppServiceBase<Client>
    {
        IEnumerable<Client> GetEspecialClient(IEnumerable<Client> clients);
    }
}
