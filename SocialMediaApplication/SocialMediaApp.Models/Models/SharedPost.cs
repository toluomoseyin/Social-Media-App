using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class SharedPost:BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }
        public List<SharedPostLikeAndDisLike> SharedPostLikeAndDisLikes{ get; set; }
        public List<SharedPostComment> SharedPostComments { get; set; }

        public SharedPost()
        {
            SharedPostLikeAndDisLikes = new List<SharedPostLikeAndDisLike>();
            SharedPostComments = new List<SharedPostComment>();
        }
    }
}
