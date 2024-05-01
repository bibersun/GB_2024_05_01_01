namespace lesson_5_hw;

public interface ICalc
{
    double Result { get; set; }
    void Sum<T>(T x);
    void Sub<T>(T x);
    void Multy<T>(T x);
    void Divide<T>(T x);
    void CancelLast();

    event EventHandler<EventArgs> MyEventHandler;
}