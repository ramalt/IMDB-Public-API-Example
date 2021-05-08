using System.Collections.Generic;
using Imdb.Entities;

namespace Imdb.DataAccess.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetById();
        Movie GetByName();
        Movie GetByYear();
        Movie GetByStar();
        Movie GetByCategory();
        Movie GetByRating();
    }
}