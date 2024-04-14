namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\lukaa\Desktop\New folder (2)\Day_25 (Linq2)\Practice_1\Practice_1\Customers.txt";

            Dictionary<int, string> customerDict = File
            .ReadLines(path)
            .Select(line => line.Split('|'))
            .Where(parts => parts.Length == 2 && int.TryParse(parts[0], out int id))
            .ToDictionary(parts => int.Parse(parts[0]), parts => parts[1]);

            foreach (var entry in customerDict)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }

            Console.WriteLine();


            string path1 = @"C:\Users\lukaa\Desktop\New folder (2)\Day_25 (Linq2)\Practice_1\Practice_1\Orders.txt";

            var orders = File
            .ReadLines(path1)
            .Select(line => line.Split('|'))
            .Select(parts => new
            {
                OrderID = int.Parse(parts[0]),
                Date = parts[1],
                Product = parts[2],
                Price = double.Parse(parts[3]),
                CustomerID = int.Parse(parts[4])
            });

            var orderCounts = orders
                .GroupBy(order => order.CustomerID)
                .Select(group => new
                {
                    CustomerID = group.Key,
                    OrderCount = group.Count()
                });

            foreach (var orderCount in orderCounts)
            {
                Console.WriteLine($"Customer ID: {orderCount.CustomerID}, Order Count: {orderCount.OrderCount}");
            }

            Console.WriteLine();

            var totalSpentByCustomer = orders
            .GroupBy(order => order.CustomerID)
            .Select(group => new
            {
                CustomerID = group.Key,
                TotalSpent = group.Sum(order => order.Price)
            });

            foreach (var totalSpent in totalSpentByCustomer)
            {
                Console.WriteLine($"Customer ID: {totalSpent.CustomerID}, Total Spent: {totalSpent.TotalSpent:C}");
            }

            Console.WriteLine();

            var minSpentByCustomer = orders
            .GroupBy(order => order.CustomerID)
            .Select(group => new
            {
                CustomerID = group.Key,
                MinSpent = group.Min(order => order.Price)
            });

            foreach (var minSpent in minSpentByCustomer)
            {
                Console.WriteLine($"Customer ID: {minSpent.CustomerID}, Total Spent: {minSpent.MinSpent:C}");
            }

            Console.WriteLine();

            var customersWithMultipleOrders = orders
            .GroupBy(order => order.CustomerID)
            .Where(group => group.Count() > 1)
            .SelectMany(group => group);

            foreach (var order in customersWithMultipleOrders)
            {
                Console.WriteLine($"Customer ID: {order.CustomerID}, Order ID: {order.OrderID}, Product: {order.Product}, Price: {order.Price:C}");
            }

            Console.WriteLine();

            var customersWithAverageGreaterThan10 = orders
             .GroupBy(order => order.CustomerID)
             .Select(group => new
             {
                 CustomerID = group.Key,
                 AverageSpent = group.Average(order => order.Price)
             })
             .Where(result => result.AverageSpent > 10);




            foreach (var averageSpent in customersWithAverageGreaterThan10)
            {
                Console.WriteLine($"Customer ID: {averageSpent.CustomerID}, Average Spent: {averageSpent.AverageSpent:C}");
            }
        }
    }
}
