namespace AdapterDP.API.ImageProcess
{
    public class BasicImageProcess : IImageProcess
    {
        public Task AddWatermark(string text, string newFileName, Stream imageStream)
        {
            Console.WriteLine($"Adding watermark '{text}' to image '{newFileName}'");
            return Task.CompletedTask;
        }
    }
}
