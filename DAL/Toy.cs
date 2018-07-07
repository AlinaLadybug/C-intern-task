using System;

namespace DAL
{
    public class Toy
    {
        public int ID { get; set; }
        public string  Age { get; set; }
        public string Category { get; set; }
        public string  Title { get; set; }
        public float Price { get; set; }  
        public override string ToString()
        {
            return String.Format("{0,-3}{1,-5}{2,-16}{3,-40}{4,-5}", ID, Age, Category, Title, Price);
        }  
    }
}