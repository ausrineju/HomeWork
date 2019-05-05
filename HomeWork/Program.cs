using System;
using System.Collections.Generic;
using System.Linq;


namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Filtering flt = new Filtering();
            var randomNumbers = new List<int>();
            var myFavoriteNames = new List<string>() { "Tadas", "Kotryna", "Kristina", "Mantas", "Matas", "Lukas", "Rita", "Simona", "Jurgita", "Linas" };
            var myTop5FavoriteNames = new List<string>(myFavoriteNames.Take(5));
            var myFavoriteNamesRating = new Dictionary<int, string>() { { 1, "Tomas" }, { 2, "Aldona" }, { 3, "Karolina" }, { 4, "Mantas" }, { 5, "Marius" }, { 6, "Paulius" }, { 7, "Dainius" }, { 8, "Lina" }, { 9, "Jurga" }, { 10, "Rolandas" } };

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                randomNumbers.Add(rnd.Next(1, 10));
            }

            Func<int, bool> MoreThan80 = delegate (int x)
            {
                if (x > 80) return true;
                return false;
            };

            Func<int, bool> DividesBy2 = delegate (int x)
            {
                if (x % 2 == 0) return true;
                return false;
            };

            Func<string, bool> DoesNotContainS = delegate (string x)
            {
                if (x.Contains("s") || x.Contains("S")) return false;

                return true;
            };

            Func<string, bool> DoesNotContainTorE = delegate (string x)
            {
                if (x.Contains("t") || x.Contains("T") || x.Contains("e") || x.Contains("E")) return false;

            return true;
            };

            Func<int, bool> Between5and8 = delegate (int x)
            {
                if (x >= 5 && x <= 8) return true;
                return false;
            };

            var list_more_than_80 = new List<int>(flt.FilterIntegers(randomNumbers, MoreThan80));
            Console.WriteLine("integers higher than 80: ");
            foreach(int l in list_more_than_80)
            {
                Console.WriteLine(l);
            }

            var list_divides_by_2 = new List<int>(flt.FilterIntegers(randomNumbers, DividesBy2));
            Console.WriteLine("integers that divide by 2: ");
            foreach (int l in list_divides_by_2)
            {
                Console.WriteLine(l);
            }

            var list_not_contains_s = new List<string>(flt.FilterStrings(myFavoriteNames, DoesNotContainS));
            Console.WriteLine("names that don't have S: ");
            foreach (string l in list_not_contains_s)
            {
                Console.WriteLine(l);
            }

            var list_not_in_top_favorite_names = new List<string>(flt.FilterStrings(myFavoriteNames, myTop5FavoriteNames));
            Console.WriteLine("names that are not in my top favorite names: ");
            foreach (string l in list_not_in_top_favorite_names)
            {
                Console.WriteLine(l);
            }

            var dict_not_contain_e_and_t = new Dictionary<int, string>(flt.FilterDictionaryValues(myFavoriteNamesRating, DoesNotContainTorE));
            Console.WriteLine("names that don't have E and T: ");
            foreach (KeyValuePair<int, string> l in dict_not_contain_e_and_t)
            {
                Console.WriteLine(l);
            }

            var dict_key_between_5_and_8 = new Dictionary<int, string>(flt.FilterDictionaryKeys(myFavoriteNamesRating, Between5and8));
            Console.WriteLine("names that have raiting between 5 and 8: ");
            foreach (KeyValuePair<int, string> l in dict_key_between_5_and_8)
            {
                Console.WriteLine(l);
            }

            Console.ReadKey();


        }
    }
}
