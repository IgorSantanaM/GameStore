namespace GameStore.Api.Entities;

public class Game
{
     public int Id {get; set; }

   public required String Name {get; set; }

   public int genreId {get; set;}

   public Genre? Genre {get; set; }

   public decimal price {get; set; }

   public DateOnly ReleaseDate {get; set; }


}
