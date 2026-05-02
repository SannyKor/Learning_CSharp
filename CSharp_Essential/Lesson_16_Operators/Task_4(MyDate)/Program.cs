using Task_4_MyDate_;

Console.OutputEncoding = System.Text.Encoding.UTF8;

MyDate date1 = new MyDate(15, 8, 2023);
MyDate date2 = new MyDate(1, 1, 2023);
Console.WriteLine($"Маємо дві дати: \n\t{date1}\n\t{date2}");
Console.WriteLine($"Різниця між датами: {date1 - date2} днів");
int daysToAdd = 30;
Console.WriteLine($"Додаємо {daysToAdd} днів до першої дати: {date1 + daysToAdd}");