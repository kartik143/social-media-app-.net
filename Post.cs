using System;

namespace SocialMediaApp
{
    class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        // additional post properties and methods can be added here
    }
}
