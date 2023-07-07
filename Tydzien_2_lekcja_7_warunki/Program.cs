using System;
using System.Linq.Expressions;

class Program
{
    static void Main()

    {
        //// ex.1
        //int a = 5;
        //int b = 5;

        //if (a == b)
        //{
        //    Console.WriteLine($"{a} i {b} są równe");
        //}
        //else
        //{
        //    Console.WriteLine($"{a} i {b} nie są równe");
        //}

        ////ex. 2
        //Console.WriteLine("Podaj liczbę i sprawdź, czy jest parzysta:");
        //string varInt = Console.ReadLine();
        //int isEven = int.Parse(varInt);

        //if (isEven % 2 == 0)
        //{
        //    Console.WriteLine($" Liczba {isEven} jest parzysta");
        //}
        //else
        //{
        //    Console.WriteLine($" Liczba {isEven} jest nieparzysta");
        //}
        ////ex.3
        //Console.WriteLine("Podaj liczbę i sprawdź, czy jest dodatnia:");
        //string var_positive = Console.ReadLine();
        //double is_positive = double.Parse(var_positive);

        //if (is_positive > 0)
        //{
        //    Console.WriteLine($" Liczba {is_positive} jest dodatnia");
        //}
        //else if (is_positive == 0)
        //{
        //    Console.WriteLine($" Liczba {is_positive} nie jest ani dodatnia, ani ujemna.");
        //}
        //else
        //{
        //    Console.WriteLine($" Liczba {is_positive} jest ujemna");
        //}
        //ex.4
        //Console.WriteLine("Podaj rok i sprawdź czy jest rokiem przestępnym:");
        //string varYear = Console.ReadLine();
        //int isLeap = int.Parse(varYear);

        //if ((isLeap % 400 == 0)||(isLeap % 4 == 0 && isLeap % 100 != 0))
        //{
        //    Console.WriteLine($" Rok {isLeap} jest przestępny.");
        //}
        //else
        //{
        //    Console.WriteLine($" Rok {isLeap} nie jest przestępny.");
        //}
        //ex.5
        Console.WriteLine("Podaj swój wiek. Sprawdzę, czy możesz być posłem.");
        string age = Console.ReadLine();
        int notToYoung = int.Parse(age);

        if (notToYoung >= 21)
        {
            Console.WriteLine("Możesz być posłem, a nawet premierem.");
        }
        else if (notToYoung >= 30)
        {
            Console.WriteLine("Możesz być posłem, premierem lub senatorem.");
        }
        else if (notToYoung >= 35) 
        {
            Console.WriteLine("Możesz być posłem, premierem, senatorem, a nawet prezydentem.");
        }
        else
        {
            Console.WriteLine("Nie możesz być posłem.");
        }

        ////ex.6
        //Console.WriteLine("\nPodaj swój wzrost w cm.");
        //string height = Console.ReadLine();
        //int is_high = int.Parse(height);

        //switch (is_high)
        //{
        //    case int h when (h < 150):
        //        Console.WriteLine("Jesteś krasnoludem. Nie możesz być posłem.");
        //        break;
        //    case int h when (h < 160):
        //        Console.WriteLine("Jesteś niski.");
        //        break;
        //    case int h when (h < 170):
        //        Console.WriteLine("Jesteś średniego wzrostu.");
        //        break;
        //    case int h when (h < 180):
        //        Console.WriteLine("Jesteś wysoki.");
        //        break;
        //    default:
        //        Console.WriteLine("Jesteś bardzo wysoki.");
        //        break;
        //}

        ////ex.7
        //{
        //    Console.WriteLine("Podaj 3 liczby. Znajdę największą.Podaj pierwszą liczbę:");
        //    string input1 = Console.ReadLine();
        //    int number1 = int.Parse(input1);

        //    Console.WriteLine("Podaj drugą liczbę:");
        //    string input2 = Console.ReadLine();
        //    int number2 = int.Parse(input2);

        //    Console.WriteLine("Podaj trzecią liczbę:");
        //    string input3 = Console.ReadLine();
        //    int number3 = int.Parse(input3);

        //    int theBiggest = number1;

        //    if (number2 > theBiggest)
        //    {
        //        theBiggest = number2;
        //    }

        //    if (number3 > theBiggest)
        //    {
        //        theBiggest = number3;
        //    }

        //    Console.WriteLine($"{theBiggest} jest największa z podanych");
        //}

        ////ex. 8
        //{
        //    Console.WriteLine("Podaj wynik z egzaminu z matematyki:");
        //    string inputMath = Console.ReadLine();
        //    int scoreMath = int.Parse(inputMath);

        //    Console.WriteLine("Podaj wynik z fizyki:");
        //    string inputPhisics = Console.ReadLine();
        //    int scorePhisics = int.Parse(inputPhisics);

        //    Console.WriteLine("Podaj wynik z chemii:");
        //    string inputChemistry = Console.ReadLine();
        //    int scoreChemistry = int.Parse(inputChemistry);

        //    int totalScore = scoreMath + scorePhisics + scoreChemistry;

        //    if (scoreMath > 70 && scorePhisics > 55 && scoreChemistry > 45 && totalScore > 180)
        //    {
        //        Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
        //    }
        //    else if ((scoreMath > 150) && (scorePhisics > 150 || scoreChemistry > 150))
        //    {
        //        Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Kandydat nie dopuszczony do rekrutacji."); ;
        //    }
        //}

        ////ex.9
        //{
        //    Console.WriteLine("Podaj temperaturę:");
        //    string inputTemp = Console.ReadLine();
        //    int temperature = int.Parse(inputTemp);

        //    string weather = "";

        //    switch (temperature)
        //    {
        //        case int n when (n < 0):
        //            weather = "bardzo zimno";
        //            break;
        //        case int n when (n >= 0 && n <= 10):
        //            weather = "zimno";
        //            break;
        //        case int n when (n > 10 && n <= 20):
        //            weather = "chłodno";
        //            break;
        //        case int n when (n > 20 && n <= 30):
        //            weather = "w sam raz";
        //            break;
        //        case int n when (n > 30 && n <= 40):
        //            weather = "zaczyna być słabo, bo gorąco";
        //            break;
        //        default:
        //            weather = "a weź, wyprowadzam się na Alaskę";
        //            break;
        //    }

        //    Console.WriteLine(weather);
        //}

        ////ex. 10
        //{
        //    Console.WriteLine("Podaj długość pierwszego boku:");
        //    string inputA = Console.ReadLine();
        //    double segm_a = double.Parse(inputA);

        //    Console.WriteLine("Podaj długość drugiego boku:");
        //    string inputB = Console.ReadLine();
        //    double segm_b = double.Parse(inputB);

        //    Console.WriteLine("Podaj długość trzeciego boku:");
        //    string inputC = Console.ReadLine();
        //    double segm_c = double.Parse(inputC);

        //    if (segm_a > 0 && segm_b > 0 && segm_c > 0 && segm_a + segm_b > segm_c && segm_a + segm_c > segm_b && segm_b + segm_c > segm_a)
        //    {
        //        Console.WriteLine("Można stworzyć trójkąt");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nie można stworzyć trójkąta");
        //    }
        //}

        ////ex. 11
        //{
        //    Console.WriteLine("Podaj ocenę jako cyfrę:");
        //    string inputGrade = Console.ReadLine();
        //    int grade = int.Parse(inputGrade);

        //    switch (grade)
        //    {
        //        case 6:
        //            Console.WriteLine("Celujący");
        //            break;
        //        case 5:
        //            Console.WriteLine("Bardzo dobry");
        //            break;
        //        case 4:
        //            Console.WriteLine("Dobry");
        //            break;
        //        case 3:
        //            Console.WriteLine("Dostateczny");
        //            break;
        //        case 2:
        //            Console.WriteLine("Dopuszczający");
        //            break;
        //        case 1:
        //            Console.WriteLine("Niedostateczny");
        //            break;
        //        default:
        //            Console.WriteLine("Nieznany");
        //            break;
        //    }
        //}

        //// ex. 12

        //{
        //    Console.WriteLine("Podaj dzień jako cyfrę:");
        //    string inputDay = Console.ReadLine();
        //    int day = int.Parse(inputDay);

        //    switch (day)
        //    {
        //        case 1:
        //            Console.WriteLine("Poniedziałek");
        //            break;
        //        case 2:
        //            Console.WriteLine("Wtorek");
        //            break;
        //        case 3:
        //            Console.WriteLine("Środa");
        //            break;
        //        case 4:
        //            Console.WriteLine("Czwartek");
        //            break;
        //        case 5:
        //            Console.WriteLine("Piątek");
        //            break;
        //        case 6:
        //            Console.WriteLine("Sobota");
        //            break;
        //        case 7:
        //            Console.WriteLine("Niedziela");
        //            break;
        //        default:
        //            Console.WriteLine("Nieznany");
        //            break;
        //    }
        //}

        //ex.12
        {
            Console.WriteLine("Wybierz numer operacji:\n1. Dodawanie\n2. Odejmowanie\n3. Mnożenie\n4. Dzielenie");

            string inputChoice = Console.ReadLine();
            int choice = int.Parse(inputChoice);

            Console.WriteLine("Podaj pierwszą liczbę:");
            string inputNumber1 = Console.ReadLine();
            double number1 = double.Parse(inputNumber1);

            Console.WriteLine("Podaj drugą liczbę:");
            string inputNumber2 = Console.ReadLine();
            double number2 = double.Parse(inputNumber2);

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy numer operacji.");
                    break;
            }

            Console.WriteLine("Twój wynik to: " + result);
            Console.WriteLine();
        }
    }
}