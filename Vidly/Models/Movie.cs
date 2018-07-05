﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; } = DateTime.Today;
        
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public int NumberInStock { get; set; }
        
        [ForeignKey("Genre")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        
        public Genre Genre { get; set; }
        public int NumberAvailable { get; set; }
    }
}