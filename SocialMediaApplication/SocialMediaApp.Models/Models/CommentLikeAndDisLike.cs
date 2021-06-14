using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class CommentLikeAndDisLike:BaseEntity
    {
        public bool Like { get; set; }
        public bool DisLike { get; set; }
        public string CommentId { get; set; }
        public Comments Comment { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
