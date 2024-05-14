using System.Net.Http.Headers;


Console.WriteLine("Hello! Welcome, we have 10 movies to pick from! Please select a category");
public class Movie
{
    public string Title { get; set; }
    public string Category { get; set; }

    public Movie(string title, string category)
    {
        Title = title;
        Category = category;
    }
}

partial class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie("The Lion King", "animated"),
            new Movie("The Shawshank Redemption", "drama"),
            new Movie("The Shining", "horror"),
            new Movie("Interstellar", "scifi"),
            new Movie("Finding Nemo", "animated"),
            new Movie("Titanic", "romance"),
            new Movie("Psycho", "horror"),
            new Movie("Star Wars", "scifi"),
            new Movie("Toy Story", "animated"),
            new Movie("The Dark Knight", "action")
            
        };

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter a category (animated, drama, horror, scifi): ");
            string inputCategory = Console.ReadLine().ToLower();

            var moviesByCategory = movies.Where(movie => movie.Category.ToLower() == inputCategory).ToList();

            if (moviesByCategory.Any())
            {
                Console.WriteLine("Movies in the category " + inputCategory + ":");
                foreach (var movie in moviesByCategory)
                {
                    Console.WriteLine("- " + movie.Title);
                }
            }
            else
            {
                Console.WriteLine("No movies found in the category " + inputCategory);
            }

            Console.Write("Do you want to continue? (yes/no): ");
            string continueChoice = Console.ReadLine().ToLower();
            continueProgram = continueChoice == "yes";
        }
    }
}









