using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Open_House
{
    class Realtor
    {
        public string Name { get; set; }

        public void Speak(string message)
        {
               Console.WriteLine(message);
        }


        public void WelcomeBuyer(Buyer newBuyer)
        {
            Speak("Welcome to the open house!");
            Speak("My name is " + Name + " and I will be showing you around the house today!");
            newBuyer.Name = GetResponseFromBuyer("What is your name?");
            Speak("It's nice to meet you, " + newBuyer.Name + ".");
        }

        public string GetResponseFromBuyer(string question)
        {
            Speak(question);
            string response = Console.ReadLine();
            return response;
        }
    

        public void SayGoodbyeToBuyer(Buyer buyer)
        {
            Speak("That concludes this open house.");
            Speak("Thank you for coming by today, " + buyer.Name + "!");
            Speak("Have a great day!");
        }

        public void ResponseFromLivingRoomAnswer(string answer)
        {
            string response = Console.ReadLine();
            string space = "Your kids will love the spaciousness!";
            string noKids = "That's too bad.";

            if(response.ToLower() == "yes" || response.ToLower() == "yeah" || response.ToLower() == "yea")
            {
                Speak(space);
            }
            else if(response.ToLower() == "no")
            {
                Speak(noKids);
            }
        }

        public void ResponseFromGarageAnswer(string answer)
        {
            string response = Console.ReadLine();
            string yesAnswer = "This house will be perfect for you, then!";
            string NoAnswer = "That's embarrassing...I do.";

            if(response.ToLower() == "yes" || response.ToLower() == "yeah" || response.ToLower() == "yea")
            {
                Speak(yesAnswer);
            }
            else
            {
                Speak(NoAnswer);
            }
        }

        public void ResponseFromBackyardAnswer(string answer)
        {
            string response = Console.ReadLine();
            string yesAnswer = "Your dogs will love all the land to play with!";
            string noAnswer = "You need some.";

            if(response.ToLower() == "yes" || response.ToLower() == "yeah" || response.ToLower() == "yea")
            {
                Speak(yesAnswer);
            }
            else
            {
                Speak(noAnswer);
            }
        }
    }
}
