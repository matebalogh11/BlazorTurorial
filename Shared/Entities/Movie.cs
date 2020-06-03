using System;
using System.Collections.Generic;
using System.Text;

namespace BlazerTutorialProject.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime RelaseDate { get; set; }

        public string Poster { get; set; }

        public string TitleBrief { get { return string.IsNullOrEmpty(Title) ? string.Empty : Title.Length > 60 ? Title.Substring(0, 60) + "..." : Title; } }
    }
}
