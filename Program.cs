using System;
using System.Collections.Generic;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Address Book";

            string userInput = "";
            bool enterAgain = false;
            string addressPath = @"C:\Users\schan\Documents\Web Development\Education\Grand Circus\Full Stack C# .NET Bootcamp\Notes Code\FileIOPractice\addressList.txt";
            

            do // Loop through the application logic if the user wants to enter indices again
            {
                FileHelper.BuildAddressList(addressPath);

                Console.WriteLine("Welcome to the address book. Please enter information to put into the address book.");
                Console.Write("Press enter to continue.");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Please enter first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Please enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Please enter street: ");
                string street = Console.ReadLine();
                Console.Write("Please enter city: ");
                string city = Console.ReadLine();
                Console.Write("Please enter state: ");
                string userInputstate = Console.ReadLine();
                Console.Write("Please enter zip code: ");
                int zip = int.Parse(Console.ReadLine());

                State state;
                // Checks the users input for state (whether the full state name or abreviation) and stores it into "state"
                switch (userInputstate.ToLower().Trim())
                {
                    case "alabama":
                    case "al":
                        state = State.AL;
                        break;
                    case "alaska":
                    case "ak":
                        state = State.AK;
                        break;
                    case "arizona":
                    case "az":
                        state = State.AZ;
                        break;
                    case "arkansas":
                    case "ar":
                        state = State.AR;
                        break;
                    case "calafornia":
                    case "ca":
                        state = State.CA;
                        break;
                    case "colorado":
                    case "co":
                        state = State.CO;
                        break;
                    case "conneticut":
                    case "ct":
                        state = State.CT;
                        break;
                    case "deleware":
                    case "de":
                        state = State.DE;
                        break;
                    case "district of columbia":
                    case "dc":
                        state = State.DC;
                        break;
                    case "florida":
                    case "fl":
                        state = State.FL;
                        break;
                    case "georgia":
                    case "ga":
                        state = State.GA;
                        break;
                    case "hawaii":
                    case "hi":
                        state = State.HI;
                        break;
                    case "idaho":
                    case "id":
                        state = State.ID;
                        break;
                    case "illinois":
                    case "il":
                        state = State.IL;
                        break;
                    case "indiana":
                    case "in":
                        state = State.IN;
                        break;
                    case "iowa":
                    case "ia":
                        state = State.IA;
                        break;
                    case "kansas":
                    case "ks":
                        state = State.KS;
                        break;
                    case "kentucky":
                    case "ky":
                        state = State.KY;
                        break;
                    case "louisiana":
                    case "la":
                        state = State.LA;
                        break;
                    case "maine":
                    case "me":
                        state = State.ME;
                        break;
                    case "maryland":
                    case "md":
                        state = State.MD;
                        break;
                    case "massachusetts":
                    case "ma":
                        state = State.MA;
                        break;
                    case "michigan":
                    case "mi":
                        state = State.MI;
                        break;
                    case "minnesota":
                    case "mn":
                        state = State.MN;
                        break;
                    case "mississippi":
                    case "ms":
                        state = State.MS;
                        break;
                    case "missouri":
                    case "mo":
                        state = State.MO;
                        break;
                    case "montana":
                    case "mt":
                        state = State.MT;
                        break;
                    case "nebraska":
                    case "ne":
                        state = State.NE;
                        break;
                    case "nevada":
                    case "nv":
                        state = State.NV;
                        break;
                    case "new hampshire":
                    case "nh":
                        state = State.NH;
                        break;
                    case "new jersey":
                    case "nj":
                        state = State.NJ;
                        break;
                    case "new mexico":
                    case "nm":
                        state = State.NM;
                        break;
                    case "new york":
                    case "ny":
                        state = State.NY;
                        break;
                    case "north carolina":
                    case "nc":
                        state = State.NC;
                        break;
                    case "north dakota":
                    case "nd":
                        state = State.ND;
                        break;
                    case "ohio":
                    case "oh":
                        state = State.OH;
                        break;
                    case "oklahoma":
                    case "ok":
                        state = State.OK;
                        break;
                    case "oregon":
                    case "or":
                        state = State.OR;
                        break;
                    case "pennsylvania":
                    case "pa":
                        state = State.PA;
                        break;
                    case "rhode island":
                    case "ri":
                        state = State.RI;
                        break;
                    case "south carolina":
                    case "sc":
                        state = State.SC;
                        break;
                    case "south dakota":
                    case "sd":
                        state = State.SD;
                        break;
                    case "tennessee":
                    case "tn":
                        state = State.TN;
                        break;
                    case "texas":
                    case "tx":
                        state = State.TX;
                        break;
                    case "utah":
                    case "ut":
                        state = State.UT;
                        break;
                    case "vermont":
                    case "vt":
                        state = State.VT;
                        break;
                    case "virginia":
                    case "va":
                        state = State.VA;
                        break;
                    case "washington":
                    case "wa":
                        state = State.WA;
                        break;
                    case "west virginia":
                    case "wv":
                        state = State.WV;
                        break;
                    case "wisconsin":
                    case "wi":
                        state = State.WI;
                        break;
                    case "wyoming":
                    case "wy":
                        state = State.WY;
                        break;
                    default:
                        state = State.Invalid;
                        break;
                }

                // Creates a person object with the given information
                Person person = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Street = street,
                    City = city,
                    State = state,
                    Zip = zip
                };

                // Adds the created person to the file.
                FileHelper.AddPersonToFile(addressPath, person);

                string continueInput = "";
                do // Loop for determining if the user wants to continue
                {
                    // Ask the user if they would like to continue
                    Console.Write("Continue (y/n)? ");
                    userInput = Console.ReadLine();
                    continueInput = userInput;
                    if (continueInput.ToLower().Trim() == "y")
                    {
                        enterAgain = true;
                    }
                    else if (continueInput.ToLower().Trim() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        goto Exit;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input.");
                        continue;
                    }
                } while (continueInput.ToLower().Trim() != "y");
                Console.Clear();


            } while (enterAgain == true);

        Exit:

            Console.ReadKey();
        }
    }
}
