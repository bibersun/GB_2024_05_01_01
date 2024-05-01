namespace lesson_5_hw;

public class CalculyatorException : Exception
{
    public CalculyatorException()
    {
    }

    public CalculyatorException(string e) : base(e)
    {
    }
}