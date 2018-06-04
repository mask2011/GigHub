using GigHubChMask2011.Core.Models;
using System.Collections.Generic;

namespace GigHubChMask2011.Core.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        Attendance GetAttendance(int gigId, string userId);
    }
}
