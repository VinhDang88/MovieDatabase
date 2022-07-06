using MovieDatabase;
using Validator;
bool runProgram = true;
List<Movie> movies = new List<Movie>()
{
    new Movie ("Moana", "Family"),
    new Movie ("Encanto", "Family"),
    new Movie ("Joker", "Action"),
    new Movie ("John Wick", "Action"),
    new Movie ("Top Gun Maverick", "Action"),
    new Movie ("Thor Ragnarok", "Action"),
    new Movie ("Avengers End Game", "Action"),
    new Movie ("Spiderman", "Action"),
    new Movie ("Insidious", "Horror"),
    new Movie ("Annabelle", "Horror"),

};

Console.WriteLine("Hello welcome to Space Theatre!");
Console.WriteLine("We have 10 different movies for you to pick,");
Console.WriteLine("which category are you interested in?");
Console.WriteLine("");
Console.WriteLine("'Family','Horror', 'Action'");
while (runProgram)
{
    while (true)
    {
        Console.Write("What catgory are you interested in? ");

        string input = Console.ReadLine().ToUpper().Trim();
        List<Movie> categoryMovies = movies.Where(x => x.Category.ToUpper().Trim() == input).ToList();
        var newList = categoryMovies.OrderBy(x => x.Title).ToList();
        //categoryMovies.Sort((x) => string.Compare(x.Title)); How come this doesnt work.
     
        foreach (Movie m in newList)
        {
            Console.WriteLine("");
            Console.WriteLine(m.Title);
            Console.WriteLine("==================");
        }
        if (categoryMovies.Count <= 0)
        {
            Console.WriteLine("Sorry we don't have that movie!");
        }
        else
        {
            break;
        }

    }
    runProgram = Valid.GetContinue("Continue?");

}


