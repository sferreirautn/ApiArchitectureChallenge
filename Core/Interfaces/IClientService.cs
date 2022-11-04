using Entities;

namespace Core.Interfaces
{
    public interface IClientService
    {
        Task<bool> CreateClientAsync(Client client);

        Task<Client?> GetClientByCustomerNumberAsync(int customerNumber);

        Task<bool> UpdateClientAsync(Client client);

        Task<bool> DeleteClientAsync(int customerNumber);
    }
}