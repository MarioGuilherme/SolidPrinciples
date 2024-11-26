namespace SolidPrinciples.Ocp;

public class CreditCardMethod(OrderPaymentInfo paymentInfo) : IOrderPaymentMethod {
    public void Process() {
        Console.WriteLine("Pagando com Cartão de crédito");
    }
}