namespace lesson_5_hw;

public class Calc : ICalc
{
    private Stack<double> LastRes { get; } = new();
    public double Result { get; set; }

    public void Sum<T>(T x)
    {
        LastRes.Push(Result);
        Result += Convert.ToDouble(x);
        PrintRes();
    }

    public void Sub<T>(T x)
    {
        LastRes.Push(Result);
        Result -= Convert.ToDouble(x);
        PrintRes();
    }

    public void Multy<T>(T x)
    {
        LastRes.Push(Result);
        Result *= Convert.ToDouble(x);
        PrintRes();
    }

    public void Divide<T>(T x)
    {
        if (Convert.ToDouble(x) != 0)
        {
            LastRes.Push(Result);
            Result /= Convert.ToDouble(x);
        }
        else
        {
            throw new CalculyatorExceptionDivideByZero("На ноль делить нельзя");
        }

        PrintRes();
    }


    public void CancelLast()
    {
        if (LastRes.TryPop(out var res))
        {
            Console.WriteLine("Последнее действие отменено");
            Result = res;
            PrintRes();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Не можем отменять последнее действие");
        }
    }

    public event EventHandler<EventArgs>? MyEventHandler;

    private void PrintRes()
    {
        MyEventHandler?.Invoke(this, EventArgs.Empty);
    }
}