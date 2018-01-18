using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventCalender.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Location { get; set; }
        public string Color { get; set; }
        public bool IsFullDay { get; set; }
    }
}