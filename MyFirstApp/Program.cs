// See on kommentaar minu koodile

//rakendus küsib kasutajale sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string = sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");

//string interpolation
Console.WriteLine($"Hello, {userName} !");