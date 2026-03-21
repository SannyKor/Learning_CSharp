using Task_2;

Train[] trains = new Train[8];

trains[0] = new Train("Харків", 76, new TimeOnly(10, 0));
trains[1] = new Train("Львів", 85, new TimeOnly(8, 45));
trains[2] = new Train("Рівне", 101, new TimeOnly(22, 0)); 
trains[3] = new Train("Херсон", 43, new TimeOnly(19, 30));
Array.Sort(trains);

foreach (var t in trains)
{ 
    if (t.TrainNumber != 0)
    Console.WriteLine($"Номер потяга: {t.TrainNumber}\tЧас відправлення: {t.DepartureTime}\t Пункт призначення: {t.Destination}");
}

bool exit = false;
while (true)
{
    Console.WriteLine("\nЩоб додати потяг, введіть 1. " +
        "\nЩоб переглянути потяг за номером, введіть 2." +
        "\nЩоб переглянути весь список потягів, введіть 3." +
        "\nЩоб вийти, введіть 0.");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("Введіть пункт призначення:");
            string destination = Console.ReadLine();
            Console.WriteLine("Введіть номер потяга:");
            int trainNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть час відправлення (години та хвилини через двокрапку):");
            TimeOnly departureTime = TimeOnly.Parse(Console.ReadLine());
            Train newTrain = new Train(destination, trainNumber, departureTime);
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == 0)
                {
                    trains[i] = newTrain;
                    break;
                }
            }
            Array.Sort(trains);
            break;
        case "2":
            Console.WriteLine("Введіть номер потяга для перегляду:");
            int searchNumber = int.Parse(Console.ReadLine());
            
            foreach (var t in trains)
            {
                if (t.TrainNumber == searchNumber)
                {
                    Console.WriteLine($"Номер потяга: {t.TrainNumber}\tЧас відправлення: {t.DepartureTime}\t Пункт призначення{t.Destination}");
                    break;
                }
            }
            Console.WriteLine("Потяг з таким номером не знайдено.");
            break;
        case "3":
            foreach (var t in trains)
            {
                if (t.TrainNumber != 0)
                    Console.WriteLine($"Номер потяга: {t.TrainNumber}\tЧас відправлення: {t.DepartureTime}\t Пункт призначення{t.Destination}");
            }
            break;
        case "0":
            exit = true;
            break;
        default:
            Console.WriteLine("Невірна команда. Спробуйте ще раз.");
            break;
    }
}