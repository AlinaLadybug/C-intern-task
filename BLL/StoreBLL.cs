using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL {

    public class StoreBLL {

        public List<Toy> GetToys () {
            try {
                StoreDAL dalobj = new StoreDAL ();
                return dalobj.ReadToys ();
            } catch {
                throw;
            }

        }

        public List<Order> GetOrders () {
            try {
                StoreDAL dalobj = new StoreDAL ();
                return dalobj.ReadOrders ();
            } catch {
                throw;
            }

        }

        public List<Customer> GetCustomers () {
            try {
                StoreDAL dalobj = new StoreDAL ();
                return dalobj.ReadCustomers ();
            } catch {
                throw;
            }

        }
        public List<object[]> GetSoldToys () {
            try {
                StoreDAL dalobj = new StoreDAL ();
                return dalobj.ReadSoldToys ();
            } catch {
                throw;
            }
        }
        public List<object[]> GetCustomersExpenses () {
            try {
                StoreDAL dalobj = new StoreDAL ();
                return dalobj.ReadCustomersExpenses ();
            } catch {
                throw;
            }
        }

        public List<object[]> GetOrdersInfo () {
            try {
                StoreDAL dalobj = new StoreDAL ();
                return dalobj.ReadOrdersInfo ();
            } catch {
                throw;
            }
        }

        static void Main (string[] args) {

        }
    }
}