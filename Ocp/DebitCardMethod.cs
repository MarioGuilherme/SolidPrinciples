namespace SolidPrinciples.Ocp;

public class DebitCardMethod(OrderPaymentInfo paymentInfo) : IOrderPaymentMethod {
    public void Process() {
        Console.WriteLine("Pagando com Cartão de débito");
    }
}