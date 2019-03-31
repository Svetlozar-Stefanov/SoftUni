using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();
            int articles = int.Parse(Console.ReadLine());

            for (int i = 0; i < articles; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                listOfArticles.Add(article);
            }

            string cryteria = Console.ReadLine();
            if (cryteria == "title")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Title).ToList();
            }
            else if (cryteria == "content")
            {
               listOfArticles = listOfArticles.OrderBy(x => x.Content).ToList();
            }
            else if (cryteria == "author")
            {
               listOfArticles = listOfArticles.OrderBy(x => x.Author).ToList();
            }

            foreach (var article in listOfArticles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title;
        public string Content;
        public string Author;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }


}
