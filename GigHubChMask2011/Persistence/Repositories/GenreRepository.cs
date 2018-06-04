using GigHubChMask2011.Core.Models;
using GigHubChMask2011.Core.Repositories;
using GigHubChMask2011.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace GigHubChMask2011.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}