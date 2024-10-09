namespace ConsoleApp4
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Виберіть завдання:");
                Console.WriteLine("1. Робота з числами");
                Console.WriteLine("2. Робота з містами");
                Console.WriteLine("3. Робота з студентами");
                Console.WriteLine("4. Робота з компаніями");
                Console.WriteLine("5. Сортування чисел за сумою цифр");
                Console.WriteLine("6. Виконання операцій над масивами");
                Console.WriteLine("7. Робота з працівниками компанії");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        HandleNumbersTask();
                        break;
                    case "2":
                        HandleCitiesTask();
                        break;
                    case "3":
                        HandleStudentsTask();
                        break;
                    case "4":
                        HandleCompaniesTask();
                        break;
                    case "5":
                        Task5.SortNumbersByDigitSum();
                        break;
                    case "6":
                        Task6.PerformArrayOperations();
                        break;
                    case "7":
                        HandleEmployeesTask();
                        break;
                    case "0":
                        return; 
                    default:
                        Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                        break;
                }

                Console.WriteLine("Натисніть будь-яку клавішу");
                Console.ReadKey();
            }
        }

        private static void HandleNumbersTask()
        {
            List<int> numbers = Enumerable.Range(1, 20).ToList();
            Task1.PrintAllNumbers(numbers);
            Task1.PrintEvenNumbers(numbers);
            Task1.PrintOddNumbers(numbers);
            Task1.PrintRangeNumbers(numbers, 5, 12);
            Task1.PrintDivisibleBySeven(numbers);
            Task1.PrintDivisibleByEight(numbers);
        }

        private static void HandleCitiesTask()
        {
            string[] cities = { "Amsterdam", "Berlin", "Copenhagen", "New York", "Stockholm", "Athens" };
            Task2.PrintAllCities(cities);
            Task2.PrintCitiesWithLength(cities, 6);
            Task2.PrintCitiesStartingWithA(cities);
            Task2.PrintCitiesEndingWithM(cities);
            Task2.PrintCitiesNK(cities);
        }

        private static void HandleStudentsTask()
        {
            Student[] students = {
                new Student { FirstName = "John", LastName = "Brown", Age = 20, University = "Oxford" },
                new Student { FirstName = "Jane", LastName = "Brooks", Age = 21, University = "Oxford" },
                new Student { FirstName = "Alice", LastName = "Smith", Age = 18, University = "Cambridge" },
                new Student { FirstName = "Bob", LastName = "Brody", Age = 22, University = "Harvard" },
                new Student { FirstName = "Eve", LastName = "Johnson", Age = 19, University = "Oxford" }
            };
            Task3.PrintAllStudents(students);
            Task3.PrintStudentsWithBro(students);
            Task3.PrintStudents19(students);
            Task3.PrintStudentsBetween20And23(students);
            Task3.PrintOxfordStudents18(students);
        }

        private static void HandleCompaniesTask()
        {
            List<Company> companies = new List<Company>
            {
                new Company { Name = "Food Lovers", FoundedDate = new DateTime(2019, 5, 1), BusinessProfile = "Marketing", DirectorName = "John White", EmployeeCount = 150, Address = "London" },
                new Company { Name = "Tech Innovators", FoundedDate = new DateTime(2022, 1, 15), BusinessProfile = "IT", DirectorName = "Jane Doe", EmployeeCount = 250, Address = "Berlin" },
                new Company { Name = "White Foods", FoundedDate = new DateTime(2021, 3, 20), BusinessProfile = "Food", DirectorName = "Alice Black", EmployeeCount = 80, Address = "New York" },
                new Company { Name = "Marketing Minds", FoundedDate = new DateTime(2018, 7, 30), BusinessProfile = "Marketing", DirectorName = "Bob White", EmployeeCount = 200, Address = "London" },
                new Company { Name = "IT Solutions", FoundedDate = new DateTime(2023, 2, 10), BusinessProfile = "IT", DirectorName = "Charlie Black", EmployeeCount = 120, Address = "London" }
            };
            Task4.RunAllTasks(companies);
        }

        private static void HandleEmployeesTask()
        {
            Company company = new Company("Tech Solutions", DateTime.Now.AddYears(-5), "IT", "John Doe", 150, "123 Main St");

            company.Employees.Add(new Employee("Lionel Messi", "Manager", "239123456", "lionel@tech.com", 1200));
            company.Employees.Add(new Employee("Cristiano Ronaldo", "Developer", "239987654", "cristiano@tech.com", 1300));
            company.Employees.Add(new Employee("David Beckham", "Manager", "240123456", "david@tech.com", 1400));
            company.Employees.Add(new Employee("Diogo Jota", "Designer", "231234567", "diogo@tech.com", 900));


            company.EmployeesSalary(1000);
            company.EmployeesByPosition("Manager");
            company.EmployeesPrefix("23");
            company.EmployeesEmailPrefix("di");
            company.EmployeesFirstName("Lionel");
        }
    }
}

