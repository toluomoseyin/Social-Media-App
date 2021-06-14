using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class PictureGallery:BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        
    }
}
