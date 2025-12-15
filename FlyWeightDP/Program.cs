var shapeFactory = new ShapeFactory();

// Factory otomatik olarak nesne oluşturur veya mevcut olanı döndürür
var redCircle1 = shapeFactory.GetShape("RedCircle", "Red", "Smooth");
redCircle1.Draw(new ExtrinsicState(10, 20, 0));

var greenCircle = shapeFactory.GetShape("GreenCircle", "Green", "Rough");
greenCircle.Draw(new ExtrinsicState(30, 40, 0));

// Aynı key ile çağrılınca AYNI nesne döner (memory tasarrufu)
var redCircle2 = shapeFactory.GetShape("RedCircle", "Red", "Smooth");
redCircle2.Draw(new ExtrinsicState(50, 60, 0));

Console.WriteLine($"redCircle1 ve redCircle2 aynı nesne mi? {ReferenceEquals(redCircle1, redCircle2)}"); // True

public class IntrinsicState(string name, string color, string texture)
{
    public string Name { get; set; } = name;
    public string Color { get; set; } = color;
    public string Texture { get; set; } = texture;
}

public class ExtrinsicState(int x, int y, int z)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public int Z { get; set; } = z;
}

public interface IShape
{
    IntrinsicState IntrinsicState { get; }
    void Draw(ExtrinsicState extrinsicState);
}

public class Circle(IntrinsicState intrinsicState) : IShape
{
    public IntrinsicState IntrinsicState => intrinsicState;
    public void Draw(ExtrinsicState extrinsicState)
    {
        Console.WriteLine($"Drawing Circle: Name={IntrinsicState.Name}, Color={IntrinsicState.Color}, Texture={IntrinsicState.Texture}, X={extrinsicState.X}, Y={extrinsicState.Y}, Z={extrinsicState.Z}");
    }
}

public class ShapeFactory
{
    private readonly Dictionary<string, IShape> _shapes = [];

    public IShape GetShape(string name, string color, string texture)
    {
        string key = name;

        if (!_shapes.ContainsKey(key))
        {
            _shapes[key] = new Circle(new IntrinsicState(name, color, texture));
            Console.WriteLine($"Yeni Circle oluşturuldu: {name}");
        }
        else
        {
            Console.WriteLine($"Mevcut Circle kullanılıyor: {name}");
        }

        return _shapes[key];
    }

    public int GetTotalShapes() => _shapes.Count;
}