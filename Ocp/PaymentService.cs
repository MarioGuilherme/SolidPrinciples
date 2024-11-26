namespace SolidPrinciples.Ocp;

public class PaymentService {
    // Agora a classe não coorderna os diferentes tipos de pagamentos
    // Para novos métodos de pagamentos, apenas cria a classe que herda a interface IOrderPaymentMethod
    public void Process(IOrderPaymentMethod paymentMethod) { // (OrderPaymentInfo paymentInfo)
        // Antes
        // if (paymentInfo.Type == PaymentType.Credit) {
        //     // Integrar com o Gateway de Pagamento A
        // } else if (paymentInfo.Type == PaymentType.Debit) {
        //     // Integrar com o Gateway de Pagamento B
        // } else if (paymentInfo.Type == PaymentType.LoyaltyPoints) {
        //     // Integrar com o Gateway de Pagamento B
        // }

        // Depois
        paymentMethod.Process();
    }
}