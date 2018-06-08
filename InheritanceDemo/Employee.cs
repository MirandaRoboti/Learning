using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
     public class Employee //class
    {
        public string Name { get; set; } //string property name
        protected double VacationDays; // protected -- can be seen by this class and any class that derives from this class property vac days

        public virtual void TakeVacation() { } // can be seen by any method of every class and can also be overriden in derived classes.

        public Employee(string name) //constructor fot he class passing the parameter name
        {
            Name = name; //assign the name property to that parameter
        }

        public Employee(string name,double vacationDays)
        {
            Name = name;
            VacationDays = vacationDays;
        }

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]"; // override the to sting method that every class inheritd from the most base class object.
        }
    }

}
