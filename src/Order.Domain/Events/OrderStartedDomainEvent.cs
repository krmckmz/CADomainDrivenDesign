namespace Order.Infrastructure;
namespace Order.Application;
using System;

public class OrderStartedDomainEvent : INotification
{
    public string UserName { get; private set; }
    public Order Order { get; set; }
}
