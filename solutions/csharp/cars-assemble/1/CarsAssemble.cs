static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 10)
        {
            double result = .77;
            return result;
        }
        else if (speed == 9)
        {
            double result = .8;
            return result;
        }
        else if (speed <=8 && speed >=5)
        {
            double result = .9;
            return result;
        }
        else if (speed <=4 && speed >=1)
        {
             int result = 1;   
            return result;
        }
        else 
        {
            int result = 0;
            return result;
        }        
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int standardPerHr = 221;
        double  productionRate = speed * standardPerHr * SuccessRate(speed);
        return productionRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workingItems = ProductionRatePerHour(speed) / 60;
        return (int)workingItems;
    }
}
