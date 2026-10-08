using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace kakewewf
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Game> games = new List<Game>()
{
    new Game("The Witcher 3", "RPG", 18, "CD Projekt"){rating = 9.7},
    new Game("Cyberpunk 2077", "RPG", 18, "CD Projekt"){rating = 8.6},
    new Game("GTA V", "Action", 18, "Rockstar Games"){rating = 9.4},
    new Game("Red Dead Redemption 2", "Action", 18, "Rockstar Games"){rating = 9.6},
    new Game("FIFA 23", "Sports", 3, "Electronic Arts"){rating = 7.4},
    new Game("Battlefield 2042", "Shooter", 16, "Electronic Arts"){rating = 6.8},
    new Game("God of War", "Action", 18, "Sony"){rating = 9.5},
    new Game("Gran Turismo 7", "Racing", 3, "Sony"){rating = 8.7},
    new Game("Super Mario Odyssey", "Platformer", 7, "Nintendo"){rating = 9.6},
    new Game("Mario Kart 8 Deluxe", "Racing", 3, "Nintendo"){rating = 9.3}




};

            games[0].Spr(11900);
            games[1].Spr(12900);
            games[2].Spr(13900);
            games[3].Spr(14900);
            games[4].Spr(15900);
            games[5].Spr(16900);
            games[6].Spr(17900);
            games[7].Spr(18900);
            games[8].Spr(19900);
            games[9].Spr(20900);
            games[0].SPlay(55);
            games[0].SPlay(60);
            games[0].SPlay(65);
            games[0].SPlay(70);
            games[0].SPlay(75);
            games[0].SPlay(80);
            games[0].SPlay(85);
            games[0].SPlay(90);
            games[0].SPlay(95);
            games[0].SPlay(100);


            Console.WriteLine(games.OrderBy(x => x.Gpri()).Select(x => x.Title).First());
            Console.WriteLine(games.Where(x => x.Genre == "Action").Count());

            games.Select(x => x.Genre).Distinct().ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine(games.Where(x => x.Genre == "Action").Sum(x => x.Gpri()));
            Console.WriteLine(games.Sum(x => x.Gpri()));
            foreach (KeyValuePair<string, double> i in games.GroupBy(x => x.Publisher).ToDictionary(y => y.Key, y => y.Max(y => y.rating))) {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);

            };

            foreach (KeyValuePair<string, int> i in games.GroupBy(x => x.Publisher).ToDictionary(y => y.Key, y => y.Sum(y => y.Gpri())))
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }
            foreach (KeyValuePair<string, double> i in games.GroupBy(x => x.Genre).ToDictionary(y => y.Key, y => y.Average(y => y.rating)))
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }
            // 9.feladat
            // LINQ segítségével számítsd ki kiadónként  a játékok átlagos árát,
            // majd keresd meg azt a kiadót, amelynek a játékai átlagosan a legdrágábbak!


            games.GroupBy(x => x.Publisher).OrderByDescending(x => x.Average(x => x.Gpri())).ToDictionary(y => y.Key, y => y.Average(y => y.Gpri())).First();
            foreach (KeyValuePair<string, int> i in games.GroupBy(x => x.Publisher).ToDictionary(y => y.Key, y => y.Select(y => y.Title).Count()))
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }
            foreach (KeyValuePair<string, double> i in games.Where(x => x.rating >= 8.8).GroupBy(x => x.Genre).ToDictionary(y => y.Key, y => y.Average(y => y.Gpri())))
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }
            foreach (KeyValuePair<string,string> i in games.GroupBy(x => x.Publisher).ToDictionary(y => y.Key, y => y.OrderByDescending(y => y.Gpri()).Select(x => x.Title).First())) {

                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }; }







            // LINQ FELADATOK


            // 1.feladat
            // LINQ segítségével keresd meg a legolcsóbb játéknak a címét!


            // 2.feladat
            // LINQ segítségével számold meg, hány Action műfajú játék található a listában!


            // 3.feladat
            // LINQ segítségével add meg az összes műfajt!
            // Minden műfaj csak egyszer szerepeljen az eredményben!


            // 4.feladat
            // LINQ segítségével számítsd ki az RPG műfajú játékok átlagos játékidejét!


            // 5.feladat
            // LINQ segítségével számítsd ki az összes játék Price értékének összegét!


            // 6.feladat
            // LINQ segítségével add vissza kiadónként a legjobb értékelésű játék címét!


            // 7.feladat
            // LINQ segítségével számítsd ki kiadónként a játékok árának összegét!


            // 8.feladat
            // LINQ segítségével add vissza műfajonként a játékok átlagos értékelését!


           

            // 10.feladat
            // LINQ segítségével add vissza kiadónként, hogy hány játék tartozik az adott kiadóhoz!


            // 11.feladat
            // LINQ segítségével számítsd ki műfajonként a játékok átlagos árát,
            // de csak azokat mentsd el, amelyek átlagos értékelése legalább 8.8!


            // 12.feladat
            // LINQ segítségével keresd meg minden kiadó legdrágább játékának címét!
        }
    }

