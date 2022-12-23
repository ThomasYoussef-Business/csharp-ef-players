global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using CS_Entity_Framework_Players;

using var db = new PlayersDbContext();

db.Players.Where(p => p.Name.Contains("Thomas")).First().Name = "Tommy";
db.SaveChanges();