using Camp.DataAccess.Repositories;
using Movies.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Business
{
    public class GenreService : IGenreService
    {
        private IGenreRepository genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;

        }

        public IList<GenreListResponse> GetAllGenres()
        {
            var dtoList = genreRepository.GetAll().ToList();
            List<GenreListResponse> result = new List<GenreListResponse>();
            dtoList.ForEach(g => result.Add(new GenreListResponse
            {
                Id = g.Id,
                Name = g.Name
            }));

            return result;
        }
    }
}
