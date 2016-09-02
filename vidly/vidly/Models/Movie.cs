using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        [Column(TypeName = "DateTime2")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        [Column(TypeName = "DateTime2")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public string GenreName { get; set; }


    }
}