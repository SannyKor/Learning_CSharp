
using Task_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Worker worker1 = new Worker(Post.Intern);
Worker worker2 = new Worker(Post.Manager);
Worker worker3 = new Worker(Post.SeniorDeveloper);

worker1.BonusCalculation(100);
Console.WriteLine("-", 50);
worker2.BonusCalculation(200);
Console.WriteLine("-", 50);
worker3.BonusCalculation(130);