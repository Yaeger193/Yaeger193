class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()//task 1 check what the counts were last week
    {
        return new int[]{0, 2, 5, 3, 7, 8,4};
    }

    public int Today()//Task 2
    {
        int _today = birdsPerDay.Length-1;
        return birdsPerDay[_today];
    }

    public void IncrementTodaysCount()//Task3
    {
        int _today = birdsPerDay.Length-1;
       birdsPerDay[_today] = birdsPerDay[_today] +1;
    }

    public bool HasDayWithoutBirds()//Task4
    {
       for(int i=0;i < birdsPerDay.Length;i++)
       {
           if(birdsPerDay[i]==0)
           {
               return true;
           }
       }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)//Task5 20:42 11/23/2025
    {
        int sumofbird=0;
        for(int i=0;i<numberOfDays;i++)
        {
            sumofbird = sumofbird + birdsPerDay[i];
        }
        return sumofbird;
    }//finish 21:00

    public int BusyDays()//21:03
    {
        int busyday=0;
        foreach(int day in birdsPerDay)
        {
            if(day>4)
            {
                busyday = busyday +1;
            }
        }
        return busyday;
    }
}
