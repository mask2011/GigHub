using GigHubChMask2011.Core.Models;
using GigHubChMask2011.Core.Repositories;
using GigHubChMask2011.Persistence;
using System.Linq;

namespace GigHubChMask2011.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Following GetFollowing(string followeeId, string followerId)
        {
            return _context.Followings
                    .SingleOrDefault(f => f.FolloweeId == followeeId && f.FollowerId == followerId);
        }
    }
}