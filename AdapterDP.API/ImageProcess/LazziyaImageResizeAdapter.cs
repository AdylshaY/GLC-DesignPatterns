using LazZiya.ImageResize;
using System.Drawing;

namespace AdapterDP.API.ImageProcess
{
    public class LazziyaImageResizeAdapter : IImageProcess
    {
        public Task AddWatermark(string text, string newFileName, Stream imageStream)
        {
            using var img = Image.FromStream(imageStream);
            var tOps = new TextWatermarkOptions()
            {
                TextColor = Color.FromArgb(50, Color.White),
                OutlineColor = Color.FromArgb(255, Color.Black)
            };

            img.AddTextWatermark(text, tOps).SaveAs(@$"wwwroot/images/{newFileName}");
            return Task.CompletedTask;
        }
    }
}
