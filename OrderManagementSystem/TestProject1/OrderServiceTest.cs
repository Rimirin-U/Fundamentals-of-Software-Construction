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
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            orderService.AddOrder(orderDetail1);
            orderService.AddOrder(orderDetail1);
        }

        [TestMethod]
        public void RemoveOrderTest1()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            orderService.RemoveOrder(order1);
            Assert.IsTrue(orderService.orders.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "RemoveError: order not found")]
        public void RemoveOrderTest2()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            orderService.RemoveOrder(order1);
            orderService.RemoveOrder(order1);
        }

        [TestMethod]
        public void GenerateIDTest()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    5
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Raana"),
                    new Goods("matcha ice"),
                    5
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            Order order2 = orderService.AddOrder(orderDetail2);
            Order order3 = orderService.AddOrder(orderDetail3);
            Assert.IsTrue(order1.id + 1 == order2.id && order2.id + 1 == order3.id);
        }

        [TestMethod]
        public void SearchByIDTest1()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    5
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Raana"),
                    new Goods("matcha ice"),
                    5
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            orderService.AddOrder(orderDetail2);
            orderService.AddOrder(orderDetail3);
            var lst = orderService.SearchByID(order1.id);
            Assert.IsTrue(lst[0] == order1);
        }

        [TestMethod]
        public void SearchByIDTest2()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    5
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Raana"),
                    new Goods("matcha ice"),
                    5
                    );
            orderService.AddOrder(orderDetail1);
            orderService.AddOrder(orderDetail2);
            orderService.AddOrder(orderDetail3);
            var lst = orderService.SearchByID(0);
            Assert.IsTrue(lst.Count == 0);
        }

        [TestMethod]
        public void SearchByGoodsTest()
        {
            OrderService orderService = new OrderService();
            Goods stone = new Goods("stone");
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    stone,
                    5
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Taki"),
                    stone,
                    5
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            Order order2 = orderService.AddOrder(orderDetail2);
            Order order3 = orderService.AddOrder(orderDetail3);
            List<Order> lst = orderService.SearchByGoods(stone);
            Equals(lst, new List<Order>() { order2, order3 });
        }

        [TestMethod]
        public void SearchByCustomerTest()
        {
            OrderService orderService = new OrderService();
            Customer tmr = new Customer("tomorin");
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    tmr,
                    new Goods("stone"),
                    5
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    tmr,
                    new Goods("paper"),
                    5
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            Order order2 = orderService.AddOrder(orderDetail2);
            Order order3 = orderService.AddOrder(orderDetail3);
            List<Order> lst = orderService.SearchByCustomer(tmr);
            Equals(lst, new List<Order>() { order2, order3 });
        }

        [TestMethod]
        public void SearchByAmountTest()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    50
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Raana"),
                    new Goods("matcha ice"),
                    10
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            Order order2 = orderService.AddOrder(orderDetail2);
            Order order3 = orderService.AddOrder(orderDetail3);
            List<Order> lst = orderService.SearchByAmount(5, 10);
            Equals(lst, new List<Order>() { order1, order3 });
        }

        [TestMethod]
        public void SortTest1()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    50
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Raana"),
                    new Goods("matcha ice"),
                    10
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            Order order2 = orderService.AddOrder(orderDetail2);
            Order order3 = orderService.AddOrder(orderDetail3);
            orderService.Sort(orderService.sortByAmountOperator);
            Equals(orderService.orders, new List<Order>() { order1, order3, order2 });
        }

        [TestMethod]
        public void SortTest2()
        {
            OrderService orderService = new OrderService();
            OrderDetail orderDetail1 =
                new OrderDetail(
                    new Customer("Anon Tokyo"),
                    new Goods("T-Shirt"),
                    5
                    );
            OrderDetail orderDetail2 =
                new OrderDetail(
                    new Customer("Tomorin"),
                    new Goods("stone"),
                    50
                    );
            OrderDetail orderDetail3 =
                new OrderDetail(
                    new Customer("Raana"),
                    new Goods("matcha ice"),
                    10
                    );
            Order order1 = orderService.AddOrder(orderDetail1);
            Order order2 = orderService.AddOrder(orderDetail2);
            Order order3 = orderService.AddOrder(orderDetail3);
            orderService.Sort((x, y) =>
            {
                return x.id < y.id ? 1 :
                x.id == y.id ? 0 : -1;
            });
            Equals(orderService.orders, new List<Order>() { order3, order2, order1 });
        }
    }
}