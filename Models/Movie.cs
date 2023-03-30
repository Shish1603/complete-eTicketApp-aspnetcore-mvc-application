﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eTicketApp.Data;

namespace eTicketApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

    }
}
