using System;

public class FinancialForecast
{
    public static double PredictFutureValue(int years, double initialValue, double growthRate)
    {
        if (years == 0)
            return initialValue;
        return PredictFutureValue(years - 1, initialValue, growthRate) * (1 + growthRate);
    }

    public static double PredictFutureValueOptimized(int years, double initialValue, double growthRate)
    {
        return initialValue * Math.Pow(1 + growthRate, years);
    }

    public static void Main(string[] args)
    {
        double initial = 10000;
        double growth = 0.05; // 5% growth
        int years = 5;

        double futureValueRecursive = PredictFutureValue(years, initial, growth);
        double futureValueOptimized = PredictFutureValueOptimized(years, initial, growth);

        Console.WriteLine($"Recursive Prediction (Year {years}): {futureValueRecursive:F2}");
        Console.WriteLine($"Optimized Prediction (Year {years}): {futureValueOptimized:F2}");
    }
}

