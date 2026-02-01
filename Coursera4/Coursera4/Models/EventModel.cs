using System.ComponentModel.DataAnnotations;

namespace Coursera4.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace Coursera4.Models
    {
        public class EventModel
        {
            public int EventId { get; set; }

            [Required(ErrorMessage = "Event Name is required.")]
            [StringLength(50, ErrorMessage = "Name is too long (50 chars max).")]
            public string EventName { get; set; } = string.Empty;

            [Required(ErrorMessage = "Location is required.")]
            public string Location { get; set; } = string.Empty;

            [Required]
            [Range(typeof(DateTime), "1/1/2024", "12/31/2030", ErrorMessage = "Date must be between 2024 and 2030")]
            public DateTime EventDate { get; set; } = DateTime.Now;
        }
    }
}
