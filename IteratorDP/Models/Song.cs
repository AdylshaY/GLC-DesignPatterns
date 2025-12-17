namespace IteratorDP.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"[{Id}] - {Title}";
    }
}
