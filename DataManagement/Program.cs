using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeanDowdall_s00210945;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Gam db = new GameData();

            using (db)
            {
                Game g1 = new Game()
                {
                    Name = "It Takes Two",
                    Platform = "PC, Xbox, PS, Switch",
                    Metacritic_Score = 88,
                    Price = 69.99m,
                    Game_Image = "/images/ittakes2.jpg",
                    Description = "From Hazelight comes bla bla bla bla bla"

                };
                

                Console.WriteLine("gmaes have been created");

                //add to games table and save changes

                db.Games.Add(g1);
                db.Games.Add(g2);
                db.Games.Add(g3);
                db.Games.Add(g4);

                Console.WriteLine("Games have been added to table");

                db.SaveChanges();
                Console.WriteLine("Data has been saved to DB, hit enter to continue");
                Console.ReadLine();
            }
    }
}
