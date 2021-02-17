// importation des espaces de nommage utiles
using System;

// Ajout de classes dans l'espace de nommage BatNav de l'application
namespace BatNav
{
    public class Gamer
    {
        public Guid ID { get => _guid;  }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        public DateTime _creationDate;
        private Guid _guid;
        public string _pseudo;

        public Gamer(string pseudo) {
            _guid = Guid.NewGuid();
            _creationDate = DateTime.UtcNow;
            Pseudo = pseudo;
        }
        public Gamer(string pseudo, Guid id)
        {
            _guid = id;
            _creationDate = DateTime.UtcNow;
            Pseudo = pseudo;
        }
    }
	
}
