using System;

namespace _3_friends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance (km):");
            double dist = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Bike Speed (km/h):");
            double bikeSpeed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Walker Speed (km/h):");
            double walkerSpeed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Best time is: {FindBestTime(dist, bikeSpeed, walkerSpeed)}");
            Console.WriteLine("The best approach is: cyclist takes first friend and drops him at second breakpoint. " +
                "\nLater cyclist comes back to take a second friend at the first meeting point and brings him to the final destination " +
                "\nwhile the first friend reaches the finish by foot at the same time. ");
            FindBestTime(dist, bikeSpeed, walkerSpeed);

            static string FindBestTime(double dist, double bikeSpeed, double walkerSpeed)
            {
                double brakePoint = 2 * walkerSpeed * dist / (bikeSpeed + 3 * walkerSpeed);

                double bestTimeBike = (brakePoint + 3 * (dist - 2 * brakePoint)) / bikeSpeed + brakePoint / bikeSpeed;

                double bestTimeWalker = brakePoint / walkerSpeed + (dist - 2 * brakePoint) / bikeSpeed + brakePoint / bikeSpeed;

                return $"\nbike: {bestTimeBike} hours  \nwalker: {bestTimeWalker} hours\nbrakepoints: \n * first: {brakePoint} km \n * second {dist - brakePoint} km";
            }
        }
    }
}
