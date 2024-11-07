
class pt2
{
    public double a,b,c;
   
    public pt2(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double giaipt1()
    {
        return -c / b;
    }
    public double denta() 
    {
        return (b * b) - (4 * a * c);
    }
    public double nghiemkep()
    {
        return -b / 2*a;
    }
    public double x1() 
    {
        return (-b + Math.Sqrt(denta())) / 2 * a;
    }
    public double x2()
    {
        return (-b - Math.Sqrt(denta())) / 2 * a;
    }
    public void giaipt2() 
    {
        if (a == 0) 
        {
            if (b ==0 )
            {
                if ((c == 0))
                {
                    Console.WriteLine("phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("phuong trinh co nghiem:{0} ", Math.Round(giaipt1(), 2));
            }            
        }
        else
        {
            if(denta() < 0) 
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if(denta() == 0) 
            {
                Console.WriteLine("phuong trinh co nghiem kep la:{0}", Math.Round(nghiemkep(), 2));

            }
            else { Console.WriteLine("phuong trinh co nghiem thu nhat x1={0}",Math.Round(x1(),2));
                Console.WriteLine("phuong trinh co nghiem thu nhat x2={0}", Math.Round(x2(), 2));
            }
        }
    }
}
