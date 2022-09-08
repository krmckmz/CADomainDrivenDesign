namespace Order.Domain;
using System.Collections;
using System.Collections.Generic;

public abstract class BaseEntity
{
    public int Id { get; set; }
    private ICollection<INotification> domainEvents;
     public ICollection<INotification> DomainEvents=>domainEvents;

     public void AddDomainEvents(INotification notification)
     {
        domainEvents ??= new List<INotification>();

        domainEvents.Add(notification);
     }
}
