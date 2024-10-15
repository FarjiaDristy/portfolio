using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx //not DateTime cause, see below
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHY ISN'T IT (namespace DateTime) WORKING?????????????????? 
            //Ans: if namespace name is same as varibale, object, name, object, function, or classname, it'll show an error
            //Date Time datatype
            var date = new DateTime(); 
            Console.WriteLine(date);
            
            var myDate = new DateTime(2015, 6, 1); // assigned date time value
            Console.WriteLine(myDate); // assigned date and time

            DateTime DateAssigned = new DateTime(2000, 12, 4);
            Console.WriteLine(DateAssigned);

            DateTime toDay = DateTime.Today;
            Console.WriteLine(toDay);

            DateTime nowDay = DateTime.Now;
            Console.WriteLine(nowDay);
            Console.WriteLine(nowDay.ToShortDateString()); //only show date
            Console.WriteLine(nowDay.ToShortTimeString()); //show time
            Console.WriteLine(nowDay.ToLongDateString()); //detailed date
            Console.WriteLine(nowDay.ToLongTimeString());
            Console.WriteLine(nowDay.AddDays(5));
            Console.WriteLine(nowDay.AddDays(-5));
            Console.WriteLine(nowDay.AddYears(4)); 
            Console.WriteLine(nowDay.AddSeconds(600000)); 
            Console.WriteLine(nowDay.AddMonths(2));
            //weird format practice yyyy year dddd day MMM month mmm  HH hour mm minute ss second tt am/pm 
            DateTime onlydate = DateTime.Now;
            string FormattedDate = string.Format("Year is {0:yyyy}", onlydate); //javascript works with this expressions
            Console.WriteLine(FormattedDate);

            string formatedatetime = string.Format("Year and month is {0: yyyy MM}", onlydate);
            Console.WriteLine(formatedatetime);
            
            string formatyearmonthdate = string.Format("Year month and date is {0:yyyy MM dd}", onlydate);
            Console.WriteLine(formatyearmonthdate);

            string formatmonthname = string.Format("date with month week short name {0: yyyy MMM ddd}", onlydate); 
            Console.WriteLine(formatmonthname);

            string formatweekname = string.Format("date with month name and weekday name {0: yyyy MMMM dddd}", onlydate); 
            Console.WriteLine(formatweekname);

            string fulldatetime = string.Format("Full date and time {0:yyyy MMMM dddd HH mm ss tt}", onlydate); 
            Console.WriteLine(fulldatetime);

            string formatethod = string.Format("{0:yyyy dddd MMM}", onlydate);
            Console.WriteLine(formatethod);
        }
    }
}
