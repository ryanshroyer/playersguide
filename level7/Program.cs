// See https://aka.ms/new-console-template for more information

// ---------- The Triangle Farmer ----------
//
string baseLengthTxt;
string heightTxt;
float area;

Console.WriteLine("What is the triangle's base length?");
baseLengthTxt = Console.ReadLine();
float baseLength = Convert.ToSingle(baseLengthTxt);
Console.WriteLine("What is the triangle's height?");
heightTxt = Console.ReadLine();
float height = Convert.ToSingle(heightTxt);
area = (baseLength * height) / 2;
Console.WriteLine("The area of the triangle is " + area);


// ---------- The Four Sisters and the Duckbear ----------
//
// Console.WriteLine("Enter the number of eggs gathered.");
// //string eggsTxt = Console.ReadLine();
// //int eggs = Convert.ToInt32(eggsTxt);
// // this next line is better than the two above
// int eggs = Convert.ToInt32(Console.ReadLine());
// int allotment = eggs / 4;
// int remainder = eggs % 4;
// Console.WriteLine("Each sister will get " + allotment + " eggs.");
// Console.WriteLine("The duckbear will get " + remainder + " eggs.");
//

// ---------- The Dominion of Kings ----------
//
// Console.WriteLine("Enter the number of estates");
// int estates = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of duchies");
// int duchies = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of provinces");
// int provinces = Convert.ToInt32(Console.ReadLine());
//
// int ePoints = estates * 1;
// int dPoints = duchies * 3;
// int pPoints = provinces * 6;
// int total = ePoints + dPoints + pPoints;
//
// Console.WriteLine("Your total points are " + total);
//

// ---------- misc ----------
// float a = 5f;
// float b = 2f;
// float result = a / b;
// Console.WriteLine(result);
//

// int a = 5;
// a = a + 1;
// a += 1;
// a++;
// Console.WriteLine(a);
//
