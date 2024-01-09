using Customers.API.DAL;
using Customers.API.DAL.Repository.Interface;
using Customers.API.DAL.Entity;
using System.Net.Mime;

namespace Customers.API.DAL.Repository
{

    public class CustomerRepository : GenericReporitory<Customer>, ICustomerRepostitory
    {
        public CustomerRepository(DataContext context) : base(context)
        {

        }

        public Customer GetById(int Id)
        {
            var query = base.FilterBy(x => x.CustomerId.Equals(Id));
            return query.Any() ? query.Single() : new Customer();
        }
        public Customer GetByEmail(string email)
        {
            var query = base.FilterBy(x => x.Email.Equals(email));
            return query.Any() ? query.Single() : new Customer();
        }

    }
}