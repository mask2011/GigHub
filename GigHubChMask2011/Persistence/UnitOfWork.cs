using GigHubChMask2011.Core.Repositories;
using GigHubChMask2011.Repositories;

namespace GigHubChMask2011.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGigRepository Gigs { get; set; }
        public IAttendanceRepository Attendances { get; set; }
        public IFollowingRepository Followings { get; set; }
        public IGenreRepository Genres { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(context);
            Attendances = new AttendanceRepository(context);
            Followings = new FollowingRepository(context);
            Genres = new GenreRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}