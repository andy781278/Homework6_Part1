using System.Numerics;

Counter c = new Counter();
bool exit = false;

while (!exit)
{
    Console.WriteLine("Welcome, what do?\n1. add 1\n2. minus 1\n3. reset\n4. print out counter number\n5. exit");
    string res = Console.ReadLine();
    switch (res)
    {
        case "1":
            c.add();
            break;
        case "2":
            c.sub();
            break;
        case "3":
            c.resetCounter();
            break;
        case "4":
            c.print();
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Not recognized.");
            break;
    }
}

public class Counter {
    private uint num;
    public Counter(int _n = 0)
    {
        if (_n < 0) {
            num = 0;
        } else
        {
            num = Convert.ToUInt32(_n);
        }
    }

    public void resetCounter() { num = 0; }
    public void add() { num++; }
    public void sub() {

        if (num == 0) { num = 0; }
        else
        {
            num--;
        }
        }

    public uint getCount() {return  num; }
    public void print()
    {
        Console.WriteLine("Counter: "+toString());
    }
    public string toString() { return num.ToString(); }
    public bool equals(Counter other) {return (num==other.num); }
}