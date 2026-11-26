namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //string title = "clean code";
            //string upperTitle =title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Question2
            //string title1 = "Clean Code";
            //string title2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(title1, title2));
            #endregion

            #region Question3
            //var text = new StringBuilder("");
            //text.Append("Book List");
            //text.Append("-updated");
            //Console.WriteLine(text);
            #endregion

            #region Question4
            //var text = new StringBuilder("");
            //text.Append("Book List");
            //text.Append("-updated");
            //text.Replace("Book List", "Library");
            //Console.WriteLine(text);
            #endregion

            #region Question5
            //string title = "Clean Code";
            //int pages = 464;
            //string message = "Book:" + title + ", " + "pages:" + pages ;
            //Console.WriteLine(message);
            #endregion

            #region Question6
            //string title = "Clean Code";
            //int pages = 464;
            //string message =$"Book: {title}, Pages: {pages}";
            //Console.WriteLine(message);
            #endregion

            #region Question7
            //string title = "Clean Code";
            //int pages = 464;
            //string message =string.Format("Book: {0}, Pages: {1}",title,pages);
            //Console.WriteLine(message);
            #endregion

            #region Question8
            //int pages = 464;
            //if (pages > 300)
            //{
            //Console.WriteLine("Long Book");
            //}
            //else
            //{
            //Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question9
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages>300 && isAvailable==true ) 
            //{
            //Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Question10
            //string title = "Refactoring";
            //switch (title)
            //{
            //case "Clean Code":
            //Console.WriteLine("Great choice!");
            //break;
            //case "Refactoring":
            //Console.WriteLine("Nice pick!");                    
            //break;
            //default:
            //Console.WriteLine("Never heard of it");
            //break;
            //}
            #endregion

            #region Question11
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region Question12 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++) {

            //Console.WriteLine($"{i + 1}.{books[i]}");
            //}
            #endregion

            #region Question13
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i< books.Length)
            //{
            //Console.WriteLine(books[i]);
            //i++;
            //}
            #endregion

            #region Question14
            //int i = 0;
            //do
            //{
            //Console.WriteLine("Checking book..");
            //i++;
            //}
            //while (i < 3);
            #endregion
        }
    }
}
