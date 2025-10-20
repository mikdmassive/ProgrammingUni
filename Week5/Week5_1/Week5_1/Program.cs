//functions
float LargestInList(List<float> numbers)
{
    float largest = 0f;
    foreach (float number in numbers)
    {
        if (number == numbers[0])
        {
            largest = number;
        }
        else if (number > largest)
        {
            largest = number;
        }
    }
    return largest;
}

//main
List <float> numbers = new List<float> () { 3.5f, 7.2f, 1.8f, 9.4f, 5.6f };
Console.WriteLine($"The largest number in the list is: { LargestInList(numbers)}");