using System;

namespace PhoneCameraApp
{
    public abstract class PhoneCamera
    {
        public void Save()
        {
            Console.WriteLine("Photo saved to the storage.");
        }

        public void Take()
        {
            Console.WriteLine("Captured a photo.");
        }

        public void SharePhotos(IShareStrategy shareStrategy)
        {
            shareStrategy.Share();
        }
        public abstract void Edit();
    }
}