namespace TestProject1
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "AddOrderError: order already exists")]
        public void AddOrderTest1()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    )
                );
            orderService.AddOrder(order1);
            orderService.AddOrder(order1);
        }

        [TestMethod]
        public void RemoveOrderTest1()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    )
                );
            orderService.AddOrder(order1);
            orderService.RemoveOrder(order1);
            Assert.IsTrue(orderService.orders.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "RemoveError: order not found")]
        public void RemoveOrderTest2()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    )
                );
            Order order2 = new Order(
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    5
                    )
                );
            orderService.AddOrder(order1);
            orderService.RemoveOrder(order2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "RemoveError: order not found")]
        public void RemoveOrderTest3()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    )
                );
            Order order2 = new Order(
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    )
                );
            orderService.AddOrder(order1);
            orderService.RemoveOrder(order2);
        }

        //[TestMethod]
        //public void SearchByIDTest1()
        //{
        //    OrderService orderService = new OrderService();
        //    Order order1 = new Order(
        //        new OrderDetail(
        //            new Customer("Anon Tokyo"),
        //            new Goods("T-Shirt"),
        //            5
        //            )
        //        );
        //    Order order2 = new Order(
        //        new OrderDetail(
        //            new Customer("Tomorin"),
        //            new Goods("stone"),
        //            5
        //            )
        //        );
        //}
    }
}