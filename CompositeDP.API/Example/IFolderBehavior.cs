namespace CompositeDP.API.Example
{
    public interface IFolderBehavior
    {
        void Add(IFileSystem item);
        void Remove(IFileSystem item);
        int GetCount();
    }
}
