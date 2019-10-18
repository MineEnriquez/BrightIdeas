
using System.Collections.Generic;

namespace BrightIdeas.Models
{
    public class BrightIdeasPageModel
    {
        public Message OneMessage { get; set; }
        public List<Message> ListOfMessages { get; set; }
        public Like OneLike {get; set;}
        public User CurrentUser {get; set;}
    }
}