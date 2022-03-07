// See https://aka.ms/new-console-template for more information

void timeSpan()
{
    var result = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);

    Console.WriteLine(result.Days);
    Console.WriteLine(result.Hours);
    Console.WriteLine(result.Minutes);
    Console.WriteLine(result.Seconds);
    Console.WriteLine(result.Milliseconds);

    Console.ReadLine();
}

void timeSpan_1()
{
    Console.WriteLine(new TimeSpan(2, 30, 0));
    Console.WriteLine(TimeSpan.FromHours(2.5));
    Console.WriteLine(TimeSpan.FromHours(-2.5));

    Console.ReadLine();
}

void dateTimeExample()
{
    DateTime date1 = new DateTime(2022, 5, 1, 8, 30, 52);

    DateTime date2 = DateTime.Now;
    DateTime date3 = DateTime.UtcNow;
    DateTime date4 = DateTime.UtcNow;
    string dateString = "5/1/2008 8:30:52 AM";
    DateTime date5 = DateTime.Parse(dateString);
    Console.ReadLine();

}

void dateTimeExample_1()
{
    DateTime today = DateTime.Now;
    TimeSpan duration = new TimeSpan(36, 0, 0, 0);
    DateTime answer = today.Add(duration);
    Console.WriteLine("{0}", answer.DayOfWeek);
    Console.ReadLine();
    Console.WriteLine("{0}", answer.DayOfWeek);
    Console.ReadLine();
}

void dateTimeExample_2()
{
    DateTime now = DateTime.Now;
    Console.WriteLine("Now - {0}", now);
   
    TimeSpan duration =  TimeSpan.FromDays(3);
    DateTime before = now.Subtract(duration);
    Console.WriteLine("Before - {0}", before);
    
    Console.ReadLine();
   
}

void dateTimeExample_3()
{
    DateTimeOffset dt = new DateTime(2000, 2, 3);
    Console.WriteLine(dt);
    Console.ReadLine();
}

void dateTimeExample_4() 
{
    var dateTime = new DateTime(2008, 5, 2, 8, 30, 52, DateTimeKind.Unspecified);
    Console.WriteLine(dateTime);

    DateTimeOffset offset = dateTime;
    Console.WriteLine(offset);

    DateTime localDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
    offset = localDateTime;
    Console.WriteLine(offset);

    DateTime utcDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
    offset = utcDateTime;
    Console.WriteLine(offset);

    Console.ReadLine();

}

void dateTimeExample_5()
{
    DateTimeOffset offset = new DateTimeOffset(DateTime.Now);
    Console.WriteLine(offset);

    string template = "{0} {1}";

    DateTime dt1 = offset.DateTime;
    Console.WriteLine(template, dt1, dt1.Kind);

    DateTime dt2 = offset.LocalDateTime;
    Console.WriteLine(template, dt2, dt2.Kind);

    DateTime dt3 = offset.UtcDateTime;
    Console.WriteLine(template, dt3, dt3.Kind);
} 

void TimeZone()
{
    // official page of microsoft example
}