using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat course are you on?");
        string courseName = Console.ReadLine();
        Console.WriteLine("You're on course " + courseName + ".\nWhat page number?");
        string pageNumber = Console.ReadLine();
        int pageInt = Convert.ToInt32(pageNumber);
        Console.WriteLine("You're on page " + pageInt + ".\nDo you need help with anything? Please answer \"true\" or \"false\".");
        string helpAnswer = Console.ReadLine();
        bool flag;
        if (Boolean.TryParse(helpAnswer, out flag))
            Console.WriteLine("'{0}' --> {1}", helpAnswer, flag);
        else
            Console.WriteLine("Unable to parse '{0}'. Please answer \"true\" or \"false\".",
                helpAnswer == null ? "<null>" : helpAnswer);

        Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
        string positiveExp = Console.ReadLine();
        Console.WriteLine("You've had these experiences: " + positiveExp + ".\nIs there any other feedback you’d like to provide? Please be specific.");
        string feedbackAnswer = Console.ReadLine();
        Console.WriteLine("Thanks for your feedback: " + feedbackAnswer + ".\nHow many hours did you study today?");
        string hoursToday = Console.ReadLine();
        int hoursInt = Convert.ToInt32(hoursToday);
        Console.WriteLine("You studied " + hoursInt + "hours today.");
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}

