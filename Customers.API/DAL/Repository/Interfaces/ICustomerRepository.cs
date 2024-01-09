using Customers.API.DAL.Interaces;
using Customers.API.DAL.Entity;

namespace Customers.API.DAL.Repository.Interface
{
    public interface ICustomerRepostitory : IGenericRepsoitory<Customer>
    {
        Customer GetById(int Id);
        Customer GetByEmail(string email);
    }
}