using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Murderparty
{
    class Students
    {

        public string CCh = "CaptainPhilip"; //captain Character
        public string RC = "Rebecca"; //  Respected Student Governing body Member 
        public string KC = "James"; //Killer Character
        public string JC = "John"; //James friend
        public string You = "You"; //Your Character
        public string Line = "";
        static string _OffierName = "";
        public void speakers(string _charName, string _text, bool _showName)
        {
            if (_charName == CCh)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (_charName == RC)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (_charName == KC)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            else if (_charName == JC)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }

            if (_showName)
            {
                Console.WriteLine(_charName + ':');
                Console.WriteLine();
            }
            // used to build sentences word for word instead of displaying static sentences
            for (int i = 0; i < _text.Length; i++)
            {
                Console.Write(_text[i]);
                if (_text[i] == ' ')
                {
                    Thread.Sleep(100);
                }
                else
                {
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        //Get varibale names from first form
        public static string Officer
        {
            get
            {
                return _OffierName;
            }
            set
            {
                _OffierName = value;
            }
        }
        public void GradeReps(int val)
        {
            if ((val >1)&&(val<3))
            {
                Console.WriteLine();
                Console.WriteLine("Narrator: All the students reps, arrive at the gym");
                Console.WriteLine();
                speakers(RC, "Another questioning? Some good, this will do...yay", true);
                Console.WriteLine();
                Console.WriteLine("Rebecca's Friends: Yeah, we need to get out of this place before one of us is forced to... ");
                Console.WriteLine();
                Console.WriteLine("Joseph: Students if you will... quiet down please. Officer " + _OffierName +" wants to talk to you guys");
                Console.WriteLine();
                speakers(You, "Thank you mrs Joseph...uhm now to cut to the chase. This morning we found the body of one, Morgan Garnely in the bathroom stalls of this very gym", true);
                Console.WriteLine();
                speakers(JC, "James dude tell him...I, for one would like to see my 21st birthday", true);
                Console.WriteLine();
                speakers(KC, "You know that this, is way over both our heads, no one can save anyone", true);
                Console.WriteLine();
                speakers(You, "Young man, if you have information that can help us in anyway, please share with us as every piece of information will help us catch the personel responsible", true);
                Console.WriteLine();
                speakers(RC, "...This is stupid... Officer, I have information. The killer is one of us", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: The gym went silent");
                Console.WriteLine();
                speakers(You, "Young lady you do realise, the position you're, putting yourselves under right?", true);
                Console.WriteLine();
                speakers(KC, "What is she doing? that wasn't the plan", true);
                Console.WriteLine();
                speakers(JC, "If only, I could marry that girl right now.", true);
                Console.WriteLine();
                speakers(KC, "Why?", true);
                Console.WriteLine();
                speakers(JC, "Dont you realise, what she is doing?", true);
                Console.WriteLine();
                speakers(JC, "Putting the blame on us, protetcs us, in the sense that we will have police survuilence, all the time boi!", true);
                Console.WriteLine();
                speakers(KC, "Ive got to hand it to her, she played her cards well... nice Rebecca", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: Yes, you are fresh out of the academy, but you suspect something is wrong... no student would be willing compromise their future as easily as that");
                Console.WriteLine();
                Console.WriteLine("Narrator: Not to mention, not a single person in the crowd was worried, in fact they all seemed rather joyous");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Line = "";
                Console.WriteLine("What do you decide?");
                Console.WriteLine("1.Confront students and demand they stop joking around?");
                Console.WriteLine("2. Speak to Rebecca alone after the speech?");
                Console.ForegroundColor = ConsoleColor.White;
                Line = Console.ReadLine();
                switch(Line)
                {
                    case "1":
                        Console.WriteLine();
                        speakers(You, "I would really appreciate it, if you all, left your sense of humour outside", true);
                        Console.WriteLine();
                        speakers(You, "From my position, you guys are lying and I guess I can investigate why, but I dont have that time people are dying", true);
                        Console.WriteLine();
                        speakers(You, "Heres whats going to happen... These men will stay behind and take all your statements and you will all be taken in for questioning... maybe spend a night in prison, until I can prove that you are all innocent", true);
                        Console.WriteLine();
                        speakers(You, "Jail isnt a fun place...You might all regret it", true);
                        Console.WriteLine();
                        Console.WriteLine("Female Student: I dont want to go to prison! James, he..uhm... knows everything so does Mrs Joseph...");
                        Console.WriteLine();
                        speakers(RC, "Stupid girl! Sorry officer she doesnt know what she is saying", true);
                        Console.WriteLine();
                        speakers(You, "I believe she does... let her speak", true);
                        Console.WriteLine();
                        speakers(RC, "You will put us all in danger... dont say anything", true);
                        Console.WriteLine();
                        Console.WriteLine("Female Student: Im tired of being silent! Im not as strong as you");
                        Console.WriteLine();
                        speakers(RC, "...Then learn how to be ", true);
                        Console.WriteLine();
                        Console.WriteLine("Narrator: rebecca walked over to her and smacked her, on her face!");
                        Console.WriteLine();
                        speakers(You, "Ey, ey you miss fisty fists... wait for me outside", true);
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You tell one of your friends to take to the stage and control the crowd as you deal with Mrs Aggro");
                        Console.WriteLine();
                        speakers(You, "Whats your problem? She was just...", true);
                        Console.WriteLine();
                        speakers(RC, "You think you can solve this? More... like you, in your position died, than i can count and i lost more friends than i can count as well", true);
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Rebecca starts crying");
                        Console.WriteLine();
                        speakers(You, "If it hurts so much dont hold it in. You are strong, I can tell, everyone looks up to you and trusts your judgement", true);
                        Console.WriteLine();
                        speakers(RC, "What of it.. if i cant save my friends", true);
                        Console.WriteLine();
                        speakers(You, "Not alone you cant... im not promising I wont fail, but i will, damn well make sure i bring down the culprits before I do", true);
                        Console.WriteLine();
                        speakers(You, "Do you know anything?", true);
                        Console.WriteLine();
                        speakers(RC, "Everything", true);
                        Console.WriteLine();
                        speakers(You, "Tell me... we wont know until we try... I may be another statistic, but I will bust this case wide open before then", true);
                        TrustingStudents(1);

                        break;

                    case "2":
                        Console.WriteLine("Narrator: The speech was a success... you were able to isolate Rebecca, James and John as potential witnesses and also quite possibly, solve the murder mystery as well");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You had asked to meet, Rebecca alone after the speech, she is waiting in the corridors ");
                        Console.WriteLine();
                        speakers(You, "Let me not waste your time... you smart enough to know why I, isolated you. Look you children have been clealy left to deal with this alone, I can help you", true);
                        Console.WriteLine();
                        speakers(RC, "Let me stop you, right there.. you are right, but just the first bit. The second part you clearly have no idea how deep this goes", true);
                        Console.WriteLine();
                        speakers(You, "Tell me then", true);
                        Console.WriteLine();
                        speakers(RC, "Ask yourself, why only recruits like yourself are the only ones who work these cases? Why no one expereinced", true);
                        Console.WriteLine();
                        speakers(RC, "There is no justice in this city Mr...If you have an answer for me you will find me on the rooftop at 15:00 this afternoon ", true);
                        Console.WriteLine();
                        TrustingStudents(1);
             
                        
                  
                     

                        break;
                }


            }

            if ((val > 2) &&(val < 4))
            {

                Console.WriteLine();
                speakers(You, "~After all thats happened,is there really a need to go speak, to the children if Mrs Josephs, could be the real culprit? ~", true);
                Console.WriteLine();

                speakers(You, "I guess I have to do things by the books , but before I go talk to the childen. I really need to talk to Mrs Joseph, she is the most suspicious one here", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You return to the reception and find that Mrs Josephs is gone? but Captain Philips is still there ");
                Console.WriteLine();
                speakers(CCh, "~Everything ok cadet? ~", true);
                Console.WriteLine();
                speakers(You, "Just had a few questions for Mrs Joseph... that i thought could wait but surpise... surprise I dont think they can, haha", true);
                Console.WriteLine();
                speakers(CCh, "She had to run a little errand for me", true);
                Console.WriteLine();
                speakers(You, "Oh? Do you know, when she will be back?", true);
                Console.WriteLine();
                speakers(CCh, "Not sure... you know my errands tend to get out of hand... anything I can do for you maybe?", true);
                Console.WriteLine();
                speakers(CCh, "Cadet word of advice... be careful who you talk to", true);
                Console.WriteLine();
                speakers(You, "~Was that, just a threat? or warning... just cant tell yet~", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You leave behind a message only Mrs Josephs, with the information she shared, could only possibly know");
                Console.WriteLine();
                TrustingStudents(1);
            }

           

        }

        public void TrustingStudents(int val)
        {
            if (val ==1)
            {
                Console.WriteLine();
                Console.WriteLine("Narrator: You meet Rebecca on the roof that afternoon. To your surprise James is with her but not John ");
                Console.WriteLine();
                speakers(You, "James ... Why are you here", true);
                Console.WriteLine();
                speakers(KC, "I figured that I might as well comply... kinda tired that my friends keep dying all the time", true);
                Console.WriteLine();
                speakers(You, "Go on", true);
                Console.WriteLine();
                speakers(KC, "firstly I would like to apologise for coming off, as if, I was hiding something...well I was... thing is... this city", true);
                Console.WriteLine();
                speakers(RC, "Oh god... are you going to spit it out anytime? fine I will say it", true);
                Console.WriteLine();
                speakers(RC, "James and Morgan were brothers", true);
                Console.WriteLine();
                speakers(You, "Sorry is that supposed to mean something?", true);
                Console.WriteLine();
                speakers(RC, "Boy, this one is thick...", true);
                Console.WriteLine();
                speakers(RC, "Mrs Josephs is their mother.", true);
                Console.WriteLine();
                speakers(You, "Wait whaaat!!", true);
                Console.WriteLine();
                speakers(You, "Could that mean you are being targeted? ", true);
                Console.WriteLine();
                speakers(KC, "Thats not all, my father is in prison and runs a criminal organisation, with the help of Captain Phillip", true);
                Console.WriteLine();
                speakers(You, "Come again?", true);
                Console.WriteLine();
                speakers(RC, "Your captin hires recruits, for these fake investigations, because they are the least to suspect what he really is up to", true);
                Console.WriteLine();
                speakers(You, "No, not possible I need evidence", true);
                Console.WriteLine();
                speakers(RC, "Do you have an answer, to the question I asked you? If it has not crossed your mind yet, then you are doomed to repeat the cycle of the 41", true);
                Console.WriteLine();
                speakers(KC, "You wanted answers, here you have it... you want proof? Vist my dad, but know if you do, you will die ", true);


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Line = "";
                Console.WriteLine("What do you decide?");
                Console.WriteLine("1.Go and meet James father?");
                Console.WriteLine("2. Trust James and Rebecca?");
                Console.ForegroundColor = ConsoleColor.White;
                Line = Console.ReadLine();
                if (Line == "1")
                {
                    Console.WriteLine("Narrator: You arrive at the Jubilee City Maximum security Facility, the guards direct you to the cell of Craig Ornilia ");
                    Console.WriteLine();
                    speakers(You, "You must be Craig... I have a few questions for you", true);
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: No you just have 1. ");
                    Console.WriteLine();
                    speakers(You, "~Whats with this guy... he is so carefree, I think coming here was a mistake~", true);
                    Console.WriteLine();
                    speakers(You, "You kmow what, I must have forgotten something in the oven", true);
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: Nonsense ...sit. How is my son treating you? He does need a firm hand, here and there but believe me he means well");
                    Console.WriteLine();
                    speakers(You, "I neeed a trump~ card~ at this rate, I wont make it to the door alive. ", true);
                    Console.WriteLine();
                    speakers(You, "You know your wife is a good woman", true);
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: What did you say you bastard? Do you know who I am? ");
                    Console.WriteLine();
                    speakers(You, "On the contrary yes I do, do you know who I am sir? I know everything about you, I can bring down your empire at any moments notice", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Craig snaps his fingers and police guards are at his cell ready to take his orders  ");
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: I dont know who you think you are but i will eliminate you ");
                    Console.WriteLine();
                    speakers(You, "No you wont", true);
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: take him out back and rough him up a bit ");
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Craig notices you hardly flinch, when you are being man-handled. ");
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: Wait... let him speak... go on you have 5 sec ");
                    Console.WriteLine();
                    speakers(You, "Your whole operation hinges on Captain Phillips... he keeps higher ups, from interfering with city in exchange for money my guess... now if a certain, tape were to get in the wrong higher ups hands, then you are finished", true);
                    Console.WriteLine();
                    speakers(You, "My proposal, I burn the tape for my safe passage out the city", true);
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: You bluffing ");
                    Console.WriteLine();
                    speakers(You, "Try me... your wife surprisingly, talks a lot when she is drunk", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Luckily Craig and Joseph, were not on speaking terms and it was, entirely probable, for Mrs Joseph to spill some secrets");
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: I want, to see you burn it");
                    Console.WriteLine();
                    speakers(You, "Yeah right... the minute you see that, you kill me...If I die, the tape will be deliverd by Isaac a trusty old friend of mine", true);
                    Console.WriteLine();
                    Console.WriteLine("Craig Ornilia: Dammit Joseph, you and your big mouth... let him go boys");
                    Console.WriteLine();
                    speakers(You, "Oh and dont follow me ", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Craig laughs because you went head to head with him and won. You ronduivre with the kids and mrs Joseph my the docks ");
                    Console.WriteLine();
                    speakers(KC, "Lets go we have been waiting 45 min, he is dead... my dad is an evil man ", true);
                    Console.WriteLine();
                    speakers(RC, "5 more min he will be here... I saw something in his eyes... a will to live ", true);
                    Console.WriteLine();
                    speakers(You, "Yo, have you guys been waiting long? ", true);
                    Console.WriteLine();
                    speakers(KC, "How did you make it out? ", true);
                    Console.WriteLine();
                    speakers(You, "Your father is a scary man... I lied.. well more like a bluff ", true);
                    Console.WriteLine();
                    speakers(You, "Long story short...im here, lets go and now I have all the evidence, i need to bring, justice to all your friends ", true);
                    Console.WriteLine();
                    speakers(RC, "What? how did you do that? ", true);
                    Console.WriteLine();
                    speakers(You, "I hooked up, a small camera to my jacket and I was able to, get all of it on tape ", true);
                    Console.WriteLine();
                    speakers(You, "I just need to show the higher ups, this and they will do the rest ", true);
                    Console.WriteLine();
                    speakers(RC, "Thank you so much ", true);
                    Console.WriteLine();
                    speakers(KC, "You are easily, the dummest man in the world", true);
                    Console.WriteLine();
                    Console.WriteLine("Josephs: You have no idea, how much I kept in all these years... thank you so much");
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Everyone hugs you");
                    Console.WriteLine("Narrator: The end");

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                else if (Line == "2")
                {
                    Console.WriteLine();
                    speakers(You, "I have had my suspicions, about this case .. for now I will trust you", true);
                    Console.WriteLine();
                    speakers(You, "What now?", true);
                    Console.WriteLine();
                    speakers(KC, "My dad, had my brother killed, because he didnt comply with his rules... my dad uses students, in the city as traffickers of drugs and jewels ", true);
                    Console.WriteLine();
                    speakers(You, "What? We cant, let him...", true);
                    Console.WriteLine();
                    speakers(KC, "With all due respect, you are 1 man. My dad has the police on his payroll and most of the town in his sleeves", true);
                    Console.WriteLine();
                    speakers(KC, "There is only...one way, out of this mess... we need to leave the city", true);
                    Console.WriteLine();
                    speakers(You, "How are you going to do that? ", true);
                    Console.WriteLine();
                    speakers(RC, "A simple plan, if everything works well... to be honest the other students and I have been working, on it for 6 months", true);
                    Console.WriteLine();
                    speakers(RC, "James' father, has Captain Philips monitor James and his mother... he always comes to college and just, sits there watching Mrs Josephs", true);
                    Console.WriteLine();
                    speakers(You, "How are you we going to make him leave? ", true);
                    Console.WriteLine();
                    speakers(RC, "Thats where you come in being a cadet... you lure him away and mrs Joseh would be able to make it out ", true);
                    Console.WriteLine();
                    speakers(You, "Thats acutally crazy enough to work", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator: The plan is put into play, it barely works, but the kids, just did enough, to ensure its success ");
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Rebecca was run over, by a car that Captain Philips drove. ");
                    Console.WriteLine();
                    Console.WriteLine("Narrator: Some students were lost in the process but James, mrs Josephs and You lived to see another day!");
                    Console.WriteLine();
                    Console.WriteLine("Narrator: The end");
                    Console.WriteLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                else
                {
                    Console.WriteLine("Narrator: enter only 1 or 2");
                }

            }
        }

        public void SuspectingCaptainPhilips(int val)
        {
            if (val==1)
            {

            }
        }
    }
}
