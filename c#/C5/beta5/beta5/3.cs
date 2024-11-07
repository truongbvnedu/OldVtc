class date
{
    public int day;
    public int year;
    public int month;
    public date() 
    {
        day = 3;
        year = 2022;
        month = 10;
    }
    public date(int day)
    {
        this.day = day;
        month = 10;
        year = 2022;
    }
    public date(int day,int month,int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public bool ktday()
    {
        if (day < 0 || day >30) {
        return false;}
        else { return true;}
    }
    public bool ktmonth()
    {
        if (month < 0 || month > 12)
        {
            return false;
        }
        else { return true; }

    }
    public bool ktyear()
    {
        if (month < 1900 || month > 2050)
        {
            return false;
        }
        else { return true; }
    }
    public bool ktnhuan()
    {
        if (year % 4 == 0)
        {
            return true;
        }
        else { return false; }
    }
    public void inkq()
    {
        if (ktday())
        {
            if (ktmonth())
            {
                if (ktyear())
                {
                    if (ktnhuan())
                    {
                        Console.Write("ngay ban nhap la ({0}:{1}:{2}) nam nay la nam nhuan", day, month, year);
                    }
                    else
                    {
                        Console.Write("ngay ban nhap la ({0}:{1}:{2}) nam nay la nam khong  nhuan", day, month, year);
                    }
                }
                else
                {
                    Console.WriteLine("nam sai");
                }
            }
            else
            {
                Console.WriteLine("thang sai");
            }
        }
        else
        {
            Console.WriteLine("ngay sai");
        }
    }
    static void Main(string[] args)
    {
        date ngay = new date();
        ngay.inkq();

    }
}