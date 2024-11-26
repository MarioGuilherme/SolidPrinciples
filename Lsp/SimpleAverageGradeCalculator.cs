namespace SolidPrinciples.Lsp;

public class SimpleAverageGradeCalculator(string subject, int year, int semester) : IAverageGradeCalculator {
    public string Subject { get; set; } = subject;
    public int Year { get; set; } = year;
    public int Semester { get; set; } = semester;

    public virtual double Calculate(int[] grades) {
        double average = Math.Floor(grades.Average());

        Console.WriteLine($"Matéria: {this.Subject} do período {this.Semester}/{this.Year} é: {average}");

        return average;
    }
}