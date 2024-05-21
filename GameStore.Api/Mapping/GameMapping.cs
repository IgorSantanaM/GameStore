﻿using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
public static Game ToEntity(this CreateGameDto game)
{
    return new Game()
    {
        Name = game.Name,
        genreId = game.GenreId,
        price = game.Price,
        ReleaseDate = game.RealeseDate
      };
    }
    public static Game ToEntity(this UpdateGameDto game, int id)
{
    return new Game()
    {

        Id = id,
        Name = game.Name,
        genreId = game.genreId,
        price = game.Price,
        ReleaseDate = game.RealeseDate
      };
    }
    public static GameSummaryDto ToGameSummaryDto(this Game game)
    {
        return new(
            game.Id,
            game.Name, 
            game.Genre!.Name,
            game.price,
            game.ReleaseDate
        );
    }

    public static GameDetailsDto ToGameDetailsDto(this Game game)
    {
        return new(
            game.Id,
            game.Name, 
            game.genreId,
            game.price,
            game.ReleaseDate
        );
    }
}
