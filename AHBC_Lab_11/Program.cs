using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC_Lab_11
{
    // James - I see you are inhereting from the Movie class to get access to all of those 
    // movie methods.  to be honest, I like that you are expirementing with inheritence, good stuff.
    class Program : Movie
    {
        static void Main(string[] args)
        {
            // James - I like that you seperating your work into seperate methods, nice job!
            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine("There are 12 movies in this list");
            WillContinue();
        }
        public static void WhichCategory()
        {

            while (true)
            {
                Console.Write("What category are you interested in? ");
                var category = Console.ReadLine();

                if (category.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                {
                    HorrorList();
                    break;
                }
                else if (category.Equals("Animated", StringComparison.OrdinalIgnoreCase))
                {

                    AnimatedList();
                    break;
                }
                else if (category.Equals("SciFi", StringComparison.OrdinalIgnoreCase))
                {
                    SciFiList();
                    break;
                }
                else if (category.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                {
                    DramaList();
                    break;
                }
                else
                {
                    Console.WriteLine("Category not found, please enter another category. ");
                    Console.ReadLine();
                    continue;
                }
            }
        }

        public static void WillContinue()
        {

            while (true)
            {
                // James - I like this logic, run the WhichCategory and then the work inside of this method will determine if we run
                // the WhichCategory() method again.  good stuff!
                WhichCategory();

                Console.Write("Continue? (y/n): ");
                var willContinue = Console.ReadLine();

                if (willContinue.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                else if (willContinue.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Y or N not selected, please try again");
                    Console.ReadLine();
                    // James - so the user will run the app again if they choose the wrong
                    // category, just a heads up.
                    continue;

                }
            }
        }
    }
}
