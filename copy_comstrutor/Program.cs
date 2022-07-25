using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_comstrutor
{
    public class Employee
    {
        private string name;
        private int id;
        private int age;

        public Employee(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public Employee(Employee x)
        {
            this.name=x.name;
            this.id = x.id;
            this.age = x.age;
        }

        public  void getdetails()
        {
            Console.WriteLine("name is:" + this.name);
            Console.WriteLine("name is:" + this.id);
            Console.WriteLine("name is:" +this. age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee("sonu kumar", 12, 20);
            obj.getdetails();
            Employee obj1 = new Employee(obj );
            obj1.getdetails();
            Console.ReadLine();
        }
    }
}
