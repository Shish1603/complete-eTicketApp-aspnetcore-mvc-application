using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Models
{
    //Many-Many Relationship class b/w Movie and Actor Class
    public class Actors_Movies
    {
        public int MovieId { get; set; }
        public Movie Movies { get; set; }
        public int ActorId { get; set; }
        public Actor Actors { get; set; }
    }
}
