using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BrightIdeas.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Comment:")]        
        public string CommentContent { get; set; }
        public int UserId{get; set;}
        public int MessageId {get; set;}

        //Navigation properties

        public User CommentCreator { get; set; }
        public Message ParentMessage { get; set; }
    }
}