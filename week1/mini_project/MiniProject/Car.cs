namespace MiniProject;
public class Car {

public string Make {get;set;} = "";
public string Model {get;set;} = "";
public int Year {get;set;} = 9999;
public string Color {get;set;} = "";
public double Price {get;set;} = 9999;
public bool Ev {get;set;} = false;


public Car() {}
public Car(string make, string model, int year, string color, double price, bool ev){
    Make = make;
    Model = model;
    Year = year;
    Color = color;
    Price = price;
    Ev = ev;
}

 public override string ToString()
    {
        string str = String.Format("|{0,-12}|{1,-12}|{2,-12}|{3,-12}|{4,-12}|{5,-12}|", Make, Model, Year, Color, Price, Ev);
        // "Make:"+Make+" , "+"Model:"+Model+" , "+"Year:"+Year+" , "+"Color:"+Color+" , "+"Price $:"+Price+" , "+"EV:"+Ev;

        return str;
    }





}