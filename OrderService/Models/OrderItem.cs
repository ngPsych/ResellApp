public class OrderProduct
{
    public int OrderProductId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    // Navigation property
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}
