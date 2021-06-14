using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Models.Models
{
    public class Chat:BaseEntity
    {
       
        public string MessageBody { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
       
    }
}
