using System.Collections.Generic;
namespace Order.Domain;

public class Buyer : BaseEntity
{
    public string UserName { get; private set; }

    public Buyer(string userName)
    {
        UserName = userName ?? ArgumentNullException.ThrowIfNull(userName);
    }
}
