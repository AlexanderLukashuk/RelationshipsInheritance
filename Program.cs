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
            }
        }
    }
}
