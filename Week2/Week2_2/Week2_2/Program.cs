int getnumber(string txt)
{
    Console.Write($"Enter {txt} number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number1 = getnumber("first");
int number2 = getnumber("second");
int number3 = getnumber("third");
List <int> numlist = new List<int>() { number1, number2, number3 };

Console.WriteLine("====");

List<int> evens = new List<int>();
List<int> odds = new List<int>();
List<int> over10s = new List<int>();

void writelist(string startermsg,List<int> list)
{
    Console.Write(startermsg);
    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i]);
        if (i != list.Count - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }

    }
    Console.WriteLine();
}

for (int i = 0; i < numlist.Count; i++)
{
    int num = numlist[i];
    if (num > 10)
    {
        over10s.Add(num);
    }
    if (num % 2 == 0)
    {
        evens.Add(num);
    }
    else
    {
        odds.Add(num);
    }
}
writelist("Even numbers: ", evens);
writelist("Odd numbers: ", odds);
writelist("Numbers over 10: ", over10s);