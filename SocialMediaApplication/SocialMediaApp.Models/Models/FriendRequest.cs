using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public  class FriendRequest:BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string RequstingAppUserId { get; set; }
       

    }
}
