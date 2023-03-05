class DistanceConverter
{
    const int MilesInFeet = 5280;
    const double MilesInMeters = 1609.34;
    const string wspace = " "; //whitespace

    static void AuthorName()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   App 01 - Distance Converter");
        Console.WriteLine("         By Denzel Eshun");
        Console.WriteLine("-----------------------------------");
    }

    static void ConversionOption()
    {
        Console.WriteLine("Please Select The Unit To Convert From:");
        Console.WriteLine("1. Miles");
        Console.WriteLine("2. Feet");
        Console.WriteLine("3. Metres");
        int fromUnit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Select The Unit To Convert To:");
        Console.WriteLine("1. Miles");
        Console.WriteLine("2. Feet");
        Console.WriteLine("3. Metres");
        int toUnit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Distance To Convert:");
        float distance; // Variable Declaration

        // Adds a parse to check and make sure correct data type has been entred
        if (!float.TryParse(Console.ReadLine(), out distance))
        {
            //Displays error message if an incorrect conversion...
            //...option is chosen
            Console.WriteLine("Incorrect input");
            return;
        }


        Console.WriteLine(" ");
        
        //  Miles to Feet
        if (fromUnit == 1 && toUnit == 2)
        {
            float distanceInFeet = (distance * MilesInFeet);
            Console.WriteLine(distance + wspace + "miles " + "is " + distanceInFeet + wspace + "feet.");
        }
       
        //  Miles to Meters
        else if (fromUnit == 1 && toUnit == 3)
        {
            double distanceInMeters = (distance * MilesInMeters);
            Console.WriteLine(distance + wspace + "miles " + "is " + distanceInMeters + wspace + "meters.");
        }

        //  Feet to Miles
        else if (fromUnit == 2 && toUnit == 1)
        {
            double distanceInMiles = (distance / MilesInFeet);
            Console.WriteLine(distance + wspace + "feet " + "is " + distanceInMiles + wspace + "miles.");
        }

        //  Feet to Meters
        else if (fromUnit == 2 && toUnit == 3)
        {
            double distanceInMeters = (distance / 3.281);
            Console.WriteLine(distance + wspace + "feet " + "is " + distanceInMeters + wspace + "meters.");
        }

        //  Meters to Miles
        else if (fromUnit == 3 && toUnit == 1)
        {
            double distanceInMiles = (distance / MilesInMeters);
            Console.WriteLine(distance + wspace + "meters " + "is " + distanceInMiles + wspace + "miles.");
        }

        //  Meters to Feet
        else if (fromUnit == 3 && toUnit == 2)
        {
            double distanceInFeet = (float)(distance * 3.281);
            Console.WriteLine(distance + wspace + "meters " + "is " + distanceInFeet + wspace + "feet.");
        }

        //  Wrong Selection Entered to Feet
        else
        {
            //Displays error message if the wrong data type is entered
            Console.WriteLine("Invalid unit selection.");
        }
    }


    static void Main()  // runs the seperate methods
    {
        AuthorName();
        ConversionOption();
    }
}
