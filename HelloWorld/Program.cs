Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");
DateTime nextChristmas = new DateTime(DateTime.Now.Year, 12, 25);
DateTime now = DateTime.Now;
int daysToChristmas = (nextChristmas - now).Days;
Console.WriteLine($"There are {daysToChristmas} days until Christmas.");