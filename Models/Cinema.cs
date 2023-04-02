﻿using System;
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
        [Display(Name = "Logo")]
        public string CinemaLogo { get; set; }
        [Display(Name = "Name")]
        public string CinemaName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
