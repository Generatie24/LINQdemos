using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_1
{
    class Person
    {
        public int Age { get; set; }
        public int Height { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region numbers


            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4,
                234, 54, 14, 653, 3, 4, 5, 6, 7 };
            // extract even numbers with lambda

            //var oddNumbers = numbers.Where(n => n % 2 == 0);
            List<int> oddNumbers = numbers.FindAll(n => n % 2 == 0);
            oddNumbers.ForEach(n => Console.WriteLine(n));


            //foreach (var number in oddNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            var person = new List<Person>()
            {
                new Person() {Age = 25, Height = 160},
                new Person() {Age = 30, Height = 160},
                new Person() {Age = 23, Height = 130},
                new Person() {Age = 60, Height = 190},
            };
            //var heights = person.Where(p => p.Height > 150).Select(p => p.Height).ToList();
            //heights.ForEach(h => Console.WriteLine(h));

            //foreach (var item in heights)
            //{
            //    Console.WriteLine(item);
            //}

            // annonime method with delegate 
            Console.WriteLine("annonime method with delegate");
            var filteredPersonDelegate = person.Where(delegate (Person p) { return p.Age < 25; }).ToList();
            foreach (var item in filteredPersonDelegate)
            {
                Console.WriteLine(item.Age);
            }
            Line();
            var filteredPersonLambda = person.Where(p => p.Age < 25).ToList();
            Console.WriteLine("annonime method with lambdas");
            foreach (var item in filteredPersonLambda)
            {
                Console.WriteLine(item.Age);
            }

            var filteredWithMethod = person.Where(Filter).ToList();
            Console.WriteLine("normal method with lambdas");
            foreach (var item in filteredWithMethod)
            {
                Console.WriteLine(item.Age);
            }

            var peopleClass = from p in person
                              select new {Category =p.Age > 50 ? 
                              "Senior": "Adult", Leeftijd = p.Age, Hoogte = p.Height };

            Console.WriteLine("Anonimous type or Class");
            foreach (var item in peopleClass)
            {
              
                Console.WriteLine(item.Leeftijd + " " + item.Hoogte + " " + item.Category);
            }
           

        }

        private static bool Filter(Person p)
        {
            return p.Age < 25;
        }
        private static void Line()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
