namespace Linq_Lab1
{
    #region EX 6
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public int Salary { get; set; }

    //    public Employee(string name, int salary)
    //    {
    //        Name = name;
    //        Salary = salary;
    //    }
    //}
    #endregion
    #region EX 7
    //class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }

    //    public Book(string title, string author)
    //    {
    //        Title = title;
    //        Author = author;
    //    }
    //}
    #endregion
    #region EX 8
    //class Sales
    //{
    //    public string Salesperson { get; set; }
    //    public int Amount { get; set; }

    //    public Sales(string salesperson, int amount)
    //    {
    //        Salesperson = salesperson;
    //        Amount = amount;
    //    }
    //}
    #endregion
    #region EX 9
    //class Student
    //{
    //    public string StudentName { get; set; }
    //    public string Subject { get; set; }
    //    public int Score { get; set; }

    //    public Student(string studentName, string subject, int score)
    //    {
    //        StudentName = studentName;
    //        Subject = subject;
    //        Score = score;
    //    }
    //}
    #endregion
    #region EX 16
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public string Department { get; set; }

    //    public Employee(string name, string department)
    //    {
    //        Name = name;
    //        Department = department;
    //    }
    //}
    #endregion
    #region EX 20
    //class Order
    //{
    //    public DateTime OrderDate { get; set; }
    //    public int Amount { get; set; }

    //    public Order(DateTime orderDate, int amount)
    //    {
    //        OrderDate = orderDate;
    //        Amount = amount;
    //    }
    //}
    #endregion
    internal class Program
    {
        #region EX 1
        //static void Main(string[] args)
        //{
        //    List<int> Nums = new List<int> { 1, 2, 3, 5, 6, 7, 8 };
        //    int product = Program.product(Nums);
        //    Console.WriteLine(product);
        //}

        //static int product(List<int> numbers)
        //{
        //    int product = 1;
        //    foreach (int number in numbers)
        //    {
        //        product *= number;
        //    }
        //    return product;
        //} 
        #endregion
        #region EX 2
        //static void Main(string[] args)
        //{
        //    List<string> words = new List<string> { "Mohamed", "Ali", "Ahmed" };
        //    string result = RemoveDigit(words);
        //    Console.WriteLine(result);
        //}

        //static string RemoveDigit(List<string> words)
        //{
        //    return String.Join(",", words);
        //}
        #endregion
        #region EX 3
        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 4 };
        //    List<int> squaredNumbers = SquareNumber(numbers);
        //    Console.WriteLine(string.Join(", ", squaredNumbers));
        //}

        //static List<int> SquareNumber(List<int> numbers)
        //{
        //    List<int> resuit = new List<int>();
        //    foreach (int number in numbers)
        //    {
        //        resuit.Add(number * number);
        //    }
        //    return resuit;
        //}
        #endregion
        #region EX 4
        //static void Main(string[] args)
        //{
        //    List<string> words = new List<string> { "Ali", "Mohamed", "Hmada" };
        //    Dictionary<string, int> wordLengths = WordLength(words);

        //    foreach (var c in wordLengths)
        //    {
        //        Console.WriteLine($"{c.Key}: {c.Value}");
        //    }
        //}

        //static Dictionary<string, int> WordLength(List<string> words)
        //{
        //    Dictionary<string, int> result = new Dictionary<string, int>();
        //    foreach (string word in words)
        //    {
        //        result[word] = word.Length;
        //    }
        //    return result;
        //}
        #endregion
        #region EX 5
        //static void Main(string[] args)
        //{
        //    List<int> list1 = new List<int> { 43, 24, 65, 5 };
        //    List<int> list2 = new List<int> { 32, 1, 43, 65 };
        //    List<int> Elements = getElements(list1, list2);

        //    Console.WriteLine(string.Join(", ", Elements));
        //}

        //static List<int> getElements(List<int> lis1, List<int> lis2)
        //{
        //    return lis1.Intersect(lis2).ToList();
        //}
        #endregion
        #region EX 6
        //static void Main(string[] args)
        //{
        //    List<Employee> employees = new List<Employee>
        //{
        //    new Employee("Ahmed", 9599),
        //    new Employee("Ali", 500),
        //    new Employee("Aya", 10000)
        //};

        //    string Paid = GetPaid(employees);
        //    Console.WriteLine(Paid);
        //}

        //static string GetPaid(List<Employee> employees)
        //{
        //    return employees.OrderByDescending(e => e.Salary).First().Name;
        //}
        #endregion
        #region EX 7
        //static void Main(string[] args)
        //{
        //    List<Book> books = new List<Book>
        //{
        //    new Book("Book1", "Author1"),
        //    new Book("Book2", "Author2"),
        //    new Book("Book3", "Author1")
        //};

        //    var booksGroupedByAuthor = GroupBooksByAuthor(books);

        //    foreach (var group in booksGroupedByAuthor)
        //    {
        //        Console.WriteLine($"Author: {group.Key}");
        //        foreach (var book in group)
        //        {
        //            Console.WriteLine($"  {book.Title}");
        //        }
        //    }
        //}

        //static IEnumerable<IGrouping<string, Book>> GroupBooksByAuthor(List<Book> books)
        //{
        //    return books.GroupBy(b => b.Author);
        //}

        #endregion
        #region EX 8
        //static void Main(string[] args)
        //{
        //    List<Sales> sales = new List<Sales>
        //{
        //    new Sales("Ali", 100),
        //    new Sales("Ramy", 200),
        //    new Sales("Ali", 150)
        //};

        //    var totalSalesBySalesperson = totalsalesbysalesperson(sales);

        //    foreach (var c in totalSalesBySalesperson)
        //    {
        //        Console.WriteLine($"{c.Key}: {c.Value}");
        //    }
        //}

        //static Dictionary<string, int> totalsalesbysalesperson(List<Sales> sales)
        //{
        //    return sales
        //        .GroupBy(s => s.Salesperson)
        //        .ToDictionary(g => g.Key, g => g.Sum(s => s.Amount));
        //}

        #endregion
        #region EX 9
        //    static void Main(string[] args)
        //    {
        //        List<Student> scores = new List<Student>
        //    {
        //        new Student("Ali", "Arabic", 90),
        //        new Student("Ali", "Scince", 85),
        //        new Student("Ramy", "Arabic", 80)
        //    };

        //        var highestScoresByStudent = GetHighestScoresByStudent(scores);

        //        foreach (var kvp in highestScoresByStudent)
        //        {
        //            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //        }
        //    }

        //    static Dictionary<string, int> GetHighestScoresByStudent(List<Student> scores)
        //    {
        //        return scores
        //            .GroupBy(s => s.StudentName)
        //            .ToDictionary(g => g.Key, g => g.Max(s => s.Score));
        //    }
        #endregion
        #region EX 11
        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3 };
        //    List<(int Number, int Frequency)> frequencyList = GetFrequencyList(numbers);

        //    foreach (var (Number, Frequency) in frequencyList)
        //    {
        //        Console.WriteLine($"({Number}, {Frequency})");
        //    }
        //}

        //static List<(int Number, int Frequency)> GetFrequencyList(List<int> numbers)
        //{
        //    return numbers
        //        .GroupBy(n => n)
        //        .Select(g => (Number: g.Key, Frequency: g.Count()))
        //        .ToList();
        //}
        #endregion
        #region EX 12
        //static void Main(string[] args)
        //{
        //    List<string> words = new List<string> { "cat", "elephant", "dog", "tiger" };
        //    string firstStringWithE = GetFirstStringWithE(words);

        //    Console.WriteLine(firstStringWithE);
        //}

        //static string GetFirstStringWithE(List<string> words)
        //{
        //    return words.FirstOrDefault(word => word.Contains('c'));
        //}
        #endregion
        #region EX 13
        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //    List<int> result = MultiplyByIndex(numbers);

        //    Console.WriteLine(string.Join(", ", result)); 
        //}

        //static List<int> MultiplyByIndex(List<int> numbers)
        //{
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        result.Add(numbers[i] * i);
        //    }

        //    return result;
        //}
        #endregion
        #region EX 14
        //static void Main(string[] args)
        //{
        //    List<string> words = new List<string> { "apple", "banana" };
        //    List<char> Characters = GetUniqueCharacters(words);

        //    Console.WriteLine(string.Join(", ", Characters));
        //}

        //static List<char> GetUniqueCharacters(List<string> words)
        //{
        //    return words
        //        .SelectMany(word => word)     
        //        .Distinct()                     
        //        .OrderBy(c => c)             
        //        .ToList();                      
        //}
        #endregion
        #region EX 15
        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        //    var (evenCount, oddCount) = CountEvenAndOdd(numbers);

        //    Console.WriteLine($"Even: {evenCount}, Odd: {oddCount}");
        //}

        //static (int EvenCount, int OddCount) CountEvenAndOdd(List<int> numbers)
        //{
        //    int evenCount = numbers.Count(n => n % 2 == 0);
        //    int oddCount = numbers.Count(n => n % 2 != 0);

        //    return (evenCount, oddCount);
        //}
        #endregion
        #region EX 16
        //static void Main(string[] args)
        //{
        //    List<Employee> employees = new List<Employee>
        //{
        //    new Employee("Ali", "HR"),
        //    new Employee("Ramy", "IT"),
        //    new Employee("Samy", "HR"),
        //    new Employee("Sara", "IT"),
        //    new Employee("John", "IT")
        //};

        //    string departmentWithMostEmployees = GetDepartmentWithMostEmployees(employees);
        //    Console.WriteLine(departmentWithMostEmployees); 
        //}

        //static string GetDepartmentWithMostEmployees(List<Employee> employees)
        //{
        //    return employees
        //        .GroupBy(e => e.Department)                
        //        .OrderByDescending(g => g.Count())          
        //        .FirstOrDefault()                            
        //        ?.Key;                                     
        //}

        #endregion
        #region EX 20
        //static void Main(string[] args)
        //{
        //    List<Order> orders = new List<Order>
        //{
        //    new Order(new DateTime(2024, 7, 10), 50),
        //    new Order(new DateTime(2024, 7, 15), 200),
        //    new Order(new DateTime(2024, 7, 16), 150)
        //};

        //    List<int> amountsLast7Days = GetOrderAmountsLast7Days(orders);

        //    Console.WriteLine(string.Join(", ", amountsLast7Days)); 
        //}

        //static List<int> GetOrderAmountsLast7Days(List<Order> orders)
        //{
        //    DateTime today = DateTime.Today; 
        //    DateTime startDate = today.AddDays(-7); 

        //    return orders
        //        .Where(order => order.OrderDate >= startDate) 
        //        .Select(order => order.Amount)            
        //        .ToList();                                   
        //}

        #endregion
    }
}




