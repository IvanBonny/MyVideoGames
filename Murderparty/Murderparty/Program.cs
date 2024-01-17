using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Murderparty
{
    class Program
    {
        static string path = @"./Save.txt";
        static public string detective = "";
        static Murder_PartyStory story = new Murder_PartyStory();
        static Forensics foren = new Forensics();
        static Decsions myDecisions = new Decsions();
        static YourStats chars = new YourStats();
        static Students stut = new Students();
        static bool gameOver = false; 
        static bool Loaded = false;
        static string LNLine = "";
        static Random myRand = new Random();
        static string CurrrentDecision = "";
        #region  JAmes Introduction
        public string[] JamesIntro = { "Greet back", "Dont greet back" };
        #endregion
        #region
   
        static string[] Decisions;
        #endregion
        static void Main(string[] args)

        {
            LNLine = "";
            gameOver = false;
            Introduction();
            #region save and load 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please note to progress to next line in the story you need to press (Enter)-key after every command");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            
                Loaded = false;
                GetName();
                Console.WriteLine("");
                Console.WriteLine("Wellcome cadet: {0}", detective);
                Console.WriteLine("");
                story.Intro();
            
            #endregion

            LNLine = "";
          
            startGame();
        }

        private static void Introduction()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                Murder Party");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
        }

        private static void startGame()
        {
            gameOver = false;
            LNLine = "";
            while (gameOver ==false)
            {
                
                Console.WriteLine("");
                
                myDecisions.JamesIntro();

        
                Console.WriteLine();

                LNLine = Console.ReadLine().ToUpper();
                if (LNLine=="quit")
                {
                    gameOver = true;
                    Environment.Exit(0);
                }
               
            }
        }

      
        static void GetName()
        {
            bool ConfBool = false;
            string LNLine = "";

            do
            {
                Console.WriteLine("What is your name cadet?");
                string Officer= Console.ReadLine();
                Murder_PartyStory.Officer = Officer;
                Forensics.Officer = Officer;
                Students.Officer = Officer;
                ConfBool = true;


                //detective = Console.ReadLine();
                //Console.WriteLine("Press (C)-key followed by (Enter)-key to continue ");
                //LNLine = Console.ReadLine().ToUpper();
                //if (LNLine == "C")
                //{
                  
                //}
            } while (!ConfBool);
                    //WriteSave();
            
        }

        //private static void WriteSave()
        //{
        //    File.WriteAllText(path, string.Empty);
        //    using (StreamWriter sw = File.AppendText(path))
        //    {
        //        sw.WriteLine(detective);
        //        if (!Loaded)
        //        {
        //            mychar.Health = 12;
        //            mychar.XP = 0;
        //            mychar.level = 1;
                   
        //        }

        //        sw.WriteLine(mychar.Health);
        //        sw.WriteLine(mychar.XP);
        //        sw.WriteLine(mychar.level);
        //        //sw.WriteLine(mychar.CurrentLocation);
        //    }
        //}
        //static void LoadSave()
        //{
        //    string line;
        //    int count = 0;
        //    try
        //    {
        //        StreamReader sr = new StreamReader(path);
        //        line = sr.ReadLine();
        //        detective = line;
        //        while (line != null)
        //        {
        //            count++;
        //            line = sr.ReadLine();
        //            switch (count)
        //            {
        //                case 1:
        //                    mychar.Health = int.Parse(line);
        //                    break;
        //                case 2:
        //                    mychar.XP = int.Parse(line);
        //                    break;
        //                case 3:
        //                    mychar.level = int.Parse(line);
        //                    break;
        //                //case 4:
        //                //    CurrentRoom = line;
        //                //    break;
        //            }
        //        }
        //        sr.Close();
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Game Succfully Loaded");
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Welcome back {0}", detective);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //    }
        }



    }
