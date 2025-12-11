using Bad = GLC_DesignPatterns.ISP.Bad;
using Good = GLC_DesignPatterns.ISP.Good;

RunBadExample();
Console.WriteLine(new string('-', 30));
RunGoodExample();

static void RunBadExample()
{
    Console.WriteLine("### Running BAD Example (ISP Violation) ###");

    var multiPrinter = new Bad.MultiFunctionPrinter();
    var oldPrinter = new Bad.OldFashionedPrinter();

    try
    {
        multiPrinter.Scan("My Document");
        Console.WriteLine("Multi printer scanned successfully.");

        Console.Write("Trying to scan with old printer... ");
        oldPrinter.Scan("My Document");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n[Error]: {ex.Message}");
    }
}

static void RunGoodExample()
{
    Console.WriteLine("\n### Running GOOD Example (ISP Compliant) ###");

    var multiPrinter = new Good.MultiFunctionPrinter();
    var oldPrinter = new Good.OldFashionedPrinter();

    List<Good.IPrinter> printers = new List<Good.IPrinter>
        {
            multiPrinter,
            oldPrinter
        };

    Console.WriteLine("--- Printing Task ---");
    foreach (var printer in printers)
    {
        printer.Print("Report.pdf");
    }

    List<Good.IScanner> scanners = new List<Good.IScanner>
        {
            multiPrinter
        };

    Console.WriteLine("\n--- Scanning Task ---");
    foreach (var scanner in scanners)
    {
        scanner.Scan("Photo.jpg");
    }
}