
using System.Collections.Generic;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(Gina.DisplayPersonInfo());
            Console.WriteLine(Mike);
            Ian.ChangeFavouriteColour();
            Console.WriteLine(Ian.DisplayPersonInfo());
            Console.WriteLine(Mary.GetAgeInTenYears());
            Relation sisters = new Relation(Gina, Mary, "sister");
            Relation brothers = new Relation(Ian, Mike, "brother");
            Console.WriteLine(sisters.ShowRelationShip(Gina, Mary));
            Console.WriteLine(brothers.ShowRelationShip(Ian, Mike));

            List<Person> list = new List<Person>();
            list.Add(Ian);
            list.Add(Gina);
            list.Add(Mike);
            list.Add(Mary);

            Console.WriteLine(GetAvgAge(list));
            Console.WriteLine(GetYougest(list));
            Console.WriteLine(GetOldest(list));
            GetByFirstLetter(list,'M');
            GetByFavoriteColour(list, "Blue");
        }

        private static void GetByFavoriteColour(List<Person> list, string colour)
        {
            foreach (Person person in list)
            {
                if (person.FavoriteColour == colour)
                {
                    Console.WriteLine(person);
                }
            }
        }

        private static void GetByFirstLetter(List<Person> list, char firstChar)
        {
            foreach (Person person in list)
            {
                if (person.FirstName[0] == firstChar)
                {
                    Console.WriteLine(person);
                }
            }
        }

        private static string GetOldest(List<Person> list)
        {
            Person oldest = list[0];
            foreach (Person person in list)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            return $"The oldest person is: {oldest.FirstName}";
        }

        private static string GetYougest(List<Person> list)
        {
            Person youngest = list[0];
            foreach (Person person in list)
            {
                if (person.Age < youngest.Age)
                {
                    youngest = person;
                }
            }
            return $"The youngest person is: {youngest.FirstName}";
        }

        private static string GetAvgAge(List<Person> list)
        {
            double count = 0;
            double sum = 0;
            foreach (Person person in list)
            {
                count++;
                sum += person.Age;
            }
            return $"Average age is {sum / count}";
        }
    }
}
