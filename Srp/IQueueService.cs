namespace SolidPrinciples.Srp;

public interface IQueueService {
    void Publish(string queue, object data);
}