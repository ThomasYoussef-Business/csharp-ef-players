global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using CS_Entity_Framework_Players;

using var db = new PlayersDbContext();

//db.Add(new Player("Thomas", "Youssef"));
//db.SaveChanges();

//foreach (var player in db.Players) {
//    Console.WriteLine($"{player.Name}, {player.Surname}, {player.Score}, {player.GamesPlayed}, {player.GamesWon}");
//}

//db.Players.Where(p => p.Name.Contains("Thomas")).First().Name = "Tommy";
//db.SaveChanges();

//var myPlayer = db.Players.First();
//db.Remove(myPlayer);
//db.SaveChanges();

