using CopaStefaniniBackEnd.Data.Repositories;
using CopaStefaniniBackEnd.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CopaStefaniniBackEnd.Services
{
    public class TeamService
    {
        private readonly TeamRepository Repository;
        private readonly PlayerRepository PlayerRepository;

        public TeamService(TeamRepository _Repository, PlayerRepository _PlayerRepository) {
            Repository = _Repository;
            PlayerRepository = _PlayerRepository;
        }

        public List<Team> GetAllTeamsWithPlayers()
        {

            var listTeam = Repository.GetAllTeams();

            foreach (var team in listTeam)
            {
                team.ListPlayers = PlayerRepository.GetAllPlayers().Where(p => p.IdTeam == team.IdTeam);
            }

            return listTeam;
        }

        public List<Team> GetAllTeams()
        {
            return Repository.GetAllTeams();
        }

        public Team GetTeamById(int id)
        {
            return Repository.GetTeamById(id);
        }

        public void PostTeam(Team newTeam)
        {
            Repository.PostTeam(newTeam);
        }

        public void PutTeam(int id, Team upTeam)
        {
            Repository.PutTeam(id, upTeam);
        }

        public void DeleteTeam(int id)
        {
            Repository.DeleteTeam(id);
        }
    }
}
