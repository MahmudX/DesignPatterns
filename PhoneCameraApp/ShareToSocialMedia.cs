using System;

namespace PhoneCameraApp
{
    public class ShareToSocialMedia : IShareStrategy
    {
        public void Share()
        {
            Console.WriteLine("Photo shared to a social media.");
        }
    }
}