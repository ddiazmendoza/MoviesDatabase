using MoviesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDatabase.Interfaces
{
    interface IMoviesProvider
    {
        public Task<List<Movie>> GetAllAsync();
        public Task<Movie> GetAsync(int id);
    }
}
