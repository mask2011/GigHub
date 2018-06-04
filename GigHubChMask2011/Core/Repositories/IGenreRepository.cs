using GigHubChMask2011.Core.Models;
using System.Collections.Generic;

namespace GigHubChMask2011.Core.Repositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
    }
}
