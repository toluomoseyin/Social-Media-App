using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class Following:BaseEntity
    {
        public string FollowerId { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
