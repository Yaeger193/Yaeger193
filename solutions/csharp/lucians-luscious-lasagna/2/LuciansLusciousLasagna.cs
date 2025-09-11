
class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    public int RemainingMinutesInOven(int x)
    {
        return x= 40-x;
    } 
    public int PreparationTimeInMinutes(int y)
    {
        return y*2;
    }
    public int ElapsedTimeInMinutes(int y, int x)
    {
        return  x + y * 2;
    }
}
