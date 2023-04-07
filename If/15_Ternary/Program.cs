int a = 1;
double b = 0.0;
int max;

// [?] və [:]  - ifadəsi eyni tipdə olmalıdır.

max = (int)((a > b) ? a : b);

// ... və ya

max = (a > b) ? a : (int)b;

Console.WriteLine(max);