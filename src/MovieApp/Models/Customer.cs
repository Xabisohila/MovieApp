using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        public bool IsSubcribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name = "MembershipType")]
        public int MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}