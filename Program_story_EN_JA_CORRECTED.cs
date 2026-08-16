using System.Threading.Tasks.Dataflow;

Start:
Console.WriteLine();
Console.WriteLine("You are STEVE");
Console.WriteLine("Press 1 to start");
Console.WriteLine("Press 2 for ending code");
Console.WriteLine("Press 3 for tutorial");
string A1 = Console.ReadKey().KeyChar.ToString();
if (A1 == "1")
{
    Console.WriteLine("Starting the game...");
    Console.WriteLine("Select Language of the game");
    Console.WriteLine("Press 1 for English");
    Console.WriteLine("Press 2 for Česky");
    Console.WriteLine("Press 3 for 日本語");
    string A4 = Console.ReadKey().KeyChar.ToString();
    if (A4 == "1")
    {
        EnglishStoryStart:
        Console.WriteLine("You've selected English");
        Console.WriteLine("Translation created with the assistance of AI.");
        bool en_i = false;
        while (!en_i)
        {
            Console.WriteLine("This is the story of an average man named Steve, who goes to work like everyone else, shops like everyone else, and lives like everyone else.");
            Console.WriteLine("press Enter to continue");

            ConsoleKeyInfo en_enterKey = Console.ReadKey();
            Console.WriteLine();

            if (en_enterKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Continuing the story...");
                bool en_i2 = false;
                while (!en_i2)
                {
                    Console.WriteLine("After no customer had come for a while, he got up from his chair and went to look around the building to see if anyone was there at all.");
                    Console.WriteLine("press Enter to continue");

                    en_enterKey = Console.ReadKey();
                    Console.WriteLine();

                    if (en_enterKey.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Continuing the story...");
                        bool en_i3 = false;
                        while (!en_i3)
                        {
                            Console.WriteLine("He opened the en_door and nobody was there, as if an alarm had just sounded and everyone had evacuated.");
                            Console.WriteLine("press Enter to continue");

                            ConsoleKeyInfo en_enterKey6 = Console.ReadKey();

                            if (en_enterKey6.Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Continuing the story...");

                                Console.WriteLine("Then he entered a room with two doors.");

                                Console.WriteLine("press Enter to continue");
                                ConsoleKeyInfo en_enterkey7 = Console.ReadKey();
                                if (en_enterkey7.Key == ConsoleKey.Enter)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("and Steve entered the en_door on the left");
                                    Console.WriteLine("");
                                    Console.WriteLine("press R for the en_door on the right and L for the en_door on the left");
                                    ConsoleKeyInfo en_door = Console.ReadKey();
                                    if (en_door.Key == ConsoleKey.L)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Continuing the story....");
                                        Console.WriteLine("");
                                        Console.ReadKey();
                                        Console.WriteLine("And he continued through the en_door on the left");
                                        Console.ReadKey();
                                        Console.WriteLine("Steve looked around, but nobody was there, so he thought the emergency stairs might lead outside.");
                                        Console.ReadKey();
                                        Console.WriteLine("When he reached the en_door marked 'EMERGENCY STAIRS', there was another en_door beside it marked EMERGENCY EXIT.");
                                        Console.ReadKey();
                                        Console.WriteLine("Press N for the emergency stairs or S for the emergency exit");
                                        string en_u = Console.ReadKey().KeyChar.ToString();
                                        if (en_u == "n")                                         {
                                            Console.WriteLine("Steve decided to take the emergency stairs");

                                            Console.ReadKey();
                                            Console.WriteLine("He walked down the stairs until he saw EXIT");
                                            Console.ReadKey();
                                            Console.WriteLine("Steve entered the exit en_door and saw");
                                            Console.ReadKey();
                                            Console.WriteLine("A button to kill the narrator");
                                            Console.ReadKey();
                                            Console.WriteLine("Steve ignored the button and kept going");
                                            Console.ReadKey();
                                            Console.WriteLine("Press K to push the button or I to ignore it");
                                            Console.ReadKey();
                                            string en_v = Console.ReadKey().KeyChar.ToString();
                                            if (en_v == "k")
                                            {
                                                Console.WriteLine("STEVE NOOOO€€€€€|||||");
                                                Console.ReadKey();
                                                Console.WriteLine("AHHHH STEVE, THAT WAS SUPPOSED TO BE A DIFFERENT ENDIŁG[[][[]]");
                                                Console.ReadKey();
                                                Console.WriteLine("Press any key");
                                                Console.ReadKey();
                                                Console.WriteLine("Sad Ending");
                                                Console.ReadKey();
                                                Console.WriteLine("Ending 6 [5]");
                                                Console.ReadKey();
                                                goto EnglishStoryStart;

                                            }
                                            else if (en_v == "i")
                                            {
                                                Console.WriteLine("Steve ignored the button and kept going");
                                                Console.ReadKey();
                                                Console.WriteLine("And he saw an EXIT en_door");
                                                Console.ReadKey();
                                                Console.WriteLine("Steve entered the en_door, but instead of an exit he found a room full of screens showing his office.");
                                                Console.ReadKey();
                                                Console.WriteLine("Steve was horrified by what he saw");
                                                Console.ReadKey();
                                                Console.WriteLine("And he realized he was only inside a game, and the purpose of his life was simply to be controlled by the player.");
                                                Console.ReadKey();
                                                Console.WriteLine("Press any key");
                                                Console.ReadKey();
                                                Console.WriteLine("Realization ending");
                                                Console.ReadKey();
                                                Console.WriteLine("Ending 7 [2]");
                                                Console.ReadKey();
                                                goto EnglishStoryStart;

                                            }

                                        }
                                        else if (en_u == "s")
                                        {
                                             
                                                    Console.WriteLine("Steve decided to take the emergency exit");
                                                     Console.ReadKey();
                                                    Console.WriteLine("He started sprinting toward the end");
                                                     Console.ReadKey();
                                                    Console.WriteLine("He could already see the light at the end of the tunnel");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Beyond the light was a small room");
                                                     Console.ReadKey();
                                                    Console.WriteLine("It looked like some kind of reception area");
                                                     Console.ReadKey();
                                                    Console.WriteLine("There was also a en_door marked Emergency Exit");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Steve entered without hesitation");
                                                     Console.ReadKey();
                                                    Console.WriteLine("And found himself in the middle of an endless desert");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Steve was surprised that the whole building was in the desert");
                                                     Console.ReadKey();
                                                    Console.WriteLine("He decided to go north");
                                                     Console.ReadKey();
                                                    Console.WriteLine("He walked for hours, days, weeks, and found nothing");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Steve started to fall into depression");
                                                     Console.ReadKey();
                                                    Console.WriteLine("He wondered when it would finally end");
                                                     Console.ReadKey();
                                                    Console.WriteLine("When he saw the same en_door he had come through, he ended it all.");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Press any key");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Depression ending");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Ending 9 [9]");
                                                     Console.ReadKey();
                                                    goto EnglishStoryStart;
                                        }

                                    }
                                    else if (en_door.Key == ConsoleKey.R)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Steve decided to take the en_door on the right.");
                                        Console.ReadKey();
                                        Console.WriteLine("Probably because his parents never taught him left from right.");
                                        Console.ReadKey();
                                        Console.WriteLine("Steve, I think we started this story on the wrong foot. I only want you to get an ending, that's all.");
                                        Console.ReadKey();
                                        Console.WriteLine("press Enter to continue");
                                        ConsoleKeyInfo en_enterkey8 = Console.ReadKey();
                                        if (en_enterkey8.Key == ConsoleKey.Enter)
                                        {
                                            Console.WriteLine("Continuing the story....");
                                            Console.WriteLine("");
                                            Console.WriteLine("Alright Steve, type Hello.");
                                            Console.WriteLine("");
                                            Console.WriteLine("Type 'hello' to continue...");

                                            string en_vstup = Console.ReadLine() ?? string.Empty;

                                            if (en_vstup.ToLower() == "ahoj")
                                            {
                                                Console.WriteLine("See? You can listen.");
                                                Console.ReadKey();
                                                Console.WriteLine("Steve, let's see where the problem is.");
                                                Console.ReadKey();
                                                Console.WriteLine("When Steve reached the end of the room, he turned around and went back.");
                                                Console.WriteLine("");
                                                Console.ReadKey();
                                                Console.WriteLine("Press 'o' to turn around, or 'm' to walk into the wall");
                                                string en_Door = Console.ReadKey().KeyChar.ToString();
                                                if (en_Door == "o")
                                                {
                                                    Console.WriteLine("As Steve walked back, he saw an open en_door");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Press 1 to enter the open en_door");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Press 2 to keep going");
                                                    string en_wt = Console.ReadKey().KeyChar.ToString();
                                                    if (en_wt == "1")
                                                    {
                                                        Console.WriteLine("Steve entered the open en_door.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve, why did you enter that en_door?");
                                                        Console.ReadKey();
                                                        Console.WriteLine("You know this is only the text version of the game, right?");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Fine, because of you I have to check the script again.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Yes, here it is: when Steve entered the open en_door, a gate named DELETE opened in front of him.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("When Steve entered the gate, two buttons appeared");
                                                        Console.ReadKey();
                                                        Console.WriteLine("DELETE a KEEP");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve didn't know what the buttons meant");
                                                        Console.ReadKey();
                                                        Console.WriteLine("So Steve pressed the DELETE button");
                                                        Console.ReadKey();
                                                        Console.WriteLine("DELETE 1 | KEEP 2");
                                                        string en_del = Console.ReadKey().KeyChar.ToString();
                                                        if (en_del == "1")
                                                        {
                                                            Console.WriteLine("Steve, I thought you wouldn't do that");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Those few minutes we spent together... sure, you rejected the story, but............");
                                                            Console.ReadKey();
                                                            Console.WriteLine("s̶̜̞̟̩͚̞̖̓̉̓́͋̓͝e̴̢̡̡̟̥̗̫̹̹͖̺͚̦̎̑̂̎̂̿́́̾̔̕͠d̷̩͓̗͉̼̺͓͔̫͈͖̈́̃t̷͓͔̻̲̼̥̬͓̲̦̞̬̐̒͐͂d̴̡̧̘͈͇̟̫̟͔̞͚́͑̆̆̚͝s̴̡̨̢͎̣̱͎͍̣̺̺̅͆̉̀̕͠ͅf̴̛̰̹̠͕̙̘̰̬̱̳̹̠̋̑̄̓̽͆̀̿͝g̵̢̺̩̻̋̔̎͐́́͂͗̈́̅̇͜͝f̷͇̤̻͓̭̟̙̤̏̆͛̀̐̾̓̓̂͗́̄͠d̵͎̠̙̱̤̻̜̦̬͒̎̉̂̓̂̋̅͊̈̕͘");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Press any key");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Delete ending");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Ending 5 [4]");
                                                            Console.ReadKey();
                                                            goto EnglishStoryStart;
                                                        }
                                                        else if (en_del == "2")
                                                        {
                                                            Console.WriteLine("Steve, you aren't listening. You were supposed to delete me, not keep me.");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Fine, if you only want an ending");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Press any key");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Here you go: You WON ending");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Ending 2 [7]");
                                                            Console.ReadKey();
                                                            goto EnglishStoryStart;

                                                        }

                                                    }
                                                    else if (en_wt == "2")
                                                    {
                                                        Console.WriteLine("Steve decided to continue.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Until he got back to the en_door he had entered through");
                                                        Console.ReadKey();
                                                        Console.WriteLine("He decided to continue toward his office");
                                                        Console.ReadKey();
                                                        Console.WriteLine("But the office was locked; instead, another en_door was open");

                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve went inside and suddenly saw people");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve was excited and wanted to go to them");
                                                        Console.ReadKey();
                                                        Console.WriteLine("He went outside, saw the sky, breathed the clean air, and Steve was happy.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Press any key");
                                                        Console.ReadKey();
                                                        Console.WriteLine("True good ending");
                                                        Console.WriteLine("Ending 10 [2]");
                                                        goto EnglishStoryStart;


                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Hey, you found a secret, but a very special secret.");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Suddenly, a portal opened in front of Steve");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();

                                                        Console.WriteLine("Narrator: Stanley entered the en_door on the left");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("'A portal opens'");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Narrator: STANLEY, DO YOU SEE THAT????");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve, I think we got into The Stanley Parable");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Narrator: WHO WAS THAT?");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("I'm the narrator, you are Steve");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Narrator: Stanley, run! This is a viruuuuuuus");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve, wait, let me check the script, um...");
                                                        Console.ReadKey();
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Okay, now we should run after them");
                                                        Console.ReadKey();
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Press B to run and S to stand still");
                                                        string en_c1 = Console.ReadKey().KeyChar.ToString();
                                                        if (en_c1 == "b")
                                                        {
                                                            Console.WriteLine("Steve, quickly, we have to catch them!");
                                                        }
                                                        else if (en_c1 == "s")
                                                        {
                                                            Console.WriteLine("Steve, why are you standing still? That's not in the script.");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Damn it Steve, the map is getting corrupted!");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("N̵̢̡̢͓̰͉̠̞̝̙͕͉̩͇̗̯̤̫̠̰̲̋́̄̈́̽̀̉̕̕̕͜͝͝ͅę̷̡̡̭͉͕̪̫̗̘͇̮̭̼͓͇̳̓̿͒̃̾̅̈́̚ͅͅͅe̶̡̜̭̱͍͍̤͓̘̝̥͉͕͍̩̹͉̙̳̟̘̓̎͗̀̾̀̌̑̆̍͒̆̅͗̉̑͗͛̓̐̔͒̾̊͘͝͝ę̸̛̛̣̘̟̩̪̺͉͉̖̝͍̹̲̯̦͍̘̳̫͙̎́̈́̊͋̓̍̏̀̊̋̈́̉͂͜͝͝͝͝e̸̡̬̫̯̳͎̼̽̾̏̏̂͗̄̍͆͗̓̊̈́̽̇̏̈͝ͅȩ̵̠̥̙̺͚̪̖͔̯͎̘̮͍̣͇̳̜̙͕͖̫̺͒͊̏̃͌͛́̄͊̎̾͊̒́̅͆͝ͅe̵̢̡̢̱͉͈͉͚̙̖͓̹̼͙̣̦̺̼̱͋̾̿͆͜͠͠ȩ̶͕͍͖̼̫̣͓͙͚̫̩̥̖͈͍̟͊̽̋̉̅͜ͅe̷̛̲̪͙̲̙̲̯̲͆̌̓̌̒̊͂͝ͅḛ̷̢̧̞̱̬̤͍̥̲̩̔͆̀͗̓̈͑̑̉́̈̊͑̾͘͜ͅę̴̡̢̺̞͚̻̮̞̰̦̖̘̞̠̯̜͎͍̘̲̬͔̜͐̈́̊͒̚e̴̢̱͓̰͖̰͖͊̂̃́̚͝ ̵̨̡̡̝̪͇͍̹̰͕̘̣̰̣̫̣̼̲̭͇̟͍͔̫̻̒̔͛̐͊͠ͅͅͅS̵̖͇͗͆́̆̈́͂͂̄̂̀̏̈̎̃̅͗̇̚̕͝͝͝͝͝͝T̵̡͎̫̮̞̰͙̦̞͇̱͈͖̰͎͕̤͇̙̘͊̀̑̐̔̾͋̓͑͊̃̏̅̔͘͜͝Ȩ̴̧̧̛̗̤̭̘͕̓͋̿̌͌̂͑͝Ṽ̵̧̞̱͍̞̩̜̗̞͙̰͍̰̗̀́͑́͜͜ͅE̵̡̳̖̣̲̝͍̗͚͕͕̲̯̩̬̣͍͚̲̮̲̼̺̙͐̌́̀̏̎̊̔̚̕͜͜E̴͎̹͇͌̕Ę̷̖̩̜̯̲̗̙̤̟̥̥͚͕̻̟̙̹̪̈́̐͂̌Ę̶̡̢̞̤̱̩̗̱̯̗̖̜̙̙͈̠̣̮̲̜̹̿̂̎͑̆̀̾̂͂̀̏̉̾̚ͅE̶̥̘̠͖̗̗̠͝Ȩ̴̣̜̬͖̼̩̓͆͛̂̀̈̌̚̕̕͠͝");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Press a key to continue");
                                                            Console.ReadKey();
                                                            Console.WriteLine();
                                                        en_Stanleyparableending:
                                                            Console.WriteLine("Stanley Parable");
                                                            Console.WriteLine("Press 1 to start");
                                                            Console.WriteLine("Press 2 for settings");
                                                            Console.WriteLine("Press 3 for epiloque");
                                                            Console.WriteLine("Press 4 to Quit");
                                                            string en_stanley = Console.ReadKey().KeyChar.ToString();
                                                            if (en_stanley == "1")
                                                            {
                                                                Console.WriteLine("Y̶̰͐Ó̶͍Ụ̷̏͜ ̶̭̇A̷̢̛̅Ṙ̶̹Ė̸̘̱ ̶̩̇̕Ń̸̦̱̚O̸̥͎̍T̷̟͝ ̵̰͌͠Ş̸͚́̕T̶̡̈͆Ä̶̹N̴͖̋L̸̡͔̈́̐E̷̪̊̀Y̴̤̳̓");
                                                                goto en_Stanleyparableending;
                                                            }
                                                            else if (en_stanley == "2")
                                                            {
                                                                Console.WriteLine("Y̶͍͛̀ͅO̴͓̺͐̓Ȗ̶͔̯͆ ̸̼̹̑̽Ḥ̷̍Ǎ̷̻̩̾V̷̥͓̈Ẹ̴̍ͅ ̸͈̬̏N̸̡̈́O̷̱̺̒͒T̴̝͗͒Ḧ̶͓͖I̷͔̠͛N̵͕͆̇G̶̤̦͐ ̷͓̱̒T̴̤̞̎O̵̘̫̊ ̷̼̖̎Ḍ̴̡͝O̷͙͖̔͋ ̶̱̈̍I̸̠̩̋N̴͎̂̏ ̴̰̞̈́̕S̴͍̒E̴͍̕T̴̥̿T̶͓͇̽̂Ḭ̸͘ͅN̶͋͝ͅG̵̳̓Š̷̘̈́");
                                                                goto en_Stanleyparableending;
                                                            }
                                                            else if (en_stanley == "3")
                                                            {
                                                                Console.WriteLine("E̸̪̯̓P̴͍͗Ĭ̷̛̦̫L̷̳̤͗̓O̶̯̓̉Q̴̼̘̑U̷͚̓E̷̝̬͌ ̷̩̰̍N̶̲̲͒̕Ò̵̘̑ ̶͍̪̿͋Y̵̳̯͐Ȍ̵͎̉U̶̦̿ͅ ̴̰̤͠͠A̴̛̱̾R̸͖͂̒E̴̲̻̿̈́ ̵͓̚N̷̡̡̒̑O̵͕̲̅̽Ṭ̴̃ ̷̬̄S̴͖̪̒͑T̴̖̑A̶̬͉̍N̶̡̦͆̈́L̶̦̈́̋Ẹ̷̋͝Y̷̰͒");
                                                                goto en_Stanleyparableending;
                                                            }
                                                            else if (en_stanley == "4")
                                                            {
                                                                Console.WriteLine("H̸̡̧̨̟̩̟̙̮͉͉̹̝̊͆̄̌̓̍̽̒̌̅͂̎̐̈͂͗̒̒̍́̈̂͒͗̂͐̋̈́͊̔̀͋̚͝͝͝͠͠G̷̜̪̮͍͎̹̦̺̣͎̤̬͍̲̣̜̖̟͕͚̔͌͌̈͑̈͛̾͌̆̉̂͒͋͒̃̆̒͘̚͝͝͝͠͝͝ͅF̶̢̣͆̿́̄̔́̓́̀̔̓̊̽̀̐̆̈̈́̓̃̉́̒̏͘͘͠͠͠Í̷̧̨̢̡̨̭̦͖̥̗̫͈̼̺͈̫͕͈̪͙̠͍̪͔̬̹͉͆̈́͋̇̃͂ͅA̷̡̢̡̛̯̳̰͎̻͈̞̘̩̫̯̱͕͈̙̟̙͉̥̘̳̯͍̞̺̦̥̙͍̦͙͚͉̱͉̹̬̝̚͜͝G̴̨̡̢̢̢̘̥̬̟̞̥͉̼̺̹̥̣̫̟̦͚̮̯̖͎̙̙̻̼̫̰̰̰̗̬̺̫͉͓͔̲̜̔̀̆̃͆́͐̒̾͒̈̄̔̎̀̃̋͋̈̇̈́̑͐͗̒̕͜͜͜b̷̧̡̡̛̖͍͓̥̟̞̹͉̙̯̳̖̮̠͍̠̬̉͗͒͒͛̇̏͗̀̇́̍͐̔͊͛͒́͌̓͑͂̈̑͂̈́̎̀̽̒̀́̑̚͠͠Ą̸̢̨̢̛̱̙͔̱̰̘̮̥̭̦̭͍̖̝̭̫̠̥͙̜̤̮̮͍̻͎͈͔̦̼͕̟̙̪̩̫̯̩͎͓̎͊͌̊̎̀͛̾͋̏̍̈̏́ͅen_i̸̧̨̨̨̧̡̨̨̛̛̭̲̮̗͉̜͇̯͉̱͚̹͍̙̮͈͚̰̙̲̙̭̥͙̯̤̲̞̱̻̞̳͈͚̯̅̇̑̒̋̽͐̊̓̌̂͑̂͐͐͒̃̈́̆̋̈́̏̏̊̾̑̂̽̈́̿̓̋̂͐́͘͜͝͝͝ͅͅen_ų̷̯͙͕̤͙̳̦͉̠̠̹͆̀̽̇̃̽̓̈́̑̉͛̋̀̆̑́̐͛̑̀̏͊̄͘̕̚̚͘͘en_v̸̨̢̢̟̣̰̫͉̻̲͉̩͙̜̮̙̻̱̖̺͚̭̮͎̦̠͕͔̺͉͚̯͓͙̗̼̜͔́͛̒͑́̈͌͒̇̓̽͌͛̔̈͗̀̀͗̄̇̌̍̃͗̎̃͑̓͋̽̉̂̈̓̊͒̍͐̐̈͆͂͋̕̚ͅğ̸̨̧̨͖̟̖̲͎̣͔̪̘͙̭̘̰͙̙̞͕̘͔̖̫̞̣̺̣͈̼̹͉̹͚̲͉̪̄̔̊̃̈́̏͛̍͒́͋̊̅̌̾̈́͂͛̐͐͛̾̉̉͊̽̕̚͝͝I̵̧̧̡̧̢̛͔̲̰͔͔̣̖̦̞̗̭̬̮̬̰̹̭͓̥̥͕̻̪͇̘̥̠̪̔̽̂̒̓̉̈́̇̈́̾̇͊͛̃͐̾̋͂́͋̀̓̄̊̈́̎̀̃̆́̐̊̓͑̐͒̀͊̚͜͠͠ͅJ̶̡̧̛̦̯̳̙͓̠̫͎͎͕͚̙͇̬̙̲̑̾̀̅̀̃̾͛̓̑̇̏̚");
                                                                Console.ReadKey();
                                                                goto ending4;
                                                            }
                                                        ending4:;
                                                            Console.WriteLine("Wait, you're not Stanleyȳ̷̡͕̣͔̼̮̫̻͆̀̚ȳ̷̡͕̣͆̀̚ȳ̷̡͕̣͔̼̮͆̀̚");
                                                            Console.ReadKey();
                                                            Console.WriteLine("s̴̢̛̥̼̥̒͐̾̐̿͠d̵̛͔͕̦͓̘̚d̸̥͓̼̙͒͂̈͆͐̾͝g̴̨̟̲̑");
                                                            Console.WriteLine("Press any key");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Stanley parable mindf*ck ending");
                                                            Console.WriteLine("ending 4 [1]");
                                                            Console.ReadKey();
                                                            goto EnglishStoryStart;













                                                        }
                                                    }
                                                }
                                                else if (en_Door == "m")
                                                {
                                                    Console.WriteLine("Steve, what the hell? That wall is passable.");
                                                    Console.ReadKey();
                                                    Console.WriteLine("A yellow room, okay?!?");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Try to go back, Steve");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Steve, it doesn't work?");
                                                    Console.ReadKey();
                                                    Console.WriteLine("STEVE, SOMETHING MOVED THERE");
                                                    Console.ReadKey();
                                                    Console.WriteLine("DAMN IT, STEVEEE");
                                                    Console.ReadKey();
                                                    Console.WriteLine("And Entity 3 ran toward him");
                                                    Console.ReadKey();
                                                    Console.WriteLine("And killed Steve");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Press any key");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Backrooms ending");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Ending 8 [5]");
                                                    Console.ReadKey();
                                                    goto EnglishStoryStart;
                                                }















                                            }
                                            else
                                            {

                                                Console.WriteLine("Fine, if you don't listen to me, why should I listen to you? Actually, it's my story, not yours.");
                                                Console.WriteLine("Press any key");
                                                Console.ReadKey();
                                            en_Fakestart:
                                                Console.WriteLine("You are STEVE");
                                                Console.WriteLine("Press 1 to start");
                                                Console.WriteLine("Press 2 for ending code");
                                                Console.WriteLine("Press 3 for tutorial");
                                                string en_B1 = Console.ReadKey().KeyChar.ToString();
                                                if (en_B1 == "1")
                                                {
                                                    Console.WriteLine("Press something for English");
                                                    Console.ReadKey();
                                                    Console.WriteLine();
                                                    Console.WriteLine("I see you're back");
                                                    Console.ReadKey();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("I have a surprise for you HAHAHA");
                                                    Console.ReadKey();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("And that surprise is the cruel truth");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Steve, this whole time you were simply insane");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("The fact that nobody was in the building was all your fault");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("The whole city evacuated because of you");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Because you, and only you, blew up the entire city with a button, and you stayed in it");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Do you understand, Steve? You've been dead this whole time");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("And me? I'm just what's left of your sanity");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Press any key");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Cruel Reality ending");
                                                    Console.WriteLine("Ending 3 [3]");
                                                    Console.ReadKey();
                                                    goto EnglishStoryStart;
                                                }
                                                if (en_B1 == "2")
                                                {
                                                    Console.WriteLine("You don't have the code anyway");
                                                    Console.ReadKey();
                                                    goto en_Fakestart;

                                                }
                                                if (en_B1 == "3")
                                                {
                                                    Console.WriteLine("What do you need the tutorial for?");
                                                    Console.ReadKey();
                                                    goto en_Fakestart;

                                                }

                                            }
                                        }
                                    }
                                }
                                en_i3 = true;
                                en_i2 = true;
                                en_i = true;
                            }
                            else
                            {
                                Console.WriteLine("Fine, have it your way. You want an ending, so you'll get one. Press any key.");
                                Console.WriteLine("");
                                Console.ReadKey();
                                Console.WriteLine("Steve tried to walk into the wall for hours until he finally succeeded. He thought he had broken the game, but then he heard...");
                                Console.WriteLine(""); Console.ReadKey();
                                Console.WriteLine("You deserved it: Wrong Button ending");
                                Console.WriteLine("");
                                Console.WriteLine("Ending 1 [8]");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                goto EnglishStoryStart;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seriously?!? You won't trick me that easily just to get an ending. You have to press Enter to continue the story.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("I know what you're trying to do: get an ending for free. It won't work. You have to press Enter to continue the story.\n");
            }
        }
        }
    else if (A4 == "2")
    {
        Console.WriteLine("You've selected Česky");
        bool i = false;
        while (!i)
        {
            Console.WriteLine("Toto je příběh průměrného člověka jménem Steve který chodí do práce jako každý jiný, nakupuje jako každý jiný a žije jak každý jiný.");
            Console.WriteLine("stiskni enter pro pokračování");

            ConsoleKeyInfo enterKey = Console.ReadKey();
            Console.WriteLine();

            if (enterKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Pokračování příběhu...");
                bool i2 = false;
                while (!i2)
                {
                    Console.WriteLine("Když mu už nějakou dobu nepřišel zákazník, tak se zvedl ze své židle a šel se kouknout po budově, jestli tam někdo vůbec je.");
                    Console.WriteLine("stiskni enter pro pokračování");

                    enterKey = Console.ReadKey();
                    Console.WriteLine();

                    if (enterKey.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Pokračování příběhu...");
                        bool i3 = false;
                        while (!i3)
                        {
                            Console.WriteLine("Otevřel dveře a nikdo tam nebyl jako kdyby ted zazněl alarm a všichni se evakuovali.");
                            Console.WriteLine("stiskni enter pro pokračování");

                            ConsoleKeyInfo enterKey6 = Console.ReadKey();

                            if (enterKey6.Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Pokračování příběhu...");

                                Console.WriteLine("A potom vešel do místnosti kde byly dvoje dveře.");

                                Console.WriteLine("stiskni enter pro pokračování");
                                ConsoleKeyInfo enterkey7 = Console.ReadKey();
                                if (enterkey7.Key == ConsoleKey.Enter)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("a steve vešel do dveří na levo");
                                    Console.WriteLine("");
                                    Console.WriteLine("stiskněte r pro dvere napravo a l pro dvere na levo");
                                    ConsoleKeyInfo door = Console.ReadKey();
                                    if (door.Key == ConsoleKey.L)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Pokračování v příběhu....");
                                        Console.WriteLine("");
                                        Console.ReadKey();
                                        Console.WriteLine("A pokračoval dveřmi na levo");
                                        Console.ReadKey();
                                        Console.WriteLine("Steve se rozhlížel ale nikdo tam nebyl tak ho napadlo co jít na nouzové schodiště že se dostane ven ");
                                        Console.ReadKey();
                                        Console.WriteLine("A když se dostal ke dveřim z nápisem 'NOUZOVÉ SCHOĎIŠTĚ' tak tam byly ještě jedny dveře a vedle toho cedule UníKOvÝ VýCHOd");
                                        Console.ReadKey();
                                        Console.WriteLine("Stisni N pro nouzové schodiště stiskni S pro uníkový východ");
                                        string u = Console.ReadKey().KeyChar.ToString();
                                        if (u == "n")                                         {
                                            Console.WriteLine("Steve se rozhodl jít na nouzové schodiště");

                                            Console.ReadKey();
                                            Console.WriteLine("Šel po schodech dolů až uviděl EXIT");
                                            Console.ReadKey();
                                            Console.WriteLine("Steve vstoupil do dveří exit a uviděl");
                                            Console.ReadKey();
                                            Console.WriteLine("Tlačítko zabít vypravěče");
                                            Console.ReadKey();
                                            Console.WriteLine("Steve tlačítko ignoroval a šel dál");
                                            Console.ReadKey();
                                            Console.WriteLine("Pro stisknutí tlačítka zmačkni k pro ignorovaní zmačkni i");
                                            Console.ReadKey();
                                            string v = Console.ReadKey().KeyChar.ToString();
                                            if (v == "k")
                                            {
                                                Console.WriteLine("STEVE NEEE€€€€€|||||");
                                                Console.ReadKey();
                                                Console.WriteLine("AHHHH STEVE TO MĚL BÝT JINÝ ENDIŁG[[][[]]");
                                                Console.ReadKey();
                                                Console.WriteLine("Stiskni libovolné tlačítko");
                                                Console.ReadKey();
                                                Console.WriteLine("Sad Ending");
                                                Console.ReadKey();
                                                Console.WriteLine("Ending 6 [5]");
                                                Console.ReadKey();
                                                goto Start;

                                            }
                                            else if (v == "i")
                                            {
                                                Console.WriteLine("Steve ignoroval tlačítko a šel dál");
                                                Console.ReadKey();
                                                Console.WriteLine("A uviděl dveře EXIT");
                                                Console.ReadKey();
                                                Console.WriteLine("Steve vstoupil do dveří ale neuviděl exit ale místnost plnou obrazovek na stevovu kancelář ");
                                                Console.ReadKey();
                                                Console.WriteLine("Steve byl zděšen když viděl toto");
                                                Console.ReadKey();
                                                Console.WriteLine("A uvědomil si že je jenom ve hře a naplň jeho života je jenom být ovládán hračem");
                                                Console.ReadKey();
                                                Console.WriteLine("Stiskni libovolné tlačítko");
                                                Console.ReadKey();
                                                Console.WriteLine("Uvědomnění ending ");
                                                Console.ReadKey();
                                                Console.WriteLine("Ending 7 [2]");
                                                Console.ReadKey();
                                                goto Start;

                                            }

                                        }
                                        else if (u == "s")
                                        {
                                             
                                                    Console.WriteLine("Steve se rozhodl jít únikovým východem");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Začal sprintovat ke konci");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Už viděl světlo na konci tunelu");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Když se dostal za světlem tak tam byla malá místnost");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Vypadalo to jako nějaká recepce");
                                                     Console.ReadKey();
                                                    Console.WriteLine("A byly tam také dveře z nápisem Uníkový východ ");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Steve bez váhaní vstoupil do nich");
                                                     Console.ReadKey();
                                                    Console.WriteLine("A ocitl se uprostřed nekonečbé poustě");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Steve byl překvapený že celá budova je v poušti");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Rozhodnul se jít na sever");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Šel hodiny dny týdny a nic nenašel");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Steve už začal být v depresích");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Říkal si kdy už to skončí ");
                                                     Console.ReadKey();
                                                    Console.WriteLine("A když uviděl ty samé dveře ze kterých vyšel skoncoval s tím ");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Depression ending");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Ending 9 [9]");
                                                     Console.ReadKey();
                                                    goto Start;
                                        }

                                    }
                                    else if (door.Key == ConsoleKey.R)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Steve se rozhodl jít dveřmi napravo.");
                                        Console.ReadKey();
                                        Console.WriteLine("Asi proto že ho rodiče nenaučili rozpoznávat strany");
                                        Console.ReadKey();
                                        Console.WriteLine("Steve asi sme vkročili do tohoto příběhu špatnou nohou ja chci jenom aby jsi získal ending jenom tohle");
                                        Console.ReadKey();
                                        Console.WriteLine("stiskni enter pro pokračování");
                                        ConsoleKeyInfo enterkey8 = Console.ReadKey();
                                        if (enterkey8.Key == ConsoleKey.Enter)
                                        {
                                            Console.WriteLine("Pokračování v příběhu....");
                                            Console.WriteLine("");
                                            Console.WriteLine("Dobře Steve napiš Ahoj.");
                                            Console.WriteLine("");
                                            Console.WriteLine("Napiš 'ahoj' pro pokračování...");

                                            string vstup = Console.ReadLine() ?? string.Empty;

                                            if (vstup.ToLower() == "ahoj")
                                            {
                                                Console.WriteLine("No vidíš umíš poslouchat.");
                                                Console.ReadKey();
                                                Console.WriteLine("Steve tak uvidíme kde je problém");
                                                Console.ReadKey();
                                                Console.WriteLine("Když Steve došel na konec místnosti tak se otočil a vrátil zpět");
                                                Console.WriteLine("");
                                                Console.ReadKey();
                                                Console.WriteLine("Pokud se chceš otočit tak stiskni 'o' pokud chceš narazit do stěny stiskni 'm");
                                                string Door = Console.ReadKey().KeyChar.ToString();
                                                if (Door == "o")
                                                {
                                                    Console.WriteLine("Když se Steve vracel zpět uvidel otevřené dveře");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Stiskni 1 aby jsi šel do otevřených dveří");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Stiskni 2 aby jsi pokračoval v cestě");
                                                    string wt = Console.ReadKey().KeyChar.ToString();
                                                    if (wt == "1")
                                                    {
                                                        Console.WriteLine("Steve vstoupil do otevřených dveří.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve proč jsi do těch dveří vstoupil?");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Víš o tom že je toto jenom textová verze hry");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Dobře kvůli tobě se musím kouknout znovu do scenáře");
                                                        Console.ReadKey();
                                                        Console.WriteLine("jo tady to je když steve vešel do otevřených dveří tak se před ním otevřela brána s názvem DELETE");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Když steve do brány vstoupil tak se objevili dvě tlačítka");
                                                        Console.ReadKey();
                                                        Console.WriteLine("DELETE a KEEP");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve nevěděl co ty tlačítka znamenají");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Takže Steve zmačknul tlačítko DELETE");
                                                        Console.ReadKey();
                                                        Console.WriteLine("DELETE 1 | KEEP 2");
                                                        string del = Console.ReadKey().KeyChar.ToString();
                                                        if (del == "1")
                                                        {
                                                            Console.WriteLine("Steve já jsem myslel že to neuděláš");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Těch pár minut co jsme spolu zažili sice jsi odmítal příběh ale............");
                                                            Console.ReadKey();
                                                            Console.WriteLine("s̶̜̞̟̩͚̞̖̓̉̓́͋̓͝e̴̢̡̡̟̥̗̫̹̹͖̺͚̦̎̑̂̎̂̿́́̾̔̕͠d̷̩͓̗͉̼̺͓͔̫͈͖̈́̃t̷͓͔̻̲̼̥̬͓̲̦̞̬̐̒͐͂d̴̡̧̘͈͇̟̫̟͔̞͚́͑̆̆̚͝s̴̡̨̢͎̣̱͎͍̣̺̺̅͆̉̀̕͠ͅf̴̛̰̹̠͕̙̘̰̬̱̳̹̠̋̑̄̓̽͆̀̿͝g̵̢̺̩̻̋̔̎͐́́͂͗̈́̅̇͜͝f̷͇̤̻͓̭̟̙̤̏̆͛̀̐̾̓̓̂͗́̄͠d̵͎̠̙̱̤̻̜̦̬͒̎̉̂̓̂̋̅͊̈̕͘");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Delete ending");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Ending 5 [4]");
                                                            Console.ReadKey();
                                                            goto Start;
                                                        }
                                                        else if (del == "2")
                                                        {
                                                            Console.WriteLine("Steve ty mě neposloucháš měl jsi mě vymazat ne nechat");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Dobře když chceš jenom ending ");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Tady máš You WON ending");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Ending 2 [7]");
                                                            Console.ReadKey();
                                                            goto Start;

                                                        }

                                                    }
                                                    else if (wt == "2")
                                                    {
                                                        Console.WriteLine("Steve se rozhodl pokračovat dál.");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Až se dostal zpátky ke dveřim ze kterých vešel");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Rozhodl se že půjde dál až ke svojí kanceláří");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Ale kancelář byla zamknutá ale místo toho byly otevřeny jiné dveře");

                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve vstoupil dovnitř až najednou uviděl lidi");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve byl nadšený a chtěl jít za nimi");
                                                        Console.ReadKey();
                                                        Console.WriteLine("A šel viděl tu oblohu a ten čistý vzduch a Steve byl štastný");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                        Console.ReadKey();
                                                        Console.WriteLine("True good ending");
                                                        Console.WriteLine("Ending 10 [2]");
                                                        goto Start;


                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Hele našel jsi secret ale specialní secret.");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Najednou se před Stevem otevřel portál");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();

                                                        Console.WriteLine("Vypravěč: Stanley vešel do dveří na levo");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("'Otevře se portál'");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Vypravěč:STANLEY VIDÍŠ TO????");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve asi jsme se dostali do Stanley parable");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Vypravěč:KDO TO BYL?");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Já jsem vypravěč you are Steve");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Vypravěč:Stanley utíkej toto je viruuuuuuus");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Steve počkej kouknu se do scénáře ehm...");
                                                        Console.ReadKey();
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Jo dobře teď by jsme měli bežet za nima ");
                                                        Console.ReadKey();
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Klikni b pro běh a klikni s pro stání");
                                                        string c1 = Console.ReadKey().KeyChar.ToString();
                                                        if (c1 == "b")
                                                        {
                                                            Console.WriteLine("Steve rychle musime je chytit!.");
                                                        }
                                                        else if (c1 == "s")
                                                        {
                                                            Console.WriteLine("Steve proč stojíš to není ve scenáři.");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Sakra Steve corruptuje se mapa! ");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("N̵̢̡̢͓̰͉̠̞̝̙͕͉̩͇̗̯̤̫̠̰̲̋́̄̈́̽̀̉̕̕̕͜͝͝ͅę̷̡̡̭͉͕̪̫̗̘͇̮̭̼͓͇̳̓̿͒̃̾̅̈́̚ͅͅͅe̶̡̜̭̱͍͍̤͓̘̝̥͉͕͍̩̹͉̙̳̟̘̓̎͗̀̾̀̌̑̆̍͒̆̅͗̉̑͗͛̓̐̔͒̾̊͘͝͝ę̸̛̛̣̘̟̩̪̺͉͉̖̝͍̹̲̯̦͍̘̳̫͙̎́̈́̊͋̓̍̏̀̊̋̈́̉͂͜͝͝͝͝e̸̡̬̫̯̳͎̼̽̾̏̏̂͗̄̍͆͗̓̊̈́̽̇̏̈͝ͅȩ̵̠̥̙̺͚̪̖͔̯͎̘̮͍̣͇̳̜̙͕͖̫̺͒͊̏̃͌͛́̄͊̎̾͊̒́̅͆͝ͅe̵̢̡̢̱͉͈͉͚̙̖͓̹̼͙̣̦̺̼̱͋̾̿͆͜͠͠ȩ̶͕͍͖̼̫̣͓͙͚̫̩̥̖͈͍̟͊̽̋̉̅͜ͅe̷̛̲̪͙̲̙̲̯̲͆̌̓̌̒̊͂͝ͅḛ̷̢̧̞̱̬̤͍̥̲̩̔͆̀͗̓̈͑̑̉́̈̊͑̾͘͜ͅę̴̡̢̺̞͚̻̮̞̰̦̖̘̞̠̯̜͎͍̘̲̬͔̜͐̈́̊͒̚e̴̢̱͓̰͖̰͖͊̂̃́̚͝ ̵̨̡̡̝̪͇͍̹̰͕̘̣̰̣̫̣̼̲̭͇̟͍͔̫̻̒̔͛̐͊͠ͅͅͅS̵̖͇͗͆́̆̈́͂͂̄̂̀̏̈̎̃̅͗̇̚̕͝͝͝͝͝͝T̵̡͎̫̮̞̰͙̦̞͇̱͈͖̰͎͕̤͇̙̘͊̀̑̐̔̾͋̓͑͊̃̏̅̔͘͜͝Ȩ̴̧̧̛̗̤̭̘͕̓͋̿̌͌̂͑͝Ṽ̵̧̞̱͍̞̩̜̗̞͙̰͍̰̗̀́͑́͜͜ͅE̵̡̳̖̣̲̝͍̗͚͕͕̲̯̩̬̣͍͚̲̮̲̼̺̙͐̌́̀̏̎̊̔̚̕͜͜E̴͎̹͇͌̕Ę̷̖̩̜̯̲̗̙̤̟̥̥͚͕̻̟̙̹̪̈́̐͂̌Ę̶̡̢̞̤̱̩̗̱̯̗̖̜̙̙͈̠̣̮̲̜̹̿̂̎͑̆̀̾̂͂̀̏̉̾̚ͅE̶̥̘̠͖̗̗̠͝Ȩ̴̣̜̬͖̼̩̓͆͛̂̀̈̌̚̕̕͠͝");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Stiskni tlačítko pro pokračováni");
                                                            Console.ReadKey();
                                                            Console.WriteLine();
                                                        Stanleyparableending:
                                                            Console.WriteLine("Stanley Parable");
                                                            Console.WriteLine("Press 1 to start");
                                                            Console.WriteLine("Press 2 for settings");
                                                            Console.WriteLine("Press 3 for epiloque");
                                                            Console.WriteLine("Press 4 to Quit");
                                                            string stanley = Console.ReadKey().KeyChar.ToString();
                                                            if (stanley == "1")
                                                            {
                                                                Console.WriteLine("Y̶̰͐Ó̶͍Ụ̷̏͜ ̶̭̇A̷̢̛̅Ṙ̶̹Ė̸̘̱ ̶̩̇̕Ń̸̦̱̚O̸̥͎̍T̷̟͝ ̵̰͌͠Ş̸͚́̕T̶̡̈͆Ä̶̹N̴͖̋L̸̡͔̈́̐E̷̪̊̀Y̴̤̳̓");
                                                                goto Stanleyparableending;
                                                            }
                                                            else if (stanley == "2")
                                                            {
                                                                Console.WriteLine("Y̶͍͛̀ͅO̴͓̺͐̓Ȗ̶͔̯͆ ̸̼̹̑̽Ḥ̷̍Ǎ̷̻̩̾V̷̥͓̈Ẹ̴̍ͅ ̸͈̬̏N̸̡̈́O̷̱̺̒͒T̴̝͗͒Ḧ̶͓͖I̷͔̠͛N̵͕͆̇G̶̤̦͐ ̷͓̱̒T̴̤̞̎O̵̘̫̊ ̷̼̖̎Ḍ̴̡͝O̷͙͖̔͋ ̶̱̈̍I̸̠̩̋N̴͎̂̏ ̴̰̞̈́̕S̴͍̒E̴͍̕T̴̥̿T̶͓͇̽̂Ḭ̸͘ͅN̶͋͝ͅG̵̳̓Š̷̘̈́");
                                                                goto Stanleyparableending;
                                                            }
                                                            else if (stanley == "3")
                                                            {
                                                                Console.WriteLine("E̸̪̯̓P̴͍͗Ĭ̷̛̦̫L̷̳̤͗̓O̶̯̓̉Q̴̼̘̑U̷͚̓E̷̝̬͌ ̷̩̰̍N̶̲̲͒̕Ò̵̘̑ ̶͍̪̿͋Y̵̳̯͐Ȍ̵͎̉U̶̦̿ͅ ̴̰̤͠͠A̴̛̱̾R̸͖͂̒E̴̲̻̿̈́ ̵͓̚N̷̡̡̒̑O̵͕̲̅̽Ṭ̴̃ ̷̬̄S̴͖̪̒͑T̴̖̑A̶̬͉̍N̶̡̦͆̈́L̶̦̈́̋Ẹ̷̋͝Y̷̰͒");
                                                                goto Stanleyparableending;
                                                            }
                                                            else if (stanley == "4")
                                                            {
                                                                Console.WriteLine("H̸̡̧̨̟̩̟̙̮͉͉̹̝̊͆̄̌̓̍̽̒̌̅͂̎̐̈͂͗̒̒̍́̈̂͒͗̂͐̋̈́͊̔̀͋̚͝͝͝͠͠G̷̜̪̮͍͎̹̦̺̣͎̤̬͍̲̣̜̖̟͕͚̔͌͌̈͑̈͛̾͌̆̉̂͒͋͒̃̆̒͘̚͝͝͝͠͝͝ͅF̶̢̣͆̿́̄̔́̓́̀̔̓̊̽̀̐̆̈̈́̓̃̉́̒̏͘͘͠͠͠Í̷̧̨̢̡̨̭̦͖̥̗̫͈̼̺͈̫͕͈̪͙̠͍̪͔̬̹͉͆̈́͋̇̃͂ͅA̷̡̢̡̛̯̳̰͎̻͈̞̘̩̫̯̱͕͈̙̟̙͉̥̘̳̯͍̞̺̦̥̙͍̦͙͚͉̱͉̹̬̝̚͜͝G̴̨̡̢̢̢̘̥̬̟̞̥͉̼̺̹̥̣̫̟̦͚̮̯̖͎̙̙̻̼̫̰̰̰̗̬̺̫͉͓͔̲̜̔̀̆̃͆́͐̒̾͒̈̄̔̎̀̃̋͋̈̇̈́̑͐͗̒̕͜͜͜b̷̧̡̡̛̖͍͓̥̟̞̹͉̙̯̳̖̮̠͍̠̬̉͗͒͒͛̇̏͗̀̇́̍͐̔͊͛͒́͌̓͑͂̈̑͂̈́̎̀̽̒̀́̑̚͠͠Ą̸̢̨̢̛̱̙͔̱̰̘̮̥̭̦̭͍̖̝̭̫̠̥͙̜̤̮̮͍̻͎͈͔̦̼͕̟̙̪̩̫̯̩͎͓̎͊͌̊̎̀͛̾͋̏̍̈̏́ͅi̸̧̨̨̨̧̡̨̨̛̛̭̲̮̗͉̜͇̯͉̱͚̹͍̙̮͈͚̰̙̲̙̭̥͙̯̤̲̞̱̻̞̳͈͚̯̅̇̑̒̋̽͐̊̓̌̂͑̂͐͐͒̃̈́̆̋̈́̏̏̊̾̑̂̽̈́̿̓̋̂͐́͘͜͝͝͝ͅͅų̷̯͙͕̤͙̳̦͉̠̠̹͆̀̽̇̃̽̓̈́̑̉͛̋̀̆̑́̐͛̑̀̏͊̄͘̕̚̚͘͘v̸̨̢̢̟̣̰̫͉̻̲͉̩͙̜̮̙̻̱̖̺͚̭̮͎̦̠͕͔̺͉͚̯͓͙̗̼̜͔́͛̒͑́̈͌͒̇̓̽͌͛̔̈͗̀̀͗̄̇̌̍̃͗̎̃͑̓͋̽̉̂̈̓̊͒̍͐̐̈͆͂͋̕̚ͅğ̸̨̧̨͖̟̖̲͎̣͔̪̘͙̭̘̰͙̙̞͕̘͔̖̫̞̣̺̣͈̼̹͉̹͚̲͉̪̄̔̊̃̈́̏͛̍͒́͋̊̅̌̾̈́͂͛̐͐͛̾̉̉͊̽̕̚͝͝I̵̧̧̡̧̢̛͔̲̰͔͔̣̖̦̞̗̭̬̮̬̰̹̭͓̥̥͕̻̪͇̘̥̠̪̔̽̂̒̓̉̈́̇̈́̾̇͊͛̃͐̾̋͂́͋̀̓̄̊̈́̎̀̃̆́̐̊̓͑̐͒̀͊̚͜͠͠ͅJ̶̡̧̛̦̯̳̙͓̠̫͎͎͕͚̙͇̬̙̲̑̾̀̅̀̃̾͛̓̑̇̏̚");
                                                                Console.ReadKey();
                                                                goto ending4;
                                                            }
                                                        ending4:;
                                                            Console.WriteLine("Počkat ty nejsi stanleyȳ̷̡͕̣͔̼̮̫̻͆̀̚ȳ̷̡͕̣͆̀̚ȳ̷̡͕̣͔̼̮͆̀̚");
                                                            Console.ReadKey();
                                                            Console.WriteLine("s̴̢̛̥̼̥̒͐̾̐̿͠d̵̛͔͕̦͓̘̚d̸̥͓̼̙͒͂̈͆͐̾͝g̴̨̟̲̑");
                                                            Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Stanley parable mindf*ck ending");
                                                            Console.WriteLine("ending 4 [1]");
                                                            Console.ReadKey();
                                                            goto Start;













                                                        }
                                                    }
                                                }
                                                else if (Door == "m")
                                                {
                                                    Console.WriteLine("Steve co to sakra ta zeď je průchozí");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Žlutá místnost okay?!?");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Zkus se vrátit zpět Steve");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Steve nejde to?");
                                                    Console.ReadKey();
                                                    Console.WriteLine("STEVE NĚCO SE TAM POHLO ");
                                                    Console.ReadKey();
                                                    Console.WriteLine("SAKRA STEVEEE");
                                                    Console.ReadKey();
                                                    Console.WriteLine("A entita 3 se rozběhla na něho");
                                                    Console.ReadKey();
                                                    Console.WriteLine("A steva zabila");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Backrooms ending");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Ending 8 [5]");
                                                    Console.ReadKey();
                                                    goto Start;
                                                }















                                            }
                                            else
                                            {

                                                Console.WriteLine("Dobře tak když mě ani neposloucháš tak proč bych měl poslouchat tebe? ale vlastně je to můj příběh ne tvůj");
                                                Console.WriteLine("Stiskni jakékoliv tlačítko");
                                                Console.ReadKey();
                                            Fakestart:
                                                Console.WriteLine("You are STEVE");
                                                Console.WriteLine("Press 1 to start");
                                                Console.WriteLine("Press 2 for ending code");
                                                Console.WriteLine("Press 3 for tutorial");
                                                string B1 = Console.ReadKey().KeyChar.ToString();
                                                if (B1 == "1")
                                                {
                                                    Console.WriteLine("Press something for Česky");
                                                    Console.ReadKey();
                                                    Console.WriteLine();
                                                    Console.WriteLine("Vidím že jsi zpátky");
                                                    Console.ReadKey();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Mám pro tebe překvapení HAHAHA");
                                                    Console.ReadKey();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("A to překvapení je krutá pravda");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Steve celou dobu jsi byl jenom a jenom šílenec");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("To že nikdo nebyl v budově byla jenom tvoje chyba");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Celé město se evakuavalo jenom kvůli tobě ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Protože ty a jenom ty jsi tlačitkem odbouchnul celé město a ty jsi v něm zůstal");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Chápeš to Steve? Jsi celou dobu mrtvý");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("A já? ja jsem jenom zbytek tvého rozumu ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("Stiskni libovolné tlačítko");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Krutá Realita ending");
                                                    Console.WriteLine("Ending 3 [3]");
                                                    Console.ReadKey();
                                                    goto Start;
                                                }
                                                if (B1 == "2")
                                                {
                                                    Console.WriteLine("Stejně ten kód nemáš");
                                                    Console.ReadKey();
                                                    goto Fakestart;

                                                }
                                                if (B1 == "3")
                                                {
                                                    Console.WriteLine("Na co ti je tutorial?");
                                                    Console.ReadKey();
                                                    goto Fakestart;

                                                }

                                            }
                                        }
                                    }
                                }
                                i3 = true;
                                i2 = true;
                                i = true;
                            }
                            else
                            {
                                Console.WriteLine("Dobře jak chceš. Chceš Ending tak ho máš mít Stiskni jakékoliv tlačítko.");
                                Console.WriteLine("");
                                Console.ReadKey();
                                Console.WriteLine("Steve se snažil vstoupit do zdi zkoušel to hodiny až se mu to povedlo a myslel si že zničil hru ale když uslyšel...");
                                Console.WriteLine(""); Console.ReadKey();
                                Console.WriteLine("Zasloužil jsi si to Špatné tlačítko ending");
                                Console.WriteLine("");
                                Console.WriteLine("Ending 1 [8]");
                                Console.WriteLine("Stiskni libovolné tlačítko pro pokračování");
                                Console.ReadKey();
                                goto Start;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vážně?!? to se ti nepovede mě jen tak přelstít kvůli endingu, musíš stisknout enter pro pokračování příběhu.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Já vím, o co se snažíš, získat jen tak ending, ale to se ti nepovede. Musíš kliknout enter pro pokračování příběhu.\n");
            }
        }
    }
    else if (A4 == "3")
    {
        JapaneseStoryStart:
        Console.WriteLine("日本語を選択しました");
        Console.WriteLine("翻訳はAIの支援を使用して作成されました。");
        bool jp_i = false;
        while (!jp_i)
        {
            Console.WriteLine("これはスティーブという、ごく普通の男の物語です。彼は普通に働き、普通に買い物をし、普通に暮らしています。");
            Console.WriteLine("続けるにはEnterキーを押してください");

            ConsoleKeyInfo jp_enterKey = Console.ReadKey();
            Console.WriteLine();

            if (jp_enterKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("物語を続けます...");
                bool jp_i2 = false;
                while (!jp_i2)
                {
                    Console.WriteLine("しばらく客が来なかったので、彼は椅子から立ち上がり、建物の中に誰かいるのか見に行きました。");
                    Console.WriteLine("続けるにはEnterキーを押してください");

                    jp_enterKey = Console.ReadKey();
                    Console.WriteLine();

                    if (jp_enterKey.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("物語を続けます...");
                        bool jp_i3 = false;
                        while (!jp_i3)
                        {
                            Console.WriteLine("ドアを開けると誰もいませんでした。まるで警報が鳴って全員が避難したかのようです。");
                            Console.WriteLine("続けるにはEnterキーを押してください");

                            ConsoleKeyInfo jp_enterKey6 = Console.ReadKey();

                            if (jp_enterKey6.Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("物語を続けます...");

                                Console.WriteLine("そして、2つのドアがある部屋に入りました。");

                                Console.WriteLine("続けるにはEnterキーを押してください");
                                ConsoleKeyInfo jp_enterkey7 = Console.ReadKey();
                                if (jp_enterkey7.Key == ConsoleKey.Enter)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("そしてスティーブは左のドアに入りました");
                                    Console.WriteLine("");
                                    Console.WriteLine("右のドアはR、左のドアはLを押してください");
                                    ConsoleKeyInfo jp_door = Console.ReadKey();
                                    if (jp_door.Key == ConsoleKey.L)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("物語を続けます....");
                                        Console.WriteLine("");
                                        Console.ReadKey();
                                        Console.WriteLine("そして左のドアを進みました");
                                        Console.ReadKey();
                                        Console.WriteLine("スティーブは周りを見ましたが誰もいません。非常階段なら外へ出られるかもしれないと思いました。");
                                        Console.ReadKey();
                                        Console.WriteLine("『非常階段』と書かれたドアの横には、もう1つ『非常口』と書かれたドアがありました。");
                                        Console.ReadKey();
                                        Console.WriteLine("非常階段はN、非常口はSを押してください");
                                        string jp_u = Console.ReadKey().KeyChar.ToString();
                                        if (jp_u == "n")                                         {
                                            Console.WriteLine("スティーブは非常階段へ行くことにしました");

                                            Console.ReadKey();
                                            Console.WriteLine("階段を下りていくとEXITの表示が見えました");
                                            Console.ReadKey();
                                            Console.WriteLine("スティーブがEXITのドアに入ると、そこには");
                                            Console.ReadKey();
                                            Console.WriteLine("『ナレーターを殺す』ボタン");
                                            Console.ReadKey();
                                            Console.WriteLine("スティーブはボタンを無視して先へ進みました");
                                            Console.ReadKey();
                                            Console.WriteLine("ボタンを押すならK、無視するならIを押してください");
                                            Console.ReadKey();
                                            string jp_v = Console.ReadKey().KeyChar.ToString();
                                            if (jp_v == "k")
                                            {
                                                Console.WriteLine("スティーブ、やめろおお€€€€€|||||");
                                                Console.ReadKey();
                                                Console.WriteLine("あああスティーブ！そこは別のエンディングのはずだったのに[[][[]]");
                                                Console.ReadKey();
                                                Console.WriteLine("何かキーを押してください");
                                                Console.ReadKey();
                                                Console.WriteLine("Sad Ending");
                                                Console.ReadKey();
                                                Console.WriteLine("Ending 6 [5]");
                                                Console.ReadKey();
                                                goto JapaneseStoryStart;

                                            }
                                            else if (jp_v == "i")
                                            {
                                                Console.WriteLine("Steve ignored the button and kept going");
                                                Console.ReadKey();
                                                Console.WriteLine("そしてEXITのドアを見つけました");
                                                Console.ReadKey();
                                                Console.WriteLine("ドアの先は出口ではなく、スティーブのオフィスを映す画面でいっぱいの部屋でした。");
                                                Console.ReadKey();
                                                Console.WriteLine("スティーブはその光景に恐怖しました");
                                                Console.ReadKey();
                                                Console.WriteLine("そして自分はゲームの中の存在で、人生の目的はプレイヤーに操作されることだけだと気づきました。");
                                                Console.ReadKey();
                                                Console.WriteLine("何かキーを押してください");
                                                Console.ReadKey();
                                                Console.WriteLine("真実に気づくエンディング");
                                                Console.ReadKey();
                                                Console.WriteLine("Ending 7 [2]");
                                                Console.ReadKey();
                                                goto JapaneseStoryStart;

                                            }

                                        }
                                        else if (jp_u == "s")
                                        {
                                             
                                                    Console.WriteLine("スティーブは非常口へ行くことにしました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("彼は出口へ向かって全力で走りました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("トンネルの先に光が見えました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("光の先には小さな部屋がありました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("受付のような場所でした");
                                                     Console.ReadKey();
                                                    Console.WriteLine("そこには『非常口』と書かれたドアもありました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("スティーブは迷わず中へ入りました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("すると果てしない砂漠の真ん中に出ました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("建物全体が砂漠にあることにスティーブは驚きました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("彼は北へ進むことにしました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("何時間、何日、何週間歩いても何も見つかりませんでした");
                                                     Console.ReadKey();
                                                    Console.WriteLine("スティーブは絶望し始めました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("いつ終わるのだろう、と彼は思いました");
                                                     Console.ReadKey();
                                                    Console.WriteLine("そして出てきたのと同じドアを見つけた時、彼はすべてを終わらせました。");
                                                     Console.ReadKey();
                                                    Console.WriteLine("何かキーを押してください");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Depression ending");
                                                     Console.ReadKey();
                                                    Console.WriteLine("Ending 9 [9]");
                                                     Console.ReadKey();
                                                    goto JapaneseStoryStart;
                                        }

                                    }
                                    else if (jp_door.Key == ConsoleKey.R)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("スティーブは右のドアへ行くことにしました。");
                                        Console.ReadKey();
                                        Console.WriteLine("たぶん両親が左右の違いを教えなかったのでしょう。");
                                        Console.ReadKey();
                                        Console.WriteLine("スティーブ、どうやら最初からうまくいかなかったようだ。私はただ君にエンディングを見てほしいだけなんだ。");
                                        Console.ReadKey();
                                        Console.WriteLine("続けるにはEnterキーを押してください");
                                        ConsoleKeyInfo jp_enterkey8 = Console.ReadKey();
                                        if (jp_enterkey8.Key == ConsoleKey.Enter)
                                        {
                                            Console.WriteLine("物語を続けます....");
                                            Console.WriteLine("");
                                            Console.WriteLine("よしスティーブ、『ahoj』と入力して。");
                                            Console.WriteLine("");
                                            Console.WriteLine("続けるには 'ahoj' と入力してください...");

                                            string jp_vstup = Console.ReadLine() ?? string.Empty;

                                            if (jp_vstup.ToLower() == "ahoj")
                                            {
                                                Console.WriteLine("ほら、ちゃんと話を聞けるじゃないか。");
                                                Console.ReadKey();
                                                Console.WriteLine("スティーブ、何が問題なのか見てみよう。");
                                                Console.ReadKey();
                                                Console.WriteLine("部屋の端まで行くと、スティーブは振り返って戻りました。");
                                                Console.WriteLine("");
                                                Console.ReadKey();
                                                Console.WriteLine("戻るなら'o'、壁に突っ込むなら'm'を押してください");
                                                string jp_Door = Console.ReadKey().KeyChar.ToString();
                                                if (jp_Door == "o")
                                                {
                                                    Console.WriteLine("戻る途中、スティーブは開いているドアを見つけました");
                                                    Console.ReadKey();
                                                    Console.WriteLine("開いているドアへ入るなら1を押してください");
                                                    Console.ReadKey();
                                                    Console.WriteLine("そのまま進むなら2を押してください");
                                                    string jp_wt = Console.ReadKey().KeyChar.ToString();
                                                    if (jp_wt == "1")
                                                    {
                                                        Console.WriteLine("スティーブは開いているドアに入りました。");
                                                        Console.ReadKey();
                                                        Console.WriteLine("スティーブ、なぜそのドアに入ったんだ？");
                                                        Console.ReadKey();
                                                        Console.WriteLine("これはゲームのテキスト版だけだって分かってるよね？");
                                                        Console.ReadKey();
                                                        Console.WriteLine("分かったよ。君のせいでまた台本を確認しないと。");
                                                        Console.ReadKey();
                                                        Console.WriteLine("あった。スティーブが開いたドアに入ると、『DELETE』というゲートが目の前に開いた。");
                                                        Console.ReadKey();
                                                        Console.WriteLine("ゲートに入ると2つのボタンが現れました");
                                                        Console.ReadKey();
                                                        Console.WriteLine("DELETE a KEEP");
                                                        Console.ReadKey();
                                                        Console.WriteLine("スティーブにはそのボタンの意味が分かりませんでした");
                                                        Console.ReadKey();
                                                        Console.WriteLine("そこでスティーブはDELETEボタンを押しました");
                                                        Console.ReadKey();
                                                        Console.WriteLine("DELETE 1 | KEEP 2");
                                                        string jp_del = Console.ReadKey().KeyChar.ToString();
                                                        if (jp_del == "1")
                                                        {
                                                            Console.WriteLine("スティーブ、まさか本当に押すとは思わなかった");
                                                            Console.ReadKey();
                                                            Console.WriteLine("一緒に過ごしたこの数分間、君は物語を拒み続けたけど............");
                                                            Console.ReadKey();
                                                            Console.WriteLine("s̶̜̞̟̩͚̞̖̓̉̓́͋̓͝e̴̢̡̡̟̥̗̫̹̹͖̺͚̦̎̑̂̎̂̿́́̾̔̕͠d̷̩͓̗͉̼̺͓͔̫͈͖̈́̃t̷͓͔̻̲̼̥̬͓̲̦̞̬̐̒͐͂d̴̡̧̘͈͇̟̫̟͔̞͚́͑̆̆̚͝s̴̡̨̢͎̣̱͎͍̣̺̺̅͆̉̀̕͠ͅf̴̛̰̹̠͕̙̘̰̬̱̳̹̠̋̑̄̓̽͆̀̿͝g̵̢̺̩̻̋̔̎͐́́͂͗̈́̅̇͜͝f̷͇̤̻͓̭̟̙̤̏̆͛̀̐̾̓̓̂͗́̄͠d̵͎̠̙̱̤̻̜̦̬͒̎̉̂̓̂̋̅͊̈̕͘");
                                                            Console.ReadKey();
                                                            Console.WriteLine("何かキーを押してください");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Delete ending");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Ending 5 [4]");
                                                            Console.ReadKey();
                                                            goto JapaneseStoryStart;
                                                        }
                                                        else if (jp_del == "2")
                                                        {
                                                            Console.WriteLine("スティーブ、話を聞いてないな。私を残すんじゃなくて削除するはずだったんだ。");
                                                            Console.ReadKey();
                                                            Console.WriteLine("分かった、エンディングだけ欲しいなら");
                                                            Console.ReadKey();
                                                            Console.WriteLine("何かキーを押してください");
                                                            Console.ReadKey();
                                                            Console.WriteLine("ほら、You WON endingだ");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Ending 2 [7]");
                                                            Console.ReadKey();
                                                            goto JapaneseStoryStart;

                                                        }

                                                    }
                                                    else if (jp_wt == "2")
                                                    {
                                                        Console.WriteLine("スティーブはそのまま進むことにしました。");
                                                        Console.ReadKey();
                                                        Console.WriteLine("そして最初に入ってきたドアまで戻りました");
                                                        Console.ReadKey();
                                                        Console.WriteLine("自分のオフィスまで進むことにしました");
                                                        Console.ReadKey();
                                                        Console.WriteLine("しかしオフィスは鍵がかかっていて、代わりに別のドアが開いていました");

                                                        Console.ReadKey();
                                                        Console.WriteLine("中に入ると突然、人々が見えました");
                                                        Console.ReadKey();
                                                        Console.WriteLine("スティーブは喜び、彼らのところへ行こうとしました");
                                                        Console.ReadKey();
                                                        Console.WriteLine("外へ出ると空と澄んだ空気があり、スティーブは幸せでした。");
                                                        Console.ReadKey();
                                                        Console.WriteLine("何かキーを押してください");
                                                        Console.ReadKey();
                                                        Console.WriteLine("True good ending");
                                                        Console.WriteLine("Ending 10 [2]");
                                                        goto JapaneseStoryStart;


                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("おい、秘密を見つけたな。それも特別な秘密だ。");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("突然スティーブの前にポータルが開きました");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();

                                                        Console.WriteLine("ナレーター：スタンリーは左のドアに入りました");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("『ポータルが開く』");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("ナレーター：スタンリー、あれが見えるか????");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("スティーブ、どうやらThe Stanley Parableに来てしまったようだ");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("ナレーター：今のは誰だ？");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("私はナレーター、君はスティーブだ");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("ナレーター：スタンリー、逃げろ！これはウイルスだああああ");
                                                        Console.WriteLine("");
                                                        Console.ReadKey();
                                                        Console.WriteLine("スティーブ、待って。台本を確認する、ええと...");
                                                        Console.ReadKey();
                                                        Console.WriteLine("");
                                                        Console.WriteLine("よし、今度は彼らを追いかけるんだ");
                                                        Console.ReadKey();
                                                        Console.WriteLine("");
                                                        Console.WriteLine("走るならB、止まるならSを押してください");
                                                        string jp_c1 = Console.ReadKey().KeyChar.ToString();
                                                        if (jp_c1 == "b")
                                                        {
                                                            Console.WriteLine("スティーブ、急げ！追いつかないと！");
                                                        }
                                                        else if (jp_c1 == "s")
                                                        {
                                                            Console.WriteLine("スティーブ、なぜ止まってる？台本にないぞ。");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("まずいスティーブ、マップが壊れていく！");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("N̵̢̡̢͓̰͉̠̞̝̙͕͉̩͇̗̯̤̫̠̰̲̋́̄̈́̽̀̉̕̕̕͜͝͝ͅę̷̡̡̭͉͕̪̫̗̘͇̮̭̼͓͇̳̓̿͒̃̾̅̈́̚ͅͅͅe̶̡̜̭̱͍͍̤͓̘̝̥͉͕͍̩̹͉̙̳̟̘̓̎͗̀̾̀̌̑̆̍͒̆̅͗̉̑͗͛̓̐̔͒̾̊͘͝͝ę̸̛̛̣̘̟̩̪̺͉͉̖̝͍̹̲̯̦͍̘̳̫͙̎́̈́̊͋̓̍̏̀̊̋̈́̉͂͜͝͝͝͝e̸̡̬̫̯̳͎̼̽̾̏̏̂͗̄̍͆͗̓̊̈́̽̇̏̈͝ͅȩ̵̠̥̙̺͚̪̖͔̯͎̘̮͍̣͇̳̜̙͕͖̫̺͒͊̏̃͌͛́̄͊̎̾͊̒́̅͆͝ͅe̵̢̡̢̱͉͈͉͚̙̖͓̹̼͙̣̦̺̼̱͋̾̿͆͜͠͠ȩ̶͕͍͖̼̫̣͓͙͚̫̩̥̖͈͍̟͊̽̋̉̅͜ͅe̷̛̲̪͙̲̙̲̯̲͆̌̓̌̒̊͂͝ͅḛ̷̢̧̞̱̬̤͍̥̲̩̔͆̀͗̓̈͑̑̉́̈̊͑̾͘͜ͅę̴̡̢̺̞͚̻̮̞̰̦̖̘̞̠̯̜͎͍̘̲̬͔̜͐̈́̊͒̚e̴̢̱͓̰͖̰͖͊̂̃́̚͝ ̵̨̡̡̝̪͇͍̹̰͕̘̣̰̣̫̣̼̲̭͇̟͍͔̫̻̒̔͛̐͊͠ͅͅͅS̵̖͇͗͆́̆̈́͂͂̄̂̀̏̈̎̃̅͗̇̚̕͝͝͝͝͝͝T̵̡͎̫̮̞̰͙̦̞͇̱͈͖̰͎͕̤͇̙̘͊̀̑̐̔̾͋̓͑͊̃̏̅̔͘͜͝Ȩ̴̧̧̛̗̤̭̘͕̓͋̿̌͌̂͑͝Ṽ̵̧̞̱͍̞̩̜̗̞͙̰͍̰̗̀́͑́͜͜ͅE̵̡̳̖̣̲̝͍̗͚͕͕̲̯̩̬̣͍͚̲̮̲̼̺̙͐̌́̀̏̎̊̔̚̕͜͜E̴͎̹͇͌̕Ę̷̖̩̜̯̲̗̙̤̟̥̥͚͕̻̟̙̹̪̈́̐͂̌Ę̶̡̢̞̤̱̩̗̱̯̗̖̜̙̙͈̠̣̮̲̜̹̿̂̎͑̆̀̾̂͂̀̏̉̾̚ͅE̶̥̘̠͖̗̗̠͝Ȩ̴̣̜̬͖̼̩̓͆͛̂̀̈̌̚̕̕͠͝");
                                                            Console.WriteLine("");
                                                            Console.ReadKey();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("続けるにはキーを押してください");
                                                            Console.ReadKey();
                                                            Console.WriteLine();
                                                        jp_Stanleyparableending:
                                                            Console.WriteLine("Stanley Parable");
                                                            Console.WriteLine("Press 1 to start");
                                                            Console.WriteLine("Press 2 for settings");
                                                            Console.WriteLine("Press 3 for epiloque");
                                                            Console.WriteLine("Press 4 to Quit");
                                                            string jp_stanley = Console.ReadKey().KeyChar.ToString();
                                                            if (jp_stanley == "1")
                                                            {
                                                                Console.WriteLine("Y̶̰͐Ó̶͍Ụ̷̏͜ ̶̭̇A̷̢̛̅Ṙ̶̹Ė̸̘̱ ̶̩̇̕Ń̸̦̱̚O̸̥͎̍T̷̟͝ ̵̰͌͠Ş̸͚́̕T̶̡̈͆Ä̶̹N̴͖̋L̸̡͔̈́̐E̷̪̊̀Y̴̤̳̓");
                                                                goto jp_Stanleyparableending;
                                                            }
                                                            else if (jp_stanley == "2")
                                                            {
                                                                Console.WriteLine("Y̶͍͛̀ͅO̴͓̺͐̓Ȗ̶͔̯͆ ̸̼̹̑̽Ḥ̷̍Ǎ̷̻̩̾V̷̥͓̈Ẹ̴̍ͅ ̸͈̬̏N̸̡̈́O̷̱̺̒͒T̴̝͗͒Ḧ̶͓͖I̷͔̠͛N̵͕͆̇G̶̤̦͐ ̷͓̱̒T̴̤̞̎O̵̘̫̊ ̷̼̖̎Ḍ̴̡͝O̷͙͖̔͋ ̶̱̈̍I̸̠̩̋N̴͎̂̏ ̴̰̞̈́̕S̴͍̒E̴͍̕T̴̥̿T̶͓͇̽̂Ḭ̸͘ͅN̶͋͝ͅG̵̳̓Š̷̘̈́");
                                                                goto jp_Stanleyparableending;
                                                            }
                                                            else if (jp_stanley == "3")
                                                            {
                                                                Console.WriteLine("E̸̪̯̓P̴͍͗Ĭ̷̛̦̫L̷̳̤͗̓O̶̯̓̉Q̴̼̘̑U̷͚̓E̷̝̬͌ ̷̩̰̍N̶̲̲͒̕Ò̵̘̑ ̶͍̪̿͋Y̵̳̯͐Ȍ̵͎̉U̶̦̿ͅ ̴̰̤͠͠A̴̛̱̾R̸͖͂̒E̴̲̻̿̈́ ̵͓̚N̷̡̡̒̑O̵͕̲̅̽Ṭ̴̃ ̷̬̄S̴͖̪̒͑T̴̖̑A̶̬͉̍N̶̡̦͆̈́L̶̦̈́̋Ẹ̷̋͝Y̷̰͒");
                                                                goto jp_Stanleyparableending;
                                                            }
                                                            else if (jp_stanley == "4")
                                                            {
                                                                Console.WriteLine("H̸̡̧̨̟̩̟̙̮͉͉̹̝̊͆̄̌̓̍̽̒̌̅͂̎̐̈͂͗̒̒̍́̈̂͒͗̂͐̋̈́͊̔̀͋̚͝͝͝͠͠G̷̜̪̮͍͎̹̦̺̣͎̤̬͍̲̣̜̖̟͕͚̔͌͌̈͑̈͛̾͌̆̉̂͒͋͒̃̆̒͘̚͝͝͝͠͝͝ͅF̶̢̣͆̿́̄̔́̓́̀̔̓̊̽̀̐̆̈̈́̓̃̉́̒̏͘͘͠͠͠Í̷̧̨̢̡̨̭̦͖̥̗̫͈̼̺͈̫͕͈̪͙̠͍̪͔̬̹͉͆̈́͋̇̃͂ͅA̷̡̢̡̛̯̳̰͎̻͈̞̘̩̫̯̱͕͈̙̟̙͉̥̘̳̯͍̞̺̦̥̙͍̦͙͚͉̱͉̹̬̝̚͜͝G̴̨̡̢̢̢̘̥̬̟̞̥͉̼̺̹̥̣̫̟̦͚̮̯̖͎̙̙̻̼̫̰̰̰̗̬̺̫͉͓͔̲̜̔̀̆̃͆́͐̒̾͒̈̄̔̎̀̃̋͋̈̇̈́̑͐͗̒̕͜͜͜b̷̧̡̡̛̖͍͓̥̟̞̹͉̙̯̳̖̮̠͍̠̬̉͗͒͒͛̇̏͗̀̇́̍͐̔͊͛͒́͌̓͑͂̈̑͂̈́̎̀̽̒̀́̑̚͠͠Ą̸̢̨̢̛̱̙͔̱̰̘̮̥̭̦̭͍̖̝̭̫̠̥͙̜̤̮̮͍̻͎͈͔̦̼͕̟̙̪̩̫̯̩͎͓̎͊͌̊̎̀͛̾͋̏̍̈̏́ͅjp_i̸̧̨̨̨̧̡̨̨̛̛̭̲̮̗͉̜͇̯͉̱͚̹͍̙̮͈͚̰̙̲̙̭̥͙̯̤̲̞̱̻̞̳͈͚̯̅̇̑̒̋̽͐̊̓̌̂͑̂͐͐͒̃̈́̆̋̈́̏̏̊̾̑̂̽̈́̿̓̋̂͐́͘͜͝͝͝ͅͅjp_ų̷̯͙͕̤͙̳̦͉̠̠̹͆̀̽̇̃̽̓̈́̑̉͛̋̀̆̑́̐͛̑̀̏͊̄͘̕̚̚͘͘jp_v̸̨̢̢̟̣̰̫͉̻̲͉̩͙̜̮̙̻̱̖̺͚̭̮͎̦̠͕͔̺͉͚̯͓͙̗̼̜͔́͛̒͑́̈͌͒̇̓̽͌͛̔̈͗̀̀͗̄̇̌̍̃͗̎̃͑̓͋̽̉̂̈̓̊͒̍͐̐̈͆͂͋̕̚ͅğ̸̨̧̨͖̟̖̲͎̣͔̪̘͙̭̘̰͙̙̞͕̘͔̖̫̞̣̺̣͈̼̹͉̹͚̲͉̪̄̔̊̃̈́̏͛̍͒́͋̊̅̌̾̈́͂͛̐͐͛̾̉̉͊̽̕̚͝͝I̵̧̧̡̧̢̛͔̲̰͔͔̣̖̦̞̗̭̬̮̬̰̹̭͓̥̥͕̻̪͇̘̥̠̪̔̽̂̒̓̉̈́̇̈́̾̇͊͛̃͐̾̋͂́͋̀̓̄̊̈́̎̀̃̆́̐̊̓͑̐͒̀͊̚͜͠͠ͅJ̶̡̧̛̦̯̳̙͓̠̫͎͎͕͚̙͇̬̙̲̑̾̀̅̀̃̾͛̓̑̇̏̚");
                                                                Console.ReadKey();
                                                                goto ending4;
                                                            }
                                                        ending4:;
                                                            Console.WriteLine("待て、お前はスタンリーじゃないȳ̷̡͕̣͔̼̮̫̻͆̀̚ȳ̷̡͕̣͆̀̚ȳ̷̡͕̣͔̼̮͆̀̚");
                                                            Console.ReadKey();
                                                            Console.WriteLine("s̴̢̛̥̼̥̒͐̾̐̿͠d̵̛͔͕̦͓̘̚d̸̥͓̼̙͒͂̈͆͐̾͝g̴̨̟̲̑");
                                                            Console.WriteLine("何かキーを押してください");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Stanley parable mindf*ck ending");
                                                            Console.WriteLine("ending 4 [1]");
                                                            Console.ReadKey();
                                                            goto JapaneseStoryStart;













                                                        }
                                                    }
                                                }
                                                else if (jp_Door == "m")
                                                {
                                                    Console.WriteLine("スティーブ、何だこれ？この壁は通り抜けられるぞ");
                                                    Console.ReadKey();
                                                    Console.WriteLine("黄色い部屋、だと?!?");
                                                    Console.ReadKey();
                                                    Console.WriteLine("戻ってみろ、スティーブ");
                                                    Console.ReadKey();
                                                    Console.WriteLine("スティーブ、戻れないのか？");
                                                    Console.ReadKey();
                                                    Console.WriteLine("スティーブ、何か動いたぞ！");
                                                    Console.ReadKey();
                                                    Console.WriteLine("くそっ、スティーブ！");
                                                    Console.ReadKey();
                                                    Console.WriteLine("そしてEntity 3が彼に向かって走り出しました");
                                                    Console.ReadKey();
                                                    Console.WriteLine("そしてスティーブを殺しました");
                                                    Console.ReadKey();
                                                    Console.WriteLine("何かキーを押してください");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Backrooms ending");
                                                    Console.ReadKey();
                                                    Console.WriteLine("Ending 8 [5]");
                                                    Console.ReadKey();
                                                    goto JapaneseStoryStart;
                                                }















                                            }
                                            else
                                            {

                                                Console.WriteLine("私の話を聞かないなら、なぜ私が君の話を聞く必要がある？そもそもこれは私の物語で、君の物語じゃない。");
                                                Console.WriteLine("何かキーを押してください");
                                                Console.ReadKey();
                                            jp_Fakestart:
                                                Console.WriteLine("You are STEVE");
                                                Console.WriteLine("Press 1 to start");
                                                Console.WriteLine("Press 2 for ending code");
                                                Console.WriteLine("Press 3 for tutorial");
                                                string jp_B1 = Console.ReadKey().KeyChar.ToString();
                                                if (jp_B1 == "1")
                                                {
                                                    Console.WriteLine("日本語を選ぶには何かキーを押してください");
                                                    Console.ReadKey();
                                                    Console.WriteLine();
                                                    Console.WriteLine("戻ってきたようだな");
                                                    Console.ReadKey();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("君にサプライズがある、ハハハ！");
                                                    Console.ReadKey();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("そのサプライズとは、残酷な真実だ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("スティーブ、君は最初からずっと狂っていたんだ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("建物に誰もいなかったのは全部君のせいだ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("街全体が避難したのも君のせいだ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("なぜなら君自身がボタンで街全体を吹き飛ばし、その中に残ったからだ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("分かるかスティーブ？君はずっと死んでいたんだ");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("そして私は？私は君に残った理性のかけらにすぎない");
                                                    Console.WriteLine(""); Console.ReadKey();
                                                    Console.WriteLine("何かキーを押してください");
                                                    Console.ReadKey();
                                                    Console.WriteLine("残酷な現実エンディング");
                                                    Console.WriteLine("Ending 3 [3]");
                                                    Console.ReadKey();
                                                    goto JapaneseStoryStart;
                                                }
                                                if (jp_B1 == "2")
                                                {
                                                    Console.WriteLine("どうせコードは持っていない");
                                                    Console.ReadKey();
                                                    goto jp_Fakestart;

                                                }
                                                if (jp_B1 == "3")
                                                {
                                                    Console.WriteLine("チュートリアルなんて何に使うんだ？");
                                                    Console.ReadKey();
                                                    goto jp_Fakestart;

                                                }

                                            }
                                        }
                                    }
                                }
                                jp_i3 = true;
                                jp_i2 = true;
                                jp_i = true;
                            }
                            else
                            {
                                Console.WriteLine("分かった、好きにしろ。エンディングが欲しいならくれてやる。何かキーを押せ。");
                                Console.WriteLine("");
                                Console.ReadKey();
                                Console.WriteLine("スティーブは何時間も壁に入ろうとし、ついに成功しました。ゲームを壊したと思ったその時、彼は聞きました...");
                                Console.WriteLine(""); Console.ReadKey();
                                Console.WriteLine("自業自得だ。Wrong Button ending");
                                Console.WriteLine("");
                                Console.WriteLine("Ending 1 [8]");
                                Console.WriteLine("続けるには何かキーを押してください");
                                Console.ReadKey();
                                goto JapaneseStoryStart;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("本気か?!? エンディングのために私を騙そうとしても無駄だ。物語を続けるにはEnterを押せ。\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("何を狙っているか分かっている。簡単にエンディングを取ろうとしても無駄だ。物語を続けるにはEnterを押せ。\n");
            }
        }
        }
    else
    {
        Console.WriteLine("Invalid selection. Please try again.");
        goto Start;
    }
}
else if (A1 == "2")
{
    Console.WriteLine("Write the code from endings and then press enter...");
    string endingCode = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Ending code entered: " + endingCode);
    if (endingCode.Length == 10 && endingCode.All(char.IsDigit) && endingCode == "8731452592")
    {
        Console.WriteLine("Select final speech language:");
        Console.WriteLine("Press 1 for English");
        Console.WriteLine("Press 2 for Česky");
        Console.WriteLine("Press 3 for 日本語");
        string A3 = Console.ReadKey().KeyChar.ToString();
        if (A3 == "1")
        {
            Console.WriteLine("Final speech in English");
            // Add English final speech logic here
            Console.WriteLine("Is this the end? i see you have seen every ending in this game and you have unlocked this the secret ending, thank you for playing my game and i hope you enjoyed it.And one more thing be prepared for the second game bye for now... if you want to restart write 'Dotnet run' in the terminal and press enter.");
        }
        else if (A3 == "2")
        {
            Console.WriteLine("Final speech in Česky");
            // Add Česky final speech logic here
            Console.WriteLine("Je to konec? Vidím, že jste viděli každý konec v této hře a odemkli jste tento tajný konec, děkuji, že jste si zahráli mou hru a doufám, že se vám líbila. A ještě jedna věc, připravte se na druhou hru, zatím sbohem... pokud se chcete restartovat, napište do terminálu 'Dotnet run' a stiskněte enter.");
        }
        else if (A3 == "3")
        {
            Console.WriteLine("Final speech in 日本語");
            // Add Japanese final speech logic here
            Console.WriteLine("これは終わりですか？このゲームのすべてのエンディングを見て、この秘密のエンディングをアンロックしたことがわかります。私のゲームをプレイしてくれてありがとう、楽しんでいただけたことを願っています。そしてもう一つ、2作目のゲームに備えてください。では、またね...再起動したい場合は、ターミナルに「Dotnet run」と入力してEnterキーを押してください。");
        }
        // Add logic to handle the ending code here
    }
    else if (endingCode.Length != 10 || !endingCode.All(char.IsDigit) || endingCode != "8731452592")
    {
        Console.WriteLine("Dont try to cheat the game, you will not get the secret ending if you do that. If you want to restart write 'Dotnet run' in the terminal and press enter.");
    }
}
else if (A1 == "3")
{
    Console.WriteLine("Showing tutorial...");
    Console.WriteLine("Select Language of tutorial");
    Console.WriteLine("Press 1 for English");
    Console.WriteLine("Press 2 for Česky");
    Console.WriteLine("Press 3 for 日本語");
    string A2 = Console.ReadKey().KeyChar.ToString();
    if (A2 == "1")
    {
        Console.WriteLine("Tutorial in English");
        // Add English tutorial logic here
        Console.WriteLine("Hi this is my first game i made all by myself.Every ending in this game is likely different and unique.Every ending has its own number and the number of which it is like (This is the First Ending [5]) First Ending equals to First Number second to second number etc... I will be adding more content to this game in the future so stay tuned for that. Thank you for playing my game.If you want to go back Press any button.");
        Console.ReadKey();
        goto Start;

    }
    else if (A2 == "2")
    {
        Console.WriteLine("Tutorial in Česky");
        // Add Česky tutorial logic here
        Console.WriteLine("Ahoj, toto je moje první hra, kterou jsem vytvořil sám. Každý konec v této hře je pravděpodobně odlišný a jedinečný. Každý konec má své vlastní číslo a číslo, které je jako (Toto je první konec [5]) První konec se rovná prvnímu číslu, druhý druhému číslu atd... V budoucnu budu do této hry přidávat více obsahu, takže zůstaňte naladěni na to. Děkuji, že jste si zahráli mou hru. Pokud se chcete vrátit zpět, Stisknete jakékoliv tlačítko.");
        Console.ReadKey();
        goto Start;
    }
    else if (A2 == "3")
    {
        Console.WriteLine("Tutorial in 日本語");
        // Add Japanese tutorial logic here
        Console.WriteLine("こんにちは、これは私が自分で作った最初のゲームです。このゲームのすべてのエンディングは、おそらく異なり、ユニークです。すべてのエンディングには独自の番号があり、それが（これは最初のエンディング[5]）のように番号付けされています。最初のエンディングは最初の番号に等しく、2番目は2番目の番号に等しいです...将来的には、このゲームにさらにコンテンツを追加する予定なので、それに注目してください。私のゲームをプレイしてくれてありがとう。 戻 戻るには、いずれかのボタンを押してください。");
        Console.ReadKey();
        goto Start;
    }
}
