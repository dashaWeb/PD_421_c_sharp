using _33_XML_Serializer;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "../../../car.xml";
        Car car= new Car(122,"Toyota",2.3);
        Car car_2 = new Car(321, "Peguot", 2.7);
        Console.WriteLine($"Origin Car    :: {car}");
        XmlSerializer xs = new XmlSerializer(typeof(Car));

        using(FileStream fs = new FileStream(fname, FileMode.Create))
        {
            xs.Serialize(fs,car);

            fs.Position= 0;
            Car recCar = (xs.Deserialize(fs) as Car)!;
            Console.WriteLine($"Recovered car :: {recCar}");
        }

        string fnameCars = "../../../listCars.xml";
        List<Car> cars = new List<Car>()
        {
            car, car_2, new Car(111,"BMW",2.9)
        };

        XmlSerializer xml= new XmlSerializer(typeof(List<Car>));
        using(TextWriter tw = new StreamWriter(fnameCars))
        {
            xml.Serialize(tw,cars);
        }

        using (TextReader tr = new StreamReader(fnameCars))
        {
            List<Car> listCar = (xml.Deserialize(tr) as List<Car>)!;

            Console.WriteLine($"\n\n Recovered list of cars :: \n{String.Join<Car>("\n",listCar)}");
        }

    }
}