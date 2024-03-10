using System;

namespace KolmeValikkoaSovellus
{
    class Program
    {
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
            // Tähän voi lisätä toiminnallisuutta Moi-valikossa
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
    }
}
