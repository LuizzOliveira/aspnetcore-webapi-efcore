using Microsoft.AspNetCore.Mvc;
using WebApi.Infrastructure;
using WebApi.Model;
using WebApi.ViewModel;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class EmployeeController(IEmployeeRepository repository) : ControllerBase
{
    private readonly IEmployeeRepository _employee = repository;

    [HttpPost]
    public IActionResult Add(EmployeerViewModel employeeView)
    {
        var employee = new Employee(employeeView.Name, employeeView.Age, null);
       _employee.Add(employee);
        return Ok();
    }

    [HttpGet]
    public IActionResult Get()
    {
        var employee = _employee.Get();
        return Ok(employee);
    }
}
