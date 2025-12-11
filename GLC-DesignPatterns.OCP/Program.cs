using GLC_DesignPatterns.OCP;

var performanceCalculator = new PerformanceCalculator();

var juniorMetrics = new PerformanceMetrics
{
    ClosedTicketCount = 20,
    AvgResolutionTimeHours = 4.5
};

performanceCalculator.GenerateReport(new JuniorCalculator(), juniorMetrics);

var seniorMetrics = new PerformanceMetrics
{
    ClosedTicketCount = 10,
    AvgResolutionTimeHours = 7
};

performanceCalculator.GenerateReport(new SeniorCalculator(), seniorMetrics);