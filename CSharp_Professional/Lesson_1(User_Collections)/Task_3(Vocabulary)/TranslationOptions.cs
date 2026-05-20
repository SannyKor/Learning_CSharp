using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class TranslationOptions
    {
        public string? EnglishTranslation { get; }
        public string? RussianTranslation { get; }
        public TranslationOptions(string? englishTranslation, string? russianTranslation)
        {
            EnglishTranslation = englishTranslation?.ToLower();
            RussianTranslation = russianTranslation?.ToLower();
        }
    }
}
