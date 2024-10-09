namespace ConsoleApp4
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {
            FullName = "Unknown Employee";
            Position = "Unknown Position";
            Phone = "0000000000";
            Email = "unknown@example.com";
            Salary = 0.0m;
        }

        public Employee(string fullName, string position, string phone, string email, decimal salary)
        {
            FullName = fullName;
            Position = position;
            Phone = phone;
            Email = email;
            Salary = salary;
        }
    }

    public class Company
    {
            public string Name { get; set; }
            public DateTime FoundedDate { get; set; }
            public string BusinessProfile { get; set; }
            public string DirectorName { get; set; }
            public int EmployeeCount { get; set; }
            public string Address { get; set; }
            public List<Employee> Employees { get; set; } = new List<Employee>();

            public Company()
            {
                Name = "Unknown Company";
                FoundedDate = DateTime.Now;
                BusinessProfile = "General";
                DirectorName = "No Director";
                EmployeeCount = 0;
                Address = "Unknown Address";
                Employees = new List<Employee>(); 
            }

            public Company(string name, DateTime foundedDate, string businessProfile, string directorName, int employeeCount, string address)
            {
                Name = name;
                FoundedDate = foundedDate;
                BusinessProfile = businessProfile;
                DirectorName = directorName;
                EmployeeCount = employeeCount;
                Address = address;
            }

            public List<Employee> GetAllEmployees()
            {
                return Employees;
            }

        public void EmployeesSalary(decimal salary)
        {
            var highSalaryEmployees = Employees.Where(e => e.Salary > salary).ToList();
            Console.WriteLine($"\nПрацівники з зарплатою більше {salary}:");
            foreach (var emp in highSalaryEmployees)
            {
                Console.WriteLine(emp.FullName);
            }
        }


        public void EmployeesByPosition(string position)
        {
            var managers = Employees.Where(e => e.Position.Equals(position, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine($"\nПрацівники з посадою {position}:");
            foreach (var emp in managers)
            {
                Console.WriteLine(emp.FullName);
            }
        }


        public void EmployeesPrefix(string prefix)
        {
            var phonePrefixEmployees = Employees.Where(e => e.Phone.StartsWith(prefix)).ToList();
            Console.WriteLine($"\nПрацівники, телефон яких починається з {prefix}:");
            foreach (var emp in phonePrefixEmployees)
            {
                Console.WriteLine(emp.FullName);
            }
        }
        public void EmployeesEmailPrefix(string prefix)
        {
            var emailPrefixEmployees = Employees.Where(e => e.Email.StartsWith(prefix)).ToList();
            Console.WriteLine($"\nПрацівники з Email, що починається з {prefix}:");
            foreach (var emp in emailPrefixEmployees)
            {
                Console.WriteLine(emp.FullName);
            }
        }

        public void EmployeesFirstName(string firstName)
        {
            var lionelEmployees =
                     from e in Employees
                     let names = e.FullName.Split(' ')
                     where names[0].Equals(firstName, StringComparison.OrdinalIgnoreCase)
                     select e;
            foreach (var emp in lionelEmployees)
            {
                Console.WriteLine(emp.FullName);
            }
        }
    }
    internal class Task4
    {
        public static void RunAllTasks(List<Company> companies)
        {

            var companyDetails = from com in companies
                                 select new
                                 {
                                     com.Name,
                                     FoundedDate = com.FoundedDate.ToShortDateString(),
                                     com.BusinessProfile,
                                     com.DirectorName,
                                     com.EmployeeCount,
                                     com.Address
                                 };

            foreach (var company in companyDetails)
            {
                Console.WriteLine($"{company.Name}, {company.FoundedDate}, {company.BusinessProfile}, {company.DirectorName}, {company.EmployeeCount}, {company.Address}");
            }

            Console.WriteLine();


            Console.WriteLine("Компанії, що мають назву Food:");
            var foodCompanies = companies.Where(c => c.Name.Contains("Food"));
            foreach (var com in foodCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

         
            Console.WriteLine("Компанії в маркетингу:");
            var marketingCompanies = companies.Where(c => c.BusinessProfile == "Marketing");
            foreach (var com in marketingCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Компанії у сфері маркетингу чи ІТ:");
            var marketingOrITCompanies = companies.Where(c => c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT");
            foreach (var com in marketingOrITCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();


            Console.WriteLine("Компанії з понад 100 співробітниками:");
            var largeCompanies = companies.Where(c => c.EmployeeCount > 100);
            foreach (var com in largeCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Компанії з кількістю співробітників від 100 до 300 осіб:");
            var mediumCompanies = companies.Where(c => c.EmployeeCount >= 100 && c.EmployeeCount <= 300);
            foreach (var com in mediumCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Компанія в London:");
            var londonCompanies = companies.Where(c => c.Address == "London");
            foreach (var com in londonCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Компанія у кінці назви якої  'White':");
            var whiteDirectors = companies.Where(c => c.DirectorName.Split().Last() == "White");
            foreach (var com in whiteDirectors)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();


            Console.WriteLine("Компанія відкрилась 2 роки тому:");
            var oldCompanies = companies.Where(c => (DateTime.Now - c.FoundedDate).TotalDays > 365 * 2);
            foreach (var com in oldCompanies)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Компанія відкрилася 123 дні тому:");
            var founded123DaysAgo = companies.Where(c => (DateTime.Now - c.FoundedDate).TotalDays == 123);
            foreach (var com in founded123DaysAgo)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Компанії з прізвищем директора 'Black' і назва містить «Білий»:");
            var blackDirectorWhiteName = companies.Where(c => c.DirectorName.Split().Last() == "Black" && c.Name.Contains("White"));
            foreach (var com in blackDirectorWhiteName)
            {
                Console.WriteLine(com.Name);
            }
            Console.WriteLine();
        }

    }
}
