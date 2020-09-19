using System.Collections.Generic;

namespace FootballManager
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }
        public int? NationalTeamId { get; set; }
        public NationalTeam NationalTeam { get; set; }
        //public List<TeamPlayer> TeamsPlayers { get; set; }
        //public List<NationalTeam> NationalTeams { get; set; }
    }
}