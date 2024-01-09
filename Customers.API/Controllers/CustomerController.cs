using Microsoft.AspNetCore.Mvc;
using Customers.API.BLL.DomainModels;
using Customers.API.BLL.Services.Interface;

namespace Customers.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly ICustomerService _srv;

    public CustomerController(ILogger<CustomerController> logger, ICustomerService srv)
    {
        _logger = logger;
        this._srv = srv;
    }

    [HttpPost, Route("[Action]")]
    public IEnumerable<CustomerModel> AddCustomer(CustomerModel model)
    {
        var results = new List<CustomerModel>();

        try
        {
            _srv.add(model);

            results = _srv.Get();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
        }

        return results;
    }

    [HttpPut, Route("[Action]")]
    public IActionResult UpdateCustomer(CustomerModel model)
    {
        try
        {
            _srv.Update(model);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);

            return NotFound();
        }
    }

    [HttpGet, Route("[Action]")]
    public IEnumerable<CustomerModel> GetCustomers()
    {
        var results = new List<CustomerModel>();

        try
        {
            results = _srv.Get();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
        }

        return results;
    }
}
