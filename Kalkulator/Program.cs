namespace Kalkulator
{
    internal class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
              //Second module
              /*string Name = "Bob";
                Name= Name+ " Bond";
                int count = 3;
                double temperature = 34.4;
                Console.WriteLine($"Hello, {Name}! You  have {count} in your inbox. The temperature is {temperature} celsius.\n");
                Console.WriteLine(@"View english output:
               c:\Exercise\ACME\data.txt
                 ");
                         Console.WriteLine(@"Посмотреть русский вывод
               c:\Exercise\ACME\data.txt
                 ");*/


              //Fourth module
              /*int fahrenheit = random.Next(1, 73);
                Console.WriteLine(Math.Floor(((float)fahrenheit - 32) / 9 * 5 * 10) / 10);
                int firstValue = random.Next(1, 100);
                int secondValue = random.Next(1, 100);
                int largerValue = Math.Max(firstValue, secondValue);
                Console.WriteLine($"First: {firstValue} Second: {secondValue} Larger:{largerValue}");*/


              //Fifth module
              /*int roll1=random.Next(1, 7);
                int roll2=random.Next(1, 7);
                int roll3=random.Next(1, 7);
                int score = roll1+roll2+roll3; 
                Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {score}");
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    score += 6;
                }
                else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    score += 2;
                }


                if (score >= 16)
                    Console.WriteLine("You win a new car!");
                else if (score >= 10)
                    Console.WriteLine("You win a new laptop!");
                else if(score == 7)
                    Console.WriteLine("You win a trip for two!");
                else
                    Console.WriteLine("You win a kitten!");*/


              //Sixth module
              /*int daysUntilExpiration = random.Next(12);
                int discountPercentage = 0;
            
                if (daysUntilExpiration == 0)
                    Console.WriteLine("Your subscription has expired");
                else if (daysUntilExpiration == 1)
                {
                    discountPercentage = 20;
                    Console.WriteLine($"Your subscription expires within a day!\r\nRenew now and save {discountPercentage}%!");
                }
                else if(daysUntilExpiration <5)
                {
                    discountPercentage = 10;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save {discountPercentage}%!");
                }
                else if(daysUntilExpiration<=10)
                    Console.WriteLine("Your subscription will expire soon. Renew now!");
                if (daysUntilExpiration > 10)
                    Console.WriteLine();*/


              //Seventh module
              /*string[] array = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
                foreach(string item in array)
                {
                    if(item.StartsWith("B"))
                        Console.WriteLine(item);
                }*/

             



        }
    }
}