string firstName = "Arya";
string lastName = "Norouzi";
string fullName = firstName + " " + lastName;

Console.WriteLine($"My full name is {firstName} {lastName}");
Console.WriteLine($"UPPERCASE: {fullName.ToUpper()}");
Console.WriteLine($"lowercase: {fullName.ToLower()}");
Console.WriteLine($"My name has {fullName.Replace(" " , "").Length} characters");
Console.WriteLine($"Has \"a\"? {fullName.Contains("a")}");
Console.WriteLine($"You can call me {fullName.Replace(lastName, "Developer")}");

string multiString = """
    this is a
    multi string
    in C#
    """;

Console.WriteLine(multiString);