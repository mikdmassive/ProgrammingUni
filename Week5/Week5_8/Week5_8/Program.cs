string ValidateAndReturnPhoneNumber(string phoneNumber)
{
    string validmessage = "";
    bool validchars = true;
    for (int i = 0; i < phoneNumber.Length; i++)
    {
        if (!char.IsDigit(phoneNumber[i]))
        {
            validchars = false;
        }
    }
    if (validchars)
    {
        switch (phoneNumber.Length)
        {
            case > 11:
                validmessage = "The phone number is too long.";
                break;
            case < 11:
                validmessage = "The phone number is too short.";
                break;
            default:
                validmessage = "The phone number is valid: " + CreatePhoneNumber(phoneNumber);
                break;
        }
    }
    else
    {
        validmessage = "The phone number does not contain only numbers";
    }
    return validmessage;
}
string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
string CreatePhoneNumber(string phoneNumber)
{
    return $"{phoneNumber.Substring(0, 5)}-{phoneNumber.Substring(5, 3)}-{phoneNumber.Substring(8, 3)}";
}
//main
Console.WriteLine(ValidateAndReturnPhoneNumber(Prompt("Enter a phone number (11 characters):")));