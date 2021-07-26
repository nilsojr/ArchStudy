using ArchStudy.Interfaces;

namespace ArchStudy.Implementations
{
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _customerDataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }

        public void ProcessCustomerData(int id)
        {
            System.Console.WriteLine(_customerDataAccess.GetCustomerName(id));
        }
    }
}