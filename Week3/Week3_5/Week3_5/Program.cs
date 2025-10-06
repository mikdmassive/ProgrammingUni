string TruncateStringIfNecessary (string msg,int len)
{
    int stringlen = msg.Length;
    if(len >= 3)
    {
        if (stringlen > len)
        {
            return msg.Substring(0, len - 3) + "...";
        }
        else
        {
            return msg;
        }
    }
   else return "ERROR STRING LENGTH LESS THAN 3";
}

 //PROMPTS
 string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
int IntPrompt(string message)
{
    return Convert.ToInt32(Prompt(message));
}
void PromptTruncateStringIfNecessary()
{
    Console.WriteLine(TruncateStringIfNecessary(Prompt("Enter a message"),IntPrompt("Enter the max length")));
}
//MAIN
PromptTruncateStringIfNecessary();