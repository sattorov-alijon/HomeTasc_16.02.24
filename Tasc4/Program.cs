﻿int n=Convert.ToInt32(Console.ReadLine());
int []arr=new int[n];
for (int i = 0; i < n; i++)
{
arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i+=2)
{
System.Console.Write(arr[i]+" ");
}
