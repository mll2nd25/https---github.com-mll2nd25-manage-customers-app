using AutoMapper;
using Customers.API.BLL.Services.Interface;
using Customers.API.BLL.DomainModels;
using Customers.API.DAL;
using Customers.API.DAL.Interaces;
using Customers.API.DAL.Entity;
using Customers.API.DAL.Repository.Interface;

namespace Customers.API.BLL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepostitory _repo;
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper, ICustomerRepostitory repo)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        public void GetById(Guid Id)
        {

        }

        public void GetByEmail(string email)
        {

        }

        public List<CustomerModel> Get()
        {
            var result = Enumerable.Empty<CustomerModel>();

            try
            {
                var entity = _repo.Get();
                var model = _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerModel>>(entity);

                result = model;
            }
            catch (Exception ex)
            {

                //TODO
                //Log Error
                var msg = ex.Message;

            }

            return result.ToList();
        }

        public void add(CustomerModel model)
        {
            var entity = _mapper.Map<CustomerModel, Customer>(model);
            _repo.Insert(entity);
        }

        public void Update(CustomerModel model)
        {
            var entity = _mapper.Map<CustomerModel, Customer>(model);
            _repo.Update(entity);
        }

        public void Delete(int Id)
        {

        }
    }
}