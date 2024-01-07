using System;

public static class NumberFormatter
{
    public static string ToShortString(double number)
    {
        if (number < 1000)
        {
            return FormatNumber(number);
        }

        int exponent = (int)Math.Floor(Math.Log10(number));
        double divisor = Math.Pow(10, exponent - exponent % 3);
        double shortenedNumber = number / divisor;

        string suffix = exponent switch
        {
            >= 9 => " bln",
            >= 6 => " mln",
            >= 3 => " k",
            _ => ""
        };

        return FormatNumber(shortenedNumber) + suffix;
    }

    private static string FormatNumber(double number)
    {
        if (number < 10)
        {
            return number.ToString("0.00");
        }
        else if (number < 100)
        {
            return number.ToString("0.0");
        }
        else
        {
            return number.ToString("0");
        }
    }
}