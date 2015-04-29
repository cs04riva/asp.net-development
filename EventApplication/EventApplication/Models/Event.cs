using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Event
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public string eventName { get; set; }

        public string eventDescription { get; set; }

        [Required]
        public DateTime eventDate { get; set; }

        public List<ApplicationUser> eventGuestList { get; set; }

        public List<string> locations { get; set; }

        public string eventHost { get; set; }

    }

}