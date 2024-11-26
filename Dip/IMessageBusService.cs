namespace SolidPrinciples.Dip;

public interface IMessageBusService {
    void Publish(string queue, object data);
}
