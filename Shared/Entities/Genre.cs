﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazerTutorialProject.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The name is required!")]
        public string Name { get; set; }

        public List<MoviesGenres> MoviesGenres { get; set; } = new List<MoviesGenres>();
    }
}
