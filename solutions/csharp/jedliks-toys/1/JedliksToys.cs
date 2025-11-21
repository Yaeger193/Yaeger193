class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        if(_PER>0)
        {
            return String.Format("Driven {0} meters",_METER);
        }
        return "Driven 2000 meters";
    }

    public string BatteryDisplay()
    {
        if(_PER>0)
        {
            return String.Format("Battery at {0}%",_PER);
        }
        return "Battery empty";
    }

    private int _METER;
    private int _PER = 100;
    public void Drive()
    {
        _METER = _METER + 20;
        _PER = _PER - 1;
    }
}
