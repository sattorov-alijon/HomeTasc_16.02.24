int n=Convert.ToInt32(Console.ReadLine());
int []arr=new int[n];
for (int i = 0; i < n; i++)
{
arr[i]=Convert.ToInt32(Console.ReadLine());
}
// Array.Sort(arr);
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (arr[i]==arr[j] && i!=j)
        {
            System.Console.Write(arr[i]+" ");
        }
        
    }
}