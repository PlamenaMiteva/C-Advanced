using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Text.RegularExpressions;

class ChatLogger
{
    static void Main()
    {
        DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        SortedDictionary<DateTime, string> result = new SortedDictionary<DateTime, string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                string[] str = Regex.Split(input, @"\s\/\s");
                string temp = str[1];
                DateTime date = DateTime.ParseExact(temp, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                string message = str[0];
                result[date] = message;
            }
        }
        DateTime lastDate = new DateTime();
        foreach (var pair in result)
        {
            Console.WriteLine("<div>{0}</div>", SecurityElement.Escape(pair.Value));
            lastDate = pair.Key;
        }
        TimeSpan span = currentDate - lastDate;
        double totalMinutes = span.TotalMinutes;
        double totalHours = span.TotalHours;
        double days = span.TotalDays;
        if (lastDate.Year == currentDate.Year && lastDate.Month == currentDate.Month && lastDate.Day == currentDate.Day&&totalMinutes < 1)
        {
            Console.WriteLine("<p>Last active: <time>a few moments ago</time></p>");
        }
        if (lastDate.Year == currentDate.Year && lastDate.Month == currentDate.Month && lastDate.Day == currentDate.Day && totalMinutes < 60)
        {
            Console.WriteLine("<p>Last active: <time>{0} minute(s) ago</time></p>", (int)totalMinutes);
        }
        else if (lastDate.Year == currentDate.Year && lastDate.Month == currentDate.Month && lastDate.Day == currentDate.Day)
        {
            Console.WriteLine("<p>Last active: <time>{0} hour(s) ago</time></p>", (int)totalHours);
        }
        else if (lastDate.Year == currentDate.Year && lastDate.Month == currentDate.Month && lastDate.AddDays(1).Day == currentDate.Day)
        {
            Console.WriteLine("<p>Last active: <time>yesterday</time></p>");
        }
        else
        {
            string formattedDate = lastDate.ToString("dd-MM-yyyy");
            Console.WriteLine("<p>Last active: <time>{0}</time></p>", formattedDate);
        }
    }
}

