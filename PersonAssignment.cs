using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal struct PersonAssignment
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonAssignment(string _name,int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }
    }
}
