int age = 18;

switch (age)
{
    case < 0:
    case > 100:
        Console.WriteLine($"Age value is {age}; out of an acceptable range.");
        break;

    default:
        Console.WriteLine($"Age value is {age}.");
        break;
}