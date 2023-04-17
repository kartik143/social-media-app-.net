using System;

namespace SocialMediaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Social Media App!");

            // create instance of the social media app
            SocialMediaApp app = new SocialMediaApp();
            app.Run();
        }
    }
}
