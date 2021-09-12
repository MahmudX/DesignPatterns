namespace DroneAsDuck
{
    public class DroneAdapter : IDuck
    {
        private readonly IDrone drone;

        public DroneAdapter(IDrone drone)
        {
            this.drone = drone;
        }
        public void Quack()
        {
            drone.Beep();
        }

        public void Fly()
        {
            drone.SpinRotors();
            drone.TakeOff();
        }
    }
}