namespace AdapterDP.API.ImageProcess
{
    public interface IImageProcess
    {
        Task AddWatermark(string text, string newFileName, Stream imageStream);
    }
}
