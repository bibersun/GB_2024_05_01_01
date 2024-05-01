namespace lesson_5_hw;

internal class Program
{
    private static void Main()
    {
        var calc = new Calc();
        var opMatrix = "+-*/u";
        Console.Write($"Текущий результат {calc.Result}\n");
        calc.MyEventHandler += Calc_MyEventHandler;
        while (true)
        {
            var s = Console.ReadLine();
            if (s!.Length == 0) break;
            var bInt = int.TryParse(s.Substring(1), out var iNum);
            var bDouble = double.TryParse(s.Substring(1), out var dNum);
            if (s.Substring(0, 1).ToLower() == "u") calc.CancelLast();
            if (!opMatrix.Contains(s[0]) || s.Length < 2 || !(bInt || bDouble)) continue;
            var op = s.Substring(0, 1);
            switch (op)
            {
                case "*":
                    calc.Multy(bInt ? iNum : dNum);
                    break;
                case "+":
                    calc.Sum(bInt ? iNum : dNum);
                    break;
                case "-":
                    calc.Sub(bInt ? iNum : dNum);
                    break;
                case "/":
                    try
                    {
                        calc.Divide(bInt ? iNum : dNum);
                    }
                    catch (CalculyatorExceptionDivideByZero e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
            }
        }
    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if (sender is Calc)
        {
            Console.Write("Текущий результат ");
            Console.WriteLine(((Calc)sender).Result);
        }
    }
}