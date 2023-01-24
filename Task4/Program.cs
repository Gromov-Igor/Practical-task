Console.WriteLine("Введите число:");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
Console.WriteLine(b % 2 == 0 ? "Четное" : "Не четное");