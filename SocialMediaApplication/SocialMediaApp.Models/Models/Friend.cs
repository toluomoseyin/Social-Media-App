using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class Friend:BaseEntity
    {
        public string AppUser_1_Id { get; set; }
        public string AppUser_2_Id { get; set; }
    }
}
