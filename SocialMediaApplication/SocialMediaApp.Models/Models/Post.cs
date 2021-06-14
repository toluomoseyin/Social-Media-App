using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class Post:BaseEntity
    {
        public string Message { get; set; }
        public string PostPhotoUrl { get; set; }
        public string VideoUrl { get; set; }
        public string UserId  { get; set; }
        public AppUser User { get; set; }
        public List<SharedPost> sharedPosts { get; set; }
        public List<Comments> Comments { get; set; }
        public List<PostLikeAndDisLike> PostLikeAndDisLikes { get; set; }
        public Post()
        {
            sharedPosts = new List<SharedPost>();
            Comments = new List<Comments>();
            PostLikeAndDisLikes = new List<PostLikeAndDisLike>();
        }
    }
}
