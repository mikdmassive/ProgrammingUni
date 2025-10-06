string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

//LIST
List<string> Tasks = new List<string>() {"Wake up","Shower","Brush teeth","Eat breakfast","Go to lectures","Go home","Sleep"};

string WhatIsAfter(string task)
{
    string msg = "ERROR OCCURED";
    if (Tasks.Contains(task))
    {
        int newtaskIndex = Tasks.IndexOf(task)+1;
        if (newtaskIndex < Tasks.Count)
        {
            msg = Tasks[newtaskIndex];
        }
        else
        {
            msg = "There is no task after this one";
        }
    }
    else
    {
        msg = "Task not found";
    }
    return msg;
}
void PromptWhatIsAfter()
{
    Console.WriteLine(WhatIsAfter(Prompt("What task do you want to know the next task of?")));
}
while (true)
{
    PromptWhatIsAfter();
}