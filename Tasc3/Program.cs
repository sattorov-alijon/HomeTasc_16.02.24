   int n=Convert.ToInt32(Console.ReadLine());
    int Negative=0, Positive=0, Zeros=0, Even=0, Odd=0, Max=-999999, Min=999999, Sum_of_Digits=0;
for (int i = 0; i < n; i++)
    {
     int a=Convert.ToInt32(Console.ReadLine()); 
     Sum_of_Digits+=a;
     if (a>0)
     {
        Positive++;
     }  
     else if (a<0)
     {
        Negative++;
     }
     else Zeros++;
     if (a%2==0)
     {
        Even++;
     }
     else Odd++;
    
    if (a>Max)
    {
        Max=a;
    }
    if (a<Min)
    {
        Min=a;
    }
}
System.Console.WriteLine("Negative : "+Negative);
System.Console.WriteLine("Positive : "+Positive);
System.Console.WriteLine("Zeros : "+Zeros);
System.Console.WriteLine("Even : "+Even);
System.Console.WriteLine("Odd : "+Odd);
System.Console.WriteLine("Max : "+Max);
System.Console.WriteLine("Min : "+Min);
System.Console.WriteLine("Sum of Digits : "+Sum_of_Digits);

