public static class LineUp
{
    public static string Format(string name, int number)
    {
        int last = number % 10;
        int lastTwo = number % 100;
        if (last == 1  && lastTwo != 11){
            return $"{name}, you are the {number}st customer we serve today. Thank you!";
        } else if (last == 2 && lastTwo != 12){
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        } else if (last == 3 && lastTwo != 13){
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        }else{
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
    }
}
