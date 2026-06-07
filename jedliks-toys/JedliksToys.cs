class RemoteControlCar
{
    private int _drivenMeters;
    private int _batteryPercentage = 100;

    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {_drivenMeters} meters";

    public string BatteryDisplay() => _batteryPercentage > 0
        ? $"Battery at {_batteryPercentage}%"
        :  "Battery empty"
    ;

    public void Drive()
    {  
        if(_batteryPercentage is 0) return;

        _drivenMeters += 20;
        _batteryPercentage -= 1;
    }
}
