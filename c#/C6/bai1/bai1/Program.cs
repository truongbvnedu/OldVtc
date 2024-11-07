class window
{
    public int top;
    public int left;
    public void drawwindow()
    {
        Console.Write("nhap so cho top(window):");
        top = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so cho left(window):");
        left = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Window: {0}:{1}",top,left);
    }
}
class buttion:window
{
    public int top;
    public int left;
    public new void drawwindow()
    {
        Console.Write("nhap so cho top(buttion):");
        top = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so cho left(buttion):");
        left = Convert.ToInt32(Console.ReadLine());
        base.drawwindow();
        Console.WriteLine("buttion: {0}:{1}",top,left);
    }
}
class listbox:window
{
    public int top;
    public int left;
    public string content;
    public new void drawwindow()
    {
        Console.Write("nhap so cho top(listbox):");
        top = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so cho left(listbox):");
        left = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap mot chuoi ky tu(listbox):");
        content = Convert.ToString(Console.ReadLine());
        base.drawwindow();
        Console.WriteLine("listbox: {0}:{1}:{2}",top,left,content);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        window down = new window();
        down.drawwindow();
        Console.ReadKey();
        System.Console.Clear();
        buttion btn = new buttion();
        btn.drawwindow();
        Console.ReadKey();
        System.Console.Clear();
        listbox lb = new listbox();
        lb.drawwindow();
    }
}