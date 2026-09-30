using System.ComponentModel.DataAnnotations;

namespace P7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Feedback is required")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        public int? Rating { get; set; }
    }
}
