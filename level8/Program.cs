// ---------- Defense of Consolas ----------
//
// Console.WriteLine("Enter the column number:");
// short column = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter the row number:");
// short row = Convert.ToInt16(Console.ReadLine());
//
// Console.BackgroundColor = ConsoleColor.Yellow;
// Console.ForegroundColor = ConsoleColor.Black;
//
// Console.Clear();
// Console.Title = "Defense of Consolas";
//
// Console.WriteLine("Deploy to: (Read Column, Row)");
// // Console.Beep(440, 333); // Beep method only works on Windows
// Console.WriteLine($"({column}, {row + 1})");
// Console.WriteLine($"({column + 1}, {row})");
// Console.WriteLine($"({column}, {row - 1})");
// Console.WriteLine($"({column - 1}, {row})");
//

// ---------- Program-Making Program (from C# 11 expansion) ----------
//
// Console.WriteLine("Enter the units (e.g. meters, feet, lightyears)");
// string units = Console.ReadLine();
// Console.WriteLine("Enter the C# data type (e.g. int, float, decimal)");
// string type = Console.ReadLine();
//
// string program = $$"""
//     Console.WriteLine("Enter the width of the triangle's base in {{units}}: ");
//     {{type}} length = {{type}}.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the height of the triangle in {{units}}: ");
//     {{type}} height = {{type}}.Parse(Console.ReadLine());
//     {{type}} result = length * height / 2;
//     Console.WriteLine($"The area of the triangle is {result} square {{units}}");
//     """;
//
// Console.Clear();
// Console.WriteLine(program);


// ---------- Output ----------

Console.WriteLine("Enter the width of the triangle's base in meters: ");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the height of the triangle in meters: ");
int height = int.Parse(Console.ReadLine());
int result = length * height / 2;
Console.WriteLine($"The area of the triangle is {result} square meters");
