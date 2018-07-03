using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; } = DateTime.Today;
        
        [Range(1, 20)]
        [Required]
        public int NumberInStock { get; set; }

        public GenreDto Genre { get; set; }

        public int GenreId { get; set; }

    }
}