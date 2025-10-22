public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool Divisible4 = ((year % 4) == 0) ;
        bool NotDivisible100 = ((year %100) > 0);
        bool Divisible400 = ((year % 400) == 0) ;
       // bool Divisible4 = ((year % 4) == 0) ;
        bool Leap = (Divisible4 & Divisible400) || (Divisible4 & NotDivisible100);
        return Leap;
    }
}