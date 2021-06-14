using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class Comments:BaseEntity
    {
       
        public string Comment { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }

    }
}
