using System.Collections.Generic;
using System;
namespace Order.Domain;

public class Order : BaseEntity, IAggregateRoot
{
    public DateTime OrderDate { get; private set; }
    public string Description { get; private set; }

    public int BuyerId { get; private set; }
    public string OrderStatus { get; private set; }
    public Address Address { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; }

    public Order(DateTime orderDate, string description, int buyerId, string OrderStatus, Address address, ICollection<OrderItem> orderItems)
    {
        if (orderDate < DateTime.Now)
            throw new Exception("Orderdate must be greater than now");

        if (string.IsNullOrEmpty(address.City))
            throw new Exception("City cannot be empty");


        OrderDate = orderDate;
        Description = description ?? ArgumentNullException.ThrowIfNull(description);
        BuyerId = buyerId;
        OrderStatus = OrderStatus ?? ArgumentNullException.ThrowIfNull(orderStatus);
        Address = address ?? ArgumentNullException.ThrowIfNull(address);
        OrderItems = orderItems ?? ArgumentNullException.ThrowIfNull(orderItems);
    }

    public void AddOrderItem(int quantity,decimal price,int productId)
    {
        OrderItem item = new OrderItem(quantity,price,productId);

        OrderItems.Add(item);
    }
}
