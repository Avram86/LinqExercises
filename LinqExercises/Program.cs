using System;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
			

		}

		private static void Sample1_SelectEvenNumbers()
        {
			//var query = from number in Numbers.AllNumbers()
			//            where number % 2 == 0
			//            select number;

			var query = Numbers.AllNumbers()
							   .Where(n => n % 2 == 0);

			Console.Write("How many even numbers to display?=");
			int n = Convert.ToInt32(Console.ReadLine());

			int i = 0;
			foreach (int evenNumber in query)
			{
				Console.Write($"{evenNumber}, ");
				i++;
				if (i >= n)
				{
					break;
				}
			}
		}
		private static void FiletrOperator_Where_PersonOver14StartingWithM()
        {
			//var query = from person in PersonsDatabase.AllPersons()
			//			where person.Age >= 14 && person.LastName.StartsWith('M')
			//			select person;

			var query = PersonsDatabase.AllPersons()
							.Where(p => p.Age >= 14)
							.Where(p => p.LastName.Contains('M'));

			foreach (var person in PersonsDatabase.AllPersons())
			{
				person.Print();
			}

			Console.WriteLine("______________________________________________________________");
			Console.WriteLine("Query result: ");
			Console.WriteLine("______________________________________________________________");


			foreach (var person in query)
			{
				person.Print();
			}
		}
    }
}
