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



        }
    }
}
