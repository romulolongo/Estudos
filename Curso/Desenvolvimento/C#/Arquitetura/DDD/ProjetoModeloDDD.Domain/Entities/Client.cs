using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> Products { get; set; }

        public bool IsClientEspecial(Client client)
        {
            return client.IsActive && DateTime.Now.Date.Year - client.DateRegister.Year >= 5;
        }
    }
}
