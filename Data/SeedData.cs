using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjeKlasoru.Models;
using System;
using System.Linq;

namespace ProjeKlasoru.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DemoDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<DemoDbContext>>()))
            {
                // Tbl_Album DbSet'inin null olup olmadığını kontrol edin.
                if (context.Tbl_Album == null)
                {
                    throw new Exception("Tbl_Album DbSet is null.");
                }

                // Look for any albums.
                if (context.Tbl_Album.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tbl_Album.AddRange(
                    new TblAlbum
                    {
                        Album_No = 5126,
                        Album_Tur = "Soul",
                        Sanatci_bilgi = "ColdPlay",
                        Album_Adi = "A Rush of Bloom",
                        Album_Fiyat = 70.0000M,
                        yerli = false
                    },
                    new TblAlbum
                    {
                        Album_No = 9547,
                        Album_Tur = "Soul",
                        Sanatci_bilgi = "Amy Winehouse",
                        Album_Adi = "Frank",
                        Album_Fiyat = 79.0000M,
                        yerli = false
                    },
                    new TblAlbum
                    {
                        Album_No = 9668,
                        Album_Tur = "Sanat Müziği",
                        Sanatci_bilgi = "Bülent Ersoy",
                        Album_Adi = "Dünyam",
                        Album_Fiyat = 50.0000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 2436,
                        Album_Tur = "Yabancı Pop",
                        Sanatci_bilgi = "Lana Del Rey",
                        Album_Adi = "Honeymoon",
                        Album_Fiyat = 55.0000M,
                        yerli = false
                    },
                    new TblAlbum
                    {
                        Album_No = 8669,
                        Album_Tur = "Soul",
                        Sanatci_bilgi = "Inda",
                        Album_Adi = "Gray Forest",
                        Album_Fiyat = 58.0000M,
                        yerli = false
                    },
                    new TblAlbum
                    {
                        Album_No = 9347,
                        Album_Tur = "Yabancı Pop",
                        Sanatci_bilgi = "Billie Eilish",
                        Album_Adi = "Happier Than Ever",
                        Album_Fiyat = 54.5000M,
                        yerli = false
                    },
                    new TblAlbum
                    {
                        Album_No = 2554,
                        Album_Tur = "Halk Müziği",
                        Sanatci_bilgi = "Volkan Konak",
                        Album_Adi = "Manolya",
                        Album_Fiyat = 29.9000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 8899,
                        Album_Tur = "Yerli Pop",
                        Sanatci_bilgi = "Kenan Doğulu",
                        Album_Adi = "Mavi yelken",
                        Album_Fiyat = 39.9000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 7784,
                        Album_Tur = "Yerli Pop",
                        Sanatci_bilgi = "Cem Adrian",
                        Album_Adi = "Kül",
                        Album_Fiyat = 29.9000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 3215,
                        Album_Tur = "Rap",
                        Sanatci_bilgi = "Ceza",
                        Album_Adi = "Onuncu Köy",
                        Album_Fiyat = 35.5000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 6998,
                        Album_Tur = "Yerli Pop",
                        Sanatci_bilgi = "Sıla",
                        Album_Adi = "Mürekkep",
                        Album_Fiyat = 37.0000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 4221,
                        Album_Tur = "Soul",
                        Sanatci_bilgi = "Amy Winehouse",
                        Album_Adi = "Rehab",
                        Album_Fiyat = 58.9000M,
                        yerli = false
                    },
                    new TblAlbum
                    {
                        Album_No = 3213,
                        Album_Tur = "Halk Müziği",
                        Sanatci_bilgi = "Volkan Konak",
                        Album_Adi = "Mora",
                        Album_Fiyat = 34.5000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 7889,
                        Album_Tur = "Sanat Müziği",
                        Sanatci_bilgi = "Muazzez Ersoy",
                        Album_Adi = "Nostalji",
                        Album_Fiyat = 23.4000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 2513,
                        Album_Tur = "Yerli Pop",
                        Sanatci_bilgi = "Sezen Aksu",
                        Album_Adi = "Ağlamak Güzeldir",
                        Album_Fiyat = 47.0000M,
                        yerli = true
                    },
                    new TblAlbum
                    {
                        Album_No = 1298,
                        Album_Tur = "Yerli Pop",
                        Sanatci_bilgi = "Sezen Aksu",
                        Album_Adi = "Gülümse",
                        Album_Fiyat = 52.0000M,
                        yerli = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
