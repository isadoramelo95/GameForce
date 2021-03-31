using System;

namespace XGame.Domain.Entities
{
    public class OwnerGames
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }

        public DateTime DataDesejo { get; set; }
        public bool Vendo { get; set; }
        public bool Troco { get; set; }





    }
}
