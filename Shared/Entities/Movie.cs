using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazerTutorialProject.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime? RelaseDate { get; set; }

        public string Poster { get; set; }

        public string TitleBrief { get { return string.IsNullOrEmpty(Title) ? string.Empty : Title.Length > 60 ? Title.Substring(0, 60) + "..." : Title; } }

        public string Summary { get; set; }

        public bool InTheaters { get; set; }

        public string Trailer { get; set; }

        public List<MoviesGenres> MoviesGenres { get; set; } = new List<MoviesGenres>();
    }
}
