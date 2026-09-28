

Console.WriteLine("welcome to the admin page");
Console.Write("Enter your username : ");
string username = Console.ReadLine() ??"";
Console.Write("Enter your password :");
string password = Console.ReadLine() ?? "";
Console.Write("""
    to proove you are not robot answer this in numbers :
    there are 8 birds sitting on a branch i shot one of them how many left ?
    hint : gun shot will scare birds it is trivial
    """);
string answerInput = Console.ReadLine() ?? "";

if (int.TryParse(answerInput, out int answer))
{
    if (answer == 0)
    {
        if (password != "1234" || username != "admin")
        {
            Console.WriteLine("your username or password was wrong");
        }
        else
        {
            Console.WriteLine("welcome");
        }
    }
    else if (answer == 7)
    {
        Console.WriteLine("think about the hint");
    } else
    {
        Console.WriteLine("your answer is wrong");
    }
} else
{
    Console.WriteLine("enter a number for the answer");
}


