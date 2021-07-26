using System.Threading;
using System.Threading.Tasks;
using ArchStudy.Implementations;
using Microsoft.Extensions.Hosting;

namespace ArchStudy.Services
{
    public class CustomerService : BackgroundService
    {
        CustomerBusinessLogic _customerBusinessLogic;

        public CustomerService()
        {
            _customerBusinessLogic = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public async Task GetCustomerName(int id)
        {
            _customerBusinessLogic.ProcessCustomerData(id);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await GetCustomerName(1);
        }
    }
}