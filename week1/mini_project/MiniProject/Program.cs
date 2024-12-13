namespace MiniProject;

class Program
{
    static void Main(string[] args)
    {
         
        while (true){

            Console.WriteLine("------------------------------------------------------\n"+
                            "Welcome. Please select from 1-4:\n"+
                            "1) Show all inventory\n"+
                            "2) Search inventory by make\n"+
                            "3) Show EV (Electric Vehicles) only\n"+
                            "4) Exit\n------------------------------------------------------");
            string? userInput = Console.ReadLine();


            //check if userInput is an integer
            if (int.TryParse(userInput, out int value))
            {
                switch (int.Parse(userInput))
            {
                case 1:  
                    foreach (Car c in DummyData.GetCars()){
                      Console.WriteLine(c);
                    }              
                break;

                case 2:
                    Console.WriteLine("Select car make (Toyota, Honda, Nissan, or Tesla)");
                    string? userInputMake = Console.ReadLine();
                    
                    if(userInputMake.ToLower().Equals("toyota")){
                         foreach (Car c in DummyData.GetCars()){
                         if(c.Make.Equals("Toyota")) Console.WriteLine(c);
                         } 
                    } else if(userInputMake.ToLower().Equals("honda")){
                        foreach (Car c in DummyData.GetCars()){
                         if(c.Make.Equals("Honda")) Console.WriteLine(c);
                         }
                    } else if(userInputMake.ToLower().Equals("nissan")){
                        foreach (Car c in DummyData.GetCars()){
                         if(c.Make.Equals("Nissan")) Console.WriteLine(c);
                         }
                    } else if(userInputMake.ToLower().Equals("tesla")){
                        foreach (Car c in DummyData.GetCars()){
                         if(c.Make.Equals("Tesla")) Console.WriteLine(c);
                         }
                    } else {
                        Console.WriteLine("Invalid input!");
                    }                    
                break;
              
                case 3:
                    foreach (Car c in DummyData.GetCars()){
                      if(c.Ev) Console.WriteLine(c);
                    } 
                break;

                case 4:
                Console.WriteLine("Thank you!");
                Environment.Exit(0);
                break;


                //invalid integer
                default:
                Console.WriteLine("Invalid input!");
                break;
            }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }



        }



        
    }
}
