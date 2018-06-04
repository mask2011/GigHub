using GigHubChMask2011.Persistence;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHubChMask2011.Controllers
{
    public class FolloweesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FolloweesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Followees
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            var artists = _context.Followings
                .Where(f => f.FollowerId == userId)
                .Select(a => a.Followee)
                .ToList();

            return View(artists);
        }
    }
}