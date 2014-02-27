using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    string username;
    string password;
   CommunityAssistEntities2 ca= new CommunityAssistEntities2();
   
    public string passcode;

    public LoginClass(string usr, string pass)
	{
        username = usr;
        password = pass;
       
    }
     public int ValidateLogin()
     {
        //personkey to return initally 0
        int pk = 0;

        //LINQ to extract personkey, passcode and hash from database
        var log = from r in ca.People
                  where r.PersonUsername == username
                  && r.PersonPlainPassword == password
                  select new { r.PersonKey, r.Personpasskey, r.PersonUserPassword};
        //variables to store results from database
        int pCode=0;
        Byte[] pWord=null;
        int personKey=0;

        //loop throug results and assign values from var log
        //to our variables
        foreach (var p in log)
        {
            personKey = (int)p.PersonKey;
            pCode = (int)p.Personpasskey;
            pWord = (Byte[])p.PersonUserPassword;
        }
        //initial the PassWordHash
        PasswordHash ph = new PasswordHash();
        //send password and passcode to be hashed
        Byte[] newHash = ph.HashIt(password,pCode.ToString());
     

        if (pWord.SequenceEqual(newHash))
        {
            pk = personKey;
        }
        return pk;
    }
    

    private string ConvertBytes(Byte[] encodedBytes)
    {
        //bitconverter is a built in method
        //to convert byte arrays to strings
        string x = BitConverter.ToString(encodedBytes);
        //you need to use a regular expression for the conversion
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        //I add an OX before the string as marker
        //of the number system used
        x = rgx.Replace(x, "");
        return "0x" + x;
       
    }
}


