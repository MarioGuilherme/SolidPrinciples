namespace SolidPrinciples.Lsp;

public class DefaultYearConsolidateService(SimpleAverageGradeCalculator averageGradeCalculator) {
    private readonly SimpleAverageGradeCalculator _calculator = averageGradeCalculator;

    public void Consolidate() {
        _calculator.Calculate([1, 2, 3, 4]);
    }
}