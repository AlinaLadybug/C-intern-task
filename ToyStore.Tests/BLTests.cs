using System;
using System.Collections.Generic;
using BLL;
using DAL;
using Xunit;

namespace ToyStore.Tests {
    public class BLTests {
        [Fact]
        public void VerifyToysType () {
            var model = new StoreBLL ();
            var result = model.GetToys ();
            var expected = typeof (List<Toy>);
            Assert.IsType<List<Toy>> (result);
            Assert.IsType (expected, result);
        }

        [Fact]
        public void VerifyOrdersType () {
            var model = new StoreBLL ();
            var result = model.GetOrders ();
            var expected = typeof (List<Order>);
            Assert.IsType<List<Order>> (result);
            Assert.IsType (expected, result);
        }

        [Fact]
        public void VerifyCustomersType () {
            var model = new StoreBLL ();
            var result = model.GetCustomers ();
            var expected = typeof (List<Customer>);
            Assert.IsType<List<Customer>> (result);
            Assert.IsType (expected, result);
        }

        [Fact]
        public void VerifyOrdersInfoType () {
            var model = new StoreBLL ();
            var result = model.GetOrdersInfo ();
            var expected = typeof (List<object[]>);
            Assert.IsType<List<object[]>> (result);
            Assert.IsType (expected, result);
        }

        [Fact]
        public void VerifySoldToysType () {
            var model = new StoreBLL ();
            var result = model.GetSoldToys ();
            var expected = typeof (List<object[]>);
            Assert.IsType<List<object[]>> (result);
            Assert.IsType (expected, result);
        }

        [Fact]
        public void VerifyCustomersExpensesType () {
            var model = new StoreBLL ();
            var result = model.GetCustomersExpenses ();
            var expected = typeof (List<object[]>);
            Assert.IsType<List<object[]>> (result);
            Assert.IsType (expected, result);
        }
    }
}