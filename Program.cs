using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace FootballManager
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                /*Team barcelona = new Team { Name = "Барселона"};
                Team realMadrid = new Team { Name = "Реал Мадрид"};
                Team arsenal = new Team { Name = "Арсенал"};

                context.Teams.Add(barcelona);
                context.Teams.Add(realMadrid);
                context.Teams.Add(arsenal);
                context.SaveChanges();

                NationalTeam spainNationalTeam = new NationalTeam { Name = "Сборная Испании"};
                NationalTeam englandNationalTeam = new NationalTeam { Name = "Сборная Англии"};

                context.NationalTeams.Add(spainNationalTeam);
                context.NationalTeams.Add(spainNationalTeam);
                context.SaveChanges();*/

                //Player player1 = new Player { Name = "Серхио Регилон", Position = "Защитник", Team = realMadrid, NationalTeam = spainNationalTeam};
                //Player player2 = new Player { Name = "Серхио Бускетс", Position = "Полузащитник", Team = barcelona, NationalTeam = spainNationalTeam};
                //Player player3 = new Player { Name = "Ансу Фати", Position = "Нападающий", Team = barcelona, NationalTeam = spainNationalTeam};
                //Player player4 = new Player { Name = "Энзли Мейтленд-Найлз", Position = "Полузащитник", Team = arsenal, NationalTeam = englandNationalTeam};
                /*Player player1 = new Player { Name = "Серхио Регилон", Position = "Защитник"};
                player1.Teams.Add(realMadrid);
                player1.NationalTeams.Add(spainNationalTeam);
                Player player2 = new Player { Name = "Серхио Бускетс", Position = "Полузащитник"};
                player2.Teams.Add(barcelona);
                player2.NationalTeams.Add(spainNationalTeam);
                Player player3 = new Player { Name = "Ансу Фати", Position = "Нападающий"};
                player3.Teams.Add(barcelona);
                player3.NationalTeams.Add(spainNationalTeam);
                Player player4 = new Player { Name = "Энзли Мейтленд-Найлз", Position = "Полузащитник"};
                player4.Teams.Add(arsenal);
                player4.NationalTeams.Add(englandNationalTeam);*/
                //context.Players.AddRange(new List<Player> { player1, player2, player3, player4 });
                //context.SaveChanges();

                /*Player player1 = new Player { Name = "Серхио Регилон", Position = "Защитник"};
                Player player2 = new Player { Name = "Серхио Бускетс", Position = "Полузащитник"};
                Player player3 = new Player { Name = "Ансу Фати", Position = "Нападающий"};
                Player player4 = new Player { Name = "Энзли Мейтленд-Найлз", Position = "Полузащитник"};
                context.Players.AddRange(new List<Player> { player1, player2, player3, player4 });
                //context.Players.Add(player1);
                //context.Players.Add(player2);
                //context.Players.Add(player3);
                //context.Players.Add(player4);
                context.SaveChanges();

                Team barcelona = new Team { Name = "Барселона"};
                barcelona.Players.Add(player2);
                barcelona.Players.Add(player3);
                Team realMadrid = new Team { Name = "Реал Мадрид"};
                realMadrid.Players.Add(player1);
                Team arsenal = new Team { Name = "Арсенал"};
                arsenal.Players.Add(player4);
                context.Teams.Add(barcelona);
                context.Teams.Add(realMadrid);
                context.Teams.Add(arsenal);
                context.SaveChanges();*/


                Team barcelona = new Team { Name = "Барселона" };
                Team realMadrid = new Team { Name = "Реал Мадрид" };
                Team arsenal = new Team { Name = "Арсенал" };

                context.Teams.Add(barcelona);
                context.Teams.Add(realMadrid);
                context.Teams.Add(arsenal);
                context.SaveChanges();

                NationalTeam spainNationalTeam = new NationalTeam { Name = "Сборная Испании" };
                NationalTeam englandNationalTeam = new NationalTeam { Name = "Сборная Англии" };

                context.NationalTeams.Add(spainNationalTeam);
                context.NationalTeams.Add(spainNationalTeam);
                context.SaveChanges();

                Player player1 = new Player { Name = "Серхио Регилон", Position = "Защитник", Team = realMadrid, NationalTeam = spainNationalTeam };
                Player player2 = new Player { Name = "Серхио Бускетс", Position = "Полузащитник", Team = barcelona, NationalTeam = spainNationalTeam };
                Player player3 = new Player { Name = "Ансу Фати", Position = "Нападающий", Team = barcelona, NationalTeam = spainNationalTeam };
                Player player4 = new Player { Name = "Энзли Мейтленд-Найлз", Position = "Полузащитник", Team = arsenal, NationalTeam = englandNationalTeam };
                //context.Players.AddRange(new List<Player> { player1, player2, player3, player4 });
                context.Players.Add(player1);
                context.Players.Add(player2);
                context.Players.Add(player3);
                context.Players.Add(player4);
                context.SaveChanges();

                foreach (Player pl in context.Players.Include(p => p.Team))
                    Console.WriteLine("{0} - {1}", pl.Name, pl.Team != null ? pl.Team.Name : "");
                Console.WriteLine();
                foreach (Team t in context.Teams.Include(t => t.Players))
                {
                    Console.WriteLine("Команда: {0}", t.Name);
                    foreach (Player pl in t.Players)
                    {
                        Console.WriteLine("{0} - {1}", pl.Name, pl.Position);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
