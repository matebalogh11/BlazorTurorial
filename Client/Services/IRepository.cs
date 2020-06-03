using BlazerTutorialProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerTutorialProject.Client.Services
{
    public interface IRepository
    {
        public List<Movie> GetMovies();
    }
}
