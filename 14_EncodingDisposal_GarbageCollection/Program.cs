// See https://aka.ms/new-console-template for more information

TimeZone zone = TimeZone.CurrentTimeZone;

Console.WriteLine(zone.StandardName);

Console.WriteLine(zone.DaylightName);

DateTime dt1 = new DateTime(2008, 1, 1);
DateTime dt2 = new DateTime(2008, 8, 1);
Console.WriteLine(zone.IsDaylightSavingTime(dt1));
Console.WriteLine(zone.IsDaylightSavingTime(dt2));
Console.WriteLine(zone.IsDaylightSavingTime(dt1));
Console.WriteLine(zone.IsDaylightSavingTime(dt2));

Console.WriteLine("-------------------------");