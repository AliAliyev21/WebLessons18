﻿namespace SocialNetworkProject.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string? UsernameOrEmail { get; set; }
        public string? Password { get; set; }
    }
}
