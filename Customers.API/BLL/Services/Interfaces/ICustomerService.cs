using Customers.API.BLL.DomainModels;

namespace Customers.API.BLL.Services.Interface
{
    public interface ICustomerService
    {
        void GetById(Guid Id);
        void GetByEmail(string email);
        
        List<CustomerModel> Get();
        void add(CustomerModel model);
        void Update(CustomerModel model);
        void Delete(int Id);
    }
}