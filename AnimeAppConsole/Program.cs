using Microsoft.EntityFrameworkCore;

namespace AnimeAppConsole;

internal class Program
{
    static void Main(string[] args)
    {
        using (var context = new AnimeAppDbContext())
        {
            var animeDetails = context.AnimeDetails.FromSqlRaw("select a.Id as Anime_Id, a.Name as Name, g.Type as GenreName from Animes as a join Genres as g on a.GenreId=g.Id").ToList();
            foreach (var item in animeDetails)
            {
                Console.WriteLine($"Id : {item.Anime_Id} - Anime Name : {item.Name} - Genre : {item.GenreName}"); 
            }
            
        }
    }
}
