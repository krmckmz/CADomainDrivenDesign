namespace Order.Infrastructure;
namespace Order.Application;
namespace Order.Domain;
using MediatR;
using System;
using System.Threading.Tasks;
using System.Threading;

public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
{
    private readonly IBuyerRepository _buyerRepository;
    public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
    {
        _buyerRepository = buyerRepository;
    }
    public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(notification.Order.UserName))
        {
            buyerRepository.Add(new Buyer(notification.UserName));
            //set order's buyerid here.
        }
    }
}
