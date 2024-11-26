namespace SolidPrinciples.Ocp;

public class LoyaltyPointsMethod(OrderPaymentInfo paymentInfo) : IOrderPaymentMethod {
    public void Process() {
        Console.WriteLine("Pagando com pontos de fidelidade");
    }
}