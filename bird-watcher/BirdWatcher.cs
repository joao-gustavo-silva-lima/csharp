class BirdCount
{
    private int[] birdsPerDay;
    private static int[] lastWeekCounts =
    {
        0, 2, 5, 3, 7, 8, 4
    };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return lastWeekCounts;
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(dayCount => dayCount == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for( int i = 0 ; i < numberOfDays ; i++ )
        {
            count += birdsPerDay[i];
        }

        return count;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach(var count in birdsPerDay)
        {
            if(count >= 5) busyDays++;
        }

        return busyDays;
    }
}
