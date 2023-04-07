Console.WriteLine("Heftenin gununu daxil edin: 1-2-3-4-5-6-7: ");

string day = Console.ReadLine();

switch (day)
{
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
        Console.WriteLine("Heftenin bu gunu-is gunudur.");
        break;
    case "6":
    case "7":
        Console.WriteLine("Heftenin bu gunu-tetil gunudur.");
        break;

    default:
        Console.WriteLine("Siz yanliq heftenin gununu daxil etmisiniz.");
        break;
}