using System;

namespace SocialMediaApp
{
    class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        // additional comment properties and methods can be added here
    }
}
