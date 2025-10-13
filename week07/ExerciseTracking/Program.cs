using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        RunningActivity runningActivity = new RunningActivity(5, 40);
        SwimmingActivity swimmingActivity = new SwimmingActivity(40, 60);
        BikesActivity bikesActivity = new BikesActivity(20, 50);

        activityList.Add(runningActivity);
        activityList.Add(swimmingActivity);
        activityList.Add(bikesActivity);

        foreach (Activity activity in activityList)
        {
            if (activity is SwimmingActivity)
            {
                swimmingActivity.displaySummary();
            }
            else
            {
                activity.displaySummary();
            }
        }
    }
}