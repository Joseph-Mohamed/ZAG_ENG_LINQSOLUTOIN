namespace ZAGENG
{
    internal class Program
    {
        public record Product(int Id, string Name, decimal Price, string Category);
        public record Employee(string Name, string Department, decimal Salary);
        public record Course(string Title, List<string> Students);
        static void Main(string[] args)
        {
            #region Q1
            //List<int> numbers = [3, 18, 7, 42, 10, 5, 29, 14, 6, 100];

            //// 1. Query Syntax
            //var query1 = from n in numbers
            //             where n % 2 == 0 && n > 10
            //             orderby n descending
            //             select n;
            //foreach (var n in query1)
            //{
            //    Console.WriteLine(n);
            //}

            //// 2. Fluent (Method) Syntax
            //var query2 = numbers.Where(n => n % 2 == 0 && n > 10)
            //                    .OrderByDescending(n => n);
            //Console.WriteLine(string.Join(",", query2)); 
            #endregion


            #region Q2

            List<Product> products = new()
            {
                new(1, "Laptop", 1200m, "Electronics"),
                new(2, "Phone", 800m, "Electronics"),
                new(3, "Desk", 350m, "Furniture"),
                new(4, "Chair", 150m, "Furniture"),
                new(5, "Headphones", 200m, "Electronics")
            };

            //// 1️ First
            //var firstElectro = products.First(p => p.Category == "Electronics");
            //Console.WriteLine($"First Electronics: {firstElectro.Name}");


            //// 2️ LastOrDefault
            //var lastExp = products.LastOrDefault(p => p.Price > 1000);
            //Console.WriteLine(lastExp != null
            //    ? $"Last > 1000: {lastExp.Name}"
            //    : "No product > 1000");


            //// 3️ Single
            //var singleFurniture = products.Single(p => p.Category == "Furniture" && p.Price > 300);
            //Console.WriteLine($"Single furniture > 300: {singleFurniture.Name}");


            //// 4️ ElementAt
            //var itemAt3 = products.ElementAt(3);
            //Console.WriteLine($"Element at index 3: {itemAt3.Name}");
            #endregion

            #region Q3

            //bool q3_1 = products.All(p => p.Price > 100);
            //Console.WriteLine($"1. Are ALL products priced above 100? -> {q3_1}");

            //bool q3_2 = products.Any(p => p.Category == "Gaming");
            //Console.WriteLine($"2. Is THERE ANY product in the 'Gaming' category? -> {q3_2}");

            //bool q3_3 = products.Any(p => p.Name == "Chair");
            //Console.WriteLine($"3. Does the collection CONTAIN a product named 'Chair'? -> {q3_3}");

            //bool q3_4 = products.Where(p => p.Category == "Electronics").All(p => p.Price > 500);
            //Console.WriteLine($"4. Are ALL Electronics products priced above 500? -> {q3_4}");

            //bool q3_5 = products.(p => p.Price < 200);
            //Console.WriteLine($"5 Is there ANY product cheaper than 200? -> {q3_5}"); 
            #endregion


            #region Q4
            //var prodArray = products.ToArray();
            //var prodDict = products.ToDictionary(p => p.Id);
            //var prodHash = products.Select(p => p.Name).ToHashSet();
            //var prodLookup = products.ToLookup(p => p.Category);
            //foreach (var group in prodLookup)
            //{
            //    if (group.Key == "Electronics")
            //    {

            //        Console.WriteLine($"Category: {group.Key}");
            //        foreach (var product in group)
            //        {
            //            Console.WriteLine(product.Id); // أو Name
            //        }
            //    }


            //}
            /* Important:
               - ToDictionary throws an Exception (ArgumentException) if keys are duplicated.
               - ToLookup handles duplicate keys by grouping values into a collection under the same key.
            */
            #endregion

            #region Q5
            //List<string> orders =
            //[
            //    "ORD-001", "ORD-002", "ORD-003",
            // "ORD-004", "ORD-005", "ORD-006", "ORD-007"
            //];

            //// 1️ Page 1 (1–3)
            //var page1 = orders.Take(3).ToList();

            //// 2️ Page 2 (4–6)
            //var page2 = orders.Skip(3).Take(3).ToList();

            //// 3️ Last 2 orders
            //var last2 = orders.TakeLast(2).ToList();

            //// 4️ Drop first & last
            //var skipFirstLast = orders.Skip(1).SkipLast(1).ToList();


            ////  Print results 
            //void Print(string title, List<string> list)
            //{
            //    Console.WriteLine(title + ": " + string.Join(", ", list));
            //}

            //Print("Page 1", page1);
            //Print("Page 2", page2);
            //Print("Last 2", last2);
            //Print("Without first & last", skipFirstLast);


            //// dy el pagination Skip((pageNumber - 1) * pageSize).Take(pageSize) ==> important
            //// 5️ BONUS — Generic Paginate

            //IEnumerable<T> Paginate<T>(IEnumerable<T> source, int pageNumber, int pageSize)
            //{
            //    return source.Skip((pageNumber - 1) * pageSize)
            //                 .Take(pageSize);
            //}

            //// Example usage
            //var page2Generic = Paginate(orders, 2, 3);
            //Console.WriteLine("Generic Page 2: " + string.Join(", ", page2Generic));
            #endregion

            #region Q6
            List<Employee> employees = [
            new("Ali", "Engineering", 9000m),
            new("Sara", "Engineering", 8500m),
            new("Omar", "HR", 6000m),
            new("Mona", "HR", 6200m),
            new("Yara", "Marketing", 7000m),
            new("Karim", "Marketing", 7500m),
            new("Nada", "Engineering", 9500m)
             ];

            //           // 1️ Anonymous projection
            //           var anon = employees.Select(e => new { FullName = e.Name.ToUpper(), e.Salary });

            //           Console.WriteLine("Anonymous:");
            //           foreach (var a in anon)
            //           {
            //               Console.WriteLine($"{a.FullName} - {a.Salary}");
            //           }
            //           // 2️ Formatted string
            //           var formatted = employees.Select(e => $"{e.Name} works in {e.Department} — EGP {e.Salary:N0}");

            //           Console.WriteLine("\nFormatted:");
            //           foreach (var f in formatted)
            //           {
            //               Console.WriteLine(f);
            //           }
            //           // 3️ Ranked by salary
            //           var ranked = employees.OrderByDescending(e => e.Salary)
            //                                .Select((e, index) => new { Rank = index + 1, e.Name, e.Salary });

            //           Console.WriteLine("\nRanking:");
            //           foreach (var r in ranked)
            //           {
            //               Console.WriteLine($"#{r.Rank} {r.Name} - {r.Salary}");
            //           }

            //           // 4️ BONUS: Seniority
            //           var seniority = employees.Select(e => new
            //           {
            //               e.Name,
            //               Level = e.Salary >= 9000 ? "Senior"
            //                     : e.Salary >= 7000 ? "Mid"
            //                     : "Junior"
            //           });

            //           Console.WriteLine("\nSeniority:");
            //           foreach (var s in seniority)
            //           {
            //               Console.WriteLine($"{s.Name} - {s.Level}");
            //           }
            #endregion
            #region Q7

            // Q 7

            //List<int> scores = [88, 92, 75, 60, 55, 80, 91, 45];
            //var takeResults = scores.TakeWhile(s => s >= 70);
            //var skipResults = scores.SkipWhile(s => s >= 70);

            //Console.WriteLine("TakeWhile (>=70): " + string.Join(", ", takeResults));
            //Console.WriteLine("SkipWhile (>=70): " + string.Join(", ", skipResults));
            #endregion

            #region Q8
            // Q 8

            //var groups = employees.GroupBy(e => e.Department);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key} → Count: {group.Count()}, Avg: {group.Average(e => e.Salary)}");

            //    Console.WriteLine("Employees (desc salary):");
            //    foreach (var emp in group.OrderByDescending(e => e.Salary))
            //    {
            //        Console.WriteLine($"   {emp.Name} - {emp.Salary}");
            //    }
            //}

            //var highestDept = employees
            //    .GroupBy(e => e.Department)
            //    .OrderByDescending(g => g.Sum(e => e.Salary))
            //    .First();

            //Console.WriteLine($"Highest Budget Dept: {highestDept.Key}"); 
            #endregion


            #region Q9
            //List<int> nums = [1, 2, 3, 4, 5];
            //var query = nums.Where(n => n > 2); // Deferred
            //nums.Add(10);

            //foreach (var n in query) Console.Write(n + " ");
            //Console.WriteLine();

            // Expected: 3 4 5 10
            // Deferred execution because query evaluated during iteration
            // Immediate execution examples: ToList(), ToArray(), Count() 
            #endregion




            #region Q10
            //List<string> words = ["apple", "fig", "banana", "kiwi", "grape", "mango", "pear", "plum"];

            //var filter1 = words.Where(w => w.Length > 4).ToList();
            //var filter2 = words.Where((w, i) => i % 2 == 0);
            //var filter3 = words.Where((w, i) => w.Length > 4 && i % 2 == 0);

            //Console.WriteLine("Length > 4: " + string.Join(", ", filter1));
            //Console.WriteLine("Even Index: " + string.Join(", ", filter2));
            //Console.WriteLine("Both Conditions: " + string.Join(", ", filter3));
            //Console.WriteLine("Index of mango in filter1: " + filter1.IndexOf("mango"));
            #endregion



            #region Q11
            //   List<Course> courses = [
            //    new("C# Basics", ["Ali", "Sara", "Omar"]),
            //       new("LINQ Mastery", ["Sara", "Mona", "Ali"]),
            //       new("ASP.NET Core", ["Yara", "Omar", "Karim"])
            //];

            //   var allStudentsFlat = courses.SelectMany(c => c.Students);
            //   var distinctStudents = allStudentsFlat.Distinct();
            //   var moreThanOneCourse = allStudentsFlat
            //       .GroupBy(s => s)
            //       .Where(g => g.Count() > 1)
            //       .Select(g => g.Key);

            //   var pairs = courses.SelectMany(c => c.Students,
            //       (course, student) => new { course.Title, student });

            //   Console.WriteLine("All Students: " + string.Join(", ", allStudentsFlat));
            //   Console.WriteLine("Distinct Students: " + string.Join(", ", distinctStudents));
            //   Console.WriteLine("Students in >1 course: " + string.Join(", ", moreThanOneCourse));

            //   Console.WriteLine("Course-Student Pairs:");
            //   foreach (var p in pairs)
            //       Console.WriteLine($"{p.Title} - {p.student}");
            #endregion

            #region Q12

            //    var top2 = employees
            //        .GroupBy(e => e.Department)
            //        .SelectMany(g => g.OrderByDescending(e => e.Salary).Take(2));

            //    Console.WriteLine("Top 2 per Department:");
            //    foreach (var emp in top2)
            //        Console.WriteLine($"{emp.Department} - {emp.Name} - {emp.Salary}");

            //    var courseDict = courses
            //        .Where(c => c.Students.Count > 2)
            //        .ToDictionary(c => c.Title, c => c.Students.Count);

            //    Console.WriteLine("Course Dictionary:");
            //    foreach (var item in courseDict)
            //        Console.WriteLine($"{item.Key} → {item.Value} students");
        }
        #endregion
        //#endregion

        //note
        //public static IEnumerable<T> Paginate<T>(IEnumerable<T> source, int pageNumber, int pageSize)
        //{
        //    return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        //}


    }
}