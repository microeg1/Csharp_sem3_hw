using System;

class Program
{
    static void Main(string[] args)
    {     
        Console.Write("Введите число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 < -100 && number1 > 100)
        {
            Console.WriteLine("Третьей цифры нет.");
        }
        else
        {
            if (number1<0)
            {
                number1 = number1 * -1;
            }
            string thrdNum = Convert.ToString(number1);
            Console.WriteLine(thrdNum[2]);
        }
    }
}