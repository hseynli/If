Console.WriteLine("1 ve ya 2 daxil edin:");

string number = Console.ReadLine();

switch (number)
{
    case "1":    // "1" — statik dəyər.
        {
            Console.WriteLine("Bir" );                                       // Budaq 1
            break;                                                           // Şərtdən çıxmaq.
        }
    case "2":
        {
            Console.WriteLine("Iki");                                        // Budaq 2
            break;
        }

    // Aşağıdakı default bloku mütləq deyil 

    default:
        {
            Console.WriteLine("Siz 1 ve 2-den ferqli eded daxil etmisiniz."); // Budaq 3
            break;
        }
}