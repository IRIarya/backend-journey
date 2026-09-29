Console.WriteLine("===DASHBOARD===");
Console.Write("Enter how many students you want to add their marks : ");
string studentsNumberInput = Console.ReadLine()??"";
if  (int.TryParse(studentsNumberInput , out int studentsNumber)) {
    
} else
{
    Console.WriteLine("you must enter a number");
}
int[] studentsList =  new int[studentsNumber];
foreach (int studentMark in studentsList)
{
    Console.Write($"enter NO.{studentMark} student mark");
    studentsList[studentMark]=Console.ReadLine()??"";
   
}