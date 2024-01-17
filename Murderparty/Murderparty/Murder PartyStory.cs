using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Murderparty
{
    class Murder_PartyStory
    {
        public string CCh = "CaptainPhilip"; //captain Character
        public string MSC = "MrsJacobs "; // Mother suspect charcacter 
        public string KC = "James"; //Killer Character
        public string You = "You"; //Your Character
        static bool choice; // true = good , false = bad choices
        public string Line = "";
        static string _OffierName = "";
        private int choiceIndex = 0;
        Forensics foren = new Forensics();
        Students stut = new Students();
        // setting characher dialog identification and story
        public void speakers(string _charName, string _text, bool _showName)
        {
            if (_charName == CCh)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (_charName == MSC)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (_charName == KC)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
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
        // USed to establich narrator speaking color and the remainibng dialogu or explanations after him
        public void Principal(string _text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();



        }
        public void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello again you will be consulting Captain Philips as you solve your first murder:");
            Console.WriteLine("");
            Console.WriteLine("He is waiting for you in his car outside the building");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            #region Introduce Captain Philips
            Console.ForegroundColor = ConsoleColor.Cyan;
            speakers(CCh, "Well what are you waiting for an invitation? Get in", true);
            Console.WriteLine("");
            speakers(CCh, "Cadet, I dont care much for you. Quite frankly i dont even care about your name. Names are for people who mean something. Until you prove yourself you will be addressed as Cadet", true);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~Alert murder at Jubilee highschool~");
            Console.WriteLine("(an afternoon drive is disrupted by a murder scene)");
            Console.WriteLine("");
            speakers(CCh, "Will you look at that time to make a name for yourself son... I will be there with you, but if solve this case you will be promoted to Junior", true);
            Console.WriteLine("");
            speakers(CCh, "You heard the lady step on it son", true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            #endregion

            #region  murder location
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jubilee High School");
            Console.WriteLine("");
            Principal("Principal: The murder took place in the school gym. The body was found by James a senior here at Jubliee High");
            Console.WriteLine("");
            Principal("Principal: Unfortunately i must leave you. I have a meeting in an hour but if you need anyting at all dont hesitate to call. Mrs Josephs is the deceased, mother and our trusty secretary. She will help you wherever possible");
            Console.WriteLine("");
            Console.WriteLine("~Intercomm~ (James, please make your way to the gym, now please James... Thank you)");
            Console.WriteLine("");
            #endregion

            #region Crime Scene
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Crime Scene:(Gym)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("James made it there before you did");
            Console.WriteLine("");
            Console.WriteLine("Captain Phillip stayed at reception desk.. he is flirting with mrs Joseph");
            Console.WriteLine("");
            speakers(KC, "Good afternoon good sir, what brings you here", true);
            #endregion



        }

        public void MeetingJames(int val)
        {
            if (val == 1)
            {
                #region Meeting James Good Decision
                speakers(KC, "Follow me the body is this way", true);
                choiceIndex += 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                speakers(You, "You notice that James, is a bit too carefree considering there was a murder: ", true);
                speakers(You, "What do you decide?", true);
                Console.WriteLine("");
                Console.WriteLine("1.Remember this");
                Console.WriteLine("2.Ignore the thought");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (Line)
                {
                    case "1":
                        Console.WriteLine("");


                        JamesStudy(1);

                        break;
                    case "2":
                        Console.WriteLine("");

                        JamesStudy(2);
                        break;
                    default:
                        Console.WriteLine("Please select 1/2");
                        break;

                }


                #endregion
            }
            else
            {
                #region Meeting James Bad decision
                speakers(KC, "Wow that wasnt rude at all", true);
                choiceIndex += 2;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("James is silent while walking toward body, but you notice he keeps his distance");
                speakers(You, "What do you decide?", true);
                Console.WriteLine("");
                Console.WriteLine("3.Ask him if there is a problem?");
                Console.WriteLine("4.Ignore the thought");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                switch (Line)
                {
                    case "3":
                        Console.WriteLine("");
                        JamesStudy(3);
                        Line = "";
                        break;
                    case "4":
                        Console.WriteLine("");
                        JamesStudy(4);
                        Line = "";
                        break;
                    default:
                        Console.WriteLine("Please select 3/4");
                        break;

                }


                #endregion
            }
        }

        public void JamesStudy(int val)
        {
            if (val <= 2)
            {
                #region Studying James Good Decision
                speakers(You, "Are you always this calm in a crisis?", true);
                Console.WriteLine("");
                speakers(KC, "Hmpf no its... Im just happy, I can finally tell someone what happend to Morgan", true);
                Console.WriteLine("");
                speakers(KC, "Plus I have nothing to hide, why would I be tense (hahaha)", true);
                choiceIndex += 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("Upon arrival at the body in the gym bathroom, you notice a blood trail leading to the body suggesting that the body was moved after the murder");
                Console.WriteLine("");
                speakers(You, "What do you decide?", true);
                Console.WriteLine("");
                Console.WriteLine("1.Ask James if he knows anything?");
                Console.WriteLine("2.Investigate the body?");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (Line)
                {
                    case "1":
                        Console.WriteLine("");
                        speakers(You, "Did you see anythhing ? As in were you anywhere near the boy when the murder happened?", true);
                        Console.WriteLine("");
                        speakers(KC, "No Unfortunately not, I dont get to school until 08:00", true);
                        InvestigatingTheBody(1);
                        Line = "";
                        break;
                    case "2":
                        Console.WriteLine("");
                        speakers(You, "Let me get to it then", true);
                        Console.WriteLine("");
                        speakers(You, "~Strange... im no expert but the bloatedness of the body and the temperature dont match up with time of death we were given... fininding the body in the shower is no coincidence at all killer must have heated the body... need more evidence~", true);
                        Console.WriteLine("");
                        speakers(You, "You young man...when did you find this body? ", true);
                        Console.WriteLine("");
                        speakers(KC, "Well my morning jog is around 7:00. So I would say roundabout 08:00 ", true);
                        InvestigatingTheBody(2);
                        Line = "";
                        break;
                    default:
                        Console.WriteLine("Please select 1/2");
                        break;

                }


                #endregion
            }
            else if (val >= 3)
                #region Studying James Bad decision

                speakers(KC, "There is the body... If you need me i will be at the Indoor Canteen:", true);
            choiceIndex += 2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("You realise you might have upset James, but what strikes you most odd, about his behaviour is how quick he was in getting away from the murder scene:");
            speakers(You, "What do you decide?", true);
            Console.WriteLine("");
            Console.WriteLine("3.Call him back?");
            Console.WriteLine("4.Investigate the body?");
            Line = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch (Line)
            {
                case "3":
                    Console.WriteLine("");
                    speakers(You, "Hey...James was it? I still have questions for you", true);
                    Console.WriteLine("");
                    speakers(KC, "Oh you do, do you", true);
                    InvestigatingTheBody(3);

                    Line = "";
                    break;
                case "4":
                    Console.WriteLine("");
                    speakers(You, "~I will deal with him later, right now the body", true);
                    Console.WriteLine("");
                    InvestigatingTheBody(4);
                    Line = "";
                    break;
                default:
                    Console.WriteLine("Please select 3/4");
                    break;

            }


            #endregion

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
        public void InvestigatingTheBody(int val)
        {

            if (val <= 2)
            {
                #region Ivestigating the body GOOD
                Line = "";
                speakers(You, "While i didnt mention time of death... that puts the time the body was found to be roundabout 08:00...need more evidence for time of murder", true);
                Console.WriteLine("");
                speakers(You, "In what condition did you find the body exactly?", true);
                Console.WriteLine("");
                speakers(KC, "Oh I was coming in for a shower after my morning jog... then i saw the body", true);
                Console.WriteLine("");
                speakers(You, "I see ... but that wasnt my question", true);
                Console.WriteLine("");
                speakers(KC, "I know but i dont like cops, so take from that what you will", true);
                Console.WriteLine("");
                Console.WriteLine("James leaves the area because he doesnt like being interrogated");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You need more tools at hand to investigate the body");
                Console.ForegroundColor = ConsoleColor.Cyan;
                speakers(You, "What do you decide?", true);
                Console.WriteLine("");
                Console.WriteLine("1.Call in forensics?");
                Console.WriteLine("2.Perform oral investigation");
                Line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (Line)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("...");
                        Console.WriteLine("...");
                        speakers(You, "Yes [I Need Healing Hospital] could you send a forensics team to Jubilee highschool? There has been a murder", true);
                        Console.WriteLine("");
                        Console.WriteLine("[I Need Healing Hospital]: We will need more information before we can dispatch a team");
                        Console.WriteLine("");
                        speakers(You, "Thank you", true);
                        foren.INeedHealingHospital(1);
                        Line = "";
                        break;
                    case "2":
                        Line = "";
                        Console.WriteLine("");
                        Console.WriteLine("The body is lying in an odd position:");
                        Console.WriteLine("");
                        speakers(You, "What do you decide?", true);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("");
                        Console.WriteLine("1.Note the wierdly positioned body?");
                        Console.WriteLine("2.Investigate torso");
                        Console.WriteLine("3.Investigate legs");
                        Line = Console.ReadLine();
                        if (Line == "1")
                        {
                            Line = "";
                            speakers(You, "Thats odd the body is in a star position", true);
                            speakers(You, "Could the killer have ritualistic tendensies? Or was this all for spectacle purposes?", true);
                            speakers(You, "Either way we are dealing with a person who has killed before", true);
                            Console.WriteLine("");


                            // Branch out following Student Investigation
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("");
                            Console.WriteLine("What do you decide?");
                            Console.WriteLine("1.Go to hospital with Forensics Team?");
                            Console.WriteLine("2. Go interview other Students?");
                            Console.ForegroundColor = ConsoleColor.White;
                            Line = Console.ReadLine();
                            switch (Line)
                            {
                                case "1":
                                    Line = "";
                                    speakers(You, "Im coming with you I need those results asap", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: It really isnt neccessary for you to come along with, poke for some answers here and let us do our job, while you do yours.");
                                    Console.WriteLine("");
                                    speakers(You, "Hmm, well when you put it that way, I guess I could ask what the students saw", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Now you talking, well we should get going now, strange how much the world has changed with kids dying so fequently and all");
                                    Console.WriteLine("");
                                    speakers(You, "What do you mean?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: You mean to tell me that Philips didnt tell you....");
                                    Console.WriteLine("");
                                    speakers(You, "Tell me what... out with it?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Oh boy the nerve of that guy... I dont know how to break it to you but Captain Philips has lost more cadets than anyone in the force and they all were working on a case similar to yours");
                                    Console.WriteLine("");
                                    speakers(You, "Wait, are you telling me that, more kids have died? How many?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: No Im telling you cadets like you, have a short life span... be careful...");
                                    Console.WriteLine("");
                                    speakers(You, "How many?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: In the past 3 months there have been 265 confirmed deaths and 48 missing... The principals in the region are having a meeting today to discuss how to go forward.");
                                    Console.WriteLine("");
                                    speakers(You, "In latent terms we are dealing with a serial killer?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Yes in basic language I cant believe he didnt share this with you... anyway I should get going");
                                    Console.WriteLine("");
                                    speakers(You, "Yeah same here... ~A serial, makes things complicated... while its true leaving and not intergotating the students now is not the brightest thing it will be harder to do without evidence ~", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Well then staying here could get you killed anyway...you seem like a nice guy, perhaps its best to come with us anyway");
                                    Console.WriteLine("");
                   
                                    foren.INeedHealingHospital(1);
                                    break;

                                case "2":
                                    Line = "";
                                    speakers(You, "I still need to, take into accoount that he might have had help... hmmm the grade reps would be a good place to start", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: you make your way back to Mrs Josephs right before lunch time");
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: ...captain philips is seated and is waiting for you...Mrs Josephs is filing away some papers");
                                    Console.WriteLine("");
                                    speakers(You, "Ahem...Mam", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Mrs Josephs is fine.");
                                    Console.WriteLine("");
                                    speakers(You, "Sry to disrupt your work but could you please call all the grade reps to the gym at lunch time", true);
                                    Console.WriteLine("");
                                    speakers(CCh, "Cadet front and center!", true);
                                    Console.WriteLine("");
                                    speakers(CCh, "Cadet did I stutter! Drop down and give me 100 push ups!", true);
                                    Console.WriteLine("");
                                    speakers(You, "Sorry sir meant no offense", true);
                                    Console.WriteLine("");
                                    speakers(CCh, "When you done, fetch me a coffee and biscuits from the store across the street", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator:~ A hundred push ups later~");
                                    Console.WriteLine();
                                    speakers(You, "Your coffee and snacks sir", true);
                                    Console.WriteLine("");
                                    speakers(CCh, "Oh I got tired of waiting I went on along and bought pizza.", true);
                                    Console.WriteLine("");
                                    speakers(You, "Oh ffs!", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Gentlemen...quite down as I make the announcement please");
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: ~could all the grade reps please meet Officer: " + _OffierName + " in the gym please");

                                    stut.GradeReps(2);
                                    break;
                                default:
                                    Console.WriteLine("Please select 1/2");
                                    break;

                            }

                        }

                        else if (Line == "2")
                        {
                            Line = "";
                            speakers(You, "His torso definately was struck, in by a heavy object... finding that object is critical to this case", true);
                            Console.WriteLine("");
                            Console.WriteLine("Forensics:...er..excuse me sir we recieved a call about a body... we should have results for you in the next 6 hours");


                            // Branch out following Student Investigation
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("");
                            Console.WriteLine("What do you decide?");
                            Console.WriteLine("1.Go to hospital with Forensics Team?");
                            Console.WriteLine("2. Go interview other Students?");
                            Console.ForegroundColor = ConsoleColor.White;
                            Line = Console.ReadLine();
                            switch (Line)
                            {
                                case "1":
                                    Line = "";
                                    speakers(You, "Im coming with you I need those results asap", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: It really isnt neccessary for you to come along with, poke for some answers here and let us do our job, while you do yours.");
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: I take it things arent going so smoothly with evidence?");
                                    Console.WriteLine("");
                                    speakers(You, "Why do you know something?", true);
                                    Console.WriteLine("");
                                    speakers(You, "If you do you better spill the beans... or I will arrest you on an obstruction charge to this case", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Calm down yeesh... I do have information but...");
                                    Console.WriteLine("");
                                    speakers(You, "But what?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Ahemm");
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: Isaac is sticking his hand out... he wants drugs");
                                    Console.WriteLine("");
                                    speakers(You, "You want drugs?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Woow...did you live under a rock, when you were young?");
                                    Console.WriteLine("");
                                    speakers(You, "I know what you want ... how much?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: R1000");
                                    Console.WriteLine("");
                                    speakers(You, "What? you insane?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Seeing as your captain didnt tell you... I imagine its for your own safety. So yes.. I am a little crazy in telling you");
                                    Console.WriteLine("");
                                    speakers(You, "This better be worth it...", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: This kid, is not the first one and you arent too");
                                    Console.WriteLine("");
                                    speakers(You, "What do you mean?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Kids and officers involved in this case have all died or gone missing... if I count correctly you are the 42nd officer investigating this case");
                                    Console.WriteLine("");
                                    speakers(You, "What??", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Yes...Some how the evidence always vanishes and so do the officers... be careful");
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: If i may... I think it would be best to investigate this matter away from school grounds");
                                    Console.WriteLine("");
                                    speakers(You, "You may... and why is that?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: The common variable in all those murders and disappearences has been schools in this city");
                                    Console.WriteLine("");
                                    speakers(You, "Hang on you said schools?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: Yes, 256 children or teenagers have been confirmed dead or abducted in the span of 3 months");
                                    Console.WriteLine("");
                                    speakers(You, "Shouldnt more people be working, the case then?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: People are scared... now, that you know this will you investigate further or leave the case altogether?");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you decide?");
                                    Console.WriteLine("1.Leave Case?");
                                    Console.WriteLine("2. Carry on case?");
                                    Line = Console.ReadLine();
                                    if (Line == "1")
                                    {
                                        Console.WriteLine("");
                                        Console.Clear();
                                        Console.Beep();
                                        Console.WriteLine("");
                                    }
                                    else if (Line == "2")
                                    {
                                        speakers(You, "Like hell Im stopping... now that I know, I will be careful. I will leave with you guys just to be safe", true);

                                        Console.WriteLine("Isaac Forensic specialist: Naturally we are with you 100%. You are brave cadet, possibly the number one hero this city has been looking for");
                                        foren.INeedHealingHospital(1);
                                    }
                                        else
                                        Console.WriteLine("Please enter 1 or 2");

                                    Console.ForegroundColor = ConsoleColor.White;
                                   
                                    break;

                                case "2":
                                    Line = "";
                                    speakers(You, "I still need to, take into accoount that he might have had help... hmmm the grade reps would be a good place to start", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: you make your way back to Mrs Josephs right before lunch time");
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: .....captain philips is still flirting with her but she doesnt seem interested");
                                    Console.WriteLine("");
                                    speakers(You, "Ahem...cough cough", true);
                                    Console.WriteLine("");
                                    speakers(You, "Sry to disrupt your lovely conversation Miss...", true);
                                    Console.WriteLine("");
                                    speakers(You, "~More like saved your life... what is the captain thinking hitting on a woman who looks 30 years younger than him~ ", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: She looked at you, as if to say thank you");
                                    Console.WriteLine("");
                                    speakers(You, "Your welcome, (slight) nod)", true);
                                    Console.WriteLine("");
                                    speakers(CCh, "What was that? What did you two just agree on?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: I think its time we turned our attention to the case");
                                    Console.WriteLine("");
                                    speakers(CCh, "No no no I want to know what you two just agreed on.", true);
                                    Console.WriteLine("");
                                    speakers(You, "I found very interesting information, your sons chest cavity collapsed as a a result of a heavy blow to the chest the object in question is still at large", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: (Cries intensly)");
                                    Console.WriteLine("");
                                    speakers(CCh, "Ahhh Crap... were you raised in a barn Cadet? A better phrasing next time ", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: Captain Phillips offered Mrs Joseph some comfort");
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Who would do such a thing?");
                                    Console.WriteLine("");
                                    speakers(You, "We will catch this son of a b***h ,  mark my words mrs", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Who knew his father being in jail, would change him so much");
                                    Console.WriteLine("");
                                    speakers(CCh, "What makes you think that?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: my baby ... was a bully, the only reason I worked here, was to monitor him directly");
                                    Console.WriteLine("");
                                    speakers(You, "seems like there is more to this story, than meets the eye... I will be back to question you. For now, call Grade reps and tell them to meet me at the gym please", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: ~could all the grade reps please meet Officer: " + _OffierName + " in the gym please");

                                    stut.GradeReps(3);
                                    break;
                                default:
                                    Console.WriteLine("Please select 1/2");
                                    break;

                            }

                        }
                        else if (Line == "3")
                        {
                            Line = "";
                            speakers(You, "Whats this? Was he running? Where is his missing shoe?", true);
                            Console.WriteLine("");
                            Console.WriteLine("..er..excuse me sir we recieved a call about a body... we should have results for you in the next 6 hours");
                            Console.WriteLine("");
                  

                            // Branch out following Student Investigation
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("");
                            Console.WriteLine("What do you decide?");
                            Console.WriteLine("1.Go to hospital with Forensics Team?");
                            Console.WriteLine("2. Go interview other Students?");

                            Line = Console.ReadLine();
                            switch (Line)
                            {
                                case "1":
                                    Line = "";
                                    speakers(You, "Im coming with you I need those results asap", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Isaac Forensic specialist: I have 13 reasons why that isnt necessary but this will be for your own good anyway so why not?");

                                    foren.INeedHealingHospital(1);
                                    break;

                                case "2":
                                    Line = "";
                                    speakers(You, "I still need to, take into accoount that he might have had help ... hmmm the grade reps would be a good place to start", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator, you make your way back to Mrs Josephs right before lunch time");
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator, .....captain philips is still flirting with her");
                                    Console.WriteLine("");
                                    speakers(You, "Ahem...cough cough", true);
                                    Console.WriteLine("");
                                    speakers(You, "Sry to disrupt your lovely conversation Miss...", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Josephs... its Josephs.");
                                    Console.WriteLine("");
                                    speakers(CCh, "Jesus Christ... and you wonder why you havent had a girlfriend lad... least you can do is  remember Mrs Janes name", true);
                                    Console.WriteLine("");
                                    speakers(You, "Im pretty sure she said her name was Jospehs sir", true);
                                    Console.WriteLine("");
                                    speakers(CCh, "That riduculous her name cant be that she looks like a Jane ... Joseph is a surname", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Actually my name is ...");
                                    Console.WriteLine("");
                                    speakers(You, "Im sure if you let her talk she will...", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: If i could just ...");
                                    Console.WriteLine("");
                                    speakers(CCh, "Why does Joseph have an s at the end if its a name?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: Glass falls to the floor and breaks... the office is radio silent");
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: If you boys are done I would like to know the progress on my sons case");
                                    Console.WriteLine("");
                                    speakers(You, "Right apologies madam... I...", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: Im 28 years old. I am anything, but a madam");
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: Captain Philips is chuckling histerically in the background");
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: I have every right mind, to cancel that date if you find my age so amusing");
                                    Console.WriteLine("");
                                    Console.WriteLine("Narrator: Silence returned to the room once more");
                                    Console.WriteLine("");
                                    speakers(You, "Your son was found shoeless... either someone took the shoe because it had a blood sample of theirs or it fell of somewhere. Either way finding that shoe will lead us in the right direction", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: my baby boy ... (cries) Was he bullied?");
                                    Console.WriteLine("");
                                    speakers(CCh, "What makes you think that?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: my baby ... was a bully himself... we tried everything, counciling, therapy ... occasional beatings");
                                    Console.WriteLine("");
                                    speakers(You, "Hold on a second.. you said beatings... From you?", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: mostly from his father, but i chipped in whenever i could ... you have to understand we tried everything...");
                                    Console.WriteLine("");
                                    speakers(You, "seems like there is more to this story, than meets the eye... I will be back to question you, for now call all grade reps and tell them to meet me at the gym please", true);
                                    Console.WriteLine("");
                                    Console.WriteLine("Joseph: ~could all the grade reps please meet Officer: " + _OffierName + " in the gym please");

                                    stut.GradeReps(3);
                                    break;
                                default:
                                    Console.WriteLine("Please select 1/2");
                                    break;

                            }

                        }
                        else
                        {
                            Console.WriteLine("You need to select 1-3 nothing else");
                        }

                        InvestigatingTheBody(2);
                        Line = "";
                        break;
                    default:
                        Console.WriteLine("Please select 1/2");
                        break;

                }


                #endregion
            }


            else if (val >= 3)
                Line = "";
                #region Investigating the body Bad decision
                speakers(You, "~To think a murder would happen in the one place we as parents dont have full control over~", true);
            Console.WriteLine("");
            speakers(You, "~That kid knows more, than he is letting me on to believe... I will break him!~", true);
            choiceIndex += 2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("You notice the body is in an awkward position.");
            Console.WriteLine("What do you decide? :");
            Console.WriteLine("");
            Console.WriteLine("3.Collect sample of blood on floor and have it tested?");
            Console.WriteLine("4.Investigate the body and surroundings?");
            Line = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            switch (Line)
            {
                case "3":
                    Line = "";
                    Console.WriteLine("");
                    speakers(You, "Jason I need a blood sample tested... when can I expect the results?", true);
                    Console.WriteLine("");
                    Console.WriteLine("Jason: Thats hard to say ... its entirely dependent on the purity of the blood sample and how long its been there");
                    Console.WriteLine("");
                    speakers(You, "Thats not a time frame... you expect me to tell the deceased's mother that?", true);
                    Console.WriteLine("");
                    Console.WriteLine("Jason: ...Im sorry but thats the best i can do for now, I will do my best to have it completed as quick as possible. Calling forensics in will help speed up the process");
                    Console.WriteLine("");
                    speakers(You, "Ok.. you have permission to call them when your done with your tests", true);
                    Console.WriteLine("");
                    Console.WriteLine("Jason: ~I actually meant you should call them you brat~");
                    Console.WriteLine("");
                    speakers(You, "what was that?", true);
                    Console.WriteLine("");
                    Console.WriteLine("Jason: ~Joins the force today and already orders me around like im his lab dog (cyka)... I need a raise~");
                    Console.WriteLine("");
                    foren.INeedHealingHospital(3);

                    break;
                case "4":
                    Line = "";
                    Console.WriteLine("");
                    speakers(You, "~Wow.. how did I miss that ... there is dent in this stalls door and the door must have collapsed. The hinges are loose.~", true);
                    Console.WriteLine("");
                    speakers(You, "~Not to mention that the body is placed in a star formation... could this have been premeditated?~", true);
                    Console.WriteLine("");
                    speakers(You, "~If this really was premeditated the killer couldnt have done it alone...hmm, now that I think about it. Its entirely possible the murder took place elsewhere~", true);
                    Console.WriteLine("");
                    speakers(You, "~What are the odds though of a murder taking place at a school and no one noticing or knowing anything?... extremly unlikely in my opinion~", true);
                    Console.WriteLine("");
                    Console.WriteLine("Narrator: Your phone is ringing... its captain Phillips");
                    Console.WriteLine("");
                    speakers(You, "Yes captain?", true);
                    Console.WriteLine("");
                    speakers(CCh, "How is your investigation going cadet?", true);
                    Console.WriteLine("");
                    speakers(You, "I dont have concrete evidence yet but i have reason to believe the murder was premeditated", true);
                    Console.WriteLine("");
                    speakers(CCh, "Oh? Based on what exactly", true);
                    Console.WriteLine("");
                    speakers(You, "The body was found in  weird star formation, not to mention the bathroom stall door is damaged", true);
                    Console.WriteLine("");
                    speakers(CCh, "Thats it?", true);
                    Console.WriteLine("");
                    speakers(You, "Call me crazy sir, but i think the other students are in on this as well", true);
                    Console.WriteLine("");
                    speakers(CCh, "What makes you say that?", true);
                    Console.WriteLine("");
                    speakers(You, "Just a hunch", true);
                    Console.WriteLine("");
                    speakers(CCh, "Well follow your hunch and find the truth... I cant write a case report based on a hunch. Goodluck Cadet", true);
                    Console.WriteLine("");
                    speakers(You, "Thank you sir...you wont be disappointed", true);
                    Console.WriteLine("");
                    speakers(You, "~Guess I better follow up on these kids~", true);
                    Console.WriteLine("");
                    speakers(You, "~Speaking to them 1 on 1, would arouse more suspicion. No, I need to speak to all of them simultaneously~", true);
                    Console.WriteLine("");
                    speakers(You, "I need to speak to mrs Joseph", true);
                    Console.WriteLine("");
                    Console.WriteLine("Joseph: could all the grade reps please meet Officer: " + _OffierName + " in the gym please");
                    stut.GradeReps(2);
                    break;
                default:
                    Console.WriteLine("Please select 3/4");
                    break;
          
            }
            #endregion

        }

    }
 }
        


            