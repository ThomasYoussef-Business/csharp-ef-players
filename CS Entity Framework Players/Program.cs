global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using CS_Entity_Framework_Players;

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

using var db = new PlayersDbContext();

var thomas = new Player("Thomas", "Youssef");
var alessio = new Player("Alessio", "Cherici");
var erika = new Player("Erika", "Rizzi");

var squadraDiscord = new Team() {
    Name = "Squadra Discord",
    City = "Milan",
    Players = new List<Player> { thomas, alessio, erika },
    Trainer = "Bryan Lucchetta",
    Colors = "Rosso e rosa"
};

db.Add(squadraDiscord);
db.SaveChanges();