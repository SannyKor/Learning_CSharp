
using Task_3;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Dictionary<string, TranslationOptions> vocabulary = new Dictionary<string, TranslationOptions>
{
    { "привіт", new TranslationOptions("Hello", "Привет") },
    { "до побачення", new TranslationOptions("Goodbye", "До свидания") },
    { "дякую", new TranslationOptions("Thank you", "Спасибо") },
    { "будь ласка", new TranslationOptions("Please", "Пожалуйста") },
    { "так", new TranslationOptions("Yes", "Да") },
    { "ні", new TranslationOptions("No", "Нет") },
    { "вибачте", new TranslationOptions("Excuse me", "Извините") },
    { "пробачте", new TranslationOptions("Sorry", "Извините") },
    { "як справи?", new TranslationOptions("How are you?", "Как дела?") },
    { "я тебе люблю", new TranslationOptions("I love you", "Я тебя люблю") }
};

Console.WriteLine("Введіть слово для якого потрібен переклад:");
int counter = 1;
foreach (var word in vocabulary)
{
        Console.WriteLine($"{counter}. {word.Key}");
}
string? choice;
while (true)
{
    choice = Console.ReadLine()?.ToLower();
    if (!string.IsNullOrWhiteSpace(choice))
    {
        break;
    }
    Console.WriteLine("Щось не так. Спробуйте ще раз ввести слово.");
}
if (vocabulary.TryGetValue(choice, out var translation))
{
    Console.WriteLine($"Виводимо на екран переклад слова '{choice}' англійською: {translation.EnglishTranslation}");
    Console.WriteLine($"Виводимо на екран переклад слова '{choice}' російською: {translation.RussianTranslation}");
}
else
{
    Console.WriteLine($"Слово '{choice}' не знайдено у словнику.");
}