using System;
using System.Collections.Generic;

namespace AHBC_Lab_11
{
    class Movie
    {

        public static void HorrorList()
        {

            var horrorList = new List<string>();
            horrorList.Add("Scream");
            horrorList.Add("The Exorcist");
            horrorList.Add("The Shining");

            foreach (var horrorMovie in horrorList)
            {
                Console.WriteLine($"{horrorMovie}");
            }
            Console.ReadLine();
        }

        public static void AnimatedList()
        {

            var animatedList = new List<string>();
            animatedList.Add("Toy Story");
            animatedList.Add("The Lion King");
            animatedList.Add("Aladdin");


            foreach (var animatedMovie in animatedList)
            {
                Console.WriteLine($"{animatedMovie}");
            }
            Console.ReadLine();

        }

        public static void DramaList()
        {

            var dramaList = new List<string>();
            dramaList.Add("The Green Mile");
            dramaList.Add("Titanic");
            dramaList.Add("The GodFather");


            foreach (var dramaMovie in dramaList)
            {
                Console.WriteLine($"{dramaMovie}");
            }
            Console.ReadLine();
        }

        public static void SciFiList()
        {

            var scifiList = new List<string>();
            scifiList.Add("Star Wars");
            scifiList.Add("Avatar");
            scifiList.Add("Martian");


            foreach (var scifiMovie in scifiList)
            {
                Console.WriteLine($"{scifiMovie}");
            }
            Console.ReadLine();
        }

    }
}
