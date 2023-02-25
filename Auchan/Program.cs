class Program
{
    static void Main()
    {
        Bottle bottle = new Bottle();
        Console.WriteLine(bottle.GetInfo());

        string inBrand = Console.ReadLine();
        string inType = Console.ReadLine();
        float inCapacity = float.Parse(Console.ReadLine());
        float inPrice = float.Parse(Console.ReadLine());

        Bottle bottle2 = new Bottle(inBrand, inType, inCapacity, inPrice);
        Console.WriteLine(bottle2.GetInfo());

        int size = int.Parse(Console.ReadLine());
        Bottle[] array = new Bottle[size];

        for (int i = 0; i < size; i++)
        {
            inBrand = Console.ReadLine();
            inType= Console.ReadLine();
            inCapacity= int.Parse(Console.ReadLine());
            inPrice= float.Parse(Console.ReadLine());

            array[i] = new Bottle(inBrand, inType, inCapacity, inPrice);
        }
        foreach (var item in array) Console.WriteLine(item.GetInfo());
        foreach (var item in array)
        {
            if (item.Brand == "Карачинаская" && item.Price < 100.0f)
            {
                item.BuyWater();
                Console.WriteLine(item.GetInfo());
            }
        }


    }
}