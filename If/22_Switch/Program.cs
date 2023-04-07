int op = 1, a = 10, b = 5;


int result = op switch
{
    1 => a + b,
    2 => a - b,
    3 => a * b,
    _ => 0
};

Console.WriteLine(result);