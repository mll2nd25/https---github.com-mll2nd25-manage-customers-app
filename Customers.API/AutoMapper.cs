using AutoMapper;
using Customers.API.BLL.DomainModels;
using Customers.API.DAL.Entity;

namespace Customers.API
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
        }
    }
}