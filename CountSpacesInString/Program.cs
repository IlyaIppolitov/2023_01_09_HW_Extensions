using Extensions.ClassString;

Console.WriteLine("=======Программа подсчёта пробелов в строке=======");
Console.WriteLine("Введите строку: ");
string? tempString = Console.ReadLine();
if (tempString == string.Empty)
    Console.WriteLine("Вы ввели пустую строку! (пробелов нет)");
else
    Console.WriteLine($"Количество пробелов в строке: {tempString.CountSpaces()}");