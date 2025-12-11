namespace GLC_DesignPatterns.OCP
{
    internal interface IPerformanceCalculator
    {
        double CalculateScore(PerformanceMetrics metrics);
    }

    internal class JuniorCalculator : IPerformanceCalculator
    {
        public double CalculateScore(PerformanceMetrics metrics)
        {
            return (metrics.ClosedTicketCount * 5) - (metrics.AvgResolutionTimeHours * 0.5);
        }
    }

    internal class SeniorCalculator : IPerformanceCalculator
    {
        public double CalculateScore(PerformanceMetrics metrics)
        {
            return (metrics.ClosedTicketCount * 3) + (metrics.AvgResolutionTimeHours * 0.5);
        }
    }

    internal class PerformanceCalculator
    {
        public void GenerateReport(IPerformanceCalculator calculator, PerformanceMetrics metrics)
        {
            double finalScore = calculator.CalculateScore(metrics);

            Console.WriteLine($"Metrics -> Tickets: {metrics.ClosedTicketCount}, Avg Time: {metrics.AvgResolutionTimeHours}h");
            Console.WriteLine($"Final Performance Score: {finalScore}");
        }
    }
}
