namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, (string, double)> menu = new Dictionary<int, (string, double)>()
            {
                {1, ("Coca Cola 150 ml", 2.50)},
                {2, ("Insalata di pollo", 5.20)},
                {3, ("Pizza Margherita", 10.00)},
                {4, ("Pizza 4 Formaggi", 12.50)},
                {5, ("Patatine fritte", 3.50)},
                {6, ("Insalata di riso", 8.00)},
                {7, ("Frutta di stagione", 5.00)},
                {8, ("Pizza fritta", 5.00)},
                {9, ("Piadina vegetariana", 6.00)},
                {10, ("Panino Hamburger", 7.90)}
            };

            List<(string, double)> ordine = new List<(string, double)>();

            Console.WriteLine("==============MENU==============");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Item1} (Euro {item.Value.Item2:F2})");
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");

            int scelta;
            do
            {
                Console.Write("Seleziona un cibo (o 11 per stampare il conto): ");
                scelta = Convert.ToInt32(Console.ReadLine());

                if (scelta >= 1 && scelta <= 10)
                {
                    ordine.Add(menu[scelta]);
                    Console.WriteLine($"{menu[scelta].Item1} aggiunto all'ordine.");
                }
                else if (scelta != 11)
                {
                    Console.WriteLine("Scelta non valida.");
                }
            } while (scelta != 11);

            Console.WriteLine("\n=============CONTO===============");
            double totale = 0;
            foreach (var item in ordine)
            {
                Console.WriteLine($"{item.Item1} (Euro {item.Item2:F2})");
                totale += item.Item2;
            }
            totale += 3.00; // Aggiunta del servizio al tavolo
            Console.WriteLine($"Servizio al tavolo (Euro 3.00)");
            Console.WriteLine($"Totale: Euro {totale:F2}");
            Console.WriteLine("Grazie per aver usufruito del nostro servizio!");

            Console.ReadLine();
        }
    }
}
