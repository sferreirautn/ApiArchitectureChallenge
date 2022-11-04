using Core.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace CargoProduceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        /// <summary>
        /// Create a new customer
        /// </summary>
        /// <param name="client"></param>
        [HttpPost("CreateClientAsync")]
        public async Task<IActionResult> CreateClientAsync(Client client)
        {
            bool created = await _clientService.CreateClientAsync(client);
            return Ok(created);
        }

        /// <summary>
        /// search client by Customer Number. For example 102
        /// </summary>
        /// <param name="customerNumber"></param>
        /// <returns></returns>
        [HttpGet("GetClientByCustomerNumberAsync")]
        public async Task<ActionResult<Client?>> GetClientByCustomerNumberAsync(int customerNumber)
        {
            return await _clientService.GetClientByCustomerNumberAsync(customerNumber);
        }

        /// <summary>
        /// Update customer data
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPut("UpdateClientAsync")]
        public async Task<ActionResult> UpdateClientAsync(Client client)
        {
            bool result = await _clientService.UpdateClientAsync(client);
            return Ok(result);
        }

        /// <summary>
        /// Delete a customer
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpDelete("DeleteClientAsync")]
        public async Task<ActionResult> DeleteClientAsync(int customerNumber)
        {
            bool result = await _clientService.DeleteClientAsync(customerNumber);
            return Ok(result);
        }
    }
}