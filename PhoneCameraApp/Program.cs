namespace PhoneCameraApp
{
    internal class Program
    {
        public static void Main()
        {
            NishadolCamera nishadolCamera = new();
            nishadolCamera.Edit();
            nishadolCamera.SharePhotos(new ShareToBlueTooth());
        }
    }
}
