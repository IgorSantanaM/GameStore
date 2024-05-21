namespace GameStore.Api.Dtos;

public record class GameSummaryDto(
int Id,
 string Name,
string genre,
decimal Price,
DateOnly RealeseDate);

