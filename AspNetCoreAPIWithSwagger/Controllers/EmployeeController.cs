using AspNetCoreAPIWithSwagger.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCoreAPIWithSwagger.Controllers
{
    /// <summary>
    /// All the endpoints related to the Employee entity
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// This will return all the employees, Currently serving from an inmemory collection for the testability.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           var employees = new List<Employee>()
            {
               new Employee(){Id = 1, Name = "Hope",City="Mistic Falls"},
               new Employee(){Id=2,Name="Lucy",City="Mistic Falls"},
               new Employee(){Id=3,Name="Amanda",City="Jacksonville"}
            };
            return employees;
        }
    }
}
