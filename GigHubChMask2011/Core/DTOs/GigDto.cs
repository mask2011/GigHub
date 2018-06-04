using GigHubChMask2011.Core.Models;
using System;

namespace GigHubChMask2011.Core.DTOs
{
    public class GigDto
    {
        public int Id { get; set; }
        public UserDto Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }
        public bool IsCanceled { get; set; }
    }
}