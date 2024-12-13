namespace MiniProject;

class Program
{
    static void Main(string[] args)
    {
         
        // foreach (Car c in DummyData.GetCars()){
        //     Console.WriteLine(c);
        // }

        while (true){

            Console.WriteLine("------------------------------------------------------\n"+
                            "Welcome. Please select from 1-6:\n"+
                            "1) Show all inventory\n"+
                            "2) Search inventory by make\n"+
                            "3) Search inventory by model\n"+
                            "4) Search inventory by year\n"+
                            "5) Show EV (Electric Vehicles) only\n"+
                            "6) Exit\n------------------------------------------------------");
            string? userInput = Console.ReadLine();


            //check if userInput is an integer
            if (int.TryParse(userInput, out int value))
            {
                switch (int.Parse(userInput))
            {
                case 1:                
                break;

                case 2:
                break;

                case 3:
                break;

                //invalid integer
                default:
                break;
            }
            }
            else
            {
                Console.WriteLine("invalid input!");
            }




            












        }



        
    }
}
