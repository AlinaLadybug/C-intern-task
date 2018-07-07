using System;

namespace DAL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return String.Format("{0,-3}{1,-20}{2,-20}", CustomerId, Name, Surname);
        }  
    }
}