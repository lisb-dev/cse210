using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),      // 4.8 km in 30 minutes
            new Cycling(new DateTime(2022, 11, 3), 60, 20.0),     // 20 kph for 60 minutes
            new Swimming(new DateTime(2022, 11, 3), 45, 30)       // 30 laps (1.5 km) in 45 minutes
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
