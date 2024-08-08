namespace TvShows.DB;

using TvShows.Models;

 public class TvShowsDB
 {
   private static List<TvShow> _tvShows =
   [
     new TvShow{ Id=1,      Name="The Wire",                        Favorite=false },
     new TvShow{ Id=2,      Name="The Sopranos",                    Favorite=false },
     new TvShow{ Id=3,      Name="The Twilight Zone",               Favorite=false },
     new TvShow{ Id=4,      Name="Breaking Bad",                    Favorite=false },
     new TvShow{ Id=5,      Name="Star Trek: The Original Series",  Favorite=false },
     new TvShow{ Id=6,      Name="I Love Lucy",                     Favorite=false },
     new TvShow{ Id=7,      Name="Mad Men",                         Favorite=false },
     new TvShow{ Id=8,      Name="Lost",                            Favorite=false },
     new TvShow{ Id=9,      Name="The Simpsons",                    Favorite=false },
     new TvShow{ Id=10,     Name="Seinfeld",                        Favorite=false }
   ];

   public static List<TvShow> GetAll() 
   {
     return _tvShows;
   } 

   public static TvShow? GetById(int id) 
   {
     return _tvShows.SingleOrDefault(tvShow => tvShow.Id == id);
   } 

   public static TvShow CreateTvShow(string name, bool favorite)
   {
      var tvShow = new TvShow {
        Id=_tvShows.Count + 1,
        Name=name,
        Favorite=favorite
      };

     _tvShows.Add(tvShow);

     return tvShow;
   }

   public static bool Remove(TvShow tvShow)
   {
        return _tvShows.Remove(tvShow);
   }
 }