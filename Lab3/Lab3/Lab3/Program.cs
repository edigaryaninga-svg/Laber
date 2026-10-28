using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Movie quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int count))
            {
                Console.WriteLine("Wrong number:");
                return;
            }

            Movie[] movies = new Movie[count];

            Console.WriteLine("\nInput movie info");
            Console.WriteLine("Number, Name, Year, Genre (1-5), Views, Likes");
            Console.WriteLine("Example: 1,Inception,2010,4,15000,1200\n");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Movie #{i + 1}: ");
                string input = Console.ReadLine();

                string[] parts = input.Split(',');

                if (parts.Length >= 6)
                {
                    int id = int.Parse(parts[0].Trim());
                    string title = parts[1].Trim();
                    int year = int.Parse(parts[2].Trim());

                    int genreNum = int.Parse(parts[3].Trim());
                    MovieGenre genre = (MovieGenre)genreNum;

                    int views = int.Parse(parts[4].Trim());
                    int likes = int.Parse(parts[5].Trim());

                    movies[i] = new Movie(id, title, year, genre, views, likes);
                }
                else
                {
                    Console.WriteLine("Wrong format, try again:");
                    i--;
                }
            }

            Console.WriteLine("\nMovies and Ratings\n");

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }
}