// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int number = new int();
int result = new int();
Console.Write("Введите  трехзначное число ");
number = Convert.ToInt32(Console.ReadLine());
if (number <100 || number < 0)
{
    Console.WriteLine("Вы ввели неверное число");
}
else 
{
    result=number/10;
    Console.WriteLine("Вторая цифра вашего числа " + result%10);
} 