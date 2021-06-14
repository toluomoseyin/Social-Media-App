
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SocialMediaApp.Models.Models
{
    public class AppUser:IdentityUser
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; } = false;
        public List<SharedPost> SharedPosts { get; set; }
        public List<Followers> Followers { get; set; }
        public List<Following> Following { get; set; }
        public List<Comments> Comments { get; set; }
        public List<Post> Posts { get; set; }
        public List<FriendRequest> FriendRequests { get; set; }
        public List<PictureGallery> PictureGalleries  { get; set; }
        public List<VideoGallery>  VideoGalleries { get; set; }

        public AppUser()
        {
            VideoGalleries = new List<VideoGallery>();
            SharedPosts = new List<SharedPost>();
            Followers = new List<Followers>();
            Following = new List<Following>();
            Comments = new List<Comments>();
            Posts = new List<Post>();
            FriendRequests = new List<FriendRequest>();
            PictureGalleries = new List<PictureGallery>();
        }
    }
}
