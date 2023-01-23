// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random();
int randNumber = rand.Next(100, 1000);
Console.WriteLine(randNumber);

System.Console.WriteLine((randNumber / 10) % 10);

// Console.WriteLine("Введите трехзначное число, ");

// string number = Console.ReadLine();
// Console.WriteLine(number[1]);

