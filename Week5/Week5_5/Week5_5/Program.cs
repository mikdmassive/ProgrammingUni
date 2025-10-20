
float AddTwoLowestValues(List<float> numbers)
{
   float lowest1 = FindLowestValue(numbers);
   numbers.Remove(lowest1);
   float lowest2 = FindLowestValue(numbers);
    return lowest1 +lowest2;
}
float FindLowestValue(List<float> numbers)
{
    float lowest = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        float num = numbers[i];
        if (i == 0)
        {
            lowest = num;
        }
        else
        {
            if (lowest > num)
            {
                lowest = num;
            }
        }
    }
    return lowest;
    
}
//main
List<float> numbers = new List<float>() { 1.0f, 5.0f, 3.0f, 3.0f, 7.0f };
Console.WriteLine($"The sum of 2 lowest values is {AddTwoLowestValues(numbers)}");