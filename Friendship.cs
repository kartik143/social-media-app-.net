using System;

namespace SocialMediaApp
{
    class Friendship
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public DateTime CreatedAt { get; set; }
        // additional friendship properties and methods can be added here
    }
}
