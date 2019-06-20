using System;
using System.Collections.Generic;
using System.Linq;
using ActionDemo;
using Clone;

namespace delegates
{
    // step 1
    public delegate void Print(int value);
    public class A
    {}
    public class B
    {}
    class Program
    {
        static void Main(string[] args)
        {
            

            // System Object
             A a = new A();             
             A a3 = a;
             var b = a.GetHashCode();
             B b5 = new B();
             var g5 = b5.GetHashCode();

             // Extention Method           
            a.GlobelExtention();

            var b1 = a.GetType();
            var b2 = a.ToString();
            
            var flag = a.Equals(a3);

            // Palindrom 
            Palindrome.IsPalindrom("MALAYALAM");
            // Number and Count
            FindNumberCount();

            //Shallow Copy
            
            Person obj = new Person();
            obj.age = 30;

            Clone.Employee objEmpSalary = new Clone.Employee(1000);
            obj.objEmp = objEmpSalary;
            
            //ShallowCopy obj2 = obj.ShallowCopyClass(obj);
            Person obj2 = obj.CreateDeepCopy(obj);
            
            objEmpSalary.Salary = 3000;
                       
            Console.WriteLine(obj.objEmp.Salary);
            Console.WriteLine(obj2.objEmp.Salary);

            // Maximum Employee Salry based on department
            EmployeeMaster();

            // Null for String and Date
            string abc = null;
            DateTime dob = new DateTime();
            Console.WriteLine( abc == null ? "Mahesh" : abc);
            Console.WriteLine( dob == null ? "Mahesh" : dob.ToString());

            // Expando Object
            dynamic user = new System.Dynamic.ExpandoObject();
            user.Name = "John Doe";
            user.Age = 42;
            user.HomeTown = "New York";
            Console.WriteLine(user.Name + " is " + user.Age + " years old and lives in " + user.HomeTown);

            
            /// <summary>
            /// Action
            /// </summary>
            /// <returns></returns>
            
            ActionTest objAction = new ActionTest();
            objAction.FindSalary();

            Console.WriteLine("Delegate");
            Print printDel = PrintNumber;
            printDel += PrintMoney;
            printDel(2000);

            //................................................................

            Console.WriteLine("Action");
            Action<int> action = PrintNumber;
            action += PrintMoney;
            action(3000);

            //................................................................
            
            Action<int> action1 = (num) => {
                Console.WriteLine("Number: {0,-12:N0}", num);
            };
            action1(2500);

            Console.WriteLine("Func");
            Func<int, double> func = new Func<int, double>(CalculateHra);
            Console.WriteLine(func(2500).ToString());

            Print print = delegate(int val) { 
                Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
            };
            Print printn = (val) => { 
                Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
            };                                
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}",num);
        }
        public static void PrintMoney(int money)
        {
             Console.WriteLine("Money: {0:C}", money);
        }
        static double CalculateHra(int basic)
        {
            return (double)(basic * .4);
        }
        public static void EmployeeMaster()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee { empId = 1, Deptid= 1, Salary= 70000  });
            empList.Add(new Employee { empId = 2, Deptid= 1, Salary= 20000  });
            empList.Add(new Employee { empId = 3, Deptid= 1, Salary= 80000  });

            empList.Add(new Employee { empId = 4, Deptid= 2, Salary= 40000  });
            empList.Add(new Employee { empId = 5, Deptid= 2, Salary= 50000  });
            empList.Add(new Employee { empId = 6, Deptid= 2, Salary= 90000  });

            var abg = empList.Where(z=>z.Salary>100).ToList();

            // 1 1 80000
            // 1 2 90000

            var result = empList.GroupBy(x => x.Deptid).Select(a=> new {      
                empId = a.Where(x=> x.Salary ==  a.Max(m => x.Salary)).FirstOrDefault().empId,        
                Deptid = a.Key,
                Salary = a.Max(x => x.Salary)
            }).ToList();

            foreach(var a in result)
            {
                
            }

            var highest =   from e in empList
                            group e by e.Deptid into dptgrp
                            let topsal = dptgrp.Max(x => x.Salary)
                            select new
                            {
                                Dept = dptgrp.Key,
                                EmpId = dptgrp.First(y => y.Salary == topsal).empId,
                                MaximumSalary = topsal
                            };


        }
        public static void FindNumberCount()
        {
            int[] num = { 10, 20, 30, 40, 10, 10, 20, 30 };
            var dict = new Dictionary<int,int>();
            foreach(var key in num)
            {
                if(dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    dict[key] = 1;  
                }
            }
            foreach(var pair in dict)  
            Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);  
        }

    }

    public class Employee
    {
        public int empId { get; set; }
        public int Deptid { get; set; }
        public int Salary { get; set; }
    }
}
