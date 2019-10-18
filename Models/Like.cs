using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BrightIdeas.Models
{
    public class Like
    {
        public int LikeId { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Like:")]        
        public string LikeContent { get; set; }
        public int UserId{get; set;}
        public int MessageId {get; set;}

        //Navigation properties

        public User LikeCreator { get; set; }
        public Message ParentMessage { get; set; }
    }
}