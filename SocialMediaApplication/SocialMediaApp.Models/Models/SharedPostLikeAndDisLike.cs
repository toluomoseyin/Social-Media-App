using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class SharedPostLikeAndDisLike:BaseEntity
    {
        public bool Like { get; set; }
        public bool DisLike { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }

}
