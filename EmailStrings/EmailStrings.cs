using System;

public class EmailStrings
{
    public static void Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        char[] spaces = { '@', '.' };
        string[] elements;
        Console.WriteLine("Enter string, enter to exit.  ");
        string email = iw.getString("email: ");
        while (!email.Equals(""))
        {
            elements = email.Split(spaces);
            foreach (string ele in elements)
            {
                Console.WriteLine(ele);
            }
            email = iw.getString("email: ");
        }
    }
}