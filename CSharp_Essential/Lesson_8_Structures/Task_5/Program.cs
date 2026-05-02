
using Microsoft.VisualBasic;
using System.Data;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

while (true)
{
    Console.WriteLine("Введіть дату народження в форматі: дд.мм.рррр");
    string input = Console.ReadLine();
    if(!string.IsNullOrWhiteSpace(input)&&DateOnly.TryParse(input,out DateOnly birthdayDay))
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        DateOnly nextBD = new DateOnly(today.Year, birthdayDay.Month, birthdayDay.Day);
        if(nextBD < today)
        {
            nextBD = new DateOnly(today.Year + 1, birthdayDay.Month, birthdayDay.Day);
        }
        int leftToNextBD = nextBD.DayNumber - today.DayNumber;
        Console.WriteLine($"До наступного дня народження залишилось {leftToNextBD} днів.");
    }
    Console.WriteLine("Щоб вийти або залишитись натисніть n/y");
    char exit = Console.ReadKey().KeyChar;
    if (char.ToLower(exit) == 'n')
        break; 
}