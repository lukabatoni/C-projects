namespace Practice_1
{
    public delegate void LogMessage(string message);
    public delegate decimal MathOperation(decimal a, decimal b);
    public delegate bool BookValidator(Book book);
    public delegate bool BookFilterDelegate(Book book);
    public delegate BookDto TransformBookDelegate(Book book);



    internal class Program
    {
        static void Main(string[] args)
        {
            LogMessage consoleLogger = LogToConsole;
            consoleLogger("Hello, this is a console log message!");

            LogMessage fileLogger = LogToFile;
            fileLogger("Hello, this is a file log message!");

            LogMessage combinedLogger = consoleLogger + fileLogger;
            combinedLogger("Combined log message!");

            //MathOperations
            MathOperation decimalPlus = PlusDecimal;
            MathOperation decimalSub = SubDecimal;
            MathOperation decimalMul = MulDecimal;
            MathOperation decimalDiv = DivDecimal;

            decimal resultAdd = decimalPlus(3.7m, 2.3m);
            Console.WriteLine($"Addition Result: {resultAdd}");

            decimal resultDiv = decimalDiv(15, 4);
            Console.WriteLine($"Division Result: {resultDiv}");

            MathOperation combinedSubMul = decimalSub + decimalMul;
            decimal resulSubAndMultiply = combinedSubMul(5, 3);
            Console.WriteLine($"Result of Add and Multiply: {resulSubAndMultiply}");



            //Book Class


            var book1 = new Book(
            "Metamorphosis",
            "Franz Kafka",
            "9780142437233",
            "Penguin Classics",
            new DateTime(1915, 10, 15),
            Genre.Fiction,
            224,
            true,
            9.99m);

            BookValidator validator = TitleValidation;

            validator += AuthorValidation;
            validator += ISBNValidation;
            validator += PublisherValidation;
            validator += PublicationDateValidation;
            validator += GenreValidation;
            validator += NumberOfPagesValidation;
            validator += IsAvailableValidation;
            validator += PriceValidation;


            bool isValid = validator(book1);
            Console.WriteLine($"Is the book valid? {isValid}");


            var book2 = new Book(
            "Metamorphosis",
            "Franz Kafka",
            "9780142437233",
            "Penguin Classics",
            new DateTime(1915, 10, 15),
            Genre.Fiction,
            -224, // Invalid Number of Pages
            true,
            -9.99m); // Invalid Price




            List<string> invalidFields = GetInvalidFields(book2, validator);
            Console.WriteLine("Invalid Fields:");
            foreach (var field in invalidFields)
            {
                Console.WriteLine(field);
            }

            //task 4

            List<Book> books = new List<Book>
            {
                new Book("Title1", "Author1", "ISBN1", "Publisher1", DateTime.Now, Genre.Fiction, 200, true, 19.99m),
                new Book("Title2", "Author2", "ISBN2", "Publisher2", DateTime.Now, Genre.Romance, 300, true, 29.99m),
                new Book("Title3", "Author3", "ISBN3", "Publisher3", DateTime.Now, Genre.Fiction, 250, false, 24.99m),
            };

            BookFilterDelegate genreFilter = book => book.Genre == Genre.Fiction;

            List<Book> filteredBooks = FilterBooks(books, genreFilter);
            foreach (Book book in filteredBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}");
            }

            TransformBookDelegate transformDelegate = book => new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                IsAvailable = book.IsAvailable,
                Price = book.Price
            };


            var bookPipeline = new DataPipeline<Book>()
                .AddFilter(FilterByGenre)
                .SetTransformation(TransformToBookDto);

            IEnumerable<BookDto> result = bookPipeline.Process<BookDto>(books);
            PrintBookDtos(result);

        }

        static IEnumerable<Book> FilterByGenre(IEnumerable<Book> books)
        {
            return books.Where(book => book.Genre == Genre.Fiction);
        }

        static BookDto TransformToBookDto(Book book)
        {
            return new BookDto
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                IsAvailable = book.IsAvailable,
                Price = book.Price
            };

        }

        static void PrintBookDtos(IEnumerable<BookDto> bookDtos)
        {
            foreach (var bookDto in bookDtos)
            {
                Console.WriteLine($"Title: {bookDto.Title}, Author: {bookDto.Author}, Genre: {bookDto.Genre}, IsAvailable: {bookDto.IsAvailable}, Price: {bookDto.Price}");
            }
        }



        static List<BookDto> TransformBooks(List<Book> books, TransformBookDelegate transformDelegate)
        {
            return books.Select(book => transformDelegate(book)).ToList();
        }


        static List<Book> FilterBooks(List<Book> books, BookFilterDelegate filter)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (var book in books)
            {
                if (filter(book))
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }

        static List<string> GetInvalidFields(Book book, BookValidator validator)
        {
            var invalidFields = new List<string>();

            foreach (BookValidator validationMethod in validator.GetInvocationList())
            {
                if (!validationMethod(book))
                {
                    string methodName = validationMethod.Method.Name.Replace("Validation", "");
                    invalidFields.Add(methodName);
                }
            }

            return invalidFields;
        } 

        static bool TitleValidation(Book book) => !string.IsNullOrEmpty(book.Title) && book.Title.Length > 1 && book.Title.Length < 255 && IsAlphaOnly(book.Title);
        static bool AuthorValidation(Book book) => !string.IsNullOrEmpty(book.Author) && book.Author.Length > 3 && book.Author.Length < 128 && IsAlphaOnly(book.Author);
        static bool ISBNValidation(Book book) => !string.IsNullOrEmpty(book.ISBN) && book.ISBN.Length == 13 && IsNumericOnly(book.ISBN);
        static bool PublisherValidation(Book book) => !string.IsNullOrEmpty(book.Publisher) && book.Publisher.Length > 2 && book.Publisher.Length < 64;
        static bool PublicationDateValidation(Book book) => book.PublicationDate == null || book.PublicationDate < DateTime.Now;
        static bool GenreValidation(Book book) => Enum.IsDefined(typeof(Genre), book.Genre);
        static bool NumberOfPagesValidation(Book book) => book.NumberOfPages > 0;
        static bool IsAvailableValidation(Book book) => book.IsAvailable;
        static bool PriceValidation(Book book) => book.Price == null || book.Price > 0;
        static bool IsAlphaOnly(string value) => !string.IsNullOrEmpty(value) && value.All(c => char.IsLetter(c) || c == ' ');
        static bool IsNumericOnly(string value) => !string.IsNullOrEmpty(value) && value.All(char.IsDigit);


        static void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        static void LogToFile(string message)
        {
            string filePath = @"C:\Users\lukaa\Desktop\New folder (2)\Day_24 (delegates)\Practice_1\Practice_1\Log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"File Log: {message}");
            }
        }

        static decimal PlusDecimal(decimal a, decimal b) 
        {
            return a + b;
        }

        static decimal SubDecimal(decimal a, decimal b)
        {
            return a - b;
        }

        static decimal MulDecimal(decimal a, decimal b)
        {
            return a * b;
        }

        static decimal DivDecimal(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
