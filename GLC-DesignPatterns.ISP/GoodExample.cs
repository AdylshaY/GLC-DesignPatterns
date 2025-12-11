namespace GLC_DesignPatterns.ISP.Good
{
    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    public interface IFaxer
    {
        void Fax(string content);
    }

    public class MultiFunctionPrinter : IPrinter, IScanner, IFaxer
    {
        public void Print(string content) => Console.WriteLine($"[Multi] Printing: {content}");
        public void Scan(string content) => Console.WriteLine($"[Multi] Scanning: {content}");
        public void Fax(string content) => Console.WriteLine($"[Multi] Faxing: {content}");
    }

    public class OldFashionedPrinter : IPrinter
    {
        public void Print(string content) => Console.WriteLine($"[Old] Printing: {content}");
    }
}
