using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC_Lab_11
{
    class Program : Movie
    {
        static void Main(string[] args)
        {

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

                    continue;

                }
            }
        }
    }
}
