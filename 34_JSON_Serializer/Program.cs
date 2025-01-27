using _34_JSON_Serializer;
using Newtonsoft.Json;
//using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "../../../car.json";
        Car car = new Car(122, "Toyota", 2.3);
        Car car_2 = new Car(321, "Peguot", 2.7);

        //string json = JsonSerializer.Serialize<Car>(car); // only property
        //Console.WriteLine(json);
        /*using(StreamWriter sw = new StreamWriter(fname))
        {
            sw.Write(json);
        }*/

        /*string json = JsonConvert.SerializeObject(car);
        Console.WriteLine(json);
        File.WriteAllText(fname, json);*/

        //Console.WriteLine(JsonConvert.DeserializeObject<Car>(File.ReadAllText(fname)));


        /*string recJson = File.ReadAllText(fname);
        Console.WriteLine(recJson);
        Car res = JsonSerializer.Deserialize<Car>(recJson)!;
        Console.WriteLine(res);*/

        ////////////////////
        /*string fList = @"../../../salonCar.json";
        List<Car> list = new List<Car>()
        {
            car, car_2, new Car(111,"BMW",2.9)
        };*/
        /*string json = JsonSerializer.Serialize<List<Car>>(list); // only property
        Console.WriteLine(json);
        using (StreamWriter sw = new StreamWriter(fList))
        {
            sw.Write(json);
        }*/

        /*string recJson = File.ReadAllText(fList);
        List<Car> res = JsonSerializer.Deserialize<List<Car>>(recJson)!;
        Console.WriteLine($"\n\n Recovered list of cars :: \n{String.Join<Car>("\n", res)}");*/


        //////////////
        string fList = @"../../../salonCar.json";
         Dictionary<int, Car> dicCars = new Dictionary<int, Car>()
         {
             [car.id] = car,
             [car_2.id] = car_2
         };

        /*string json = JsonSerializer.Serialize<Dictionary<int, Car>>(dicCars); // only property
        Console.WriteLine(json);
        using (StreamWriter sw = new StreamWriter(fList))
        {
            sw.Write(json);
        }*/

        /*string recJson = File.ReadAllText(fList);
        Dictionary<int, Car> res = JsonSerializer.Deserialize<Dictionary<int, Car>>(recJson)!;
        Console.WriteLine($"\n\n Recovered list of cars ::");
        foreach (var item in res)
        {
            item.Value.id= item.Key;
            Console.WriteLine($"{item.Key} -- {item.Value}");
        }*/

        //File.WriteAllText(fList,JsonConvert.SerializeObject(dicCars));
        /*foreach (var item in JsonConvert.DeserializeObject<Dictionary<int,Car>>(File.ReadAllText(fList)))
        {
            Console.WriteLine($"{item.Key} -- {item.Value}");
        }*/
    }
}