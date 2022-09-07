using System.Collections.Generic;
namespace Order.Domain;

public class Buyer : BaseEntity
{
   public string FirstName { get; set; }
   public string LastName { get; set; }
}
