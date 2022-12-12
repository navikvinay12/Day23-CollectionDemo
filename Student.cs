using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} ,Student Name : {Name} , Phone Number : {PhoneNumber} , Address : {Address}";
        }
    }
}
