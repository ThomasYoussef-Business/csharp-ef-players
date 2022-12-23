global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using CS_Entity_Framework_Players;

using var db = new PlayersDbContext();

foreach (var player in db.Players) {
    Console.WriteLine($"{player.Name}, {player.Surname}, {player.Score}, {player.GamesPlayed}, {player.GamesWon}");
}