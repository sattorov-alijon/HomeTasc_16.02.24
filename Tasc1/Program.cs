int EvenCount(int n)
{int cnt=0;
    for (int i = n; i >0; i/=10)
    {
        if (i%2==0)
        {
            cnt++;
        }
    }
return cnt;
}

int OddCount(int n)
{int cnt=0;
    for (int i = n; i >0; i/=10)
    {
        if (i%2!=0)
        {
            cnt++;
        }
    }
return cnt;
}

int ZeroCount(int n)
{int cnt=0;
    for (int i = n; i >0; i/=10)
    {
        if (i%10==0)
        {
            cnt++;
        }
    }
return cnt;
}

int DigitCount(int n)
{int cnt=0;
    for (int i = n; i >0; i/=10)
    {
            cnt++;
    }
return cnt;
}

int MinDigit(int n)
{int cnt=99999;
    for (int i = n; i >0; i/=10)
    {
        if(i%10<cnt)
            cnt=i%10;
    }
return cnt;
}

int MaxDigit(int n)
{int cnt=-99999;
    for (int i = n; i >0; i/=10)
    {
        if(i%10>cnt)
            cnt=i%10;
    }
return cnt;
}

int SumDigit(int n)
{int cnt=0;
    for (int i = n; i >0; i/=10)
    {
        
            cnt+=i%10;
    }
return cnt;
}

int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Even : ");
Console.WriteLine(EvenCount(a));
System.Console.Write("Odd : ");
Console.WriteLine(OddCount(a));
System.Console.Write("Zeros : ");
Console.WriteLine(ZeroCount(a));
System.Console.Write("Digits : ");
Console.WriteLine(DigitCount(a));
System.Console.Write("Min : ");
Console.WriteLine(MinDigit(a));
System.Console.Write("Max : ");
Console.WriteLine(MaxDigit(a));
System.Console.Write("Sum of Digits : ");
Console.WriteLine(SumDigit(a));

