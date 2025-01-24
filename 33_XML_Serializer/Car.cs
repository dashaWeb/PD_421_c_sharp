using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _33_XML_Serializer
{
    // 1) клас для серіалізації = public
    // 2) серіалізувати можна -  public поля, властивості
    // 3) явний конструктор по замовчуванню
    public class Engine
    {
        public double Power { get; set; } // auto-props
        public Engine()
            :this(1.0)
        {}
        public Engine(double power)
        {
            Power = power;
        }
        public override string ToString()
        {
            return $"Engine power : {Power}";
        }
    }
    public class Car
    {
        //[XmlAttribute("Number")]
        public int id;
        private string brand;
        //[XmlIgnore()]
        public string Brand { get=>brand; set=> brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }

        public Car( int id, string brand, double power)
        {
            Brand = brand;
            this.id = id;
            Engine = new Engine(power);
        }
        public Car()
            :this(0,"Nobrand",1.0)   
        {}
        public override string ToString()
        {
            return $"Id {id}. \t Car brand {Brand ?? "Nobrand"} \t {Engine}";
        }
    }
}
