namespace SolidPrinciples.Lsp;

public class WeightAverageGradeCalculator(string subject, int year, int semester) : IAverageGradeCalculator {
    public string Subject { get; set; } = subject;
    public int Year { get; set; } = year;
    public int Semester { get; set; } = semester;

    public double Calculate(int[] grades) {
        int average = (grades[0] * 2 + grades[1] * 2 + grades[2] * 3 + grades[3] * 3) / 10;

        Console.WriteLine($"Matéria: {this.Subject} do período {this.Semester}/{this.Year} é: {average}");

        return average;
    }
}