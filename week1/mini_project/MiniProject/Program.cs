namespace MiniProject;

class Program
{
    static void Main(string[] args)
    {
        DummyData.GetCars();

        foreach (Car c in DummyData.GetCars()){
            Console.WriteLine(c.Model);
        }
        
    }
}
