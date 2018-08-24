using CopaStefaniniBackEnd.Models.Entities;
using CopaStefaniniBackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaStefaniniBackEnd.Data.Repositories
{
    public class PlayerRepository
    {
        private CupContext _context;

        public PlayerRepository(CupContext context) {
            _context = context;
        }

        //Retorna todos os jogadores do contexto
        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        //Retorna o jogador vinculado ao ID
        public Player GetPlayerById(int id)
        {
            return _context.Players.Find(id);
        }

        //Insere um jogador novo
        public void PostPlayer(Player newPlayer)
        {
            newPlayer.IdPlayer = _context.Players.Max(p => p.IdPlayer) + 1;

            _context.Players.Add(newPlayer);
            _context.SaveChanges();
        }

        //Atualiza um time
        public void PutPlayer(int id, Player upPlayer)
        {
            var toUpPlayer = _context.Players.Find(id);

            toUpPlayer.Name = upPlayer.Name;
            toUpPlayer.Position = upPlayer.Position;
            toUpPlayer.IdTeam = upPlayer.IdTeam;
            toUpPlayer.Shirt = upPlayer.Shirt;
            toUpPlayer.Holder = upPlayer.Holder;
            toUpPlayer.Cap = upPlayer.Cap;

            _context.Players.Update(toUpPlayer);
            _context.SaveChanges();
        }

        //Deleta um jogador
        public void DeletePlayer(int id)
        {
            var jog = _context.Players.Find(id);
            _context.Players.Remove(jog);
            _context.SaveChanges();
        }
    }
}
