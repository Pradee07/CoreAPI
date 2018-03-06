using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Models
{
    public interface IEmployee
    {
        void DoImpementaion(); //Mock method
    }
    public class Employee : IEmployee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public void DoImpementaion()
        {
            //Implementation 
        }
    }

    public class EmployeeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }        
    }
}
