using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murderparty
{
    class Decsions
    {
        //James Introduction
        static string Line;
        Murder_PartyStory MJames = new Murder_PartyStory();
        static bool choice; // true = good , false = bad choices
        public int choiceIndex;
        public void JamesIntro()
        {

            //Decide how you initially react to James
            #region James Introduction
            choiceIndex = 0;
            choice = false;
            Line = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("What do you decide? :");
            Console.WriteLine("");
            Console.WriteLine("1.Greet");
            Console.WriteLine("2.Ignore");
            Line = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch(Line)
            {
                case "1":
                    Console.WriteLine("");
                    choice = true;
                    choiceIndex = 1;
                    MJames.MeetingJames(1);
                    break;                   
                    case "2":
                 
                    choice = false;
                    choiceIndex = 2;
                    MJames.MeetingJames(2);
                    break;
                default:
                    Console.WriteLine("Please select 1/2");
                    break;
                    
            }

        
            #endregion
        }
   
        #region
        public void Body()
        {
            Console.WriteLine(""); 
        }
        #endregion
    }
}
