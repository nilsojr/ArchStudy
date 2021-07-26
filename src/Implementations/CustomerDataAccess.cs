using ArchStudy.Interfaces;

namespace ArchStudy.Implementations
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
            
        }

        public string GetCustomerName(int id)
        {
            return "The Customer Name";
        }
    }
}