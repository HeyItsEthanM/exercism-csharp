class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[]{0, 2, 5, 3, 7, 8, 4};

    public int Today()
    {
        return this.birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount() => this.birdsPerDay[^1] += 1;

    public bool HasDayWithoutBirds() => this.birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++){
            count += this.birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (int day in this.birdsPerDay){
            if (day >= 5){
                count += 1;
            }
        }
        return count;
    }
}
