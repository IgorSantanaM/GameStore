namespace GameStore.Api.Dtos;

public record class GameDetailsDto(
int Id,
 string Name,
int genreId,
decimal Price,
DateOnly RealeseDate);

