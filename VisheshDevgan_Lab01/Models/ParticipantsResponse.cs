using System.ComponentModel.DataAnnotations;
namespace VisheshDevgan_Lab01.Models
{
    public class ParticipantsResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
           ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please specify if you will attend or not")]
        public bool? WillAttend { get; set; }
    }
}
