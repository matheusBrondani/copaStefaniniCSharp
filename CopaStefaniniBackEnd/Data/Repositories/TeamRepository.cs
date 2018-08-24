using CopaStefaniniBackEnd.Models.Entities;
using CopaStefaniniBackEnd.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CopaStefaniniBackEnd.Data.Repositories
{
    public class TeamRepository
    {
        private readonly CupContext _context;

        public TeamRepository(CupContext context) {
            _context = context;
        }

        //Retorna todos os times do contexto
        public List<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        //Retorna o time vinculado ao ID
        public Team GetTeamById(int id)
        {
            return _context.Teams.Find(id);
        }

        //Insere um time novo
        public void PostTeam(Team newTeam)
        {
            newTeam.IdTeam = _context.Teams.Max(p => p.IdTeam) + 1;

            _context.Teams.Add(newTeam);
            _context.SaveChanges();
        }

        //Atualiza um time
        public void PutTeam(int id, Team upTeam)
        {
            var toUpTeam = _context.Teams.Find(id);

            toUpTeam.Name = upTeam.Name;
            toUpTeam.NameStadium = upTeam.NameStadium;

            _context.Teams.Update(toUpTeam);
            _context.SaveChanges();
        }

        //Deleta um time
        public void DeleteTeam(int id)
        {
            var team = _context.Teams.Find(id);
            _context.Teams.Remove(team);
            _context.SaveChanges();
        }
    }
}
