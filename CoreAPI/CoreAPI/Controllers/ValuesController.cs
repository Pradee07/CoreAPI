using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreAPI.Models;
using Newtonsoft.Json;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IEmployee _employee { get; }


        public ValuesController(IEmployee employee) //Dependency Injection for Employee Concrete class
        {
            _employee = employee;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "from first method";
        }

        // GET api/values/second/5
        [HttpGet("second/{id:int}")]
        public string GetSecond(int id)
        {
            return "from second method";
        }

        // GET api/values/third/5
        [HttpGet("third/{id:int}")]
        public string GetThird(int id)
        {
            return "from third method";
        }

       //POST  api/Values
       [HttpPost]
        public void Post([FromBody] EmployeeDto employeeDto) //Alternatively we can inject  'IEmployee' instance as an action parameter instead of constructor injection
        {
            // Implement logic on employeeDto
            _employee.DoImpementaion(); //Mock
           var sObj = JsonConvert.SerializeObject(employeeDto);           
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
           
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
