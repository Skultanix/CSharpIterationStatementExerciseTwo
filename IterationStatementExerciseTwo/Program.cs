using System.Xml.Schema;

namespace IterationStatementExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 0;

            while(true)
            {
                

                Console.WriteLine(@"Please type a number or type ""ok"" to exit.");
                var userInput = Console.ReadLine();

                if (userInput == "ok")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                } else
                {
                    var newInput = int.Parse(userInput);
                    total = newInput + total;
                    Console.WriteLine(string.Format("Total of numbers entered is: {0}.", total));
                }
            }
        }
    }
}