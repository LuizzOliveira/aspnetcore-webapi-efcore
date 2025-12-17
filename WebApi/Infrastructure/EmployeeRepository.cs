using WebApi.Model;

namespace WebApi.Infrastructure
{
    public class EmployeeRepository(ConectionContext context) : IEmployeeRepository
    {
        private readonly ConectionContext _context = context;

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }
    }
}
