## CSharp-intern-task
### The Toy Store
It's a 3-tier project with 3 separated projects(Data Access Layer, Business Logic Layer and the top-most Presentation Layer, which is actually Console Application)


#### Project's features:
- Language: C# via .Net Core 2.1 SDK (v2.1.301)
- Database: SQLite version 3.24.0
- Testing Framework: xUnit version 2.3.1

#### DB's structure:
* Toys;
* Customers;
* Orders.

##### Meanings of SQL Statements:
* _OrdersInfo_ - gets information from 3 tables(inner join)
* _SoldToys_ - gets information about sold toys, and shows count of sold toys
* _CustomersExpenses_  gets info about purchases of customers in descending order.

Launch with _dotnet run_ command in /PL directory.
