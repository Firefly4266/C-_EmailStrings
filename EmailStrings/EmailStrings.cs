using System;

public class EmailStrings
{
    public static void Main(string[] args)
    {
        InputWrapper iw = new InputWrapper();
        char[] spaces = { '@', '.' };
        Console.WriteLine("Enter string, enter to exit.  ");
        string email = iw.getString("email: ");
        while (!email.Equals(""))
        {
            int index = email.IndexOf('@', 0);
            if(index != -1)
            {
                string user = email.Substring(0, index);
                int start = index + 1;
                index = email.IndexOf('.', index);
                if(index != -1)
                {
                    string domain = email.Substring(start, index - start);
                    string suffix = email.Substring(index + 1);
                    if (suffix == "com" || suffix == "org" || suffix == "edu")
                    {
                        if(isAlphaNum(user) && isAlphaNum(domain))
                        {
                            Console.WriteLine("user = {0}, \n domain = {1}, \n suffix = {2}.", user, domain, suffix);                      
                        }
                        else
                            Console.WriteLine("user and domaim must be alpha numeric");
                    }
                    else
                        Console.WriteLine("{0}, {1}, and {2} are the only leagal suffixes.", "com", "org", "edu" );
                }
                else
                    Console.WriteLine("Missing '.', address invalid.");
            }
            else
                Console.WriteLine("Missing '@', address invalid.");
        }
        Console.WriteLine("Enter string, enter to exit.  ");
        email = iw.getString("email: ");
    }
   

    private static bool isAlphaNum(String domain)
    {
        Regex testPattern = new RegularExpression("^[a-zA-Z0-9]*$");
        return domain.IsMatch(testPattern);
    }
}
























            //elements = email.Split(spaces);
            //foreach (string ele in elements)
            //{
            //    Console.WriteLine(ele);
            //}