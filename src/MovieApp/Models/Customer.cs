using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Full name")]
        [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [MinLength(1, ErrorMessage ="First name cannot be a character.")]
        public string FullName { get; set; }

        public bool IsSubcribedToNewsletter { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}