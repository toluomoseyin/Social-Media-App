using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMediaApp.Models.Models;

namespace SocialMediaApp.Data
{
    public class SocialMediaDbContext:IdentityDbContext<AppUser>
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options):base(options)
        {

        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<CommentLikeAndDisLike>  CommentLikeAndDisLikes { get; set; }
        public DbSet<Followers> Followers{ get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }
        public DbSet<PictureGallery> PictureGalleries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostLikeAndDisLike> PostLikeAndDisLikes { get; set; }
        public DbSet<SharedPost> SharedPosts { get; set; }
        public DbSet<SharedPostComment> SharedPostComments { get; set; }
        public DbSet<SharedPostLikeAndDisLike> SharedPostLikeAndDisLikes { get; set; }
        public DbSet<VideoGallery> VideoGalleries { get; set; }
    }
}
