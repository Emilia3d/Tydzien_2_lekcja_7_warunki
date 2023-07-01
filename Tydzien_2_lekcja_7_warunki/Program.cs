class Program
{
    static void Main()
    {
        // ex.1
        int a = 5;
        int b = 5;

        if (a == b)
        {
            Console.WriteLine($"{a} i {b} są równe");
        }
        else
        {
            Console.WriteLine($"{a} i {b} nie są równe");
        }

        //ex. 2
        Console.WriteLine("Podaj liczbę i sprawdź, czy jest parzysta:");
        string var_int = Console.ReadLine();
        int is_even = int.Parse(var_int);

        if (is_even % 2 ==0)
        {
            Console.WriteLine($" Liczba {is_even} jest parzysta");
        }
        else
        {
            Console.WriteLine($" Liczba {is_even} jest nieparzysta");
        }
        //ex.3
        Console.WriteLine("Podaj liczbę i sprawdź, czy jest dodatnia:");
        string var_positive = Console.ReadLine();
        double is_positive = double.Parse(var_positive);

        if (is_even > 0)
        {
            Console.WriteLine($" Liczba {is_positive} jest dodatnia");
        }
        else
        {
            Console.WriteLine($" Liczba {is_positive} jest ujemna");
        }
    }
}
