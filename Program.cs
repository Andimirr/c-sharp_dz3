// Задача 23
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(double N)
// {
//     double i = 1;
//     while (i <= N)
//     {
//         Console.WriteLine($"{i}-> {i}^3 -> {Math.Pow(i, 3)}");
//         i++;
//     }
// }
// Console.WriteLine("Enter the number N:");
// double N = Convert.ToDouble(Console.ReadLine());

// Cube(N);

// double Cube(double N)
// {
//    return Math.Pow(N, 3);
// }
// Console.WriteLine("Impute the number N: ");
// double N = Convert.ToDouble(Console.ReadLine());
// double i = 1;
// while (i <= N)
// {
//     Console.WriteLine($"{i} -> {i}^3 -> {Cube(i) }");
//     i++;
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.Clear();
// double Distance(double x1, double y1,double z1,
//                 double x2, double y2,double z2)
               
                 
// {
//    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + 
//                                Math.Pow(y2 - y1, 2) +
//                                Math.Pow(z2 - z1, 2)), 2);
// }
// Console.Write("Enter point Coordinates Xa: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter point Coordinates Ya: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter point Coordinates Za: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter point Coordinates Xb: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter point Coordinates Yb: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter point Coordinates Zb: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Segment Length: -> {distance}");  


// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.Clear();
//  bool IsPalindrom(string word, bool ignoreCase = true)
// {
//     var reversedWord = new string(word.Reverse().ToArray());
//     bool result;
//     if (ignoreCase)
//     {
//         result = reversedWord.Equals(word, StringComparison.InvariantCultureIgnoreCase);
//     }
//     else
//     {
//         result = reversedWord.Equals(word);
//     }

//     return result;
// }
// Console.Write("Enter number: ");
// Console.WriteLine(IsPalindrom(Console.ReadLine()));