using System;

public enum MovieGenre
{
    Action = 1,
    Comedy,
    Drama,
    SciFi,
    Horror
}

namespace Lab3
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }

        public Movie(int id, string title, int year, MovieGenre genre, int views, int likes)
        {
            Id = id;
            Title = title;
            Year = year;
            Genre = genre;
            Views = views;
            Likes = likes;
        }

        public double CalculateRating()
        {
            if (Views <= 0) return 0;
            double value = (double)(Likes * Likes) / Views;
            return Math.Sqrt(value);
        }

        public override string ToString()
        {
            string genreStr = Genre.ToString();
            double rating = CalculateRating();

            return string.Format("{0,4} | {1,-15} | ({2,-8}), {3,-12} | Rating: {4,8:0.000}",
                Id,
                Title,
                Year,
                genreStr,
                rating);
        }
    }
}