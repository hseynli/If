double quantity = 10;    // Məhsulun sayı.            
double price = 100;      // Məhsulun birinin dəyəri.           
double discount = 0.75;  // Üçmumi məbləğə endirim faizi - 25%.
double cost;             // Ümumi məbləğ.  

// ƏGƏR məhsulundan 10 və daha artıq alıblarsa, ONDA 25% endirim etmək, ƏKS HALDA endirim etməmək.

cost = quantity >= 10 ? quantity * price * discount : quantity * price;

Console.WriteLine("Mehsulun umumi meblegi: {0}", cost);