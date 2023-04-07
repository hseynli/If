int firstAge = 18, secondAge = 18;

switch ((firstAge, secondAge))
{
    case ( > 0, > 0) when firstAge == secondAge:
        Console.WriteLine($"Both age are equal.");
        break;

    case ( > 0, > 0):
        Console.WriteLine($"First age is{firstAge}, second age is {secondAge}.");
        break;

    default:
        Console.WriteLine("One or both age are not valid.");
        break;
}
