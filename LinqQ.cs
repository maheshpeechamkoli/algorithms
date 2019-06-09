using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithams
{
    public class LinqQ
    {
        public void ListofEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() {
                Name = "Mahesh",
                DOB =  Convert.ToDateTime("05/01/1996")
            } );
            emplist.Add(new Employee() {
                Name = "Prnil",
                DOB =  Convert.ToDateTime("05/01/1997")
            } );
             emplist.Add(new Employee() {
                Name = "Rahul",
                DOB =  Convert.ToDateTime("05/01/1990")
            } );
            emplist.Add(new Employee() {
                Name = "Ram",
                DOB =  Convert.ToDateTime("05/01/1990")
            } );
             emplist.Add(new Employee() {
                Name = "Manu",
                DOB =  Convert.ToDateTime("05/01/1993")
            } );
             emplist.Add(new Employee() {
                Name = "maku",
                DOB =  Convert.ToDateTime("05/01/1992")
            } );
             emplist.Add(new Employee() {
                Name = "Mang",
                DOB =  Convert.ToDateTime("05/01/1995")
            } );
             emplist.Add(new Employee() {
                Name = "Mahi",
                DOB =  Convert.ToDateTime("05/01/1992")
            } );
            var emp = (from a in emplist where a.Name.ToLower().StartsWith("ma") 
                        orderby a.DOB descending
                        select new {a}).Skip(1).Take(2).ToList();

            // var emp = (from a in emplist
            //             where a.Name.ToLower().StartsWith("ma")
            //             orderby a.DOB descending
            //             select new {
            //                 epmlst = a
            //             }).ToList().Skip(3).Take(5);
            
            Console.WriteLine(emp);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
    }
}