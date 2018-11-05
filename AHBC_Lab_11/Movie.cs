using System;
using System.Collections.Generic;

namespace AHBC_Lab_11
{
    class Movie
    {
        // James - so I see you are handling lists just fine, adding items and 
        // printing out the values for the list but I'm afraid you are missing the main 
        // reasons we use classes for encapsulating data.  so what we are looking for   
        // is making a movie class that contains the data associated with movie. 
        // so you could make make a Movie class that looks kind of like this
        // 
        //  public class Movie 
        // {
        //      public string Name { get; set; }
        //      public string Genre {get; set; }
        // }
        //
        // so then we would have a class of movie that will and can 
        // make a movie Object, we can then store a 
        // list of movie Objects in well.. a list.
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

        // James - I still like that you have a method for getting each list based on each genre,
        // I would still like to see a Movie class though.
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
