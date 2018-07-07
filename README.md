## CSharp-intern-task
### The Toy Store
It's a 3-tier project with 3 separated projects(Data Access Layer, Business Logic Layer and the top-most Presentation Layer, which is actually Console Application)

There is a db with three tables
* Toys;
* Customers;
* Orders.

Meanings of SQL Statements:
* _OrdersInfo_ - gets information from 3 tables(inner join)
* _SoldToys_ - gets information about sold toys, and shows count of sold toys
* _CustomersExpenses_  gets info about purchases of customers in descending order.

Launch with _dotnet run_ in /PL directory.
