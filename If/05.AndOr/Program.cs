bool operand1 = false, operand2 = false, result = false;

operand1 = true;                           // true          
operand2 = false;                          // false
//&& simvolları bitişik yoxlama onu göstərir ki, əgər sol tərəfdəki operand false qaytarsa,
//onda sağ tərəfdəki yoxlanılma aparılmayacaq.
result = operand1 && operand2;             // false
result = operand1 & operand2;              // false

Console.WriteLine(new string('-', 120));

//|| simvolları bitişik yoxlama onu göstərir ki, əgər sol tərəfdəki operand true qaytarsa,
//onda sağ tərəfdəki yoxlanılma aparılmayacaq.
result = operand1 || operand2;             // false
result = operand1 | operand2;              // false