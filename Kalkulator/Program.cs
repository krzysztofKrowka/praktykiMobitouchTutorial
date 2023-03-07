namespace Kalkulator
{
    internal class Program
    {
        /// <summary>
        /// Calculate simple operations
        /// </summary>
        /// <param name="operation">Operation in string - 2 numbers separated with operation sign and spaces</param>
        /// <returns>Answer to the operation</returns>
        public static double Calculate(string operation)
        {
            double answer = 0;
            var arguments = operation.Split(" ");
            switch (arguments[1].ToString())
            {
                case "+":
                    answer = Convert.ToDouble(arguments[0]) + Convert.ToDouble(arguments[2]);
                    break;

                case "-":
                    answer = Convert.ToDouble(arguments[0]) - Convert.ToDouble(arguments[2]);
                    break;

                case "*":
                    answer = Convert.ToDouble(arguments[0]) * Convert.ToDouble(arguments[2]);
                    break;

                case "/":
                    answer = Convert.ToDouble(arguments[0]) / Convert.ToDouble(arguments[2]);
                    break;

                case "^":
                    answer = Math.Pow(Convert.ToDouble(arguments[0]), Convert.ToDouble(arguments[2]));
                    break;

                case "%":
                    answer = Convert.ToDouble(arguments[0]) % Convert.ToDouble(arguments[2]);
                    break;

                default:
                    break;
            }
            return answer;
        }
        public static Random random = new Random();
        static void Main(string[] args)
        {
            // Second module
            /* string Name = "Bob";
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


            // Fourth module
            /* int fahrenheit = random.Next(1, 73);
               Console.WriteLine(Math.Floor(((float)fahrenheit - 32) / 9 * 5 * 10) / 10);
               int firstValue = random.Next(1, 100);
               int secondValue = random.Next(1, 100);
               int largerValue = Math.Max(firstValue, secondValue);
               Console.WriteLine($"First: {firstValue} Second: {secondValue} Larger:{largerValue}");*/


            // Fifth module
            /* int roll1=random.Next(1, 7);
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


            // Sixth module
            /* int daysUntilExpiration = random.Next(12);
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


            // Seventh module
            /* string[] array = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
               foreach(string item in array)
               {
                   if(item.StartsWith("B"))
                       Console.WriteLine(item);
               }*/

            // Eighth module
            /*
               The following code creates five random OrderIds
               to test the fraud detection process. OrderIds
               consist of a letter from A to E, and a three
               digit numver. Ex. A123
            
            string[] orderIDs = new string[5];
            
            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix=Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");
                orderIDs[i] = prefix + suffix;
            }
            foreach (var orderId in orderIDs)
                Console.WriteLine(orderId);
            */
            /*
                The code reverses the text, prints out
                the new message and says how much 'o' is 
                the text
            */
            /* string originalMessage = "The quick brown fox jumps over the lazy dog.";
            
               char[] charMessage = originalMessage.ToCharArray();
               Array.Reverse(charMessage);
            
               int letterCount = 0;
               foreach (char letter in charMessage)
               { 
                   if (letter == 'o')
                   {
                       letterCount++;
                   }
               }
            
               string newMessage = new String(charMessage);
               Console.WriteLine(newMessage);
            
               Console.WriteLine($"'o' appears {letterCount} times.");*/


            //Calculator
            Console.WriteLine("Write operation in format \nNumber Sign Number \nTo exit write 'EXIT'");
            while (true)
            {
                string operation = Console.ReadLine();
                if (operation == "EXIT")
                    break;
                double answer = Calculate(operation);
                Console.WriteLine($"{operation} = {answer}");
            }
            
        }
    }
}