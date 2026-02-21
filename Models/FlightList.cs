using System.ComponentModel.DataAnnotations;

namespace Flight.Models
{
    public class FlightList
    {
        public int FlightListId { get; set; }

        [Required(ErrorMessage = "Please enter a FlightNumber.")]
        public string FlightNumber { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter a From.")]
        public string From { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter a To.")]
        public string To { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter a Date.")]
        public string Date { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Price.")]
        public int? Price { get; set; }
    }
}
