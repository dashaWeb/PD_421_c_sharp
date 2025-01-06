using _12_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        // Device device = new Device(); error
        TV tV = new TV("LG");
        Smartphone smartphone = new Smartphone("Nokia");
        tV.Print();
        smartphone.Print();
        SmartTV smartTV = new SmartTV();
        Device[] tVs = new Device[] { tV, smartphone, smartTV};
        Console.WriteLine("\n===================================\n");
        foreach (Device device in tVs)
        {
            device.Print();
        }
        Console.WriteLine("\n===================================\n");
        foreach (Device item in tVs)
        {
            Console.WriteLine(item);
            //((TV)item).NextChannel(); // error
            // 1)
            /*try
            {
                ((TV)item).NextChannel();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }*/
            // 2) 
            /*TV tmp_tv = item as TV;
            if(tmp_tv != null)
            {
                tmp_tv.NextChannel();
            }
            Smartphone tmp_smart = item as Smartphone;
            if(tmp_smart != null)
            {
                tmp_smart.Call();
            }*/

            //3)
            if (item is SmartTV)
            {
                (item as SmartTV)?.Print();
            }
            if (item is TV)
            {
                (item as TV)?.NextChannel();
            }
            if(item is Smartphone)
            {
                (item as Smartphone)?.Call();
            }

        }
    }
}