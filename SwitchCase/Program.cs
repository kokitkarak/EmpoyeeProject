﻿//UC4
class program
{
    //constants
    public const int IS_PART_TIME = 0;
    public const int IS_FULL_TIME = 1;
    public const int EMP_RATE_PER_HOUR = 20;
    static void Main(string[] args)
    {
        //variables
        int empHrs = 0;
        int empWage = 0;
         Random random = new Random();
        int empCheck = random.Next(0, 3);
        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_TIME:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage : " + empWage);

    }
}