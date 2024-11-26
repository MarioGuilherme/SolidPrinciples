namespace SolidPrinciples.Dip;

public class RabbitMqService : IMessageBusService {
    public RabbitMqService() {
        // Cria o canal com o RabbitMQ
    }

    public void Publish(string queue, object data) {
        throw new NotImplementedException();
    }
}