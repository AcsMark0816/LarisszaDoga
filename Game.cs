using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakewewf
{
    public record Game(string Title,string Genre,int AgeLimit,string Publisher)
    {
        private int price {  get; set; }
        public double rating { get; set; }
        private int Playtime { get; set; }

        public int GPLay()
        {
            return Playtime;
        }
        public string GPublis()
        {
            return Publisher;
        }
        public int Gpri()
        {
            return price;
        }
        public void SPlay(int i)
        {
            Playtime = i;
        }
        public void Spr(int i)
        {
            price = i;
        }


        public bool AgeOK(int i)
        {
            if(i > AgeLimit)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        // 2.feladat
        // Készíts egy public függvényt, amely paraméterként kap egy százalékos kedvezményt!
        // Ha a kedvezmény 1 és 40 százalék közé esik, csökkentse ennek megfelelően a játék Price értékét!
            public double percent(int i)
        {
            if(i > 1 && i <= 40)
            {
              price *= (100 + i) / 100;
                
            }
            return price;
            
            
        }
        public bool LongOK()
        {
            if(Playtime >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ROK(double r)
        {
            if(r >= 1 &&  r <= 10)
            {
                rating = r;
            }
        }
        public bool  PriOk(int i)
        {
            if(price > i)
            {
                return false;
            }
            else
            {
                return true ;
            }
        }
        // 6.feladat
        // Készíts egy public függvényt, amely visszaad egy szöveget az alábbi példa alapján:
        // "A Cyberpunk 2077 egy RPG műfajú játék, amelyet a CD Projekt adott ki, 19990 forintba kerül és 18 éves kortól ajánlott."
        public override string ToString()
        {
            return $"{Title},{Genre},{Publisher},{price},{AgeLimit}";
        }

        public bool ROK()
        {
            if(rating >= 8.5)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        public int PlaxOk(int i)
        {
            return Playtime / i;
        }

    }


    // 16. feladat – Game

    // Készíts egy Game nevű recordot!

    // A record az alábbi adatokat tárolja:
    // - Title : string – public, immutable
    // - Genre : string – public, immutable
    // - Price : int – private, mutable
    // - Rating : double – public, mutable
    // - PlayTime : int – private, mutable
    // - AgeLimit : int – public, immutable
    // - Publisher : string – private, immutable


    // Készíts Get függvényt a PlayTime értékéhez!
    // Készíts Get függvényt a Publisher értékéhez!
    // Készíts Get függvényt a Price értékéhez!
    // Készíts Set függvényt a PlayTime értékéhez!
    // Készíts Set függvényt a Price értékéhez!
}
