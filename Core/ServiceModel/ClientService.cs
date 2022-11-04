using Core.Interfaces;
using DataAccess.Interfaces;
using Entities;
using static Core.Helpers.Exceptions;

namespace Core.ServiceModel
{
    public class ClientService : IClientService
    {
        private readonly IClientMapper _clientMapper;
        public ClientService(IClientMapper clientMapper)
        {
            _clientMapper = clientMapper;
        }

        public async Task<bool> CreateClientAsync(Client client)
        {
            return await _clientMapper.CreateClientAsync(client);
        }

        public async Task<Client?> GetClientByCustomerNumberAsync(int customerNumber)
        {
            return await _clientMapper.GetClientByCustomerNumberAsync(customerNumber);
        }

        public async Task<bool> UpdateClientAsync(Client client)
        {
            return await _clientMapper.UpdateClientAsync(client);
        }

        public async Task<bool> DeleteClientAsync(int customerNumber)
        {
            Client? client = await _clientMapper.GetClientByCustomerNumberAsync(customerNumber);
            if (client == null)
                throw new UnprocessableEntity("customer doesn't exist");
            return await _clientMapper.DeleteClientAsync(client);
        }
    }
}