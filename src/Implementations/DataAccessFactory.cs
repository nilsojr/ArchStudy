using ArchStudy.Interfaces;

namespace ArchStudy.Implementations
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}