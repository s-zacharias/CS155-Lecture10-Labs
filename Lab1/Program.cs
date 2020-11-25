using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email1 = new Email("Rob", "Rey", "Hi", "What's up?");
            Email email2 = new Email("Kate", "Kathy", "Where do we meet?",
                "Just checking in on our upcoming meeting.");
            File file1 = new File("/documents/file1", "Just a test file.");
            File file2 = new File("/documents/file2", "Just a second test file.");

            Console.WriteLine(ContainsKeyword(email1, "up"));
            Console.WriteLine(ContainsKeyword(email2, "our"));
            Console.WriteLine(ContainsKeyword(file1, "file"));
            Console.WriteLine(ContainsKeyword(file2, "files"));
        }

        public static bool ContainsKeyword(Document docObject, string keyword)

        {

            if (docObject.toString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;

        }
    }

    public class Document
    {
        public string Content { get; set; }

        public Document(string content)
        {
            Content = content;
        }

        public string toString()
        {
            return Content;
        }
    }

    public class Email : Document
    {
        public string Sender { get; set; }
        public string Receipient { get; set; }
        public string Title { get; set; }

        public Email(string sender, string receipient, string title,
            string content) : base(content)
        {
            Sender = sender;
            Receipient = receipient;
            Title = title;
            Content = content;
        }

        public new string toString()
        {
            return "Sender: " + Sender + "\nReceipient: " + Receipient +
                "Title: " + Title + "\n Body: " + Content;
        }
    }

    public class File : Document
    {
        public string Pathname { get; set; }

        public File(string pathname, string content) : base(content)
        {
            Pathname = pathname;
            Content = content;
        }

        public new string toString()
        {
            return "Pathname: " + Pathname + "\nContent: " + Content;
        }
    }
}
