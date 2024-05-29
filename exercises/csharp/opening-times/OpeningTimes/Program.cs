/*** Requirement
* Designing and handling opening hours
*/

// Create opening hours for a store
OpeningHours storeHours = new OpeningHours(OpeningHours.Monday | OpeningHours.Tuesday | OpeningHours.Wednesday,
                                            TimeSpan.FromHours(8), TimeSpan.FromHours(12));

// Check if the store is open on Tuesday
bool isOpenOnTuesday = storeHours.IsOpen(OpeningHours.Tuesday);
Console.WriteLine($"Is the store open on Tuesday? {isOpenOnTuesday}");


// Check if the store is open on Monday
bool isOpenOnMonday = storeHours.IsOpen(OpeningHours.Monday);
Console.WriteLine($"Is the store open on Monday? {isOpenOnMonday}");


// Check if the store is open on Saturday
bool isOpenOnSaturday = storeHours.IsOpen(OpeningHours.Saturday);
Console.WriteLine($"Is the store open on Saturday? {isOpenOnSaturday}");


class OpeningHours
{
    // Define constants for each day of the week
    public const int Monday = 1;
    public const int Tuesday = 1 << 1;
    public const int Wednesday = 1 << 2;
    public const int Thursday = 1 << 3;
    public const int Friday = 1 << 4;
    public const int Saturday = 1 << 5;
    public const int Sunday = 1 << 6;

    public int DaysOpen { get; set; }
    public TimeSpan OpenTime { get; set; }
    public TimeSpan CloseTime { get; set; }

    public OpeningHours(int daysOpen, TimeSpan openTime, TimeSpan closeTime)
    {
        DaysOpen = daysOpen;
        OpenTime = openTime;
        CloseTime = closeTime;
    }

    public bool IsOpen(int day)
    {
        // Use bitwise AND operation to check if the day is set in DaysOpen
        return (DaysOpen & day) != 0;
    }
}
