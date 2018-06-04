using GigHubChMask2011.Core.Models;

namespace GigHubChMask2011.Core.Repositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string followeeId, string followerId);
    }
}
