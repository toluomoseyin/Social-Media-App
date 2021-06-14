using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
   public  class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
