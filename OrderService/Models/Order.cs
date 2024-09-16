
public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderStatus { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; }
    public string ShippingAddress { get; set; }
    public string BillingAddress { get; set; }
    public string OrderNotes { get; set; }
    public string TrackingNumber { get; set; }

    // Navigation property
    // public virtual User User { get; set; }
    public virtual ICollection<OrderProduct> OrderProducts { get; set; }
}
