char CheckGrade(int grade)
{
    if (grade>89 && grade<=100)
    {
        return 'A';   
    }
        if (grade>79 && grade<90)
    {
        return 'B';   
    }
        if (grade>69 && grade<80)
    {
        return 'C';   
    }
        if (grade>59 && grade<70)
    {
        return 'D';   
    }
        if (grade>=0 && grade<60)
    {
        return 'F';   
    }
    else
     {
        return '?';
     }
}
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckGrade(a));