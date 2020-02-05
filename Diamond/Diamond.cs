using System;

namespace AClerbois.Kata
{
    public class Diamond
    {
        public void Display(int number)
        {
            var maxRange = 9;
            for (int i = 1; i < (number * 2); i++)
            {
                var rest = i < number ? number - i : i - number;
                var white = maxRange - number + rest;
                Console.Write(new string(' ', white));
                System.Console.WriteLine(Math.Pow(double.Parse(new string('1', number-rest)),2));
            }

        }
    }
}
