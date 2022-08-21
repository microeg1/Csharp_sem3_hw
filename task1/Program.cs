using System;

class Program
{
    static void Main(string[] args)
    {
        // int[] numbers = {};
        // int number1 = Convert.ToInt32(Console.ReadLine());
        // int div = 100;
        // int i = 0;

        // while(i < 3)
        // {
        //     numbers[i] = number1/div;
        //     div = div/10;
        //     Console.WriteLine(numbers[i]);
        //     i++;
        // }
        // //Console.WriteLine(numbers[^2]); почему-то не сработало :(
        Console.Write("Введите трехзначное число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        number1 = number1 % 100 / 10;
        Console.WriteLine(number1);
        


    }
}