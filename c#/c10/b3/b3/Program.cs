class car
{
    public string name;
    public string color;
    public car(string name, string color)
    {
        this.name = name;
        this.color = color;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        List<car> xe = new List<car>();
        xe.Add(new car("mec","red"));
        xe.Add(new car("toyota", "blue"));
        xe.Add(new car("audi", "yellow"));
        xe.Add(new car("toyota", "pink"));
        xe.Add(new car("lambo", "brown"));
        xe.Add(new car("rollroy", "light pink"));
        xe.Add(new car("honda", "galaxy"));
        xe.Add(new car("tesla", "black"));
        xe.Add(new car("lambo", "red"));
        xe.Add(new car("audi", "green"));
        foreach (car car in xe)
        {
            Console.WriteLine("name:{0} / color: {1} ", car.name, car.color);
        }
        Console.WriteLine("danh sach sau khi xoa red la:");
        Console.WriteLine("-------------------------------------");
        xe.RemoveAll(xe => xe.color == "red");
        foreach(car car in xe)
        {
            Console.WriteLine("name:{0} / color: {1} ",car.name,car.color);
        }
    }
}