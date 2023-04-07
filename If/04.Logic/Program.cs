bool operand1 = false, operand2 = false, result = false;

#region Konyuksiya

// false && false = false                  true && false = false
// false && true = false                   true && true = true

operand1 = true;                           // true          
operand2 = false;                          // false
result = operand1 && operand2;             // false

Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);

#endregion

#region Dizyunksiya

// false || false = false                  true || false = true         
// false || true = true                    true || true = true

operand1 = true;                           // true          
operand2 = false;                          // false
result = operand1 || operand2;             // true

Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);

#endregion

#region İnkar

// !false  = true
// !true  = false       

operand1 = true;
result = !operand1;

Console.WriteLine("NOT {0} = {1}", operand1, result);

#endregion