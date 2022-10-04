int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        if (b > c)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
        }
    }
    else 
    {
        Console.WriteLine(c);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
  }
else if (a>c)
{
    Console.WriteLine(b);
    Console.WriteLine(a);
    Console.WriteLine(c);
}
else if (b>c)
{
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(c);
    Console.WriteLine(b);
    Console.WriteLine(a);
}
