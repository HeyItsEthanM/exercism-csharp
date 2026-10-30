public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
    var result = new HashSet<int>();
    for(int i = 1; i < max; i++){
        foreach(int num in multiples){
            if(num > 0 &&i % num == 0){
                result.Add(i);
                break;
            }
        }
    }
     return result.Sum();
    }
}