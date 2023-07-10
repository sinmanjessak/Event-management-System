using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookReading.Event.Models
{
    public class CommentViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string Comment { get; set; }

        public DateTime TimeStamp { get; set; }

        public EventViewModel _Event { get; set; }

        public CommentViewModel()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
