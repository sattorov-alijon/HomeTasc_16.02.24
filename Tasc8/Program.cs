// int a=Convert.ToInt32(Console.ReadLine());
// char x=Convert.ToChar(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());

// if (x=='+')
// {
//     System.Console.WriteLine(a+"+"+b+"="+(a+b));
// }
// else if (x=='-')
// {
//     System.Console.WriteLine(a+"-"+b+"="+(a-b));
// }
// else if (x=='*')
// {
//     System.Console.WriteLine(a+"*"+b+"="+(a*b));
// }
// else if (x=='/')
// {
//     System.Console.WriteLine(a+"/"+b+"="+(a/b));
// }


int Sum(int a, int b)
{
    return a+b;
}
int Subtract(int a, int b)
{
    return a-b;
}
int Multiplication(int a, int b)
{
    return a*b;
}
int Division(int a, int b)
{
    return a/b;
}
int a = Convert.ToInt32(Console.ReadLine());
Char c = Convert.ToChar(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(c=='+')
{
    System.Console.WriteLine(Sum(a,b));
}
if (c=='-')
{
    System.Console.WriteLine(Subtract(a,b));
}
if(c=='*')
{
    System.Console.WriteLine(Multiplication(a,b));
}
if(c=='/')
{
    System.Console.WriteLine(Division(a,b));
}