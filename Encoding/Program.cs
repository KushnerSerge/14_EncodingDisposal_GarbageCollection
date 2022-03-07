// See https://aka.ms/new-console-template for more information

using System.Text;


void Encod()
{
    Encoding utf8 = Encoding.GetEncoding("utf-8");
    Encoding chinese = Encoding.GetEncoding("GB18030");
    Encoding ascii = Encoding.ASCII;
}

void systemTextEncoding()
{
    string str = "0123456789";

    byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes(str);
    byte[] utf16Bytes = System.Text.Encoding.Unicode.GetBytes(str);
    byte[] utf32Bytes = System.Text.Encoding.UTF32.GetBytes(str);

    Console.WriteLine(utf8Bytes.Length);
    Console.WriteLine(utf16Bytes.Length);
    Console.WriteLine(utf32Bytes.Length);

    string original1 = System.Text.Encoding.UTF8.GetString(utf8Bytes);
    string original2 = System.Text.Encoding.UTF8.GetString(utf16Bytes);
    string original3 = System.Text.Encoding.UTF8.GetString(utf32Bytes);

    Console.WriteLine(original1);
    Console.WriteLine(original2);
    Console.WriteLine(original3);
}

void encodingConvert()
{
    string unicodeString = "This string contains the Unicode character Pi (\u03a0) ";

    // Creating two different encodings.
    Encoding ascii = Encoding.ASCII;
    Encoding unicode = Encoding.Unicode;

    // Convert the string into a byte array.
    byte[] unicodeBytes = unicode.GetBytes(unicodeString);

    //Perform the conversion from one encoding to the other.
    byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

    // Convert the new byte[] into a string.
    string asciiString = ascii.GetString(asciiBytes);

    //Display the strings created before and after the conversion.
    Console.WriteLine("Original string: {0}", unicodeString);
    Console.WriteLine("ASCII converted string: {0}", asciiString);

    Console.ReadLine();
}

void stringConstruct()
{
    // Simple way - assigning a literal
    string s1 = "Hello";
    string s2 = "First Line\r\nSecond Line";
    string s3 = @"\\server\fileshare\helloworld.cs";

    Console.Write(new string('*', 10));

    char[] ca = "Hello".ToCharArray();
    string s = new string(ca);
    Console.WriteLine(s);
}

void emptyStrings()
{
    string empty = "";
    Console.WriteLine(empty == "");
    Console.WriteLine(empty == string.Empty);
    Console.WriteLine(empty.Length == 0);

    Console.WriteLine("--------------");

    string nullString = null;
    Console.WriteLine(nullString == null);
    Console.WriteLine(nullString == "");
    Console.WriteLine(nullString.Length == 0);

    Console.ReadLine();

}

void emptyStrings_1(){
    string nullString = null;
    string emptyString = "";

    if (string.IsNullOrEmpty(nullString))
        Console.WriteLine("nullString");

    if (string.IsNullOrEmpty(emptyString))
        Console.WriteLine("emptyString");

    string str = "abcde";
    char letter = str[1];

    Console.ReadLine();
}

void stringSearching()
{
    string testString = "quick brown fox";
    testString.StartsWith("quick");
    testString.Contains("brown");
    testString.EndsWith("fox");
}

void stringFormatting()
{
    string composite = "It's {0} degree in {1} on this {2} morning";
    string s = string.Format(composite, 35, "Timisoarea", DateTime.Now.DayOfWeek);
    Console.WriteLine(s);
    Console.ReadLine();
}

void stringFormatting_1()
{
    string composite = "Name={0,-20} Credit Limit={1,15:C}";

    Console.WriteLine(string.Format(composite, "Mary", 500));
    Console.WriteLine(string.Format(composite, "Elizabeth", 2000));
    Console.ReadLine();
}

void stringComparing()
{
    string first = "Sie tanzen auf der Straße.";
    string second = "Sie tanzen auf der Strasse.";

    Console.WriteLine($"First sentence is <{first}>");
    Console.WriteLine($"Second sentence is <{second}>");

    bool equal = String.Equals(first, second, StringComparison.InvariantCulture);
    Console.WriteLine($"The two strings {(equal == true ? "are" : "are not")} equal.");
    showComparison(first, second);

    string word = "coop";
    string words = "co-op";
    string other = "cop";

    showComparison(word, words);
    showComparison(word, other);
    showComparison(words, other);
    void showComparison(string one, string two)
    {
        int compareLinguistic = String.Compare(one, two, StringComparison.InvariantCulture);
        int compareOrdinal = String.Compare(one, two, StringComparison.Ordinal);
        if (compareLinguistic < 0)
            Console.WriteLine($"<{one}> is less than <{two}> using invariant culture");
        else if (compareLinguistic > 0)
            Console.WriteLine($"<{one}> is greater than <{two}> using invariant culture");
        else
            Console.WriteLine($"<{one}> and <{two}> are equivalent in order using invariant culture");
        if (compareOrdinal < 0)
            Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
        else if (compareOrdinal > 0)
            Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
        else
            Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
    }
}

void  stringsOrderComparison()
{
    Console.WriteLine(string.Compare("Boston", "Austin", StringComparison.InvariantCulture));
    Console.WriteLine(string.Compare("Boston", "Boston", StringComparison.InvariantCulture));
    Console.WriteLine(string.Compare("Boston", "Chicago", StringComparison.InvariantCulture));
    Console.WriteLine(string.Compare("foo", "FOO", StringComparison.InvariantCulture));
    Console.WriteLine(string.Compare("foo", "FOO", StringComparison.CurrentCulture));
}
}



