Console.WriteLine("===DASHBOARD===");
Console.Write("How many students do you have ?");
string studentsNumberInput  = Console.ReadLine() ??"";
if (int.TryParse(studentsNumberInput, out int studentsNumber))
{

}else
{
    while (!int.TryParse(studentsNumberInput,out studentsNumber))
    {
        Console.Write("You must enter a number for this . How many students do you have ?");
        studentsNumberInput = Console.ReadLine() ?? "";
    }
}
int[] studentsList = new int[studentsNumber];
Console.WriteLine(studentsList.Length);
int lowestMark = studentsList[0];
int highestMark = studentsList[0];
int total = 0;

for (int student = 0; student < studentsNumber; student++ )
{
    Console.Write($"Enter NO.{student + 1} student mark : ");
    string studentMarkInput = Console.ReadLine() ?? "";
    while (!int.TryParse(studentMarkInput, out _) )
    {
        Console.Write($"Your mark must be a number . Enter NO.{student} student mark : ");
        studentMarkInput = Console.ReadLine() ??"";
    }
   
    studentsList[student] = studentMark;
    total += studentMark;
    highestMark = highestMark > studentMark ? highestMark : studentMark;
    lowestMark = lowestMark < studentMark ? lowestMark : studentMark;

}
for (int i = 0; i < studentsNumber; i++) { Console.WriteLine(studentsList[i]); }
Console.WriteLine($"""
    Total = {total}
    highest mark = {highestMark}
    lowest mark = {lowestMark}
    average = {(double)total / studentsList.Length}
    """);

