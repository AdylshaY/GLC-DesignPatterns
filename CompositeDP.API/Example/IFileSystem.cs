namespace CompositeDP.API.Example
{
    public interface IFileSystem
    {
        public string Name { get; set; }
        public long GetSize();
        public void Print(int indent = 0);
        public IFileSystem? Get(string name);
    }
}
