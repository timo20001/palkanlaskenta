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
                Console.WriteLine("1. Add worker");
                Console.WriteLine("2. Display all workers");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
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
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
            }
        }

        static void toinenValikko()
        {
            Console.WriteLine("Tervetuloa Palkka ja Sivukulut-valikkoon!"); //2 valikko
            // Tähän voi lisätä toiminnallisuutta Hei-valikossa
        }

        static void kolmasValikko()
        {
            Console.WriteLine("Tervetuloa Tulevat palkkapäivät-valikkoon!"); //3 valikko
            // Tähän voi lisätä toiminnallisuutta Terve-valikossa
        }


        static void AddWorker()
        {
            Console.Write("Enter worker's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter worker's salary: ");
            double salary = double.Parse(Console.ReadLine());

            workers.Add(new Worker(name, salary));
            Console.WriteLine("Worker added successfully.");
        }

        static void DisplayWorkers()
        {
            if (workers.Count == 0)
            {
                Console.WriteLine("No workers added yet.");
                return;
            }

            Console.WriteLine("Workers:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"Name: {worker.Name}, Salary: {worker.Salary}");
            }
        }
    }
    
}
