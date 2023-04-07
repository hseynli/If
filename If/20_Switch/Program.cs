Console.WriteLine("Heftenin gununu daxil edin: 1-2-3-4-5-6-7: ");

string myDay = Console.ReadLine();

int day = Convert.ToInt32(myDay);

switch (day)
{
    case 1:
        Console.WriteLine("Bazar ertesi.");
        break;
    case 2:
        Console.WriteLine("Cersenbe axsami.");
        break;
    case 3:
        Console.WriteLine("Cersenbe.");
        break;
    case 4:
        Console.WriteLine("Cume axsami.");
        break;
    case 5:
        Console.WriteLine("Cume.");
        break;
    case 6:
        Console.WriteLine("Senbe.");
        break;
    case 7:
        Console.WriteLine("Bazar.");
        break;
    default:
        Console.WriteLine("Siz yanlis heftenin gununu daxil etmisiniz.");
        break;
}