# Patika Code First Relation

Bu proje, **Entity Framework Core Code First** yaklaşımıyla **User** ve **Post** tabloları arasında bire-çok ilişki kurmayı göstermektedir.  
Bir kullanıcı birden fazla post paylaşabilir.

---

## Özellikler
- **User Tablosu**
  - `Id` → Primary Key
  - `Username` (string, max 100)
  - `Email` (string, zorunlu)

- **Post Tablosu**
  - `Id` → Primary Key
  - `Title` (string, max 200)
  - `Content` (string, zorunlu)
  - `UserId` → Foreign Key (Users tablosuna bağlı)

- **İlişki:**  
  - 1 Kullanıcı → n Post  
  - Cascade delete aktif (User silinirse Post’lar da silinir).

---

## Kullanılan Teknolojiler
- .NET 8.0
- Entity Framework Core 8.0
- SQL Server LocalDB
- C#
