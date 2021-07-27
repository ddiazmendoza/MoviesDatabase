using MoviesDatabase.Interfaces;
using MoviesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDatabase.DataProviders
{
    public class ImdbProvider : IMoviesProvider
    {
        public Task<List<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
