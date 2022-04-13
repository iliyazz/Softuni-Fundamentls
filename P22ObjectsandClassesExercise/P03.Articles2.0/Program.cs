using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for(int i = 0; i < numberN; i++)
            {
                string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string title = article[0];
                string content = article[1];
                string author = article[2];
                articles.Add(new Article(title, content, author));
            }

            string command = Console.ReadLine();
            List<Article> orderedArticle = new List<Article>();
            switch (command)
            {
                case "title":
                    orderedArticle = articles.ToList();//.OrderBy(a => a.Title)
                    break;
                case "content":
                    orderedArticle = articles.ToList();//OrderBy(a => a.Content).
                    break;
                case "author":
                    orderedArticle = articles.ToList();//OrderBy(a => a.Author).
                    break;
                default:
                    break;
            }

            foreach (Article item in orderedArticle)
            {
                Console.WriteLine(item);
            }



        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
}
