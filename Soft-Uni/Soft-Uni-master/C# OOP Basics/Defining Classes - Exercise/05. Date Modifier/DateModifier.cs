using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

    public class DateModifier
    {

    public static double DifferenceBetweenDates(string firstDate, string secondDate)
    {
        var FirstDate = DateTime.ParseExact(firstDate,"yyyy MM dd", CultureInfo.InvariantCulture);
        var SecondDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        double difference = Math.Abs((SecondDate - FirstDate).TotalDays);
        return difference;
    }

    }

