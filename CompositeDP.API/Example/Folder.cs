namespace CompositeDP.API.Example
{
    public class Folder(string Name) : IFileSystem, IFolderBehavior
    {
        private readonly List<IFileSystem> _children = new();
        public string Name { get; set; } = Name;

        public void Add(IFileSystem item)
        {
            _children.Add(item);
        }

        public void Remove(IFileSystem item)
        {
            _children.Remove(item);
        }

        public long GetSize()
        {
            return _children.Sum(child => child.GetSize());
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)} + {Name} ({GetSize()} bytes) ({GetCount()} items)");
            foreach (var child in _children)
            {
                child.Print(indent + 2);
            }
        }

        public int GetCount()
        {
            return _children.Count;
        }
    }
}
