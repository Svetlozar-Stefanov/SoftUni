using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article(input[0], input[1], input[2]);
            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article.ToString());

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

        string Title;
        string Content;
        string Author;

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newName)
        {
            Title = newName;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

  
}
