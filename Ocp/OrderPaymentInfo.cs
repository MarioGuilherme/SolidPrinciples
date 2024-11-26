namespace SolidPrinciples.Ocp;

public class OrderPaymentInfo {
    public Guid OrderId { get; set; }
    public decimal TotalPrice { get; set; }
    public PaymentType Type { get; set; }
}