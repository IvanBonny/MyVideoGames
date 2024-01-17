using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Murderparty
{
    class Forensics
    {
        public string CCh = "CaptainPhilip"; //captain Character
        public string FS = "Issac"; // Forensic Specialist charcacter 
        public string KC = "James"; //Killer Character
        public string FSA = "Urarakachan"; //Forensic Specialist Character
        public string You = "You"; //Your Character
        Random teachas = new Random(); //Will Randomise Teachers assistents general introductions
        string[] assistT = new string[] {"Hi how may I assist you today","Hello welcome to Western High Villa","Get Lost... Im on my break","You too old to apply here...next","Lovely day we are having isnt it","Greetings", "To what do we owe this lovely visit officer", "My... you quite attractive would you like to take my statement?"};
        string[] BridgeMenAnalysis = new string[] { "Man to your left is the biggest: He is slighty taller than you but he isnt the leader","Man to your right: average body build, same height as you, could be the leader","Man in front: Average body build, taller than you,seems most likely to be leader","Man behind: Shorter than you, looks more to be in for the ride more than anything else"};
        Random bridgeMen = new Random();
        static YourStats CharStats = new YourStats();
        static Enemies EnemyStats = new Enemies();
        static bool choice; // true = good , false = bad choices
        public string Line = "";
        static string _OffierName = "";
        public void INeedHealingHospital (int val)
        {
            if (val==1)
            {
                #region forensics good
                speakers(FS, "We need to catch this sick bastard... cant have have you dying there is somone I would like you to meet", true);
                Console.WriteLine("");
                speakers(FS, "Well what are you waiting for lets catch ourselves a murderer shall we ", true);
                Console.WriteLine("");
                speakers(You, "And just who might that be", true);
                Console.WriteLine("");
                speakers(FS, "A bunny never reveals his ears ", true);
                Console.WriteLine("");
                speakers(You, "Yes they do when they hop the world can clearly see them... maybe you mean a bunny never reveals its secrets?", true);
                Console.WriteLine("");
                speakers(FS, "Its a bunny it doesnt have secrets... Pretty sure it was ears", true);
                Console.WriteLine("");
                speakers(You, "I bet a certain holiday has something to say about that", true);
                Console.WriteLine("");
                speakers(FS, "News flash it isnt chocolate that they lay... believe me when I was 8 I...", true);
                Console.WriteLine("");
                speakers(You, "OK back to the case please... yuck", true);
                Console.WriteLine("");
                speakers(FS, "Lets go to the ambulance my team will finalise everything else and bring the body", true);
                Console.WriteLine("");
                Console.WriteLine("The Ambulance");
                Console.WriteLine("");
                speakers(FS, "Let me just call my assistant and let her know we need a lab ready", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator: Isaac is calling Urarakachan at I need healing hospital");
                Console.WriteLine("");
                speakers(FSA, "Yes hello", true);
                Console.WriteLine("");
                speakers(FS, "Hello Uraraka-san, uhm could you use the list I sent you last week to gather the people I specified...we have an operation to perform and I need a laboratory ready asap.", true);
                Console.WriteLine("");
                speakers(FSA, "Understood sir will get right to it... uhm the best time available would be 16:00 is that ok with you sir?", true);
                Console.WriteLine("");
                speakers(FS, "Perfect ready and waiting", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator: Isaac is hangs up");
                Console.WriteLine("");
                speakers(FS, "its now 14:18... if we leave now there is no traffic but when we get knowing Uraraka she wont finish until 10min before with task i have given her...what do you want to do till then?", true);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("What do you decide? :");
                Console.WriteLine("");
                Console.WriteLine("1. Go talk to james before you go?");
                Console.WriteLine("2. Go to Hospital?");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (Line == "1")
                {
                    Line = "";
                    Console.WriteLine("");
                    speakers(You, "I just want to ask James one last thing before we leave", true);
                    Console.WriteLine("");
                    speakers(FS, "Go on will give you a call when she is ready", true);
                    Console.WriteLine("");
                    Console.WriteLine("Narrator: You run back to James");
                    Console.WriteLine("");
                    speakers(You, "Thank god you still here, but what are you doing with that shovel?", true);
                    Console.WriteLine("");
                    speakers(You, "wait never mind I have an important question to ask you just let me catch my breath... phew", true);
                    Console.WriteLine("");
                    speakers(You, "Did morgan really die today?", true);
                    Console.WriteLine("");
                    speakers(KC, "pffft of course he did... why do you ask ?", true);
                    Console.WriteLine("");
                    speakers(You, "just a question... just wanted you to know that you can trust me", true);
                    Console.WriteLine("");
                    speakers(KC, "Yeah right... i havent heard that before", true);
                    Console.WriteLine("");
                    speakers(You, "look Mr whatever your name is Im just doing what Im told... I did nothing wrong", true);
                    Console.WriteLine("");
                    Console.WriteLine("Narrator: James realises what he just said and bite his tongue");
                    Console.WriteLine("");
                    speakers(You, "What do you mean by that exactly?", true);
                    Console.WriteLine("");
                    speakers(KC, "Nothing", true);
                    Console.WriteLine("");
                    Console.WriteLine("Narrator: James looks away...Your phone ring (Its Issac the prepping is finished");
                    Console.WriteLine("");
                    speakers(FS, "She is ready for us time to go", true);
                    Console.WriteLine("");
                    speakers(You, "Will be there in a sec", true);
                    Console.WriteLine("");
                    speakers(You, "Look son if you in any trouble I am here clearly you know something so I wont pry... so trust in the system to get justice for your friend", true);
                    Console.WriteLine("");
                    speakers(KC, "Mr if i were you I wouldnt make promises I couldnt keep... take care of yourself... ", true);
                    Console.WriteLine("");
                    speakers(You, "What does that mean? Are you threatening me?", true);
                    Console.WriteLine("");
                    speakers(KC, "Not at all... all im saying is  the system didnt do jack for my father so I dont expect anthing from it", true);
                    Console.WriteLine("");
                    speakers(You, "Fair enough then have faith in me", true);
                    Console.WriteLine("");
                    speakers(KC, "Dont you have someone else to annoy?", true);
                    Console.WriteLine("");
                    speakers(You, "haha I do well then I will be taking off", true);
                    Console.WriteLine("");
                    Console.WriteLine("Narrator: You make your way back to ambulance");
                    Console.WriteLine("");
                    speakers(You, "Now Im convinced more than ever that, that kid knows more than he leading on...forcing him wont make him give me what I want so I wonder if I should try being friends with him", true);
                    Console.WriteLine("");
                    Line = "";
                    Console.WriteLine("");
                    Console.WriteLine("What do you decide? :");
                    Console.WriteLine("");
                    Console.WriteLine("1. Be friends with him?");
                    Console.WriteLine("2. Ignore thought");
                    Line = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    if (Line=="1")
                    {
                        Line = "";
                        speakers(You, "Ok then its decided", true);
                        HospitalArrival(1);
                    
                    }
                    else if (Line == "2")
                    {
                        Line = "";
                        speakers(You, "Ok then its decided", true);
                        HospitalArrival(2);
                    }
                    else
                    {
                        Line = "";
                        Console.WriteLine("Please enter 1 or 2");
                    }

                }
                else if (Line == "2")
                {
                    Line = "";
                    HospitalArrival(1);
                }
                else
                {
                    Line = "";
                    Console.WriteLine("Please enter 1 or 2");
                }
             
                #endregion
            }
            else
            {
                #region forensics bad
                Console.WriteLine("Narrator: Jason is calling Issac the forensic specialist at I need healing hospital");
                Console.WriteLine();
                speakers(FS, "Hello Jason how can I be of assistance to you?", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Hello, Isaac uhm i have gathered the basic blood samples but an officer would like you to perform more in depth analysis of the sample that I will provide in the next 45 min");
                Console.WriteLine();
                speakers(FS, "Whats this a new cadet already ordering you around again?", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Could you prep a forensics lab so that when i get there we can just start the procedure");
                Console.WriteLine();
                speakers(FS, "My oh my, what knobs did he have to turn to make you so obedient I wonder", true);
                Console.WriteLine();
                Console.WriteLine("Jason: If you done with the theatrics could I have a serious answer now");
                Console.WriteLine();
                speakers(FS, "Anything for my wonchkin", true);
                Console.WriteLine();
                Console.WriteLine("Jason: So the lab?");
                Console.WriteLine();
                speakers(FS, "Yes I have a lab free but for 15:00, another unit is still busy in there", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Similar case?");
                Console.WriteLine();
                speakers(FS, "Yup...Someone really needs to do something about this crisis", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Maybe the schools meeting could help?");
                Console.WriteLine();
                speakers(FS, "Son... nothing good really comes from women meeting with each other", true);
                Console.WriteLine();
                Console.WriteLine("Jason: and people wonder why Im gay");
                Console.WriteLine();
                speakers(FS, "Speaking of which did the charm of the first time noobie get to you?", true);
                Console.WriteLine();
                Console.WriteLine("Jason: while he is good looking... no i not into him... Im just... you know worried about whats been happening to people who investigate these cases");
                Console.WriteLine();
                speakers(FS, "Thats the most adorible thing Ive ever heard", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Stop its not like that... you of all people should know what I mean");
                Console.WriteLine();
                speakers(FS, "While I do find your current predicament hillarious ... yes the seriousness of the matter at hand can not be taken lightly", true);
                Console.WriteLine();
                speakers(FS, "We must do all we can to protect your bae", true);
                Console.WriteLine();
                Console.WriteLine("Jason: The ambulance is taking off now... I have the body with me ETA 30 min with traffic. It is monday after all");
                Console.WriteLine();
                speakers(FS, "Is your man with you?", true);
                Console.WriteLine();
                Console.WriteLine("Jason: see you soon");
                Console.WriteLine();
                Console.WriteLine("Narrator: Isaac loves teasing people");
                Console.WriteLine();
                Console.WriteLine("Narrator: You call Jason");
                speakers(You, "Jason I will be investigating reports from other schools regarding this matter when you have the results send them to me asap ", true);
                Console.WriteLine();
                Console.WriteLine("Jason: I really dont think thats a good idea... This city is not safe and with whats been happening the past 3 months its not the ideal time to be the hero");
                Console.WriteLine();
                speakers(You, "Well you should have told me all that before I boarded this train... since I dont have a police vehicle yet I will be traveling by train ", true);
                Console.WriteLine();
                Console.WriteLine("Jason: rookie! rookie? are you there? get off the train! shit... shit this is bad");
                Console.WriteLine();
                Console.WriteLine("Narrator: Jason in his panick calls Captain Philips");
                Console.WriteLine();
                Console.WriteLine("Jason: Hello is this captain phillips speaking?");
                Console.WriteLine();
                speakers(CCh, "yes ... slow down son I can barely make out a word you are saying ", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Your rookie officer... the one who started today?");
                Console.WriteLine();
                speakers(CCh, "who cadet? ", true);
                Console.WriteLine();
                Console.WriteLine("Jason: Im not sure about his name but he left jubilee High in search of answers from nehibouring schools...hello you there sir...hello?");
                Console.WriteLine();
                Console.WriteLine("Narrator: Captain Phillips almost fainted ... his face grew pale and was reduced to a saying not again");
                Console.WriteLine();
                speakers(CCh, "Listern carefully time is of the essence do you know where he went?", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: Unfortunately not sir but he did board a train");
                Console.WriteLine();
                speakers(CCh, "~Its now 16:00 a train at this time would only have its last trip...thing charles think... uhm... Western Villa High! I got it his first stop is western Villa high. Its the closest location via train", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You have arrived at western Villa High");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Line = "";
                Console.WriteLine("What do you decide? :");
                Console.WriteLine("");
                Console.WriteLine("1. Go Investigate by talking to the vice principal of the school");
                Console.WriteLine("2. Call Captain Philips?");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (Line=="1")
                {

                    Line = "";
                    Console.WriteLine("Narrator: You have arrived at the schools office");
                    Console.WriteLine();
                    Console.WriteLine("secretary " + assistT[teachas.Next(assistT.Length)]);
                    Console.WriteLine();
                    speakers(You, "Is the principal in? ", true);
                    Console.WriteLine();
                    Console.WriteLine("Secretary: Unfortunately no ");
                    Console.WriteLine();
                    speakers(You, "Will she be back anytime soon? ", true);
                    Console.WriteLine();
                    Console.WriteLine("secretary:  no ");
                    Console.WriteLine();
                    speakers(You, "Can you tell me where she is? ", true);
                    Console.WriteLine();
                    Console.WriteLine("secretary:  no ");
                    Console.WriteLine();
                    speakers(You, "You are not going to tell me, what I want are you? ", true);
                    Console.WriteLine();
                    Console.WriteLine("Secretary:  depends who is asking ");
                    Console.WriteLine();
                    speakers(You, "Im asking ", true);
                    Console.WriteLine();
                    Console.WriteLine("Secretary:  you are? ");
                    Console.WriteLine();
                    speakers(You, "My name is cadet  "+ _OffierName+" I work for the police department and Im here, to ask about a recent sreak of student murders around the city... a little bird told me to come here for answers", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator: The secretary and office assistant exchanged glares and they both got up and left the room ");
                    Console.WriteLine();
                    speakers(You, "Where are you going? ", true);
                    Console.WriteLine();
                    Console.WriteLine("Secretary: home everytime someone investigates or helps people investigate this case innocent people die or go missing... friendly advice quit. You in too deep ");
                    Console.WriteLine();
                    speakers(You, "I will be back tomorow ", true);
                    Console.WriteLine();
                    Console.WriteLine("Dont bother, I'm quitting my job the last secretary, before me died aiding an officer so no thanks. ");
                    Console.WriteLine();
                    speakers(You, "~I guess i played my hand now i need to deal with what comes next~ speaking of which should probably drive by the hospital to chek those results", true);
                    HospitalArrival(3);

                }
                else if(Line=="2")
                {
                    Line = "";
                    speakers(You, "Hello Captain Phillips ", true);
                    Console.WriteLine();
                    speakers(CCh, "Cadet... Believe it or not cadet I was worried about you... looks like you still have some way to go until i call you by name", true);
                    Console.WriteLine();
                    speakers(CCh, "where are you? ", true);
                    Console.WriteLine();
                    speakers(You, "believe it or not I was at western high villa before i decided to give you a call", true);
                    Console.WriteLine();
                    speakers(CCh, "... Cadet listern to me... very carefully. Has the train departed ... ", true);
                    Console.WriteLine();
                    speakers(You, "yes sir ", true);
                    Console.WriteLine();
                    speakers(CCh, "shit its my fault I should have told you... im sorry cadet ", true);
                    Console.WriteLine();
                    speakers(You, "Told me what exactly? ", true);
                    Console.WriteLine();
                    speakers(CCh, "That your life was in danger the minute you took this case ", true);
                    Console.WriteLine();
                    speakers(You, "Come again? ", true);
                    Console.WriteLine();
                    speakers(CCh, "truth is I didnt tell you becasue curiosity killed the cat and that how i lost 41 cadets who worked this case? ", true);
                    Console.WriteLine();
                    speakers(You, "Why you telling me this now? ", true);
                    Console.WriteLine();
                    speakers(CCh, "The city you are in now is where most of them died... I'm so sorry cadet? ", true);
                    Console.WriteLine();
                    speakers(You, "Im not dead yet... what should I do? ", true);
                    Console.WriteLine();
                    speakers(CCh, "its almost dark word on the street will slowly creep out before you know it everyone will be after you ", true);
                    Console.WriteLine();
                    speakers(You, "how does that even work? ", true);
                    Console.WriteLine();
                    speakers(CCh, "Its something ive been looking into myself i dont know... but for now break contact and find shelter for evening call me in the morning. They probably tracing the call ", true);
                    Console.WriteLine();
                    speakers(You, "This is crazy all this for a 16 year old boy? ", true);
                    Console.WriteLine();
                    speakers(CCh, "Its goes much deeper than that... survive the night and I will tell you everyting tomorow?", true);
                    Console.WriteLine();
                    speakers(You, "Over and out", true);
                    SurvivingTheNight();
                }

                #endregion
            }
        }


        public void speakers(string _charName, string _text, bool _showName)
        {
            if (_charName == CCh)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (_charName == FS)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (_charName == KC)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            else if (_charName==FSA)
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

        public void HospitalArrival(int val)
            {
            #region Hospital Story
            if (val == 1)

            {
                Console.WriteLine();
                Console.WriteLine("Narrator: The van ride, to the hospital begins");
                Console.WriteLine();
                speakers(You, "Being friends with him, shouldnt be so bad... I will talk to him, when I return", true);
                Console.WriteLine();
                speakers(FS, "Why the glum face chum?... Cheer up, we finally going to catch that bastard!", true);
                Console.WriteLine();
                speakers(You, "Im not, worried by that, Im more concerned about that kid", true);
                Console.WriteLine();
                speakers(FS, "Oh whats his face... the emo, look alike, kid?", true);
                Console.WriteLine();
                speakers(You, "Yes cant help but think, that he is in trouble", true);
                Console.WriteLine();
                speakers(FS, "Oh?", true);
                Console.WriteLine();
                speakers(You, "Its like secretly, he is crying out for help and is waiting for someone to help him, get out of this rut", true);
                Console.WriteLine();
                speakers(FS, "Oh oh, someones getting too attached to the case... personal feelings aside. You need to look at this objectively or you not going to survive this case", true);
                Console.WriteLine();
                speakers(You, "I understand that, but his dad is supposedly in jail and he, hasnt had a father figure", true);
                Console.WriteLine();
                speakers(FS, "I see, so naturally you have taken it upon, yourself to show him the way...not everyone deserves your kindness, especially in this line of work", true);
                Console.WriteLine();
                speakers(FS, "Its normally the difference, between a bullet in your head and making it home to your family", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You arrive at the hospital ");
                Console.WriteLine();
                speakers(FSA, "They are ready and waiting for your instructions in the lab", true);
                Console.WriteLine();
                speakers(FS, "Quite the welcome party. This is Uraraka, Id like you to meet...", true);
                Console.WriteLine();
                speakers(FSA, "Sir not to be rude but I dont care and time is of the essence... if you wish to save the poor soul next to you then we should act quickly", true);
                Console.WriteLine();
                speakers(You, "I actually have a name.. you know...its...", true);
                Console.WriteLine();
                speakers(FSA, "Glad to meet you fresh meat, now if we could stop wasting time with the unessesary formalities and do what we came here for, I can go home and enjoy my evening early", true);
                Console.WriteLine();
                speakers(FS, "Yeesh woman..ok then. Tell the boys to unload the body", true);
                Console.WriteLine();
                speakers(You, "Whats her problem?", true);
                Console.WriteLine();
                speakers(FS, "Believe it or not she actually, dated a recruit much like yourself... and based on events so far you know how it went. This is her way of dealing with the pain. Be nice", true);
                Console.WriteLine();
                speakers(You, "Oh I...I, didnt realise... must be hard for her", true);
                Console.WriteLine();
                speakers(FS, "Oooh, I wouldnt say that in front of her... that is, if you want to keep all your teeth", true);
                Console.WriteLine();
                speakers(You, "Why?", true);
                Console.WriteLine();
                speakers(FS, "She hates it when people feel sorry for her.. dont believe me? ask Riley... when you see him inside. She broke his spine and punched the living shit out of him", true);
                Console.WriteLine();
                speakers(You, "Unless you going, to be gawking at my ass the whole day... I suggest you come inside", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You have entered, I need healing hospital and the body is being sent to the operation lab for forensic analysis ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Line = "";
                Console.WriteLine("");
                Console.WriteLine("You have a gut feeling telling you, to catch up to Uraraka and talk to her");
                Console.WriteLine("What do you decide? :");
                Console.WriteLine("");
                Console.WriteLine("1.Catch up to her?");
                Console.WriteLine("2.Ignore thought");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (Line=="1")
                {
                    speakers(You, "Hey ", true);
                    speakers(FSA, "What do you want? ", true);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Line = "";
                    Console.WriteLine("");
                    Console.WriteLine("What do you decide? :");
                    Console.WriteLine("");
                    Console.WriteLine("1.Ask her how her day has been?");
                    Console.WriteLine("2.Ask her to give you a chance");
                    Console.WriteLine("3.Ask her out on a date when this is all over ");
                    Console.WriteLine("4.Never mind");
                    Line = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (Line)
                    {
                        case "1":
                            Console.WriteLine("");
                            speakers(You, "How has your day been? ", true);
                            Console.WriteLine("");
                            speakers(FSA, "... ", true);
                            Console.WriteLine("");
                            speakers(You, "come on, you can do this... ", true);
                            Line = "";
                            Console.WriteLine("What do you decide? :");
                            Console.WriteLine("");
                            Console.WriteLine("1.Talk about weather?");
                            Console.WriteLine("2.Talk about sitation");
                            Line = Console.ReadLine();
                             if (Line=="1")
                            {
                                Console.WriteLine("");
                                speakers(You, "Lovely weather we are having..right?", true);
                                Console.WriteLine("");
                                speakers(FSA, "Listern here twerp fall back in line ", true);
                                Console.WriteLine("");
                                speakers(FS, "what the hell was that? ", true);
                                Console.WriteLine("");
                                speakers(You, "shut up ", true);

                                Laboratory();
                            }
                            else if (Line == "2")
                            {
                                Console.WriteLine("");
                                speakers(You, "So how does a beauty like you, end up in a place like this?", true);
                                Console.WriteLine("");
                                speakers(FSA, "A beauty like me, ends up in a place, like this when a psychotic killer, murderders, her brother and writes her a note on how to find pieces of his body in hidden locations in the city", true);
                                Console.WriteLine("");
                                speakers(FSA, "So if you have, quite finished I would like to move on with saving your sorry ass ", true);
                                Console.WriteLine("");
                                speakers(You, "I di..", true);
                                Console.WriteLine("");
                                Console.WriteLine("Narrator: You took a blow to the head...");
                                Console.WriteLine("");
                                speakers(FS, "Jesus what did you say?", true);
                                Console.WriteLine("");
                                speakers(You, "shut up ", true);

                                Laboratory();
                            }

                            break;

                        case "2":
                            Console.WriteLine("");
                            speakers(You, "look I know, Im not the best looking guy in the world, but I promise you, Im anything but crude... If i offended you at all, I am sorry ", true);
                            Console.WriteLine("");
                            speakers(FSA, "Its not you... I just need to come to terms, with what happened last time I got close to someone ", true);
                            Console.WriteLine("");
                            speakers(You, "I understand... just wanted you to know that, whenver you need to talk. Even though Im a stranger just shout ", true);
                            Console.WriteLine("");
                            speakers(FS, "Well, how did it go?", true);
                            Console.WriteLine("");
                            speakers(You, "I think... ok ", true);

                            Laboratory();
                            break;

                        case "3":
                            Console.WriteLine("");
                            speakers(You, "Hey, listern I was wondering if / when I survive this if you would would like to get some coffee  with me?", true);
                            Console.WriteLine("");
                            speakers(FSA, "... Lets keep you alive first", true);
                            Console.WriteLine("");
                            speakers(You, "Is that a yes? ", true);
                            Console.WriteLine("");
                            speakers(FS, "Wow, that was brave the last person who asked her out is six feet under ", true);
                            Console.WriteLine("");
                            speakers(You, "She killed him?... you could have told me, before i asked out a killer ", true);
                            Console.WriteLine("");
                            speakers(FS, "What? no I mean literally 6 floors below us ", true);
                            Console.WriteLine("");
                            speakers(You, "You said feet though? ", true);
                            Console.WriteLine("");
                            speakers(FS, "ag, did I? I always confuse the two haha ", true);

                            Laboratory();

                            break;

                        case "4":
                            Console.WriteLine("");
                            speakers(You, "Nothing much, was just wondering what the time was, haha... ", true);
                            Laboratory();
                            break;

                        default:

                            Console.WriteLine("Narrator: You need to enter only numbers 1-4");
                            break;
                    }
                }


            }
            else if (Line=="2")
            {
                Laboratory();
            }
            else if( val== 2)
            {

                Console.WriteLine();
                Console.WriteLine("Narrator:The van ride to the hospital begins ");
                Console.WriteLine();
                speakers(You, "~I hope i dont regret trying to be friends with him...shouldnt even be thinking about such. The brat will be fine~ ", true);
                Console.WriteLine();
                speakers(FS, "Why the glum face chum... cheerup we finally going to catch that bastard", true);
                Console.WriteLine();
                speakers(You, "Was just thinking... about that kid", true);
                Console.WriteLine();
                speakers(FS, "Oh whats his face... the emo, look alike?", true);
                Console.WriteLine();
                speakers(FS, "why, you thinking about him?", true);
                Console.WriteLine();
                speakers(You, "He knows something, but I need evidence before I can do anything", true);
                Console.WriteLine();
                speakers(FS, "If he is involved, in anyway we will bring him down!", true);
                Console.WriteLine();
                speakers(You, "You got that right... finally we arrive", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You arrive at the hospital ");
                Console.WriteLine();
                speakers(FSA, "They are ready and waiting for your instructions in the lab", true);
                Console.WriteLine();
                speakers(FS, "Quite, the welcome party. This is Uraraka Id, like you to meet...", true);
                Console.WriteLine();
                speakers(FSA, "Sir, not to be rude, but I dont care and time is of the essence... if you wish to save the poor soul, next to you then we should act quikly", true);
                Console.WriteLine();
                speakers(You, "I actually have a name.. you know...its", true);
                Console.WriteLine();
                speakers(FSA, "Glad to meet you, fresh meat now if we could stop wasting time with the unessesary formalities and do what we came here for I can go home and enjoy my evening early", true);
                Console.WriteLine();
                speakers(FS, "Yeesh woman..ok then. Tell the boys to unload the body", true);
                Console.WriteLine();
                speakers(You, "Whats her problem?", true);
                Console.WriteLine();
                speakers(FS, "Believe it or not, she actually dated a recruit much like yourself... and based on events so far, you know how it went. This is her way of dealing with the pain. Be nice", true);
                Console.WriteLine();
                speakers(You, "I didnt realise... must be hard for her", true);
                Console.WriteLine();
                speakers(FS, "Oooh, I wouldnt say that in front of her if you want to keep all your front row, teeth", true);
                Console.WriteLine();
                speakers(You, "Why?", true);
                Console.WriteLine();
                speakers(FS, "She hates it when people feel sorry for.. dont believe me ask Riley... when you see him inside. She broke his spine and punched, the living shit out of him", true);
                Console.WriteLine();
                speakers(You, "Unless you going to be gawking at my ass the whole day... I suggest you come inside", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You have entered, I need healing hospital and the body is being sent to the operation lab, for forensic analysis ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Line = "";
                Console.WriteLine("");
                Console.WriteLine("You have a gut feeling telling you to catch up to uraraka and talk to her");
                Console.WriteLine("What do you decide? :");
                Console.WriteLine("");
                Console.WriteLine("1.Catch up to her?");
                Console.WriteLine("2.Ignore thought");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (Line == "1")
                {
                    speakers(You, "Hey ", true);
                    speakers(FSA, "What do you want? ", true);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Line = "";
                    Console.WriteLine("");
                    Console.WriteLine("What do you decide? :");
                    Console.WriteLine("");
                    Console.WriteLine("1.Ask her how her day has been?");
                    Console.WriteLine("2.Ask her to give you a chance");
                    Console.WriteLine("3.Ask her out on a date when this is all over ");
                    Console.WriteLine("4.Never mind");
                    Line = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (Line)
                    {
                        case "1":
                            Console.WriteLine("");
                            speakers(You, "How has your day been? ", true);
                            Console.WriteLine("");
                            speakers(FSA, "... ", true);
                            Console.WriteLine("");
                            speakers(You, "come on you can do this... ", true);
                            Line = "";
                            Console.WriteLine("What do you decide? :");
                            Console.WriteLine("");
                            Console.WriteLine("1.Talk about weather?");
                            Console.WriteLine("2.Talk about sitation");
                            Line = Console.ReadLine();
                            if (Line == "1")
                            {
                                Console.WriteLine("");
                                speakers(You, "Lovely weather we are having..right?", true);
                                Console.WriteLine("");
                                speakers(FSA, "Listern here twerp fall back in line ", true);
                                Console.WriteLine("");
                                speakers(FS, "what the hell was that? ", true);
                                Console.WriteLine("");
                                speakers(You, "shut up ", true);

                                Laboratory();
                            }
                            else if (Line == "2")
                            {
                                Console.WriteLine("");
                                speakers(You, "So how does a beauty like you, end up in a place like this?", true);
                                Console.WriteLine("");
                                speakers(FSA, "a beauty like me ends up in a palace this when a psycotic killer, murderders his brother and writes her a note on how to find pieces of his body in the city", true);
                                Console.WriteLine("");
                                speakers(FSA, "So if you quite, finished I would like to move on with saving, your sorry ass ", true);
                                Console.WriteLine("");
                                speakers(You, "I di..", true);
                                Console.WriteLine("");
                                Console.WriteLine("Narrator: You took a blow to the head...");
                                Console.WriteLine("");
                                speakers(FS, "Jesus what did you say?", true);
                                Console.WriteLine("");
                                speakers(You, "shut up ", true);

                                Laboratory();
                            }

                            break;

                        case "2":
                            Console.WriteLine("");
                            speakers(You, "look I know im not the best looking guy in the world but I promise you I am anything but crude... If i offended you at all I am sorry ", true);
                            Console.WriteLine("");
                            speakers(FSA, "Its not you... I just need to come to terms with what happened last time I got close to someone ", true);
                            Console.WriteLine("");
                            speakers(You, "I understand... just wanted you to know that whenver you need to talk. Even though Im a stranger just shout ", true);
                            Console.WriteLine("");
                            speakers(FS, "Well, how did it go?", true);
                            Console.WriteLine("");
                            speakers(You, "I think ok ", true);

                            Laboratory();
                            break;

                        case "3":
                            Console.WriteLine("");
                            speakers(You, "Hey listern I was wondering if / when I survive this if you would would like to get some coffee  with me?", true);
                            Console.WriteLine("");
                            speakers(FSA, "... Lets keep you alive first", true);
                            Console.WriteLine("");
                            speakers(You, "Is that a yes? ", true);
                            Console.WriteLine("");
                            speakers(FS, "Wow, that was brave the last person who asked her out is six feet under ", true);
                            Console.WriteLine("");
                            speakers(You, "She killed him... you could have told me before i asked out a killer? ", true);
                            Console.WriteLine("");
                            speakers(FS, "What? no I mean literally 6 floors below us ", true);
                            Console.WriteLine("");
                            speakers(You, "You said feet though? ", true);
                            Console.WriteLine("");
                            speakers(FS, "ag did I? I always confuse the two haha ", true);

                            Laboratory();

                            break;

                        case "4":
                            Console.WriteLine("");
                            speakers(You, "Nothing much was just wondering what the time was haha... ", true);
                            Laboratory();
                            break;

                        default:

                            Console.WriteLine("Narrator: You need to enter only numbers 1-4");
                            break;
                    }
                }



            }
            else if (val ==3)
            {
                Console.WriteLine();
                Console.WriteLine("Narrator: On your way to hospital, you are thinking about your life in the city");
                Console.WriteLine();
                Console.WriteLine("Narrator: You arrive at the hospital");
                Console.WriteLine();
                Console.WriteLine("You see a beautiful woman in the distance as you get off the taxi ");
                Console.WriteLine();
                speakers(You, "Isaac is that you?", true);
                Console.WriteLine();
                speakers(FS, "Quite the welcome party, this is Uraraka Id like you to meet...", true);
                Console.WriteLine();
                speakers(FS, "By george... is that you?" +_OffierName, true);
                Console.WriteLine();
                speakers(FSA, "Sir not to be rude, but could we speed this up a bit...", true);
                Console.WriteLine();
                speakers(You, "I actually have a name.. you know...its", true);
                Console.WriteLine();
                speakers(FSA, "Glad to meet you, fresh meat. Now if we could stop wasting time, with the unessesary formalities and do what we came here for, I can go home and enjoy my evening early", true);
                Console.WriteLine();
                speakers(FS, "Yeesh women..ok then. Tell the boys to unload the body", true);
                Console.WriteLine();
                speakers(You, "Whats her problem?", true);
                Console.WriteLine();
                speakers(FS, "Believe it or not she actually dated a recruit much like yourself... and based on events so far you know how it went. This is her way of dealing with the pain. Be nice", true);
                Console.WriteLine();
                speakers(You, "I didnt realise... must be hard for her", true);
                Console.WriteLine();
                speakers(FS, "Oooh, I wouldnt say that in front of her if you want to keep all your teeth", true);
                Console.WriteLine();
                speakers(You, "Why?", true);
                Console.WriteLine();
                speakers(FS, "She hates it when people feel sorry for.. dont believe me ask Riley... when you see him inside. She broke his spine and punched, the living shit out of him", true);
                Console.WriteLine();
                speakers(You, "Unless you going to be gawking at my ass the whole day... I suggest you come inside", true);
                Console.WriteLine();
                Console.WriteLine("Narrator: You have entered I need healing hospital and the body is being sent to the operation lab for forensic analysis ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Line = "";
                Console.WriteLine("");
                Console.WriteLine("You have a gut feeling telling you to catch up to uraraka and talk to her");
                Console.WriteLine("What do you decide? :");
                Console.WriteLine("");
                Console.WriteLine("1.Catch up to her?");
                Console.WriteLine("2.Ignore thought");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (Line == "1")
                {
                    speakers(You, "Hey ", true);
                    speakers(FSA, "What do you want? ", true);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Line = "";
                    Console.WriteLine("");
                    Console.WriteLine("What do you decide? :");
                    Console.WriteLine("");
                    Console.WriteLine("1.Ask her how her day has been?");
                    Console.WriteLine("2.Ask her to give you a chance");
                    Console.WriteLine("3.Ask her out on a date when this is all over ");
                    Console.WriteLine("4.Never mind");
                    Line = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (Line)
                    {
                        case "1":
                            Console.WriteLine("");
                            speakers(You, "How has your day been? ", true);
                            Console.WriteLine("");
                            speakers(FSA, "... ", true);
                            Console.WriteLine("");
                            speakers(You, "come on you can do this... ", true);
                            Line = "";
                            Console.WriteLine("What do you decide? :");
                            Console.WriteLine("");
                            Console.WriteLine("1.Talk about weather?");
                            Console.WriteLine("2.Talk about sitation");
                            Line = Console.ReadLine();
                            if (Line == "1")
                            {
                                Console.WriteLine("");
                                speakers(You, "Lovely weather we are having..right?", true);
                                Console.WriteLine("");
                                speakers(FSA, "Listern here twerp fall back in line ", true);
                                Console.WriteLine("");
                                speakers(FS, "what the hell was that? ", true);
                                Console.WriteLine("");
                                speakers(You, "shut up ", true);

                                Laboratory();
                            }
                            else if (Line == "2")
                            {
                                Console.WriteLine("");
                                speakers(You, "So how does a beauty like you end up in a place like this?", true);
                                Console.WriteLine("");
                                speakers(FSA, "a beauty like me ends up in a place this when, her psycotic killer murderdous his brother and writes her a note on how to find pieces of his body ", true);
                                Console.WriteLine("");
                                speakers(FSA, "So if you have quite finished, I would like to move on with saving your sorry ass ", true);
                                Console.WriteLine("");
                                speakers(You, "I di..", true);
                                Console.WriteLine("");
                                Console.WriteLine("Narrator: You took a blow to the head...");
                                Console.WriteLine("");
                                speakers(FS, "Jesus what did you say?", true);
                                Console.WriteLine("");
                                speakers(You, "shut up ", true);

                                Laboratory();
                            }

                            break;

                        case "2":
                            Console.WriteLine("");
                            speakers(You, "look I know im not the best looking guy in the world, but I promise you, I am anything but crude... If i offended you at all I am sorry ", true);
                            Console.WriteLine("");
                            speakers(FSA, "Its not you... I just need to come to terms, with what happened last time I got close to someone ", true);
                            Console.WriteLine("");
                            speakers(You, "I understand... just wanted you to know, that whenver you need to talk, even though, Im a stranger just shout ", true);
                            Console.WriteLine("");
                            speakers(FS, "Well, how did it go?", true);
                            Console.WriteLine("");
                            speakers(You, "I think ok... ", true);

                            Laboratory();
                            break;

                        case "3":
                            Console.WriteLine("");
                            speakers(You, "Hey listern, I was wondering if / when I survive this, if you would would like to get some coffee with me?", true);
                            Console.WriteLine("");
                            speakers(FSA, "... Lets keep you alive first", true);
                            Console.WriteLine("");
                            speakers(You, "Is that a yes? ", true);
                            Console.WriteLine("");
                            speakers(FS, "Wow that was brave, the last person who asked her out is six feet under ", true);
                            Console.WriteLine("");
                            speakers(You, "She killed him... you could have told me before i asked out a killer? ", true);
                            Console.WriteLine("");
                            speakers(FS, "What? no I mean literally 6 floors below us ", true);
                            Console.WriteLine("");
                            speakers(You, "You said feet though? ", true);
                            Console.WriteLine("");
                            speakers(FS, "ag did I? I always confuse the two haha ", true);

                            Laboratory();

                            break;

                        case "4":
                            Console.WriteLine("");
                            speakers(You, "Nothing much was just wondering what the time was haha... ", true);
                            Laboratory();
                            break;

                        default:

                            Console.WriteLine("Narrator: You need to enter only numbers 1-4");
                            break;
                    }
                }



                }
            else
            {

                Console.WriteLine("Narrator: Please select 1,2 nothing else");
            }

            #endregion
        }

        public void Laboratory()
        {
            #region Laboratory ending
            Console.WriteLine("");
            speakers(FSA, "... Welcome to the lab", true);
            Console.WriteLine("");
            speakers(FS, "... Sometimes I think she lives here, she never goes home when she is working", true);
            Console.WriteLine();
            speakers(You, "... wow she looks beautiful... her smile... breathless", true);
            Console.WriteLine();
            speakers(FS, "You know you are not thinking, you are speaking right?", true);
            Console.WriteLine();
            Console.WriteLine("Narrator: Uraraka is rethinking, a lot of things primarily whether or not she should save you");
            Console.WriteLine();
            speakers(FS, "...Well done Uraraka, gathering my team in a short time frame... you need to get a raise", true);
            Console.WriteLine();
            speakers(FSA, "Actually, now that you mention it, did you get my e-mai...", true);
            Console.WriteLine();
            speakers(FS, "but, you wont get one", true);
            Console.WriteLine();
            speakers(FS, "... Ok, dear cadet of mine, do you want, to watch the festivities up close or behind that screen?", true);
            Console.WriteLine();
            speakers(FS, "Here, should be perfect", true);
            Console.WriteLine();
            speakers(FSA, "Sir, the body is ready for dissection", true);
            Console.WriteLine();
            speakers(FS, "All the answers, you were looking, for will be revealed shortly... dim the lights please", true);
            Console.WriteLine();
            speakers(You, "Last time, it was this quiet... I was writing exams... hahaha", true);
            Console.WriteLine();
            Console.WriteLine("Ben Assistant Forensic Scientist : Where did you find this kid boss?");
            Console.WriteLine();
            Console.WriteLine("Narrator: The room went awkwardly silent... for a few minutes");
            Console.WriteLine();
            Console.WriteLine("Narrator: ~2 hours later~");
            Console.WriteLine();
            speakers(You, "Sorry to disturb, but I dont have a car and I need to catch the, 17:00 train ... any results to report?", true);
            Console.WriteLine();
            speakers(FS, "Ahh you awake... you looked, so peaceful, I didnt want to distrub... The results are weird and confusing, but they seem, to confirm a rumour that I had", true);
            Console.WriteLine();
            speakers(You, "Which is?", true);
            Console.WriteLine();
            speakers(FS, "Our killer, kills for sacrificial purposes", true);
            Console.WriteLine();
            speakers(You, "You based this on?", true);
            Console.WriteLine();
            speakers(FS, "Firstly: When we undressed, him we found whiplash scars, on the lowerside of his body, suggesting torturing", true);
            Console.WriteLine();
            speakers(You, "Couldnt, it be self inflicted?", true);
            Console.WriteLine();
            speakers(FS, "Quite possibly, but notice the, depth and the inconsistency of the lashes? Going by my theory then it would mean our killer, has an M-O of perfectionism and planning... remember how you found the body?", true);
            Console.WriteLine();
            speakers(FS, "Second: The were ritualistic markings, under his chin and on his neck, but it was covered by a layer of fake skin that Uraraka noticed", true);
            Console.WriteLine();
            speakers(FS, "Third but must importantly his chest cavity, caved in as a result of a heavy object... I looked at some murders in the past 3 months and definately this object was used before", true);
            Console.WriteLine();
            speakers(You, "Any idea what the object could be?...It seams round, based on the wound markings", true);
            Console.WriteLine();
            speakers(FS, "Look, at you, taking over my thesis session... go on", true);
            Console.WriteLine();
            speakers(You, "Could it be a book? no... maybe a weapon? A medival weapon? something from a pawn shop no... If he is a perfectionist, he would, want soemthing real... from an auction house", true);
            Console.WriteLine();
            speakers(FS, "hahaa, stay with me please, Uraraka is no fun... she is standing behind me, isnt she", true);
            Console.WriteLine();
            Console.WriteLine("Narrator: Uraraka attacks Issac");
            Console.WriteLine();
            speakers(You, "But, there are only 3 auction houses in the city and the only one in the Jubilee district is Hwarangs Auction House and they specialise in medieval weaponry", true);
            Console.WriteLine();
            Console.WriteLine("Narrator: Uraraka is punching issac in the face");
            Console.WriteLine();
            speakers(You, "My daughter, was in a play and I had to buy her armour... luckily being broke as I am... I asked a friend to buy it, for me then i bought it from him at a fraction of the price... though Im, still paying for it even today", true);
            Console.WriteLine();
            speakers(FS, "wow, that is the sweetest, yet most saddest thing I have ever heard", true);
            Console.WriteLine();
            Console.WriteLine("Narrator: Isaac, had a serious look on his face... Uraraka stopped hitting him");
            Console.WriteLine();
            speakers(FS, "This means 1 of two things . Exhbit A our killer is a student with deep pockets. Exhbit B our killer is a parent with deep pockets", true);
            Console.WriteLine();
            speakers(You, "Question is why, are they, after officers investigating this case and why kidnap and kill children, you would think, its out of revenge or something... I me", true);
            Console.WriteLine();
            speakers(FS, "Wait, repeat what you just said?", true);
            Console.WriteLine();
            speakers(You, "Officers dying?", true);
            Console.WriteLine();
            speakers(FS, "After that", true);
            Console.WriteLine();
            speakers(You, "Children being killed?", true);
            Console.WriteLine();
            speakers(FS, "No, the revenge part", true);
            Console.WriteLine();
            speakers(FS, "What, if our killer lost their child, or friend, in a harmless sacrifce and something went wrong and the friend or child died? This could all be happening, becasue they are trying to ressurect their child or friend and they kill officers because they interfere", true);
            Console.WriteLine();
            speakers(You, "Thats a bit of a stretch...", true);
            Console.WriteLine();
            speakers(FS, " Here me out senpai... If we were to say my, previous bogous claim is true...", true);
            Console.WriteLine();
            speakers(FSA, "Atleast you know its bogous", true);
            Console.WriteLine();
            speakers(FS, "I heard... our new killers M-O would be a revengful, perfectionist that loved medival sorcerry ", true);
            Console.WriteLine();
            speakers(You, "So you are saying, Merlin is our killer?", true);
            Console.WriteLine();
            speakers(FS, "wow, way to sterotype all magic users... That would make magic fanboys potentially our killers", true);
            Console.WriteLine();
            speakers(FSA, "What if, its a girl?", true);
            Console.WriteLine();
            speakers(FS, "Did you see the boys chest?", true);
            Console.WriteLine();
            speakers(FSA, "So you are saying that, girls can do that?", true);
            Console.WriteLine();
            speakers(You, "choose your next words, very carefully", true);
            Console.WriteLine();
            speakers(FS, "...uhm", true);
            Console.WriteLine();
            Console.WriteLine("Ben Assistant Forensic Scientist : Hey boss, I found something, in his stomach");
            Console.WriteLine();
            speakers(FS, "Thank the heavens... dafaq is that a ruby?", true);
            Console.WriteLine();
            speakers(FS, "Case, closed the killer, hunts people that steal from him or her", true);
            Console.WriteLine();
            Console.WriteLine("Ben Assistant Forensic Scientist : Thats not the only thing in his body...");
            Console.WriteLine();
            speakers(FS, "is that a coacain bag, under his intestines? What did, this guy eats? are those diamonds?", true);
            Console.WriteLine();
            speakers(You, "What is going on here??", true);
            Console.WriteLine();
            Console.WriteLine("Narrator : The train left.. you need a lift home...");
            Console.WriteLine();
            speakers(You, "Uhm guys, I need a lift home... train, left like 20 min ago", true);
            Console.WriteLine();
            speakers(FS, "Uraraka, take him home please ... there is no-one, I trust better than you... no offense guys", true);
            Console.WriteLine();
            Console.WriteLine("Ben Assistant Forensic Scientist :Meh");
            Console.WriteLine();
            Console.WriteLine("Narrator : You are in the car, with Uraraka and the car is just about to take of");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Line = "";
            Console.WriteLine("");
            Console.WriteLine("What do you decide? :");
            Console.WriteLine("");
            Console.WriteLine("1.Call and inform Captain Philips?");
            Console.WriteLine("2.Enjoy Ride");
            Line = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (Line =="1")
            {
                Console.WriteLine("");
                speakers(You, "Uhm, Captain Philips we made a break through", true);
                Console.WriteLine("");
                speakers(CCh, "Evening, Cadet...you close to making arrests?", true);
                Console.WriteLine("");
                speakers(You, "No, not yet but this case is so much bigger, than we first thought", true);
                Console.WriteLine("");
                speakers(CCh, "Oh, in what way is that?", true);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Line = "";
                Console.WriteLine("");
                Console.WriteLine("What do you decide? :");
                Console.WriteLine("");
                Console.WriteLine("1.Mislead?");
                Console.WriteLine("2.Tell the truth");
                Line = Console.ReadLine();
                 if (Line=="1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Narrator : Car starts moving");
                    Console.WriteLine();
                    speakers(You, "oh, uhm, the culprit is a student and I will a make the arrest tommorow and will bring you the evidence", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator : Uraraka whispers, towards her left ear");
                    Console.WriteLine();
                    Console.WriteLine("Narrator : The car spirals out of control, moments later, it crashes into a tree at high speeds killing you instantly");
                    Console.WriteLine();
                    speakers(You, "No not y...o..", true);
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Game Over");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                 else if(Line=="2")
                {
                    Console.WriteLine();
                    speakers(You, "We discovered evidence, of a criminal of network in the city... we dont know who is involved and how, but we do know that children are used as travel carriagges for their supply", true);
                    Console.WriteLine();
                    speakers(You, "wouldnt be, too far off, to even conclude that they profile each other and specifically target the kids, hence the high number of children deaths... after 3 months", true);
                    Console.WriteLine();
                    speakers(CCh, "Well done cadet"+_OffierName, true);
                    Console.WriteLine();
                    speakers(You, "Thank you but... why did you say my...", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator : Gun is reloaded... Uraraka has a pistol in her hand and the barrel is staring you down");
                    Console.WriteLine();
                    speakers(You, "I thought we were... ", true);
                    Console.WriteLine();
                    speakers(CCh, "Pull the trigger...U-san" , true);
                    Console.WriteLine();
                    speakers(You, "You guys are part of this?", true);
                    Console.WriteLine();
                    Console.WriteLine("Narrator : Uraraka pulled the trigger and the bullet, pierced your skull at close range");
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Game Over");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                 else
                {
                    Console.WriteLine("Narrator : Please select 1 to 2");
                }

            }
            else if( Line =="2")
            {
                Console.WriteLine("");
                speakers(You, "This case just took a wrong turn ... I really, didnt see this comming", true);
                Console.WriteLine("");
                speakers(FSA, "Shall we... my warm bath at home is waiting for me", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator : Car starts moving");
                Console.WriteLine("");
                speakers(FSA, "Where is it you live again?", true);
                Console.WriteLine("");
                speakers(You, "Oh by the Kempton bridge", true);
                Console.WriteLine("");
                speakers(FSA, "You live, by a bridge?", true);
                Console.WriteLine("");
                speakers(You, "No I live in a motel complex, with my daughter thats near a brigde", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator : You arrive at the bridge, by your home and see the captain");
                Console.WriteLine("");
                speakers(You, "Captain? what brings you here?", true);
                Console.WriteLine("");
                speakers(CCh, "Business...I just came to check up on you, to see if you still are breathing", true);
                Console.WriteLine("");
                speakers(You, "Im alive and well Captain and we made a break through in the case", true);
                Console.WriteLine("");
                speakers(CCh, "I know U-san told me all about it", true);
                Console.WriteLine("");
                speakers(You, "U-san... oh, you mean Uraraka told you?", true);
                Console.WriteLine("");
                speakers(You, "Are you two?", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator : Uraraka, takes out a gun and shoots you, in the your left leg");
                Console.WriteLine("");
                speakers(CCh, "You see son... everyone has his place in this world, leaving your boundries is never good, for any reason", true);
                Console.WriteLine("");
                speakers(You, "You are part of the ring? the connection... the missing link, it was missing because even the law was on the criminals side", true);
                Console.WriteLine("");
                speakers(CCh, "You see... thats what im saying, you are asking the wrong questions", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator : Uraraka shoots you in the your right leg");
                Console.WriteLine("");
                speakers(You, "AHHHHHHH!! what i want to know is, why? Why go through, all this trouble?", true);
                Console.WriteLine("");
                speakers(CCh, "Now, you asking the right questions.", true);
                Console.WriteLine("");
                speakers(CCh, "Firstly, this city pays cops peanuts and expects us to risks ourlives,  everyday for a worthless cause", true);
                Console.WriteLine("");
                Console.WriteLine("Narrator : Uraraka, shoots you in the your right arm");
                Console.WriteLine("");
                speakers(You, "Ah! Is that why you became a cop? For Money? Fame?", true);
                Console.WriteLine("");
                speakers(CCh, "You need to open your ears and eyes, or you will bleed out, before you know why you died here tonight", true);
                Console.WriteLine("");
                speakers(CCh, "As I was saying we began our venture, with crimnal lords 6 months ago, but only 3 months later did we see the error of our ways", true);
                Console.WriteLine("");
                speakers(CCh, "Sure it payed more but anyone, who didnt enlist on the criminals side where killed and their familes used as tojan horses... ", true);
                Console.WriteLine("");
                speakers(You, "That doesnt explain why you are killing me, or why you killed other cadets?", true);
                Console.WriteLine("");
                speakers(CCh, "Its my job, if i dont keep order I loose everything, I care about... You die here tonight because of your ignorance ", true);
                Console.WriteLine();
                Console.WriteLine("Narrator : Uraraka pulled the trigger and the bullet pierced your skull at close range");
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Game Over");
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else
            {
                Console.WriteLine("Narrator : Please select 1 to 2");
            }
            #endregion
        }
        public void SurvivingTheNight()
        {
            #region surving the night
            Console.WriteLine("Narrator: You have an unshakable, feeling that the captain knows more than he is letting on to believe");
            Console.WriteLine("");
            speakers(You, "I guess there is no sense in worrying about it now... I need to find shelter or I will freeze to death", true);
            Console.WriteLine("");
            Console.WriteLine("Narrator: You are standing on a hill, with a clear view of the city. To your right is a bridge connecting, from the old city to the new city. To your left is the town and straight ahead is the CBD of the town");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("You need to find shelter where do you decide to go?");
            Console.WriteLine("What do you decide? :");
            Console.WriteLine("");
            Line = "";
            Console.WriteLine("1.Towards the bridges?");
            Console.WriteLine("2.Towards the town?");
            Line = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch(Line)
            {
                case "1":
                    Console.WriteLine("Narrator: You made it to the bridge and as you try to find a place to lay low, you are approached by 4 men with the intention of assaulting you");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine("What do you decide? :");
                    Console.WriteLine("");
                    Line = "";
                    Console.WriteLine("1.Run away?");
                    Console.WriteLine("2.Fight back?");
                    //Console.WriteLine("3.Negotiate?"); 
                    Line = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    

                    if (Line == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You evade the attacks the men hurled at you and make a break for it");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: The men are chasing you and now more than ever, are determined to kill you");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You realise that you, dont know the bridge area well, becasue the men keep popping out of no-where and you cant even see the main road ");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: A man throws a brick at you and it just grazes your, foot and leaves you limping");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You decide to use your gun");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You shoot 3 men, before one gets the jump on you... confused by this, you start panicking and in an instant you are surrounded");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You are kicked to the floor and are tring desperatly to reach for the gun you dropped.");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You are repeatedly assaulted and start to bleed internally" );
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Morning, comes and your lifeless body, is put up for display on a flag pole");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Passers by vomit at the sight of it, while others start crying");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Moments before your death, you thought maybe running away wansnt a good idea, but it was just a thought that will haunt you forever");

                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Game Over");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (Line == "2")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Narrator: You carefully, analyse the men and your surroundings and make the following discovery");

                        for(int i=0; i<BridgeMenAnalysis.Length-1;i++)
                        {
                            Console.WriteLine();
                            speakers(You, BridgeMenAnalysis[bridgeMen.Next(BridgeMenAnalysis.Length)], true);

                        }
                        Console.WriteLine("Narrator: Running, also seems like an option, but you realise, you dont know this area, all too well so you are at a huge disadvantage");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Without hesitation, you decide to act... a fight breaks out!");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: 3 of the men step back, as you are left to fight the big gun!");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Its a test if you are strong. If you win you survive... you if you lose you die!");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: Hand to hand, close quarter combat only!");
                        Console.WriteLine();
                        Console.WriteLine("Narrator: First one, to down the other wins!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("");
                      
                        Console.WriteLine("What do you decide? :");

                        Console.WriteLine("");
                        Line = "";
                        Console.WriteLine("1.Wait for him to strike first?");
                        Console.WriteLine("2.Stall?");
                        Line = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        if (Line=="1")
                        {
                            int p = CharStats.MaleAttackP();

                            // Your Stats
                            int YouP = CharStats.MaleAttackP();
                            int YouK = CharStats.MaleAttackK();
                            int YouD = CharStats.MaleDefense();
                            //Your Stats

                            // Enemies Stats
                            int EnemiesP = EnemyStats.EnemyAttackP();
                            int EnemieeK = EnemyStats.EnemyAttackK();
                            int EnemiesD = EnemyStats.EnemyDefense();
                            //Enemies Stats
                            Console.WriteLine("");
                            speakers(You, "A direct punch from this guy will knock me out instantly... we cant use weapons so the best way to survive. is dodge or parry his attacks until I see an opening ", true);
                            Console.WriteLine("");
                            Console.WriteLine("Narrator: Big guy strikes first");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("");

                            Console.WriteLine("What do you decide? :");

                            Console.WriteLine("");
                            Line = "";
                            Console.WriteLine("1.Throw a punch?");
                            Console.WriteLine("2.Kick the big guy?");
                            Console.WriteLine("3.Evade");
                            Line = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            if (Line == "1")
                            {
                                if (YouP >= EnemiesD)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: Enemy lets his guard down and you deal damage");
                                    Console.WriteLine();
                                }

                                Console.WriteLine();
                                Console.WriteLine("Narrator: You made him mad and he starts rampaging... his actions are out of control and you dont see an opening anymore ");
                                Console.WriteLine();
                                Console.WriteLine("Narrator: He fakes his left hook and connects with his right knee on your stomach... you temporarily loose conciousness and when you awake you are met by a barrage of punches that inevitably kill you");

                                    Console.WriteLine();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Game Over");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                

                            }
                            else if (Line == "2")
                            {
                                if (YouK >= EnemiesD)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: Enemy lets his guard down and you deal damage");
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Narrator: You made him mad and he starts rampaging... his actions are out of control and you dont see an opening anymore ");
                                Console.WriteLine();
                                Console.WriteLine("Narrator: He lifts you up by you neck and strangles you after breaking through your defense");

                                    Console.WriteLine();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Game Over");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                


                            }
                            else if (Line == "3")
                            {
                                if (EnemiesP>YouD )
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: Enemy knocks you out");
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: He sits on your body and starts hamemering away at your skull");
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: You die instantly");

                                    Console.WriteLine();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Game Over");
                                    Console.ForegroundColor = ConsoleColor.Red;

                                }
                            }
                            else
                            {
                                Console.WriteLine("Narrator: Please select 1,2,3 nothing else");
                            }



                        }
                        else if (Line=="2")
                        {


                            Console.WriteLine();
                            Console.WriteLine("Narrator: You carefully analyse the men and your surroundings and make the following discover");

                            for (int i = 0; i < BridgeMenAnalysis.Length - 1; i++)
                            {
                                Console.WriteLine();
                                speakers(You, BridgeMenAnalysis[bridgeMen.Next(BridgeMenAnalysis.Length)], true);

                            }
                            Console.WriteLine(); speakers(You,"Do we really have to fight?", true);
                            Console.WriteLine();
                            Console.WriteLine(); speakers(You, "We can work something out", true);
                            Console.WriteLine();
                            Console.WriteLine("Narrator: 3 of the men step back as you are left to fight the big gun!");
                            Console.WriteLine();
                            Console.WriteLine(); speakers(You, "Dang fighting it is then", true);
                            Console.WriteLine();
                            Console.WriteLine("Narrator: Its a test if you win you survive... you lose you die!");
                            Console.WriteLine();
                            Console.WriteLine("Narrator: Hand to hand close quarter combat only!");
                            Console.WriteLine();
                            Console.WriteLine("Narrator: First one to down wins!");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("");

                            Console.WriteLine("What do you decide? :");

                            Console.WriteLine("");
                            Line = "";
                            Console.WriteLine("1.Wait for him to strike first?");
                            Console.WriteLine("2.Stall?");
                            Line = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            if (Line == "1")
                            {
                                int p = CharStats.MaleAttackP();

                                // Your Stats
                                int YouP = CharStats.MaleAttackP();
                                int YouK = CharStats.MaleAttackK();
                                int YouD = CharStats.MaleDefense();
                                //Your Stats

                                // Enemies Stats
                                int EnemiesP = EnemyStats.EnemyAttackP();
                                int EnemieeK = EnemyStats.EnemyAttackK();
                                int EnemiesD = EnemyStats.EnemyDefense();
                                //Enemies Stats
                                Console.WriteLine("");
                                speakers(You, "A direct punch from this guy will knock me out instantly... we cant use weapons so the best way to survive. is dodge or parry his attacks until I see an opening ", true);
                                Console.WriteLine("");
                                Console.WriteLine("Narrator: Big guy strikes first");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");

                                Console.WriteLine("What do you decide? :");

                                Console.WriteLine("");
                                Line = "";
                                Console.WriteLine("1.Throw a punch?");
                                Console.WriteLine("2.Kick the big guy?");
                                Console.WriteLine("3.Evade");
                                Line = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                if (Line == "1")
                                {
                                    if (YouP >= EnemiesD)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Narrator: Enemy lets his guard down and you deal damage");
                                        Console.WriteLine();
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: You made him mad and he starts rampaging... his actions are out of control and you dont see an opening anymore ");
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: He fakes his left hook and connects with his right knee on your stomach... you temporarily loose conciousness and when you awake you are met by a barrage of punches that inevitably kill you");

                                    Console.WriteLine();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Game Over");
                                    Console.ForegroundColor = ConsoleColor.Red;


                                }
                                else if (Line == "2")
                                {
                                    if (YouK >= EnemiesD)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Narrator: Enemy lets his guard down and you deal damage");
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: You made him mad and he starts rampaging... his actions are out of control and you dont see an opening anymore ");
                                    Console.WriteLine();
                                    Console.WriteLine("Narrator: He lifts you up by you neck and strangles you after breaking through your defense");

                                    Console.WriteLine();
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Game Over");
                                    Console.ForegroundColor = ConsoleColor.Red;



                                }
                                else if (Line == "3")
                                {
                                    if (EnemiesP > YouD)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Narrator: Enemy knocks you out");
                                        Console.WriteLine();
                                        Console.WriteLine("Narrator: He sits on your body and starts hamemering away at your skull");
                                        Console.WriteLine();
                                        Console.WriteLine("Narrator: You die instantly");

                                        Console.WriteLine();
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine("Game Over");
                                        Console.ForegroundColor = ConsoleColor.Red;

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Narrator: Please select 1,2,3 nothing else");
                                }
                            }

                            }
                        else
                        {

                            Console.WriteLine("Narrator: Please select 1,2 nothing else");
                        }


                    }

                   
                    else
                    {
                        Console.WriteLine("Narrator: Please select 1,2 nothing else");
                    }
                    break;

            }


        }
        #endregion
    }

}
