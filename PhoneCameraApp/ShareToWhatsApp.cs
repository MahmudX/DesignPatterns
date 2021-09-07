using System;

namespace PhoneCameraApp
{
    public class ShareToWhatsApp : IShareStrategy
    {
        public void Share()
        {
            Console.WriteLine("Photo shared via WhatsApp.");
        }
    }
}