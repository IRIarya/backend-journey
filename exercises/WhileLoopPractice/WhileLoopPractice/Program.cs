const int MaxAttempts = 3;
int attempts = 0;
bool granted = false;

while (attempts < MaxAttempts)
{
    Console.Write("Enter your password: ");
    string password = Console.ReadLine() ?? "";

    if (password == "secret")
    {
        granted = true;
        break;
    }

    attempts++;
    int left = MaxAttempts - attempts;

    if (left > 0)
    {
        Console.WriteLine($"Wrong password. {left} attempt(s) left.");
    }
}

if (granted)
{
    Console.WriteLine("Access granted.");
}
else
{
    Console.WriteLine("You ran out of attempts.");
}

// mine had bug and this is AI generated but not due to i didnt know what to do ( i was lazy to rewrite sth i know )