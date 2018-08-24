using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaStefaniniBackEnd.Models.Entities;
using CopaStefaniniBackEnd.Repository;

namespace CopaStefaniniBackEnd.Data
{
    public class DbInitializer
    {

        public static void Initialize(CupContext cupContext) {

            if (cupContext.Players.Any() && cupContext.Teams.Any()) {
                return;
            }

            //Insere na inicialização do banco de teste os players
            cupContext.Players.Add(new Player(1, "Ronaldo Fenomeno", 1, 22, 1, 0, true));
            cupContext.Players.Add(new Player(2, "Galvão Bonno", 2, 33, 1, 0, true));
            cupContext.Players.Add(new Player(3, "João Jogador", 3, 44, 1, 0, true));
            cupContext.Players.Add(new Player(4, "Giuberto NãoGoleiro", 4, 55, 1, 0, true));
            cupContext.Players.Add(new Player(5, "Alberto JogaMuito", 5, 66, 1, 0, true));
            cupContext.Players.Add(new Player(6, "Roberto JogaPouco", 6, 77, 1, 0, true));
            cupContext.Players.Add(new Player(7, "Adalberto JogaRazoavel", 7, 88, 1, 0, true));
            cupContext.Players.Add(new Player(8, "Dagoberto SoCorre", 8, 99, 1, 0, true));
            cupContext.Players.Add(new Player(9, "Qualquerberto EsseGasta", 9, 245, 1, 0, true));
            cupContext.Players.Add(new Player(10, "Michael Jackson", 10, 35, 1, 1, true));
            cupContext.Players.Add(new Player(11, "Oliver Green", 11, 45, 1, 0, true));
            cupContext.Players.Add(new Player(12, "Muro da Silva", 0, 1, 2, 1, true));
            cupContext.Players.Add(new Player(13, "Geromel do Smurf", 1, 2, 0, 0, true));
            cupContext.Players.Add(new Player(14, "Lelogas Elfo", 3, 2, 2, 0, true));
            cupContext.Players.Add(new Player(15, "Gandalf Mago", 4, 2, 2, 0, true));
            cupContext.Players.Add(new Player(16, "Tolkien Escritor", 5, 2, 2, 0, true));
            cupContext.Players.Add(new Player(17, "Luke CeuAndante", 6, 2, 2, 0, true));
            cupContext.Players.Add(new Player(18, "Darth Vader", 7, 2, 2, 0, true));
            cupContext.Players.Add(new Player(19, "Leia Organa", 8, 2, 2, 0, true));
            cupContext.Players.Add(new Player(20, "Han Chão", 9, 2, 2, 0, true));
            cupContext.Players.Add(new Player(21, "R2D2", 10, 2, 2, 0, true));
            cupContext.Players.Add(new Player(22, "C3PO", 11, 2, 2, 0, true));
            cupContext.Players.Add(new Player(23, "Igor Oliveira", 10, 3, 3, 0, true));
            cupContext.Players.Add(new Player(24, "Giuliano Perreira", 1, 3, 3, 0, true));
            cupContext.Players.Add(new Player(25, "Aha de Oliveira", 5, 3, 3, 0, true));
            cupContext.Players.Add(new Player(26, "Nome Aleatório", 0, 1, 3, 0, true));
            cupContext.Players.Add(new Player(27, "Jogador Muito Caro", 10, 9, null, null, false));
            cupContext.Players.Add(new Player(28, "Jogador Sample", 5, 34, null, null, false));
            cupContext.Players.Add(new Player(29, "Ultimo Jogador", 7, 69, null, null, false));
            cupContext.Players.Add(new Player(30, "Marquinhos Boleiro", 0, 1, 1, 0, true));
            cupContext.SaveChanges();

            cupContext.Teams.Add(new Team(1, "Jurubeba F.C.", "Maracabeba"));
            cupContext.Teams.Add(new Team(2, "Wizard Gizzard F.C.", "Wizard\'s Stadium"));
            cupContext.Teams.Add(new Team(3, "Sem Grana F.C.", "Minha Carteira"));

            cupContext.SaveChanges();

        }
    }
}
