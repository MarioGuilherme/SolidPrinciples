namespace SolidPrinciples.Srp;

public class Person(string name, string document, DateTime birthDate) {
    public string Name { get; set; } = name;
    public string Document { get; set; } = document;
    public DateTime BirthDate { get; set; } = birthDate;
}