// // 17. Напишите программу, которая принимает на вход координаты 
// // точки (X и Y), причем X != 0 Y != 0
// // выдает номер четверти плоскости

// Console.WriteLine("Введите координаты точки:");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xCoordinate, yCoordinate);
// string result = quarter > 0 
//                 ? $"Указаные координаты соответствуют четверти: {quarter}" 
//                 : "Введены некоректные координаты";
// Console.WriteLine(result);

// int Quarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }

// Console.WriteLine("Введите номер четверти:");
// Console.Write("Четверть: ");
// int Quarter = Convert.ToInt32(Console.ReadLine());

// string finish = Coordinates(Quarter);
// Console.WriteLine(finish);

// string Coordinates(int quarter)
// {
//     if (quarter == 1) return "x > 0, y > 0";
//     if (quarter == 2) return "x < 0, y > 0";
//     if (quarter == 3) return "x < 0, y < 0";
//     if (quarter == 4) return "x > 0, y < 0";
//     return "Такой четверти не существует";
// }

// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними
// в 2D пространстве.

// Console.WriteLine("Введите координаты первой точки:");
// Console.Write("X: ");
// int x1Coord = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y1Coord = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int z1Coord = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки:");
// Console.Write("X: ");
// int x2Coord = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y2Coord = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int z2Coord = Convert.ToInt32(Console.ReadLine());

// double result = Distance(x1Coord, y1Coord, z1Coord, x2Coord, y2Coord, z2Coord);
// double finish = Math.Round(result, 2, MidpointRounding.ToZero);
// Console.WriteLine($"Расстояние между двух точек в 3D пространстве {finish}");
// double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     int dis = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
//     return dis; 
// }

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if(N < 1)
// {
//     Console.WriteLine("Некоректные данные");
//     return;
// }
// CubeTable(N);

// void CubeTable(int num)
// {
//     for(int i = 1; i <= num; i++)
//     {
//         int cube = i * i * i;
//         Console.WriteLine($"{i}    {cube}");
//     }
// }