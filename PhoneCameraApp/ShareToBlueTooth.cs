using System;

namespace PhoneCameraApp
{
    public class ShareToBlueTooth : IShareStrategy
    {
        public void Share()
        {
            Console.WriteLine("Photo shared via BlueTooth.");
        }
    }
}