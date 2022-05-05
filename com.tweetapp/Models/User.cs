using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.tweetapp.Models
{
    public class User
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        [Required]
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }

        [Required]
        public string EmailId { get; set; }

        [Required]
        public string Passcode { get; set; }

        public bool Status { get; set; }

    }
}
