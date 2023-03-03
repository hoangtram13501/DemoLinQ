using Demo123.Data;
using Demo123.Models;
using Demo123.Models.Domain;
//using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo123.Controllers
{
   
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public EmployeesController(MVCDemoDbContext mvcDemoDbContext) {
        this.mvcDemoDbContext = mvcDemoDbContext;
        }

            [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await mvcDemoDbContext.Employee.ToListAsync();
            return View(employees);
        }
            [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
                Department = addEmployeeRequest.Department

            };
            await mvcDemoDbContext.Employee.AddAsync(employee);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");

           


        }
        [HttpGet]
        public IActionResult View(Guid id)
        {
            var employee = mvcDemoDbContext.Employee.FirstOrDefaultAsync(x => x.Id == id);
            return View();
        }


    }
}
