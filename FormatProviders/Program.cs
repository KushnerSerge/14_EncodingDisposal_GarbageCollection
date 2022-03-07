// See https://aka.ms/new-console-template for more information
using System.Globalization;

void cultInfo1()
{
    Console.WriteLine("Hello, World!");

    CultureInfo uk = CultureInfo.GetCultureInfo("en-GB");
    Console.WriteLine(3.ToString("C"), uk);
    Console.WriteLine(3.ToString("C"), CultureInfo.CurrentCulture);
}

void cultInfo2()
{
    DateTime dt = new DateTime(2000, 12, 26);
    CultureInfo invariant = CultureInfo.InvariantCulture;
    CultureInfo uk = new CultureInfo("en-GB");

    Console.WriteLine(dt.ToString(invariant));
    Console.WriteLine(dt.ToString(uk));
    Console.ReadLine(); 
}

void cultInfo3()
{
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

    DateTime[] dates = {
                new DateTime(2019, 10, 9),
                new DateTime(2020, 1, 2)
            };

    using var sw = new StreamWriter(@"C:\Users\Jano\Documents\tmp\dates.dat");
    sw.Write(String.Format(CultureInfo.InvariantCulture,
        "{0:d}|{1:d}", dates[0], dates[1]));
}

//  ------------- Number Formating ---------------------
NumberFormatInfo f = new NumberFormatInfo();
f.NumberGroupSeparator = " ";
Console.WriteLine(12345.6789.ToString("N1, f")); // 12 345.7
Console.WriteLine(12345.6789.ToString("N2, f")); // 12 345.68
Console.WriteLine(12345.6789.ToString("N3, f")); // 12 345.679
