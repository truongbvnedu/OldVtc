class ProductEnumerable
{
    public string name;
    public decimal price;
    public string useday;
    public ProductEnumerable(string name, decimal price, string useday)
    {
        this.name = name;
        this.price = price;
        this.useday = useday;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        List<ProductEnumerable> product = new List<ProductEnumerable>();
        product.Add(new ProductEnumerable("nuoc ngot", 20000, "21/04/2025"));
        product.Add(new ProductEnumerable("banh" , 10000,"21/03/2026"));
        product.Add(new ProductEnumerable("trai cay", 50000,"22/05/2024"));

        Console.WriteLine("san pham cua cua hang gom:");
        foreach (var item in product) 
        {
            
            Console.WriteLine("name:{0}--price:{1}--expiry:{2}",item.name,item.price,item.useday);
        }
    }
}