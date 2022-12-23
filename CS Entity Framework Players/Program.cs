global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
using CS_Entity_Framework_Players;

using (var db = new PlayersDbContext()) {
    var thomasYoussef = new Player("Thomas", "Youssef");
    db.Add(thomasYoussef);
    db.SaveChanges();
}