using BlazerTutorialProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerTutorialProject.Client.Services
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Title = "Spider-Man: Far from home", RelaseDate = new DateTime(2019, 7, 2), Poster = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRPzzfxN6Ugvq902Ut7A-QkCDOqLzzbiYQ2bPk2pn5D9fBZBrT_" },
                new Movie { Id = 2, Title = "Moana", RelaseDate = new DateTime(2020, 2, 13),  Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTJOaSVrzlgewVqmUgUz4W5ty2KUeHH6s-aYSIr_Qw8v2EBrtCS" },
                new Movie { Id = 3, Title = "Inception", RelaseDate = new DateTime(2016, 11, 6),  Poster = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg" }
            };     
        }
    }
}
