namespace first_assignment
{
    internal class Program
    {
        class Book
        {
            string Title;
            int Pages;
        }
        static void Main(string[] args)
        {
            #region Question1
            //1-Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it. 

            //Book book1 = new Book();
            //object obj = book1;

            //Console.WriteLine(obj);
            #endregion

            #region Question2
            //2-Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book. 

            //Console.WriteLine(book1.ToString());

            //Console.WriteLine(book1.Equals(book1));

            //Console.WriteLine(book1.GetHashCode());

            //Console.WriteLine(book1.GetType());

            #endregion

            #region Question3
            //3-Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. int pages = "464"; Compile-time error — you can't put text (string) into an int variable. int pages = 464; 

            //its a Compile Time Erorr bc its int not string to be between " " 

            // int pages= 464;        //fixed
            #endregion
            #region Question4
            //4-Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block. 

            //try
            //{
            //    int result = 10 / 0;
            //}
            //catch
            //{
            //    Console.WriteLine("cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}

            #endregion

            #region Question5
            //-5 Declare an int pages = 300; then store it in a double variable without using a cast. 

            //int pages = 300;

            //double number = pages;

            #endregion

            #region Question6
            //6-Declare a double price = 49.99; then convert it into an int using a cast. 

            //double price = 49.99;

            //int number = (int)price;
            #endregion

            #region Question7
            //7- Given string pagesText = "464";, convert it into an int using the Convert class. 

            //string pagesText = "464";

            //int pages = Convert.ToInt32(pagesText);

            #endregion

            #region Question8
            //8- Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails. 

            //string yeartext = "2023";

            //int year = int.Parse(yeartext);

            //string badtext = "abc";

            //if (int.TryParse(badtext, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Question9
            //9- Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string. 

            //int pages = 464;

            //string text = pages.ToString();

            //Console.WriteLine(text);
            //Console.WriteLine(text.GetType());
            #endregion

            #region Question10
            //10- Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both. 

            //int copie = 100;

            //object obj = copie;

            //int newcopie = (int)obj;

            //Console.WriteLine(copie);
            //Console.WriteLine(newcopie);
            #endregion





        }
    }
}
