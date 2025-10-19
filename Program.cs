namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobManager manager = new JobManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Jobbansökningshanterare ---");
                Console.WriteLine("1. Lägg till ansökan");
                Console.WriteLine("2. Visa alla ansökningar");
                Console.WriteLine("3. Uppdatera status");
                Console.WriteLine("4. Ta bort ansökan");
                Console.WriteLine("5. Avsluta");
                Console.Write("Välj ett alternativ: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddApplication(manager);
                        break;
                    case "2":
                        manager.ShowAll();
                        break;
                    case "3":
                        UpdateApplicationStatus(manager);
                        break;
                    case "4":
                        UpdateApplicationStatus(manager);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }

            // Hjälpmedel för att lägga till ansökan
            static void AddApplication(JobManager manager)
            {
                Console.Write("Företagsnamn: ");
                string companyName = Console.ReadLine();
                Console.Write("Positionstitel: ");
                string positionTitle = Console.ReadLine();
                DateTime applicationDate;
                while (true)
                {
                    Console.Write("Ansökningsdatum (yyyy-mm-dd): ");
                    if (DateTime.TryParse(Console.ReadLine(), out applicationDate))
                        break;
                    Console.WriteLine("Ogiltigt datumformat, försök igen.");
                }
                Console.Write("Löneförväntning: ");
                int salaryExpectation;
                while (!int.TryParse(Console.ReadLine(), out salaryExpectation))
                {
                    Console.WriteLine("Ogiltig siffra, försök igen.");
                }
                JobApplication newApp = new JobApplication
                {
                    CompanyName = companyName,
                    PositionTitle = positionTitle,
                    ApplicationDate = applicationDate,
                    Status = "Applied",
                    SalaryExpectation = salaryExpectation
                };
                manager.AddJob(newApp);
            }

            static void UpdateApplicationStatus(JobManager manager)
            {
                Console.Write("Företagsnamn att uppdatera: ");
                string companyName = Console.ReadLine() ?? "";

                Console.WriteLine("Välj ny status:");
                Console.WriteLine("1. Applied");
                Console.WriteLine("2. Interview");
                Console.WriteLine("3. Offer");
                Console.WriteLine("4. Rejected");
                Console.Write("Val: ");
                string statusChoice = Console.ReadLine();

                string newStatus;

                switch (statusChoice)
                {
                    case "1": newStatus = "Applied"; break;
                    case "2": newStatus = "Interview"; break;
                    case "3": newStatus = "Offer"; break;
                    case "4": newStatus = "Rejected"; break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        return;
                }

                manager.UpdateStatus(companyName, newStatus);
                Console.WriteLine("Status uppdaterad!");
            }

        }
        // Feature 2: validation test

    }
}

