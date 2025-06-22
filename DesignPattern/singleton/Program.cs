using System;

public class Logger
{
    private static Logger instance;

    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log entry");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log entry");

        if (logger1 == logger2)
        {
            Console.WriteLine("Same logger instance used.");
        }
        else
        {
            Console.WriteLine("Different logger instances.");
        }
    }
}
