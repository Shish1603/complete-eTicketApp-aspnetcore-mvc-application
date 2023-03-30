using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string CinemaLogo { get; set; }
        public string CinemaName { get; set; }
        public string Description { get; set; }
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
