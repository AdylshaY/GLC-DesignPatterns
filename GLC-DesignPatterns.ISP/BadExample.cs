namespace GLC_DesignPatterns.ISP.Bad
{
    public interface IMachine
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Print(string content)
        {
            Console.WriteLine($"[Multi] Printing: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"[Multi] Scanning: {content}");
        }

        public void Fax(string content)
        {
            Console.WriteLine($"[Multi] Faxing: {content}");
        }
    }

    public class OldFashionedPrinter : IMachine
    {
        public void Print(string content)
        {
            Console.WriteLine($"[Old] Printing: {content}");
        }

        public void Scan(string content)
        {
            throw new NotImplementedException("Old printers cannot scan!");
        }

        public void Fax(string content)
        {
            throw new NotImplementedException("Old printers cannot fax!");
        }
    }
}
