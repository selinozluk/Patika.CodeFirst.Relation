using Microsoft.EntityFrameworkCore;
using Patika.CodeFirst.Relation.App.Data;
using Patika.CodeFirst.Relation.App.Models;

Console.WriteLine("Code First Relation Başladı.");

using var db = new PatikaSecondDbContext();

// Migrationları otomatik uygula
db.Database.Migrate();

// Eğer hiç kullanıcı yoksa seed verisi ekle
if (!db.Users.Any())
{
    var user = new User { Username = "selin", Email = "selin@example.com" };
    user.Posts.Add(new Post { Title = "Merhaba", Content = "İlk gönderim!" });
    user.Posts.Add(new Post { Title = "İkinci Post", Content = "Code First Relation çok güzel." });

    db.Users.Add(user);
    db.SaveChanges();
}

Console.WriteLine($"Users: {db.Users.Count()} | Posts: {db.Posts.Count()}");
