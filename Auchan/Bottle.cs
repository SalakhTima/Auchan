public class Bottle
{
    private float capacity;
    private string brand;
    private float price;
    private string type;
    public float Price
    {
        get => Price;      
    }
    public string Type
    {
        get => Type;    
    }
    public float Capacity
    {
        get => Capacity;
    }
    public string Brand
    {
        get => Brand;   
    }

    public Bottle(string brand = "No brand", string type = "Undefined", float capacity = 0.0f, float price = 0.0f)
    {
        this.brand = brand;
        this.type = type;
        this.capacity = capacity;
        this.price = price;
    }
    public string GetInfo()
    {
        string s = string.Format($"1. Производитель: {brand}\n2. Тип: {type}\n3. Объем: {capacity}\n4. Цена: {price}\n");
        return s;
    }
    public void BuyWater()
    {
        Console.WriteLine("Бутылка кулена");
    }
}

