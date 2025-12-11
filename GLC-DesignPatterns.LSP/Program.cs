using Bad = GLC_DesignPatterns.LSP.BadExample;
using Good = GLC_DesignPatterns.LSP.GoodExample;


RunBadExample();
Console.WriteLine(new string('-', 30));
RunGoodExample();
Console.ReadLine();


static void RunBadExample()
{
    Console.WriteLine("### Running BAD Example (LSP Violation) ###");

    List<Bad.Pet> pets = new List<Bad.Pet>
        {
            new Bad.Dog(),
            new Bad.Cat(),
            new Bad.Goldfish()
        };

    foreach (var pet in pets)
    {
        try
        {
            pet.Walk();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error]: {ex.Message}");
        }
    }
}

static void RunGoodExample()
{
    Console.WriteLine("\n### Running GOOD Example (LSP Compliant) ###");

    List<Good.Pet> pets = new List<Good.Pet>
        {
            new Good.Dog(),
            new Good.Cat(),
            new Good.Goldfish()
        };

    foreach (var pet in pets)
    {
        pet.Eat();

        if (pet is Good.IWalkable walkingPet)
        {
            walkingPet.Walk();
        }
        else
        {
            Console.WriteLine($"> Skipping {pet.GetType().Name} (Cannot walk)");
        }
    }
}