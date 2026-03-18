using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task_4
{
    internal class Store
    {
        Article[] articles;
        public string StoreName { get; set; }
        public Store(string storeName) { articles = new Article[1]; StoreName = storeName; }

        public Article this[int index]
        {
            get
            {
                if (index < 0 || index >= articles.Length)
                    throw new IndexOutOfRangeException("Індекс виходить за межі масиву.");
                return articles[index];
            }
            set
            {
                if (index < 0 || index >= articles.Length)
                    throw new IndexOutOfRangeException("Індекс виходить за межі масиву.");
                articles[index] = value;
            }
        }
        public Article this[string name]
        {
            get
            {
                foreach (var article in articles)
                {
                    if (article != null && article.Name.ToLower() == name.ToLower())
                    {
                        return article;
                    }
                }
                return null;
            }
        }
        public bool AddArticle(Article article)
        {
            foreach (var item in articles)
            {
                if (item != null && item.Name == article.Name)
                {
                    Console.WriteLine($"Товар з назвою '{article.Name}' вже існує в магазині.");
                    return false; // Стаття з такою назвою вже існує
                }
            }
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i] == null)
                {
                    articles[i] = article;
                    return true;
                }
            }
            Article[] newArticles = new Article[articles.Length * 2];
            for (int i = 0; i < articles.Length; i++)
            {
                newArticles[i] = articles[i];
            }
            newArticles[articles.Length] = article;
            articles = newArticles;
            return true;
        }
        public Article FindArticleByName(string name)
        {
            foreach (var article in articles)
            {
                if (article != null && article.Name.ToLower() == name.ToLower())
                {
                    return article;
                }
            }
            return null;
        }
    }
}
