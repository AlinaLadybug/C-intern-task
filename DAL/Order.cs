using System;

namespace DAL
{
    public class Order
    {
        public int OrderID { get; set; }
        public string  Date { get; set; }
        public int CustomerId { get; set; }
        public int  ToyId { get; set; }
        public override string ToString()
        {
            return String.Format("{0,-3}{1,-22}{2,-11}{3,-5}", OrderID, Date, CustomerId, ToyId);
        }  
    }
}