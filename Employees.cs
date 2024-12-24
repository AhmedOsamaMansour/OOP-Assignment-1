using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal class Employees
    {
        private int id;
        private string name;
        private decimal salary;

        public Employees(int _id, string _name ,decimal _salary) 
        { 
            this.id = _id;
            this.name = _name;
            this.salary = _salary;
        }
        public override string ToString()
        {
            return $"id = {this.id} \nname = {this.name} \nsalary = {this.salary}";
        }
        public void setId(int _id) { this.id = _id; }
        public int getId() {  return this.id; }
        public void setName(string _name) { this.name = _name.Length<5? _name:_name.Substring(0,5); }
        public string getName() { return this.name; }
        public void setSalary(decimal _salary) { this.salary = _salary; }
        public decimal getSalary() {  return this.salary; }


        public decimal Salary
        {
            get 
            {
                return this.salary;
            }
            set
            {
                this.salary = value>4000?value:4000;
            }
        }

        public int Age { get; set; }

        /* 
         * propfull + Tab -> Full property
         * prop + Tab -> Automatic property
         */

    }
}
