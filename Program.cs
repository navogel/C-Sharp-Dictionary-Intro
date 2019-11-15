using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new dictionary variable.  same same but different to objects in JS.
            Dictionary<string, int> cohortCount = new Dictionary<string, int>();

            cohortCount.Add("Cohort 34", 20);
            cohortCount.Add("Cohort 35", 14);
            cohortCount.Add("Cohort 36", 28);
            cohortCount.Add("Cohort 37", 28);

            foreach (KeyValuePair<string, int> item in cohortCount)
            {
                Console.WriteLine($"{item.Key} has {item.Value} students");
            }
            //another way to declare a dictionary
            Dictionary<string, double> products = new Dictionary<string, double>()
            { { "Deodorant", 8.50 }, { "Foods", 4.50 }, { "Vino", 10.50 }, { "Hairbrush", 5.50 }, { "Shampoo", 5.50 },

            };

            foreach (KeyValuePair<string, double> product in products)
            {
                Console.WriteLine($"{product.Key} costs: {product.Value}");
            }
        }

    }
}