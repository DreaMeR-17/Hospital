using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minuteForPerson = 10;
            int personInQueue;
            int minutesInHour = 60;
            int minutesWaited;
            int hoursWaited;
            int allMinutesWaited;

            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Среднее время приема одного человека: " + minForPerson);

            Console.Write("Введите количество человек перед вами: ");
            personInQueue = Convert.ToInt32(Console.ReadLine());

            allMinutesWaited = minuteForPerson * personInQueue;
            hoursWaited = allMinutesWaited / minutesInHour;
            minutesWaited = allMinutesWaited % minutesInHour;

            Console.WriteLine($"Перед вами {personInQueue} человек, время ожидания составит: {hoursWaited} часа {minutesWaited} минут");
        }
    }
}
