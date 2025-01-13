// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the column number:");
short column = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the row number:");
short row = Convert.ToInt16(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();
Console.Title = "Defense of Consolas";

Console.WriteLine("Deploy to: (Read Column, Row)");
// Console.Beep(440, 333); // Beep method only works on Windows
Console.WriteLine($"({column}, {row + 1})");
Console.WriteLine($"({column + 1}, {row})");
Console.WriteLine($"({column}, {row - 1})");
Console.WriteLine($"({column - 1}, {row})");
