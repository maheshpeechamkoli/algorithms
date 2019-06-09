using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionDemo {

    public delegate void Firm (int num);
    
    public class Employee
    {
        public int empId { get; set; }
        public int Deptid { get; set; }
        public int Salary { get; set; }
    }
    public class ActionTest {

        Action<int> action = delegate( int i) 
        {
            Console.WriteLine("Inside Anonymous method. Value: {0}", i.ToString());
        };
        // Action<int> action = (i)  =>
        // {
        //     Console.WriteLine("Inside Anonymous method. Value: {0}", i.ToString());
        // };

     // Firm delfirm = (i) => {Console.WriteLine("Inside Anonymous method. Value: {0}", i.ToString());};
        
        public void FindSalary()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { empId = 1, Deptid= 1, Salary= 70000  });
            empList.Add(new Employee { empId = 2, Deptid= 1, Salary= 20000  });
            empList.Add(new Employee { empId = 3, Deptid= 1, Salary= 80000  });

            empList.Add(new Employee { empId = 4, Deptid= 2, Salary= 40000  });
            empList.Add(new Employee { empId = 5, Deptid= 2, Salary= 50000  });
            empList.Add(new Employee { empId = 6, Deptid= 2, Salary= 90000  });

            Firmware obj = new Firmware();
            var employee = empList.Where(x => obj.FirmwareUpdate(x, action))  ;
        }
    }

    public class Firmware {
        public bool FirmwareUpdate (Employee emp, Action<int> act) 
        {
            if(emp.Salary >= 40000)
            {
                act(emp.Salary);
                return true;
            }
            return false;
        }
    }
}