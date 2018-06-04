using GigHubChMask2011.Core.Models;
using System.Collections.Generic;

namespace GigHubChMask2011.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string artistId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        void Add(Gig gig);
    }
}
