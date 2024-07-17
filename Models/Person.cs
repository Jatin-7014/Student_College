using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string DOB {  get; set; }

        public Person(){}

        public Person(int id,string address,string dob )
        {
            Id = id;
            Address = address;
            DOB = dob;
        }
        public virtual string PrintDetails()
        {
            return $"Id: {Id}\n" +
                $"Address:{Address}\n" +
                $"DOB:{DOB}";
        }
    }
}
