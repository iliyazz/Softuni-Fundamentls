using System;
using System.Linq;

namespace P02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = article[0];
            string content = article[1];
            string author = article[2];
            int numberN = int.Parse(Console.ReadLine());
            Article articles = new Article(title, content, author);
            for (int i = 0; i < numberN; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmdArg[0])
                {
                    case "Edit":
                        articles.Edit(cmdArg[1]);
                        break;
                    case "ChangeAuthor":
                        articles.ChangeAuthor(cmdArg[1]);
                        break ;
                    case "Rename":
                        articles.Rename(cmdArg[1]);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(articles);
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

        public string Edit(string newContent)
        {
            this.Content = newContent;
            return newContent;
        }
        public string ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
            return newAuthor;
        }
        public string Rename(string newTitle)
        {
            this.Title = newTitle;
            return newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
