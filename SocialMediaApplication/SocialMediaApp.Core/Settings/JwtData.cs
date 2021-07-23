using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaApp.Core.Settings
{
    public class JwtData
    {
        public const string Data = "JWTConfigurations";
        public TimeSpan TokenLifeTime { get; set; }

        public string SecretKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }
    }
}
