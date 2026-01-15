using Microsoft.EntityFrameworkCore;

// Question: Find the issues with the following EF Core LINQ query

List<OrderDto> GetOrdersAsync()
{
    using OrderContext _context = new OrderContext();

    var orderDtos = _context.Orders
        .Select(o => new OrderDto
        {
            Id = o.Id,
            FirstProduct = _context.Items
                .Where(c => c.Id == o.Id)
                .Select(c => c.Product)
                .FirstOrDefault()
        })
        .ToList();

    return orderDtos;
}

// Question: Where is the filter takes place? Is it efficient?

List<Order> GetOrders1Async()
{
    using OrderContext _context = new OrderContext();

    var orders = _context.Orders.AsEnumerable();

    var result = orders.Where(u => u.Price > 30).ToList();
    return result;
}

#region Mocked EF Core Context and Entities
public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Item> Items { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public List<Item> Items { get; set; }
}

public class Item
{
    public int Id { get; set; }
    public string Product { get; set; }
}

public class OrderDto
{
    public int Id { get; set; }
    public string FirstProduct { get; set; }
}
#endregion