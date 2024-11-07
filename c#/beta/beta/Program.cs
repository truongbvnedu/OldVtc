public abstract class person
{
    public abstract void action();
    public abstract void job();
    public abstract void workplace();
}
class devfont : person 
{
    public override void action()
    {
        Console.WriteLine("work");
    }
    public override void job()
    {
        Console.WriteLine("developer of website");
    }
    public override void workplace()
    {
        Console.WriteLine("city");
    }
    static int number = 0;
    public static int count()
    {
        number++;
        return number;
    }
}
class dev_font 
{
    
}
internal class Program
{
    static void Main(string[] args)
    {
        devfont dev_font = new devfont();
        dev_font.action();
        dev_font.job();
        dev_font.workplace();
        dev_font devfont = new dev_font();  
    }
}