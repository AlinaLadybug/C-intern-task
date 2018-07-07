using System;
using System.Collections.Generic;
using BLL;
using DAL;

namespace PL {
    class Program {
        static void Main (string[] args) {
            Start ();
        }
        static public void Start () {
            System.Console.WriteLine ("Hello, and welcome to ToysStore! Choose the action down below.(Press 1-7)\n");
            while (true) {
                ShowMenu ();
                int k;
                var key = Console.ReadLine ();
                if (int.TryParse (key, out k)) {
                    ShowResult (k);
                } else System.Console.WriteLine ("It's not a number. Please press 1-7.");
            }
        }
        static public void ShowMenu () {
            int k = 1;
            System.Console.WriteLine (k + ".Show the list of TOYS.");
            System.Console.WriteLine (++k + ".Show the list of ORDERS.");
            System.Console.WriteLine (++k + ".Show the list of CUSTOMERS.");
            System.Console.WriteLine (++k + ".Show orders with all main info.");
            System.Console.WriteLine (++k + ".Show all sold toys");
            System.Console.WriteLine (++k + ".Show customers with their expenses");
            System.Console.WriteLine (++k + ".Exit..."); //k=7
        }

        static public void ShowResult (int k) {
            try {
                StoreBLL logicObj = new StoreBLL ();
                ShowInfo show = new ShowInfo ();
                switch (k) {
                    case 1:
                        show.ShowToys (logicObj.GetToys ());
                        break;
                    case 2:
                        show.ShowOrders (logicObj.GetOrders ());
                        break;
                    case 3:
                        show.ShowCustomers (logicObj.GetCustomers ());
                        break;
                    case 4:
                        show.ShowOrdersInfo (logicObj.GetOrdersInfo ());
                        break;
                    case 5:
                        show.ShowSoldToys (logicObj.GetSoldToys ());
                        break;
                    case 6:
                        show.ShowCustomersExpenses (logicObj.GetCustomersExpenses ());
                        break;
                    case 7:
                        Environment.Exit (0);
                        break;
                    default:
                        System.Console.WriteLine ("Please, press 1-7.");
                        break;
                }
            } catch {
                System.Console.WriteLine("Something wrong");
            }
        }

    }
}