namespace SolidPrinciples.Lsp;

public class SchoolService {
    public void ConsolidateClass() {
        SimpleAverageGradeCalculator averageGradeCalculator = new("Portugues", 2024, 1);
        DefaultYearConsolidateService defaultYearConsolidateService = new(averageGradeCalculator);

        defaultYearConsolidateService.Consolidate();
    }
}