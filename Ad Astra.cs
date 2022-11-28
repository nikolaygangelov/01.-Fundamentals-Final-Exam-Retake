
namespace _2._Ad_Astra
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"((\|)?(\#)?)(?<name>[A-Za-z\ ]+)\1(?<expirationDate>(?<day>\d{2})\/(?<month>\d{2})\/(?<year>\d{2}))\1(?<calories>\d{1,5})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);
            int sumOfCalories = 0;
            foreach (Match food in matchCollection)
            {
                sumOfCalories += int.Parse(food.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {sumOfCalories/2000} days!");

            foreach (Match food in matchCollection)
            {
                Console.WriteLine($"Item: {food.Groups["name"]}, Best before: {food.Groups["expirationDate"]}, Nutrition: {food.Groups["calories"]}");
            }
        }
    }
}
