class RemoteControlCar
{
    private int distanceDriven;
    
    private int batteryPercentage = 100;


    public int Speed { get; }

    public int BatteryDrain { get; }

    public int BatteryPercentage 
    { 
        get { return batteryPercentage; } 
    }

    public RemoteControlCar
    (
        int _speed, 
        int _batteryDrain
    )
    {
        Speed = _speed;

        BatteryDrain = _batteryDrain;
    }

    public bool BatteryDrained()
    {
        return BatteryPercentage < BatteryDrain;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if(BatteryDrained()) return;

        distanceDriven += Speed;

        batteryPercentage -= BatteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new(50, 4);
    }
}

class RaceTrack
{
    private readonly int distance;

    public RaceTrack(int _distance)
    {
        distance = _distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int carDriveableDistance = 
            car.Speed * 
            car.BatteryPercentage / 
            car.BatteryDrain;

        return carDriveableDistance >= distance;
    }
}
