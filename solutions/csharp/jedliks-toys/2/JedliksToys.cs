class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
            return String.Format("Driven {0} meters",_METER);
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
        if(_PER>0)
        {
            this._METER = _METER + 20;
            this._PER = _PER - 1;
        }
    }
}
