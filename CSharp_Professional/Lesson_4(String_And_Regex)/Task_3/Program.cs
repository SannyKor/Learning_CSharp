
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string text = @"
        Старий лицар їхав на коні через густий ліс. 
        Сонце повільно ховалося за обрій, і промені падали під ноги тварині. 
        Маг подорожував разом з ним заради безпеки, бо в цих краях ходили чутки про розбійників. 
        Вони зупинилися біля джерела, щоб відпочити перед важкою дорогою до замку. 
        Намет розбили під крислатим дубом для захисту від нічного дощу. 
        Зі сходом сонця мандрівники знову вирушили в дорогу.";
Console.WriteLine(text);
// Список популярних українських прийменників
string[] prepositions = {
                "в", "у", "на", "під", "за", "до", "з", "із", "зі", "для",
                "без", "про", "через", "над", "перед", "при", "по", "біля"
            };
string pattern = $@"\b({string.Join("|", prepositions)})\b";
string barkedText = Regex.Replace(text, pattern, "ГАВ!", RegexOptions.IgnoreCase);
Console.WriteLine(barkedText);