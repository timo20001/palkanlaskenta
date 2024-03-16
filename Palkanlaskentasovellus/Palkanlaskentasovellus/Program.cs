using System;
using System.Collections.Generic;
class Worker
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Worker(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}




namespace KolmeValikkoaSovellus
{
    class Program
    {
        static List<Worker> workers = new List<Worker>();
        static void Main(string[] args)
        {
            string valinta = "";

            while (valinta != "lopeta")
            {
                Console.WriteLine("Valitse valikko numerolla:");
                Console.WriteLine("1. Työntekijöiden lisäys ja tietojen muutto");
                Console.WriteLine("2. Palkka- ja sivukulutiedot"); 
                Console.WriteLine("3. Tulevat palkkapäivät"); 
                Console.WriteLine("Kirjoita 'lopeta' poistuaksesi.");

                valinta = Console.ReadLine().ToLower();

                switch (valinta)
                {
                    case "1": 
                        ensimmäinenValikko();
                        break;
                    case "2": 
                        toinenValikko();
                        break;
                    case "3": 
                        kolmasValikko();
                        break;
                    case "lopeta":
                        Console.WriteLine("Sovellus suljetaan.");
                        break;
                    default:
                        Console.WriteLine("Virheellinen valinta, yritä uudelleen.");
                        break;
                }
            }
        }

        static void ensimmäinenValikko()
        {

            Console.WriteLine("Tervetuloa Työntekijöiden lisäysvalikkoon!"); //1 valikko
            { 
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Lisää työntekijä");
                Console.WriteLine("2. Näytä kaikki työntekijät");
                Console.WriteLine("3. Poistu päävalikkoon");
                Console.Write("Kirjaa valintasi: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddWorker();
                        break;
                    case "2":
                        DisplayWorkers();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Väärä valinta. Yritä uudelleen.");
                        break;
                }

                Console.WriteLine();
            }
            }
        }

        static void toinenValikko()
        {

            Console.WriteLine("Tervetuloa Palkka- ja sivukulutiedot -valikkoon!"); //2 valikko

            if (workers.Count == 0)
            {
                Console.WriteLine("Työntekijöitä ei ole vielä lisätty.");
                return;
            }

            Console.WriteLine("Palkka- ja sivukulutiedot:");

            foreach (var worker in workers)
            {
                double totalCost = CalculateTotalCost(worker.Salary);
                double totalCostAfterAdvanceBooking = AdvanceBooking(worker.Salary);

                Console.WriteLine($"Nimi: {worker.Name}, Palkka: {worker.Salary}, Kokonaiskustannus: {totalCost}, Ennakkopidätyksen jälkeen: {totalCostAfterAdvanceBooking}, Ennakkopidätysmäärä: {worker.Salary - totalCostAfterAdvanceBooking}");
            }

            static double CalculateTotalCost(double salary)
            {
                // Olettaen että muut kulut ovat 20% palkasta
                double additionalCostPercentage = 0.20;
                double additionalCost = salary * additionalCostPercentage;
                double totalCost = salary + additionalCost;
                return totalCost;
            }
            static double AdvanceBooking(double salary)
            {
                // Olettaen että ennakkopidätys kulut ovat 24% kokopalkasta
                double advanceBookingPercentage = 0.24; // 24% 
                double advanceBookingDeduction = salary * advanceBookingPercentage;
                double totalCostAfterAdvanceBooking = salary - advanceBookingDeduction;
                return totalCostAfterAdvanceBooking;
            }

        }

        static void kolmasValikko()
        {
            Console.WriteLine("Tervetuloa Tulevat palkkapäivät-valikkoon!"); //3 valikko
            // Tähän voi lisätä toiminnallisuutta Terve-valikossa
        }


        static void AddWorker()
        {
            Console.Write("Lisää työntekijän nimi: ");
            string name = Console.ReadLine();

            Console.Write("Lisää työntekijän palkka: ");
            double salary = double.Parse(Console.ReadLine());

            workers.Add(new Worker(name, salary));
            Console.WriteLine("Työntekijä lisätty onnistuneesti.");
        }

        static void DisplayWorkers()
        {
            if (workers.Count == 0)
            {
                Console.WriteLine("Työntekijöitä ei ole vielä lisätty.");
                return;
            }

            Console.WriteLine("Työntekijät:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"Nimi: {worker.Name}, Palkka: {worker.Salary}");
            }
        }
    }


}
