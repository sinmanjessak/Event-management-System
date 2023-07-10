using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReading.Event.Models
{
    public class EventViewModel                                     //Events table with custom validations
    {
        public int ID { get; set; }                                 //ID will automatically be selected as primary key

        [Required(ErrorMessage = " Please Enter title of the book")]
        [Display(Name = "Title of the Book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter the Event Date")]
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Please Enter the start time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Please Enter the venue")]
        [Display(Name = "Venue")]
        public string Location { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(1, 4, ErrorMessage = " Duration should be 1-4 hours only")]
        public int? Duration { get; set; }

        [Display(Name = "Organiser")]
        [Required(ErrorMessage = "Please Enter your name")]
        public string Organiser { get; set; }


        [Display(Name = "Type of Event")]
        public string EventType { get; set; }


        [Display(Name = "Invite People")]
        public string? Invitees { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
