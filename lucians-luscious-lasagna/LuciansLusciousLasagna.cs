class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int elapsedTime)
    {
        return ExpectedMinutesInOven() - elapsedTime;
    }

    public int PreparationTimeInMinutes(int numLayers)
    {
        return numLayers * 2;
    }

    public int ElapsedTimeInMinutes(int numLays, int elapsedTime)
    {
        return PreparationTimeInMinutes(numLays) + elapsedTime;
    }
}
