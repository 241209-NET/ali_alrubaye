
namespace MiniProject;

public static class DummyData{

 public static readonly List<Car> carsData = [

    new(){Make = "Toyota", Model = "Avalon", Year = 2010, Color = "White", Price = 20000.0, Ev = false},
    new(){Make = "Toyota", Model = "Avalon", Year = 2020, Color = "White", Price = 25000.0, Ev = false},
    new(){Make = "Toyota", Model = "Avalon", Year = 2025, Color = "Blue", Price = 30000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 1999, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 2000, Color = "Black", Price = 22000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 2010, Color = "Blue", Price = 23000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 2011, Color = "Red", Price = 29000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 2020, Color = "Yellow", Price = 30000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 2025, Color = "Purple", Price = 35000.0, Ev = false},
    new(){Make = "Toyota", Model = "Camry", Year = 2020, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Toyota", Model = "Corolla", Year = 1999, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Toyota", Model = "Corolla", Year = 2020, Color = "Blue", Price = 22000.0, Ev = false},
    new(){Make = "Toyota", Model = "Corolla", Year = 2020, Color = "Red", Price = 23000.0, Ev = false},
    new(){Make = "Toyota", Model = "Corolla", Year = 2024, Color = "Black", Price = 30000.0, Ev = false},
    new(){Make = "Toyota", Model = "Corolla", Year = 2025, Color = "white", Price = 35000.0, Ev = false},
    new(){Make = "Toyota", Model = "Prius", Year = 2018, Color = "white", Price = 20000.0, Ev = true},
    new(){Make = "Toyota", Model = "Prius", Year = 2020, Color = "Red", Price = 25000.0, Ev = true},
    new(){Make = "Toyota", Model = "Prius", Year = 2024, Color = "Black", Price = 29000.0, Ev = true},
    new(){Make = "Toyota", Model = "Prius", Year = 2025, Color = "Purple", Price = 35000.0, Ev = true},

    new(){Make = "Honda", Model = "Accord", Year = 2020, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Honda", Model = "Accord", Year = 2020, Color = "Black", Price = 22000.0, Ev = false},
    new(){Make = "Honda", Model = "Accord", Year = 2024, Color = "Blue", Price = 29000.0, Ev = false},
    new(){Make = "Honda", Model = "Accord", Year = 2025, Color = "Blue", Price = 35000.0, Ev = false},
    new(){Make = "Honda", Model = "Civic", Year = 2020, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Honda", Model = "Civic", Year = 2020, Color = "Red", Price = 22000.0, Ev = false},
    new(){Make = "Honda", Model = "Civic", Year = 2025, Color = "white", Price = 40000.0, Ev = false},
    new(){Make = "Honda", Model = "Civic", Year = 2022, Color = "Black", Price = 28000.0, Ev = false},
    new(){Make = "Honda", Model = "Insight", Year = 2020, Color = "white", Price = 20000.0, Ev = true},
    new(){Make = "Honda", Model = "Insight", Year = 2021, Color = "Blue", Price = 26000.0, Ev = true},
    new(){Make = "Honda", Model = "Insight", Year = 2023, Color = "Red", Price = 29000.0, Ev = true},
    new(){Make = "Honda", Model = "Insight", Year = 2025, Color = "white", Price = 35000.0, Ev = true},

    new(){Make = "Nissan", Model = "Altima", Year = 2023, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Nissan", Model = "Altima", Year = 2024, Color = "Yellow", Price = 25000.0, Ev = false},
    new(){Make = "Nissan", Model = "Altima", Year = 2025, Color = "Black", Price = 29000.0, Ev = false},
    new(){Make = "Nissan", Model = "Sentra", Year = 2024, Color = "white", Price = 20000.0, Ev = false},
    new(){Make = "Nissan", Model = "Sentra", Year = 2025, Color = "Black", Price = 25000.0, Ev = false},
    new(){Make = "Nissan", Model = "Leaf", Year = 2020, Color = "white", Price = 20000.0, Ev = true},
    new(){Make = "Nissan", Model = "Leaf", Year = 2020, Color = "Red", Price = 23000.0, Ev = true},
    new(){Make = "Nissan", Model = "Leaf", Year = 2021, Color = "white", Price = 25000.0, Ev = true},
    new(){Make = "Nissan", Model = "Leaf", Year = 2025, Color = "Yellow", Price = 30000.0, Ev = true},

    new(){Make = "Tesla", Model = "3", Year = 2023, Color = "white", Price = 80000.0, Ev = true},
    new(){Make = "Tesla", Model = "S", Year = 2024, Color = "Yellow", Price = 88000.0, Ev = true},
    new(){Make = "Tesla", Model = "X", Year = 2025, Color = "Black", Price = 100000.0, Ev = true},
    new(){Make = "Tesla", Model = "Y", Year = 2024, Color = "white", Price = 99000.0, Ev = true},
    new(){Make = "Tesla", Model = "Cybertruck", Year = 2025, Color = "Black", Price = 125000.0, Ev = true},
  ];

public static List<Car> GetCars(){
    return carsData;
}

}