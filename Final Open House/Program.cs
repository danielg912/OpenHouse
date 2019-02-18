using System;

namespace Final_Open_House
    {
    class Program
        {
        static void Main(string[] args)
        {
            Realtor realtor = new Realtor();
            realtor.Name = "Chip";

            Buyer buyer = new Buyer();

            Room livingRoom = new Room();
            livingRoom.Name = "Living Room";
            livingRoom.Description = "This living room is quite spacious. \nDo you have any kids?";

            Room kitchen = new Room();
            kitchen.Name = "Kitchen";
            kitchen.Description = "The kitchen is fairly small and you will need to purchase all necessary appliances.";

            Room masterBedroom = new Room();
            masterBedroom.Name = "Master bedroom";
            masterBedroom.Description = "This is where the magic happens!";

            Room garage = new Room();
            garage.Name = "Garage";
            garage.Description = "The garage has enough space to fit two cars. \nDo you work on your own cars?";

            Room backyard = new Room();
            backyard.Name = "Backyard";
            backyard.Description = "The backyard is massive with 5 acres of land! \nDo you have any dogs?";
                

            realtor.WelcomeBuyer(buyer);
            realtor.Speak("We'll start off with the living room.");
            realtor.Speak(livingRoom.Description);
            realtor.ResponseFromLivingRoomAnswer(livingRoom.Description);
            Console.ReadLine();

            realtor.Speak("Let's move on to the kitchen.");
            realtor.Speak(kitchen.Description);
            Console.ReadLine();
            realtor.Speak("Let's move on to the master bedroom.");

            realtor.Speak(masterBedroom.Description);
            Console.ReadLine();
            realtor.Speak("Sorry if that made you feel uncomfortable...");
            realtor.Speak("Let's move on to the garage...");
            Console.ReadLine();

            realtor.Speak(garage.Description);
            realtor.ResponseFromGarageAnswer(garage.Description);
            Console.ReadLine();

            realtor.Speak("Let's move on to the backyard.");
            realtor.Speak(backyard.Description);
            realtor.ResponseFromBackyardAnswer(backyard.Description);
            Console.ReadLine();

            realtor.SayGoodbyeToBuyer(buyer);

            Console.ReadLine();
        }
    }
}
