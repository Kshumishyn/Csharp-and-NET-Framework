using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9lab1
{
    class Driver
    {
        static void Main(string[] args)
        {
            // Creates new Objects
            Email myEmail = new Email();
            Email myOtherEmail = new Email();

            File myFile = new File();
            File myOtherFile = new File();

            // Subtle
            myEmail.SetSender("Kshumishyn@gmail.com");
            myEmail.SetRecipient("LewisK@Miracosta.edu");
            myEmail.SetTitle("Hey");
            myEmail.SetText("You should teach advanced C++ in Spring and save my sanity.");

            // Prints toString
            Console.WriteLine("Contains Keyword: " + ContainsKeyword(myEmail, "teach advanced C++"));

            // Prevents Console from closing
            Console.ReadLine();
        }

        // Keyword Test Method
        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }
            return false;
        }

    }
}
