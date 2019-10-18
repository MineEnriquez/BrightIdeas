using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{

public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name:")]
        public string UserName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Alias:")]
        // [RegularExpression(@"^[a-zA-Z-'\s]{1,40}$")]
        [RegularExpression(@"^[\w\d_.-]+$", ErrorMessage = "Your alias must contain only Letters or Numbers")]
        public string Alias { get; set; }

        [EmailAddress]
        [Required]
        [MinLength(5)]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Password:")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Will not be mapped to your users table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        //navigation properties
        public List<Message> MyMessages { get; set; }
        public List<Like> MyLikes {get; set;}
    }
}
