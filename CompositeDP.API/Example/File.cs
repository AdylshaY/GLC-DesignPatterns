namespace CompositeDP.API.Example
{
    public class File(string Name, long Size) : IFileSystem
    {
        public string Name { get; set; } = Name;

        public long GetSize()
        {
            return Size;
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)} - {Name} ({GetSize()} bytes)");
        }
    }
}
