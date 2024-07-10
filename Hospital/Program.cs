using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minForPerson = 10;
            int personInQueue;
            int minInHour = 60;
            int minutes;
            int hours;

            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Среднее время приема одного человека: " + minForPerson);

            Console.Write("Введите количество человек перед вами: ");
            personInQueue = Convert.ToInt32(Console.ReadLine());

            hours = (minForPerson * personInQueue) / minInHour;
            minutes = (minForPerson * personInQueue) % minInHour;

            Console.WriteLine($"Перед вами {personInQueue} человек, время ожидания составит: {hours} часа {minutes} минут");
        }
    }
}
