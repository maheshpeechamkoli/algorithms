using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Clone
{
    [Serializable]
    public class Person
    {
        public int age;
        public Employee objEmp;

        public Person CretaeShallowCopy(Person objShallow)
        {
            return (Person)objShallow.MemberwiseClone();
        }
        public Person CreateDeepCopy(Person obj)
        {
            MemoryStream m = new MemoryStream();
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(m, obj);
            m.Position = 0;
            return (Person)b.Deserialize(m);
        }        
    }
    [Serializable]
    public class Employee
    {
        public int Salary;
        public Employee(int _wage)
        {
            Salary = _wage;
        }
    }
}