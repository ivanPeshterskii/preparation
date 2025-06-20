// Четем вход
int numberOfStudents = int.Parse(Console.ReadLine());
int numberOfLectures = int.Parse(Console.ReadLine());
int additionalBonus = int.Parse(Console.ReadLine());

int maxAttendance = 0;
double maxBonus = 0;

for (int i = 0; i < numberOfStudents; i++)
{
    // Броя на всеки студент => присъствия
    int attendance = int.Parse(Console.ReadLine());

    double totalBonus = 0;
    if (attendance > 0)
    {
        totalBonus = (1.0 * attendance / numberOfLectures) * (5 + (additionalBonus));
    }

    if (totalBonus > maxBonus)
    {
        maxBonus = totalBonus;
        maxAttendance = attendance; 
    }
}
//Изход
Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
Console.WriteLine($"The student has attended {maxAttendance} lectures.");