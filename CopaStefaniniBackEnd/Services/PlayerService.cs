using CopaStefaniniBackEnd.Data.Repositories;
using CopaStefaniniBackEnd.Models.Entities;
using System.Collections.Generic;

namespace CopaStefaniniBackEnd.Services
{
    public class PlayerService
    {
        private readonly PlayerRepository _Repository;

        public PlayerService(PlayerRepository Repository)
        {
            _Repository = Repository;
        }

        public List<Player> GetAllPlayers()
        {
            return _Repository.GetAllPlayers();
        }

        public Player GetPlayerById(int id)
        {
            return _Repository.GetPlayerById(id);
        }

        public void PostPlayer(Player newTeam)
        {
            _Repository.PostPlayer(newTeam);
        }

        public void PutPlayer(int id, Player upTeam)
        {
            _Repository.PutPlayer(id, upTeam);
        }

        public void DeletePlayer(int id)
        {
            _Repository.DeletePlayer(id);
        }
    }
}
