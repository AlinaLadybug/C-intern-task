using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Dynamic;
using System.Linq;

namespace DAL {
    public class StoreDAL {
        private string conString = "DataSource = ../DAL/toys.db; FailIfMissing=True";
        public List<object[]> ReadSoldToys () {
            List<object[]> str = new List<object[]> ();

            using (var connection = new SQLiteConnection (conString)) {
                var command = connection.CreateCommand ();
                var query = "SELECT toys.id, toys.age, toys.category, toys.title, toys.price, " +
                    "sum(case when orders.OrderID is null then 0 else 1 end) count, " +
                    "sum(case when orders.OrderID is null then 0 else toys.price end) sum  from toys " +
                    "left join orders on toys.id = orders.ToyId " +
                    "group by toys.id " +
                    "order by  toys.id";
                command.CommandText = query;

                if (connection != null && connection.State != ConnectionState.Open) {
                    try {
                        connection.Open ();
                    } catch (SQLiteException) {
                        System.Console.WriteLine ("Unable to open db");
                    }

                    try {
                        var reader = command.ExecuteReader ();

                        while (reader.Read ()) {
                            string Value1 = reader["id"].ToString ();
                            string Value2 = (string) reader["age"];
                            string Value3 = (string) reader["category"];
                            string Value4 = (string) reader["title"];
                            string Value5 = (string) reader["price"].ToString ();
                            string Value6 = (string) reader["count"].ToString ();
                            string Value7 = (string) reader["sum"].ToString ();

                            object[] row = { Value1, Value2, Value3, Value4, Value5, Value6, Value7 };
                            str.Add (row);
                        }

                        return str;
                    } catch {
                        System.Console.WriteLine ("It was unable to execute statement");
                        return new List<object[]> ();
                    }

                } else return new List<object[]> ();

            }

        }

        public List<object[]> ReadCustomersExpenses () {
            List<object[]> str = new List<object[]> ();

            using (var connection = new SQLiteConnection (conString)) {
                var command = connection.CreateCommand ();
                var query = "SELECT customers.CustomerId, customers.Name, customers.Surname, round(sum(case when toys.price is null then 0 else toys.price end),2) Expenses from customers " +
                    "left join orders on customers.CustomerId = orders.CustomerId " +
                    "left join toys on orders.ToyId = toys.id " +
                    "group by customers.CustomerId " +
                    "order by expenses DESC;";
                command.CommandText = query;
                if (connection != null && connection.State != ConnectionState.Open) {
                    try {
                        connection.Open ();
                    } catch (SQLiteException) {
                        System.Console.WriteLine ("Unable to open db");
                    }

                    try {
                        var reader = command.ExecuteReader ();

                        while (reader.Read ()) {
                            string Value1 = reader["CustomerId"].ToString ();
                            string Value2 = (string) reader["Name"];
                            string Value3 = (string) reader["Surname"];
                            string Value4 = reader["Expenses"].ToString ();

                            object[] row = { Value1, Value2, Value3, Value4 };
                            str.Add (row);
                        }

                        return str;
                    } catch {
                        System.Console.WriteLine ("It was unable to execute statement");
                        return new List<object[]> ();
                    }

                } else return new List<object[]> ();

            }

        }
        //INNER JOIN
        public List<object[]> ReadOrdersInfo () {
            List<object[]> str = new List<object[]> ();

            using (var connection = new SQLiteConnection (conString)) {
                var command = connection.CreateCommand ();
                var query = "SELECT orders.OrderID, orders.Date, (customers.Name ||' '||customers.Surname) as [Customer Name], toys.title as Title, round(toys.price,2) Price from orders " +
                    "join customers on orders.CustomerId = customers.CustomerId " +
                    "join toys on orders.ToyId = toys.id";
                command.CommandText = query;
                if (connection != null && connection.State != ConnectionState.Open) {
                    try {
                        connection.Open ();
                    } catch (SQLiteException) {
                        System.Console.WriteLine ("Unable to open db");
                    }

                    try {

                        var reader = command.ExecuteReader ();

                        while (reader.Read ()) {
                            string Value1 = reader["OrderID"].ToString ();
                            string Value2 = reader["Date"].ToString ();
                            string Value3 = (string) reader["Customer Name"];
                            string Value4 = (string) reader["Title"];
                            string Value5 = (string) reader["Price"].ToString ();

                            object[] row = { Value1, Value2, Value3, Value4, Value5 };
                            str.Add (row);
                        }

                        return str;
                    } catch {
                        System.Console.WriteLine ("It was unable to execute statement");
                        return new List<object[]> ();
                    }

                } else return new List<object[]> ();

            }

        }
        public List<Toy> ReadToys () {
            List<Toy> toys = new List<Toy> ();
            using (var connection = new SQLiteConnection (conString)) {
                var command = connection.CreateCommand ();
                var query = "SELECT * FROM toys";
                command.CommandText = query;
                if (connection != null && connection.State != ConnectionState.Open) {
                    try {
                        connection.Open ();
                    } catch (SQLiteException) {
                        System.Console.WriteLine ("Unable to open db");
                    }

                    try {
                        var reader = command.ExecuteReader ();
                        while (reader.Read ()) {
                            Toy tempToy = new Toy ();
                            tempToy.ID = int.Parse (Convert.ToString (reader["id"]));
                            tempToy.Age = Convert.ToString (reader["age"]);
                            tempToy.Category = Convert.ToString (reader["category"]);
                            tempToy.Title = Convert.ToString (reader["title"]);
                            tempToy.Price = float.Parse (Convert.ToString (reader["price"]));
                            toys.Add (tempToy);
                        }
                        return toys;
                    } catch {
                        System.Console.WriteLine ("It was unable to execute statement");
                        return new List<Toy> ();
                    }

                } else return new List<Toy> ();

            }

        }

        public List<Customer> ReadCustomers () {
            List<Customer> customers = new List<Customer> ();
            using (var connection = new SQLiteConnection (conString)) {
                var command = connection.CreateCommand ();
                var query = "SELECT * FROM customers";
                command.CommandText = query;
                if (connection != null && connection.State != ConnectionState.Open) {
                    try {
                        connection.Open ();
                    } catch (SQLiteException) {
                        System.Console.WriteLine ("Unable to open db");
                    }

                    try {
                        var reader = command.ExecuteReader ();
                        while (reader.Read ()) {
                            Customer tempCust = new Customer ();
                            tempCust.CustomerId = int.Parse (Convert.ToString (reader["CustomerId"]));
                            tempCust.Name = Convert.ToString (reader["Name"]);
                            tempCust.Surname = Convert.ToString (reader["Surname"]);
                            customers.Add (tempCust);
                        }
                        return customers;
                    } catch {
                        System.Console.WriteLine ("It was unable to execute statement");
                        return new List<Customer> ();
                    }

                } else return new List<Customer> ();

            }
        }

        public List<Order> ReadOrders () {
            List<Order> orders = new List<Order> ();
            using (var connection = new SQLiteConnection (conString)) {
                var command = connection.CreateCommand ();
                var query = "SELECT * FROM orders";
                command.CommandText = query;
                if (connection != null && connection.State != ConnectionState.Open) {
                    try {
                        connection.Open ();
                    } catch (SQLiteException) {
                        System.Console.WriteLine ("Unable to open db");
                    }

                    try {
                        var reader = command.ExecuteReader ();
                        while (reader.Read ()) {
                            Order tempOrder = new Order ();
                            tempOrder.OrderID = int.Parse (Convert.ToString (reader["OrderID"]));
                            tempOrder.Date = Convert.ToString (reader["Date"]);
                            tempOrder.CustomerId = int.Parse (Convert.ToString (reader["CustomerId"]));
                            tempOrder.ToyId = int.Parse (Convert.ToString (reader["ToyId"]));
                            orders.Add (tempOrder);
                        }
                        return orders;
                    } catch {
                        System.Console.WriteLine ("It was unable to execute statement");
                        return new List<Order> ();
                    }

                } else return new List<Order> ();

            }
        }

        static void Main (string[] args) {

        }
    }
}