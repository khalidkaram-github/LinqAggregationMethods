namespace LinqAggregationMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region normal total example
            var arr = new[] { 1, 2, 3 };

            var total = 0;

            foreach (var item in arr)
            {
                total += item;
            }

            //Console.WriteLine(total); 
            #endregion

            #region aggregate func

            int[] nums = { 1, 2, 3 };
            int sum1 = nums.Aggregate(0, (total, n) => total + n, x => x * 2); // 6
            Console.WriteLine(sum1);

            //Console.WriteLine(sum); // Output: 6 
            #endregion

            #region sum , agv
            var people2 = new[]
                {
                new { Name = "Alice", Salary = 5000 },
                new { Name = "Bob", Salary = 7000 },
                new { Name = "Charlie", Salary = 6000 }
            };

            int totalSalary = people2.Sum(p => p.Salary); // 18000
            double avgSalary = people2.Average(p => p.Salary); // 6000

            //Console.WriteLine($"Total Salary: {totalSalary}, Average Salary: {avgSalary}"); 
            #endregion

            #region min , max
            var people = new[]
              {
                new { Name = "Alice", Age = 30 },
                new { Name = "Bob", Age = 25 },
                new { Name = "Charlie", Age = 35 }
            };

            var min = people.MinBy(p => p.Age); // 25
            var max = people.MaxBy(p => p.Age); // 35


            // Console.WriteLine($"min age for  = {min.Name} max age for  = {max.Name}");

            #endregion

            #region Examples
            //CountExample();
            //SumExample();
            //MinExample();
            //MaxExample();
            //AverageExample();
            //AggregateExample(); 
            #endregion
        }


        #region Count Example
        static void CountExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int count = numbers.Count(); // Returns 5
            int evenCount = numbers.Count(n => n % 2 == 0); // Returns 2

            Console.WriteLine($"Count: {count}, Even Count: {evenCount}");
        }
        #endregion

        #region Sum Example
        static void SumExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = numbers.Sum(); // Returns 15

            var people = new List<Person>
            {
                new Person { Age = 30 },
                new Person { Age = 40 }
            };
            int totalAge = people.Sum(p => p.Age); // Returns 70

            Console.WriteLine($"Sum: {sum}, Total Age: {totalAge}");
        }
        #endregion

        #region Min Example
        static void MinExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int min = numbers.Min(); // Returns 1

            var people = new List<Person>
            {
                new Person { Age = 30 },
                new Person { Age = 40 }
            };
            int minAge = people.Min(p => p.Age); // Returns 30

            Console.WriteLine($"Min: {min}, Min Age: {minAge}");
        }
        #endregion

        #region Max Example
        static void MaxExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int max = numbers.Max(); // Returns 5

            var people = new List<Person>
            {
                new Person { Age = 30 },
                new Person { Age = 40 }
            };
            int maxAge = people.Max(p => p.Age); // Returns 40

            Console.WriteLine($"Max: {max}, Max Age: {maxAge}");
        }
        #endregion

        #region Average Example
        static void AverageExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            double average = numbers.Average(); // Returns 3.0

            var people = new List<Person>
            {
                new Person { Age = 30 },
                new Person { Age = 40 }
            };
            double averageAge = people.Average(p => p.Age); // Returns 35.0

            Console.WriteLine($"Average: {average}, Average Age: {averageAge}");
        }
        #endregion

        #region Aggregate Example
        static void AggregateExample()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            int product = numbers.Aggregate((acc, n) => acc * n); // Returns 120 (1*2*3*4*5)

            var words = new List<string> { "Hello", "World" };
            string sentence = words.Aggregate((acc, word) => acc + " " + word); // Returns "Hello World"

            Console.WriteLine($"Product: {product}, Sentence: {sentence}");
        }
        #endregion
    }

    #region Helper Classes
    class Person
    {
        public int Age { get; set; }
    }
    #endregion
}



