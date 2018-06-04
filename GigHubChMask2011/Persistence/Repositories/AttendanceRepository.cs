using GigHubChMask2011.Core.Models;
using GigHubChMask2011.Core.Repositories;
using GigHubChMask2011.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GigHubChMask2011.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                .ToList();
        }

        public Attendance GetAttendance(int gigId, string userId)
        {
            return _context.Attendances
                    .SingleOrDefault(a => a.GigId == gigId && a.AttendeeId == userId);
        }
    }
}