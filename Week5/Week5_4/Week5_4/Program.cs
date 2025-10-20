List<float> Blur (List<float> numbers)
{
    List<float> BluredNumbers = new List<float>();
    for (int i = 0;i<numbers.Count;i++)
    {
       float number = numbers[i];
       int prevIndex = i - 1;
       int nextIndex = i + 1;
       if (prevIndex < 0)
       { 
            BluredNumbers.Add((number + numbers[nextIndex]) / 2);
       }
       else if (nextIndex > numbers.Count-1)
       {
           BluredNumbers.Add((number + numbers[prevIndex]) / 2);
       }
        else
        {
            BluredNumbers.Add((number + numbers[prevIndex] + numbers[nextIndex]) / 3);
        }
    }
    return BluredNumbers;
}
//main
List<float> numbers = new List<float>() { 1.0f,5.0f,3.0f,3.0f,7.0f};
Console.Write($"The blured list is:");
foreach (float number in Blur(numbers))
{
    Console.Write($"{number} ");
}