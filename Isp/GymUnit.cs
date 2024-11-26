namespace SolidPrinciples.Isp;

public class GymUnit(Guid id, string name, string fullAddress, DateTime createdAt) {
    public Guid Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public string FullAddress { get; private set; } = fullAddress;
    public DateTime CreatedAt { get; private set; } = createdAt;
}
