using System.Collections.Generic;
namespace Order.Domain;

public class OrderItem : BaseEntity
{
  public int Quantity { get; set; }
  public decimal Price { get; set; }
  public int ProductId { get; set; }

  public OrderItem(int quantity , decimal price,int productId)
  {
    Quantity = quantity;
    Price = price;
    ProductId = productId;
  }
}
