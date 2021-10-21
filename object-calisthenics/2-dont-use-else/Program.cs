using System;

namespace DontUseElse
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetMyDrink("beer", 16);
            Console.WriteLine(result);
        }

        private static string GetMyDrink(string choice, int age)
        {
            string result = "string.Empty";

            if(choice == "beer")
            {
                if(age >= 18)
                {
                    result = "Here's your cold beer!";
                }
                else
                {
                    result = "Sorry, you are not old enough as per law.";
                }
            }
            else if(choice == "juice")
            {
                result = "Here you go. Fresh juice.";
            }
            else
            {
                result = "We only serve Beer or Juice";
            }

            return result;
        }
    }
}
