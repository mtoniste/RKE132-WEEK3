Console.WriteLine("Palun sisesta oma hinne:");
char hinne = Char.Parse(Console.ReadLine().ToUpper());

switch (hinne)
{
    case 'A':
        Console.WriteLine("Suurepärane!");
        break;
    case 'B':
        Console.WriteLine("Väga hea!");
        break;
    case 'C':
        Console.WriteLine("Hea!");
        break;
    case 'D':
        Console.WriteLine("Rahuldav.");
        break;
    case 'E':
        Console.WriteLine("Kasin.");
        break;
    case 'F':
        Console.WriteLine("Puudulik");
        break;

    default:
        Console.WriteLine("Looks like your calendar is broken...");
        break;
}

Console.WriteLine("Have a great day!");