class RemoteControlCar
{
    private int _distanceDriven;
    private int _batteryPercentage = 100;

    public int Speed { get; }
    public int BatteryDrain { get; }
    public int BatteryPercentage => _batteryPercentage;
    public int MaximumDistance => Speed * BatteryPercentage / BatteryDrain; 

    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }
    public static RemoteControlCar Nitro() => new(50, 4);

    public void Drive()
    {
        if(BatteryDrained()) return;

        _distanceDriven += Speed;
        _batteryPercentage -= BatteryDrain;
    }

    public int DistanceDriven() => _distanceDriven;

    public bool BatteryDrained() => BatteryPercentage < BatteryDrain;
}

class RaceTrack
{
    private readonly int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) => 
        car.MaximumDistance >= _distance;
}
