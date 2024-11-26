namespace SolidPrinciples.Dip;

public class PersonController(IPersonService service) {
    private readonly IPersonService service = service;
}