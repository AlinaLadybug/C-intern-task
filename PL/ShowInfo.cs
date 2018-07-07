using System;
using System.Collections.Generic;
using DAL;

namespace PL {
    public class ShowInfo {
        public void ShowCustomers (List<Customer> customers) {
            System.Console.WriteLine ("Showing all customers...");
            System.Console.WriteLine ("{0,-3}{1,-20}{2,-20}", "ID", "Name", "Surname");
            foreach (var item in customers) {
                System.Console.WriteLine ();
                System.Console.WriteLine (item.ToString ());
            }
            System.Console.WriteLine ();
        }

        public void ShowOrders (List<Order> orders) {
            System.Console.WriteLine ("Showing all orders...");
            System.Console.WriteLine ("{0,-3}{1,-22}{2,-11}{3,-5}", "ID", "Date", "CustomerId", "ToyId");
            foreach (var item in orders) {
                System.Console.WriteLine ();
                System.Console.WriteLine (item.ToString ());
            }
            System.Console.WriteLine ();
        }

        public void ShowToys (List<Toy> toys) {
            System.Console.WriteLine ("Showing all toys...");
            System.Console.WriteLine ("{0,-3}{1,-5}{2,-16}{3,-40}{4,-5}", "ID", "Age", "Category", "Title", "Price");
            foreach (var item in toys) {
                System.Console.WriteLine ();
                System.Console.WriteLine (item.ToString ());
            }
            System.Console.WriteLine ();
        }

        public void ShowSoldToys (List<object[]> str) {
            System.Console.WriteLine ("Showing all sold toys...");
            System.Console.WriteLine ("{0,-3}{1,-5}{2,-16}{3,-40}{4,-5}{5,5}{6,8}", "ID", "Age", "Category", "Title", "Price", "Count", "Sum");
            foreach (var item in str) {
                var list = (object[]) item;
                System.Console.WriteLine ();
                System.Console.WriteLine ("{0,-3}{1,-5}{2,-16}{3,-40}{4,-5}{5,5}{6,8}", list[0], list[1], list[2], list[3], list[4], list[5], list[6]);

            }
            System.Console.WriteLine ();
        }
        public void ShowCustomersExpenses (List<object[]> str) {
            System.Console.WriteLine ("Showing all expenses of customers...");
            System.Console.WriteLine ("{0,-3}{1,-20}{2,-20}{3,8}", "ID", "Name", "Surname", "Expenses");
            foreach (var item in str) {
                var list = (object[]) item;
                System.Console.WriteLine ();
                System.Console.WriteLine ("{0,-3}{1,-20}{2,-20}{3,8}", list[0], list[1], list[2], list[3]);

            }
            System.Console.WriteLine ();
        }

        public void ShowOrdersInfo (List<object[]> str) {
            System.Console.WriteLine ("Showing all main information of orders...");
            System.Console.WriteLine ("{0,-3}{1,-22}{2,-28}{3,-30}{4,8}", "ID", "Date", "Customer Name", "Toy Title", "Sum");
            foreach (var item in str) {
                var list = (object[]) item;
                System.Console.WriteLine ();
                System.Console.WriteLine ("{0,-3}{1,-22}{2,-28}{3,-30}{4,8}", list[0], list[1], list[2], list[3], list[4]);

            }
            System.Console.WriteLine ();
        }
    }
}