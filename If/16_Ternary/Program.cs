int x = 10, y = -5;


// Ternar operatordan aşağıdakı şəkildə istifadə etmək məsləhər görülmür.
// Çünki bu halda kodun oxunaqlığı çətinləşir.

//                         condition    true block    false block     condition   true block       false block
//                          -------- ? ------------ : -------------    -------- ? ------------- : --------------
string quadrant = (x > 0) ? ((y > 0) ? "I kvadrant" : "IV kvadrant") : ((y > 0) ? "II kvadrant" : "III kvadrant");
//                ------- ? ---------------------------------------- : -------------------------------------------
//                condition               true block                                   false block

// ... və ya

quadrant = x > 0 ? (y > 0 ? "I kvadrant" : "IV kvadrant") : (y > 0 ? "II kvadrant" : "III kvadrant");

// ... və ya

quadrant = x > 0 ? y > 0 ? "I kvadrant" : "IV kvadrant" : y > 0 ? "II kvadrant" : "III kvadrant";


Console.WriteLine(quadrant);