namespace lesson_5_hw;

public class CalculyatorExceptionDivideByZero : CalculyatorException
{
    public CalculyatorExceptionDivideByZero()
    {
    }

    public CalculyatorExceptionDivideByZero(string e) : base(e)
    {
    }
}