﻿using GigHubChMask2011.Core.DTOs;
using GigHubChMask2011.Core.Models;
using GigHubChMask2011.Persistence;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GigHubChMask2011.Controllers.api
{
    [Authorize]
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _context;

        public FollowingsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();

            if (_context.Followings.Any(u => u.FollowerId == userId && u.FolloweeId == dto.FolloweeId))
            {
                return BadRequest("Already Following this Artist");
            }

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = dto.FolloweeId
            };

            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Unfollow(string id)
        {
            var userId = User.Identity.GetUserId();

            var following = _context.Followings
                .SingleOrDefault(a => a.FollowerId == userId && a.FolloweeId == id);

            if (following == null)
            {
                return NotFound();
            }

            _context.Followings.Remove(following);
            _context.SaveChanges();

            return Ok(id);
        }
    }
}
