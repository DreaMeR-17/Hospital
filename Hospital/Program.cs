using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minuteForPerson = 10;
            int personsInQueue;
            int minutesInHour = 60;
            int minutesWaited;
            int hoursWaited;
            int allMinutesWaited;

            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Среднее время приема одного человека: " + minForPerson);

            Console.Write("Введите количество человек перед вами: ");
            personsInQueue = Convert.ToInt32(Console.ReadLine());

            allMinutesWaited = minuteForPerson * personsInQueue;
            hoursWaited = allMinutesWaited / minutesInHour;
            minutesWaited = allMinutesWaited % minutesInHour;

            Console.WriteLine($"Перед вами {personsInQueue} человек, время ожидания составит: {hoursWaited} часа {minutesWaited} минут");
        }
    }
}
